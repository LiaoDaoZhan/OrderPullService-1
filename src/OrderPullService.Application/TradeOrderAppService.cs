using AutoMapper.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OrderPullService.EntityFrameworkCore;
using OrderPullService.TopService;
using OrderPullService.TradeOrder;
using OrderPullService.TradeOrder.Dto;
using OrderPullService.XhsService;
using Polly;
using Polly.Retry;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Threading;

namespace OrderPullService
{
    [RemoteService(true)]

    public class TradeOrderAppService : OrderPullServiceAppService, ITradeOrderAppService
    {
        private OrderPullServiceDbContext _pullServiceDbContext;
        public TradeOrderAppService(OrderPullServiceDbContext pullServiceDbContext)
        {
            Trades = new ConcurrentBag<Trade>();
            _pullServiceDbContext = pullServiceDbContext;
        }

        protected ConcurrentBag<Trade> Trades;

        public async Task GetShopTradeAsync(Guid id)
        {
            using (CurrentShop.Change(id))
            {
                IPullTradeOrderService pullTradeOrderService = PullTradeOrderFactory();

                await ExecuteAsync(pullTradeOrderService);

                // 结果批量导入
                await _pullServiceDbContext.Trades.BulkInsertAsync(Trades);
                // 明细批量导入
                await _pullServiceDbContext.TradeDetails.BulkInsertAsync(Trades.SelectMany(c => c.Details));
                
            }
        }

        protected virtual async Task ExecuteAsync(IPullTradeOrderService pullTradeOrderService)
        {
            //var orderIds = await pullTradeOrderService.GetListAsync(new TradeOrder.Dto.TradeOrderGetListInput() { SkipCount=0,MaxResultCount=1});
            var orderIds = new PagedResultDto<OrderTradeGetListOutput> {
                Items=new List<OrderTradeGetListOutput>()
                {
                 new OrderTradeGetListOutput(){ TradeId="1208621211133660394"}
                }
            };

            // 遇到错误 重试3次
            var retry = Policy.Handle<Exception>().RetryAsync(3);

            var fallback = Policy
                  .Handle<Exception>()
                  .FallbackAsync(async (cancel) =>
                  {
                      // 
                  },async (ex) =>
                  {
                      // TODO: 降级处理 记录已发生错误
                      Logger.LogError($"店铺:{CurrentShop.Name}({CurrentShop.Id}) 获取订单明细出现失败!", ex);  
                  });

            orderIds.Items.AsParallel().ForAll(async item =>
            {
                // 失败重试3次 确保正确处理到数据
                await fallback
                  .WrapAsync(retry)
                  .ExecuteAsync(async () =>
                 {
                     var trade = await pullTradeOrderService.GetTradeAsync(item.TradeId);
                     trade.ShopId = CurrentShop.Id;
                     trade.SetId(GuidGenerator.Create());
                     
                     trade.CreationTime = DateTime.Now;
                     trade.Details.ForAll(item =>
                     {
                         item.TradeId = trade.Id;
                         item.SetId(GuidGenerator.Create());
                         item.CreationTime = DateTime.Now;
                     });
                     //var trade = ObjectMapper.Map<OrderTradeOutput, Trade>(tradeDetail);

                     Trades.Add(trade);
                 });
            });
        }

        protected virtual IPullTradeOrderService PullTradeOrderFactory()
        {
            if (CurrentShop.Platform == ShopPlatformType.TMall||CurrentShop.Platform==ShopPlatformType.TaoBao)
            {
                return ServiceProvider.GetRequiredService<TopTradeOrderService>();
            }
            else
            {
                return null;
            }
        }
    }
}
