using OrderPullService.Extensions;
using OrderPullService.TradeOrder;
using OrderPullService.TradeOrder.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vipapis.jitx;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace OrderPullService.VipService
{
    /// <summary>
    /// 唯品汇
    /// </summary>
    [RemoteService(IsEnabled = false, IsMetadataEnabled = false)]//禁用api方式访问
    public class VipTradeOrderService : OrderPullServiceAppService, IPullTradeOrderService
    {
        private int Vendor_id;
        public VipTradeOrderService(int _vendei_id)
        {
            Vendor_id = _vendei_id;
        }
        public async Task<OrderTradeOutput> GetAsync(string id)
        {
            var orderList = new List<string>() { id };
            JitXServiceHelper.JitXServiceClient client = new vipapis.jitx.JitXServiceHelper.JitXServiceClient();
            Osp.Sdk.Context.InvocationContext invocationContext = Osp.Sdk.Context.Factory.GetInstance();
            invocationContext.SetAppKey(CurrentShop.AppKey);
            invocationContext.SetAppSecret(CurrentShop.AppSecret);
            invocationContext.SetAppURL(CurrentShop.ApiUrl);
            invocationContext.SetAccessToken(CurrentShop.AppSessionKey);
            GetOrdersByOrderSnRequest getOrdersByOrderSnRequest = new GetOrdersByOrderSnRequest();
            getOrdersByOrderSnRequest.SetOrder_sns(orderList);
            getOrdersByOrderSnRequest.SetVendor_id(Vendor_id);
            GetOrdersResponse rep = client.getOrdersByOrderSn(getOrdersByOrderSnRequest);
            var result = ObjectMapper.Map<vipapis.jitx.Order, OrderTradeOutput>(rep.GetOrders().FirstOrDefault());
            return result;
        }

        public async Task<PagedResultDto<OrderTradeGetListOutput>> GetListAsync(TradeOrderGetListInput input)
        {
            vipapis.jitx.JitXServiceHelper.JitXServiceClient client = new vipapis.jitx.JitXServiceHelper.JitXServiceClient();
            Osp.Sdk.Context.InvocationContext invocationContext = Osp.Sdk.Context.Factory.GetInstance();
            invocationContext.SetAppKey(CurrentShop.AppKey);
            invocationContext.SetAppSecret(CurrentShop.AppSecret);
            invocationContext.SetAccessToken(CurrentShop.AppSessionKey);
            GetOrdersRequest request = new GetOrdersRequest();
            if (!input.Status.IsNullOrEmpty())
            {
                List<string> OrderStaList = input.Status.Trim(',').Split(',').ToList();
                request.SetOrder_status(OrderStaList);
            }
            request.SetStart_time(input.StartTime.ToTimestampLong(false));
            request.SetEnd_time(input.EndTime.ToTimestampLong(false));
            request.SetVendor_id(Vendor_id);
            request.SetLimit(input.PageSize);
            request.SetPage(input.PageNo);
            GetOrdersResponse rep = client.getOrders(request);
            var result = new PagedResultDto<OrderTradeGetListOutput>(rep.GetTotal() ?? 0, ObjectMapper.Map<List<vipapis.jitx.Order>, List<OrderTradeGetListOutput>>(rep.GetOrders()));
            return result;
        }

        public Task<Trade> GetTradeAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
