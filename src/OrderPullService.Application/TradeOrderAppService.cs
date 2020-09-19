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
using Volo.Abp.Threading;

namespace OrderPullService
{
    public class TradeOrderAppService : OrderPullServiceAppService
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
                IPullTradeOrderAppService pullTradeOrderAppService = PullTradeOrderFactory();

                await ExecuteAsync(pullTradeOrderAppService);

                // 结果批量导入
                await _pullServiceDbContext.Trades.BulkInsertAsync(Trades);
            }
        }

        protected virtual async Task ExecuteAsync(IPullTradeOrderAppService pullTradeOrderAppService)
        {
            var orderIds = await pullTradeOrderAppService.GetListAsync(new TradeOrder.Dto.TradeOrderGetListInput());

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
                     var tradeDetail = await pullTradeOrderAppService.GetAsync(item.TradeId);

                     var trade = ObjectMapper.Map<OrderTradeOutput, Trade>(tradeDetail);

                     Trades.Add(trade);
                 });
            });
        }

        protected virtual IPullTradeOrderAppService PullTradeOrderFactory()
        {
            if (CurrentShop.Platform == ShopPlatformType.TMall||CurrentShop.Platform==ShopPlatformType.TaoBao)
            {
                return ServiceProvider.GetRequiredService<TopTradeOrderAppService>();
            }
            else
            {
                return null;
            }
        }
    }
}
