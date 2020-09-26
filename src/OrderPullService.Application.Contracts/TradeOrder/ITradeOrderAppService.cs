using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace OrderPullService.TradeOrder
{
    public interface ITradeOrderAppService : IApplicationService
    {
        Task GetShopTradeAsync(Guid id);
    }
}
