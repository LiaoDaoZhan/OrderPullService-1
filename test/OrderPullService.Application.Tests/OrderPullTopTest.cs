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
        public async Task PullTop_Test()
        {
            //利用Change 改变当前店铺的api等信息 在当前店铺内的using里面可以直接访问当前店铺所有支持的api资源
            using (_currentShop.Change(Guid.NewGuid(), "无双淘宝", "appkey", "appsecret", "sessionKey"))
            {
                var input = new TradeOrderGetListInput
                {
                    //PageNo = 1,
                    //PageSize = 10,
                    MaxResultCount = 10,
                    SkipCount = 0,
                    EndTime = DateTime.Now,
                    StartTime = DateTime.Now.AddDays(-1),
                    Status = ""
                };
                var result = await _tradeOrderApplicationService.GetListAsync(input);

                Assert.NotNull(result);
            }

        }
    }
}
