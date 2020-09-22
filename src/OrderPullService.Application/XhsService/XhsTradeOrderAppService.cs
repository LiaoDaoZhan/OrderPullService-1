using OrderPullService.TradeOrder;
using OrderPullService.TradeOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace OrderPullService.XhsService
{
    /// <summary>
    /// 小红书
    /// </summary>
    [RemoteService(IsEnabled = false, IsMetadataEnabled = false)]//禁用api方式访问
    public class XhsTradeOrderAppService : OrderPullServiceAppService, IPullTradeOrderService
    {
        public Task<OrderTradeOutput> GetAsync(string id)
        {
            return null;
            //var action = "/ark/open_api/v0/packages";
            //Dictionary<string, object> dic = new Dictionary<string, object>();
            //dic.Add("package_id", id);
            //var client = _xhsClient.GetSignClient(action, dic);
            //var response = await client.GetStringAsync(_xhsClient.GetUrl(action, dic));

            //var xhsRespons = Newtonsoft.Json.JsonConvert.DeserializeObject<XhsResponse>(response);
            //if (!xhsRespons.success)
            //{
            //    //返回错误信息
            //    return null;
            //}
            //var detail = Newtonsoft.Json.JsonConvert.DeserializeObject<TradeDetail>(xhsRespons.data);
            //var output = ObjectMapper.Map<TradeDetail, OrderTradeOutput>(detail);

            //return output;
        }

        public Task<PagedResultDto<OrderTradeGetListOutput>> GetListAsync(TradeOrderGetListInput input)
        {
            return null;
            //var hasNext = true;
            //var action = "/ark/open_api/v0/packages";
            ////组建签名参数
            //Dictionary<string, object> dic = new Dictionary<string, object>();
            ////=====================================
            //dic.Add("status", input.Status); //订单状态, waiting待打包和打包中(APP端显示为待配货和配货中),shipped已发货,received收件人已签收。若不传入该字段则默认返回waiting状态下订单
            //dic.Add("page_no", input.PageNo);
            //dic.Add("page_size", input.PageSize);
            //dic.Add("start_time", input.StartTime.ToTimestampLong(false));
            //dic.Add("end_time", input.EndTime.ToTimestampLong(false));
            //dic.Add("time_type", "created_at"); //订单查询时间类型，订单创建时间：created_at，订单确认时间：confirmed_at，订单更新时间：updated_at
            //var client = _xhsClient.GetSignClient(action, dic);
            //var response = await client.GetStringAsync(_xhsClient.GetUrl(action, dic));

            //var xhsRespons = Newtonsoft.Json.JsonConvert.DeserializeObject<XhsResponse>(response);
            //var trade = Newtonsoft.Json.JsonConvert.DeserializeObject<TradeList>(xhsRespons.data);

            ////TODO:需要自己实现翻页
            //if (trade.total_page <= input.PageNo)
            //    hasNext = false;
            ////pageNo++;
            ////foreach (var item in trade.package_list)
            ////{
            ////    var detail= await GetAsync(new OrderTradeGetInput {  OrderId=item.package_id});

            ////}
            //var output = new PagedResultDto<OrderTradeGetListOutput>();
            //output.TotalCount = trade.total_number;
            //output.Items = ObjectMapper.Map<List<Trade>, List<OrderTradeGetListOutput>>(trade.package_list);
            //return output;
        }

        public Task<global::OrderPullService.Trade> GetTradeAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
