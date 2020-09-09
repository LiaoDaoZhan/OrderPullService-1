using OrderPullService.TradeOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace OrderPullService.TradeOrder
{
    /// <summary>
    /// 订单交易类 统一接口
    /// </summary>
    public interface ITradeOrderAppService : IApplicationService
    {
        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<OrderTradeGetListOutput>> GetListAsync(TradeOrderGetListInput input);
        /// <summary>
        /// 获取订单交易明细
        /// </summary>
        /// <param name="id">交易ID</param>
        /// <returns></returns>
        Task<OrderTradeOutput> GetAsync(string id);
    }
}
