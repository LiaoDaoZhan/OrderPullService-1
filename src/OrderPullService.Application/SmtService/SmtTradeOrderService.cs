using OrderPullService.Deliver;
using OrderPullService.Deliver.Dto;
using OrderPullService.TradeOrder;
using OrderPullService.TradeOrder.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using static Top.Api.Response.AliexpressTradeNewRedefiningFindorderbyidResponse;
using static Top.Api.Response.AliexpressTradeSellerOrderlistGetResponse;

namespace OrderPullService.SmtService
{
    [RemoteService(IsEnabled = false, IsMetadataEnabled = false)]//禁用api方式访问
    public class SmtTradeOrderService : OrderPullServiceAppService, IPullTradeOrderService, ITradeDeliverAppService
    {


        public async Task<OrderTradeOutput> GetAsync(string id)
        {
            ITopClient client = new DefaultTopClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            AliexpressTradeNewRedefiningFindorderbyidRequest req = new AliexpressTradeNewRedefiningFindorderbyidRequest();
            AliexpressTradeNewRedefiningFindorderbyidRequest.AeopTpSingleOrderQueryDomain obj1 = new AliexpressTradeNewRedefiningFindorderbyidRequest.AeopTpSingleOrderQueryDomain();
            obj1.OrderId = Convert.ToInt64(id);
            req.Param1_ = obj1;
            AliexpressTradeNewRedefiningFindorderbyidResponse rsp = client.Execute(req, CurrentShop.AppSessionKey);
            var result = ObjectMapper.Map<AeopTpOrderDetailDtoDomain, OrderTradeOutput>(rsp.Target);
            return result;
        }

        public async Task<PagedResultDto<OrderTradeGetListOutput>> GetListAsync(TradeOrderGetListInput input)
        {
            ITopClient client = new DefaultTopClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            AliexpressTradeSellerOrderlistGetRequest req = new AliexpressTradeSellerOrderlistGetRequest();
            AliexpressTradeSellerOrderlistGetRequest.AeopOrderQueryDomain obj1 = new AliexpressTradeSellerOrderlistGetRequest.AeopOrderQueryDomain();
            obj1.ModifiedDateStart = input.StartTime.ToString();
            obj1.ModifiedDateEnd = input.EndTime.ToString();
            //obj1.CreateDateEnd = endTime;
            //obj1.CreateDateStart = startTime;
            obj1.CurrentPage = input.PageNo;
            if (input.Status.IsNullOrEmpty())
            {
                var strList = new string[] { "WAIT_SELLER_SEND_GOODS", "SELLER_PART_SEND_GOODS", "WAIT_BUYER_ACCEPT_GOODS" };
                obj1.OrderStatusList = strList.ToList();
            }
            else
            {
                var splt = input.Status.Split(',');
                obj1.OrderStatusList = splt.ToList();
            }
            obj1.PageSize = input.PageSize;
            req.ParamAeopOrderQuery_ = obj1;
            AliexpressTradeSellerOrderlistGetResponse rsp = client.Execute(req, CurrentShop.AppSessionKey);
            var result = new PagedResultDto<OrderTradeGetListOutput>(rsp.Result.TotalCount, ObjectMapper.Map<List<AeopOrderItemDtoDomain>, List<OrderTradeGetListOutput>>(rsp.Result.TargetList));
            return result;
        }

        public Task<Trade> GetTradeAsync(string id)
        {
            throw new NotImplementedException();
        }
        public async Task DeliverAsync(TradeOrderDeliverInput input)
        {
            ITopClient client = new DefaultTopClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            AliexpressLogisticsSellershipmentfortopRequest req = new AliexpressLogisticsSellershipmentfortopRequest();
            req.LogisticsNo = input.LogiNo;
            req.SendType = input.IsSplit ? "part" : "all";
            req.OutRef = input.OrderId;
            req.ServiceName = input.CompanyCode; ;
            AliexpressLogisticsSellershipmentfortopResponse rsp = client.Execute(req, CurrentShop.AppSessionKey);
        }
    }
}
