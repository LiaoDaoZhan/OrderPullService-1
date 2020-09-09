using OrderPullService.Deliver.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace OrderPullService.Deliver
{
    /// <summary>
    /// 交易订单的发货
    /// </summary>
    public interface ITradeDeliverAppService : IApplicationService
    {
        /// <summary>
        /// 创建发货信息并推送至指定的平台
        /// </summary>
        /// <returns></returns>
        Task CreateAsync(TradeOrderDeliverInput input);
    }
}
