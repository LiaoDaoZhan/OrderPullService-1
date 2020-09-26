using Lazop.Api;
using OrderPullService.Deliver.Dto;
using OrderPullService.LaZaDaService.Dto;
using OrderPullService.TradeOrder;
using OrderPullService.TradeOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace OrderPullService.LaZaDaService
{
    [RemoteService(IsEnabled = false, IsMetadataEnabled = false)]//禁用api方式访问
    public class LaZaDaTradeOrderService : OrderPullServiceAppService, IPullTradeOrderService
    {
        /// <summary>
        /// 获取单条订单详情
        /// </summary>
        /// <seealso cref="https://open.lazada.com/doc/api.htm?spm=a2o9m.11193487.0.0.3ac413fekZjbNA#/api?cid=8&path=/order/get"/>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<OrderTradeOutput> GetAsync(string id)
        {
            ILazopClient client = new LazopClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            LazopRequest request = new LazopRequest();
            request.SetApiName("/order/get");
            request.SetHttpMethod("GET");
            request.AddApiParameter("order_id", id);
            LazopResponse rsp = client.Execute(request, CurrentShop.AppSessionKey);
            if (rsp.Code != "0")
                return null;
            var lzdRespons = Newtonsoft.Json.JsonConvert.DeserializeObject<LaZaDaRspBody>(rsp.Body);
            var detail = Newtonsoft.Json.JsonConvert.DeserializeObject<Dto.Trade>(lzdRespons.data);
            var result = ObjectMapper.Map<Dto.Trade, OrderTradeOutput>(detail);
            return result;
        }

        public async Task<PagedResultDto<OrderTradeGetListOutput>> GetListAsync(TradeOrderGetListInput input)
        {
            ILazopClient client = new LazopClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            LazopRequest request = new LazopRequest();
            request.SetApiName("/orders/get");
            request.SetHttpMethod("GET");
            request.AddApiParameter("created_before", input.StartTime.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            request.AddApiParameter("created_after", input.EndTime.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            request.AddApiParameter("status", input.Status);
            request.AddApiParameter("limit", input.PageSize.ToString()); //页大小
            request.AddApiParameter("offset", ((input.PageNo - 1) * input.PageSize).ToString()); //跳过条数
            request.AddApiParameter("sort_by", "created_at");
            LazopResponse rsp = client.Execute(request, CurrentShop.AppSessionKey);
            if (rsp.Code != "0")
                return null;
            var lzdRespons = Newtonsoft.Json.JsonConvert.DeserializeObject<LaZaDaRspBody>(rsp.Body);
            var detail = Newtonsoft.Json.JsonConvert.DeserializeObject<Dto.TradeList>(lzdRespons.data);
            var result = new PagedResultDto<OrderTradeGetListOutput>();
            result.Items = ObjectMapper.Map<List<Dto.Trade>, List<OrderTradeGetListOutput>>(detail.orders);
            result.TotalCount = detail.count;
            return result;
        }

        public async Task DeliverAsync(TradeOrderDeliverInput input)
        {
            ILazopClient client = new LazopClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            LazopRequest request = new LazopRequest();
            request.SetApiName("/order/sof/delivered");
            request.AddApiParameter("order_item_ids", "[" + input.OrderId + "]");
            LazopResponse response = client.Execute(request, CurrentShop.AppSessionKey);
        }

        public Task<Trade> GetTradeAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
