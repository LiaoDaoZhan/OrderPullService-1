using OrderPullService.CurrentShop;
using OrderPullService.TradeOrder;
using OrderPullService.TradeOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace OrderPullService
{
    /// <summary>
    /// 京东交易类订单
    /// </summary>
    public class JdTradeOrderAppService : OrderPullServiceAppService, ITradeOrderAppService
    {
        public ICurrentShop CurrentShop { get; set; }
        public async Task<OrderTradeOutput> GetAsync(string id)
        {
            return null;
            //IJdClient client = new DefaultJdClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            //var request = ObjectMapper.Map<OrderTradeGetInput, PopOrderEnGetRequest>(input);
            //var rsp = client.Execute(request, CurrentShop.AppSessionKey);

            //var result = ObjectMapper.Map<OrderSearchInfo, OrderTradeOutput>(rsp.orderDetailInfo.orderInfo);
            //return result;
        }

        public async Task<PagedResultDto<OrderTradeGetListOutput>> GetListAsync(TradeOrderGetListInput input)
        {
            
            return null;
            //IJdClient client = new DefaultJdClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            //PopOrderSearchRequest req = ObjectMapper.Map<TradeOrderGetListInput, PopOrderSearchRequest>(input);
            //var rsp = client.Execute(req, CurrentShop.AppSessionKey);


            //var result = new PagedResultDto<OrderTradeGetListOutput>();
            //result.TotalCount = rsp.searchorderinfoResult.orderTotal;
            ////result.Items=rsp.searchorderinfoResult.orderInfoList
            //return result;
        }

        //public async Task DeliverAsync(TradeOrderDeliverInput input)
        //{
        //    IJdClient client = new DefaultJdClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
        //    //OrderSopOutstorageRequest req = new OrderSopOutstorageRequest();
        //    PopOrderShipmentRequest req = ObjectMapper.Map<TradeOrderDeliverInput, PopOrderShipmentRequest>(input);
        //    //物流公司ID(只可通过获取商家物流公司接口获得),多个物流公司以|分隔。如：2100|4700。请注意：如果填写厂家自送（1274），则不会保存物流单号，也不会有具体的跟踪信息。
        //    var rspresponse = client.Execute(req, CurrentShop.AppSessionKey, DateTime.Now.ToLocalTime());

        //}
        //public Task<OrderTradeOutput> GetAsync(string id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<PagedResultDto<OrderTradeGetListOutput>> GetListAsync(TradeOrderGetListInput input)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
