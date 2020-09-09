# OrderPullService
OMS订单拉取服务

## 项目结构说明
### 主要项目 src

 - OrderPullService.Domain 数据库实体对象
 - OrderPullService.EntityFrameworkCore 数据库Ef的访问支持
 - OrderPullService.HttpApi 提供对外访问的api 暂时不用处理
 - OrderPullService.Application.Contracts 定义接口与DTO输出的格式
 - *（重要）OrderPullService.Application 标准接口的具体实现 里面含有各大平台的请求内容

### 测试项目 test
OrderPullService.Application.Tests 关于接口的测试内容，具体使用方式见下面

# 测试说明

**多个店铺的测试**

例如：京东测试
在测试项目test/OrderPullService.Application.Tests/ 中找到OrderPullJDTest查阅现有代码
#### 示例代码
```csharp
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
```
