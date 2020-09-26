extern alias snSDK;

using OrderPullService.Deliver;
using OrderPullService.Deliver.Dto;
using OrderPullService.TradeOrder.Dto;
using snSDK::suning_api_sdk;
using snSDK::suning_api_sdk.BizRequest.CustomSelfmarketRequest;
using snSDK::suning_api_sdk.BizResponse.CustomSelfmarketResponse;
using snSDK::suning_api_sdk.Models.CustomSelfmarketModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace OrderPullService.SnService
{
    [RemoteService(IsEnabled = false, IsMetadataEnabled = false)]//禁用api方式访问
    public class SnTradeOrderService : OrderPullServiceAppService, IPullTradeOrderService, ITradeDeliverAppService
    {


        public async Task<OrderTradeOutput> GetAsync(string id)
        {
            OrderGetRequest request = new OrderGetRequest();
            request.orderCode = id;
            request.supplierCode = CurrentShop.AppSessionKey; //使用session 代替
                                                              //开启日志调试，当测试稳定之后建议设置为 false 或者删除该行
                                                              //SuningLogger.IsLogDebug = true;

            ISuningClient client = new DefaultSuningClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            OrderGetResponse rep = client.Execute(request);
            var result = ObjectMapper.Map<OrderGetResponse, OrderTradeOutput>(rep);
            return result;
        }

        public async Task<PagedResultDto<OrderTradeGetListOutput>> GetListAsync(TradeOrderGetListInput input)
        {
            OrdercodeQueryRequest request = new OrdercodeQueryRequest();
            request.endTime = input.EndTime.ToString();
            request.orderStatus = input.Status;
            request.pageNo = input.PageNo;
            request.pageSize = input.PageSize;
            request.startTime = input.StartTime.ToString();
            request.supplierCode = CurrentShop.AppSessionKey;
            //开启日志调试，当测试稳定之后建议设置为 false 或者删除该行
            //SuningLogger.IsLogDebug = true;
            string serverUrl = CurrentShop.ApiUrl; //"https://open.suning.com/api/http/sopRequest";
            string appKey = CurrentShop.AppKey;// "你的appKey";
            string appSecret = CurrentShop.AppSecret; //"你的appSecret";
            ISuningClient client = new DefaultSuningClient(serverUrl, appKey, appSecret);
            OrdercodeQueryResponse rep = client.Execute(request);
            var result = new PagedResultDto<OrderTradeGetListOutput>(rep.queryOrdercode.Count, ObjectMapper.Map<List<QueryOrdercode>, List<OrderTradeGetListOutput>>(rep.queryOrdercode));
            return result;
        }


        public async Task DeliverAsync(TradeOrderDeliverInput input)
        {
            OrderDeliverAddRequest request = new OrderDeliverAddRequest();
            request.expressCompCode = input.CompanyCode;
            request.expressNo = input.LogiNo;
            request.orderItemId = input.OrderId;
            //request.sender = sender;
            //request.senderTel = senderTel;
            request.sign = "1";
            request.supplierCode = CurrentShop.AppSessionKey;
            //开启日志调试，当测试稳定之后建议设置为 false 或者删除该行
            //SuningLogger.IsLogDebug = true;
            ISuningClient client = new DefaultSuningClient(CurrentShop.ApiUrl, CurrentShop.AppKey, CurrentShop.AppSecret);
            OrderDeliverAddResponse rsp = client.Execute(request);
        }

        public Task<Trade> GetTradeAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
