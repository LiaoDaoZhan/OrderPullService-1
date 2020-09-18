using OrderPullService.CurrentShop;
using OrderPullService.TopService;
using OrderPullService.TradeOrder;
using OrderPullService.TradeOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrderPullService
{
    public class OrderPullTopTest : OrderPullServiceApplicationTestBase
    {
        private ITradeOrderAppService _tradeOrderApplicationService;
        private ICurrentShop _currentShop;
        public OrderPullTopTest()
        {
            _tradeOrderApplicationService = GetRequiredService<TopTradeOrderAppService>();
            _currentShop = GetRequiredService<ICurrentShop>();
        }

        [Fact]
        public async Task PullTop_GetList_Test()
        {
            //利用Change 改变当前店铺的api等信息 在当前店铺内的using里面可以直接访问当前店铺所有支持的api资源
            using (_currentShop.Change(Guid.NewGuid(), "无双淘宝",ShopPlatformType.TaoBao, "23710332", "e7c54c38fc070f12d3e8650b876d8ef2", "6102b04e52ae12d3dfdbcf8f6bd8727805b2fd3d9cd16234072237246"))
            {
                var input = new TradeOrderGetListInput
                {
                    //PageNo = 1,
                    //PageSize = 10,
                    MaxResultCount = 1,
                    SkipCount = 0,
                    EndTime = DateTime.Now,
                    StartTime = DateTime.Now.AddDays(-1),
                    Status = ""
                };
                var result = await _tradeOrderApplicationService.GetListAsync(input);

                Assert.NotNull(result);
            }

        }

        [Fact]
        public async Task PullTop_Get_Test()
        {
            //利用Change 改变当前店铺的api等信息 在当前店铺内的using里面可以直接访问当前店铺所有支持的api资源
            using (_currentShop.Change(Guid.NewGuid(), "无双淘宝", ShopPlatformType.TaoBao, "23710332", "e7c54c38fc070f12d3e8650b876d8ef2", "6102b04e52ae12d3dfdbcf8f6bd8727805b2fd3d9cd16234072237246"))
            {
                var result = await _tradeOrderApplicationService.GetAsync("1208621211133660394");

                Assert.NotNull(result);
            }

        }
    }
}
