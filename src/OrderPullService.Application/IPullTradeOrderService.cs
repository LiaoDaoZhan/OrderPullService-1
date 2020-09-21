using OrderPullService.TradeOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace OrderPullService
{
    public interface IPullTradeOrderService
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

        Task<Trade> GetTradeAsync(string id);
    }
}
