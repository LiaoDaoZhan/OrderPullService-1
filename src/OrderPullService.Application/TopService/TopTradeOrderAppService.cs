using OrderPullService.TradeOrder;
using OrderPullService.TradeOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace OrderPullService.TopService
{
    /// <summary>
    /// 淘宝类交易订单
    /// </summary>
    [RemoteService(IsEnabled = false,IsMetadataEnabled = false)]//禁用api方式访问
    public class TopTradeOrderAppService:OrderPullServiceAppService, ITradeOrderAppService
    {
        /// <summary>
        /// 获取增量交易列表
        /// <see cref="https://open.taobao.com/api.htm?docId=128&docType=2"/>
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<OrderTradeGetListOutput>> GetListAsync(TradeOrderGetListInput input)
        {
            return null;
            //ITopClient client = new DefaultTopClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            //TradesSoldIncrementGetRequest req =
            //ObjectMapper.Map<TradeOrderGetListInput, TradesSoldIncrementGetRequest>(input);
            //TradesSoldIncrementGetResponse rsp = client.Execute(req, CurrentShop.AppSessionKey);
            ////return rsp;

            //var result = new PagedResultDto<OrderTradeGetListOutput>(rsp.TotalResults, ObjectMapper.Map<IReadOnlyList<Trade>, List<OrderTradeGetListOutput>>(rsp.Trades));
            //return result;
        }
        /// <summary>
        /// 获取订单交易明细
        /// </summary>
        /// <param name="id">订单明细ID</param>
        /// <returns></returns>
        public async Task<OrderTradeOutput> GetAsync(string id)
        {
            return null;
            //ITopClient client = new DefaultTopClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            //TradeFullinfoGetRequest req =new TradeFullinfoGetRequest();
            //req.id = id;

            ////ObjectMapper.Map<OrderTradeGetInput, TradeFullinfoGetRequest>(id);


            //TradeFullinfoGetResponse rsp = client.Execute(req, CurrentShop.AppSessionKey);

            //var result = ObjectMapper.Map<Trade, OrderTradeOutput>(rsp.Trade);
            //return result;
        }
        /// <summary>
        /// 订单发货
        /// </summary>
        /// <returns></returns>
        //public async Task DeliverAsync(TradeOrderDeliverInput input)
        //{
        //    ITopClient client = new DefaultTopClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
        //    LogisticsOnlineSendRequest req = ObjectMapper.Map<TradeOrderDeliverInput, LogisticsOnlineSendRequest>(input);

        //    var rsp = client.Execute(req, CurrentShop.AppSessionKey);
        //}
    }
}
