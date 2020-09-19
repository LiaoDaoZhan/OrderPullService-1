using AutoMapper;
using OrderPullService.Deliver.Dto;
using OrderPullService.TradeOrder.Dto;
using System;
using Top.Api.Request;

namespace OrderPullService
{
    public class OrderPullServiceApplicationAutoMapperProfile : Profile
    {
        public OrderPullServiceApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            #region 京东类订单
            //CreateMap<TradeOrderGetListInput, PopOrderSearchRequest>(MemberList.None)
            //    .ForMember(c => c.startDate, c => c.MapFrom(d => d.StartTime.ToString("yyyy-MM-dd HH:mm:ss")))
            //    .ForMember(c => c.endDate, c => c.MapFrom(d => d.EndTime.ToString("yyyy-MM-dd HH:mm:ss")))
            //    .ForMember(c => c.page, c => c.MapFrom(d => d.MaxResultCount))
            //    .ForMember(c => c.pageSize, c => c.MapFrom(d => d.SkipCount))
            //    .AfterMap((input, request) =>
            //    {
            //        request.optionalFields = "orderId,venderId,orderType，payType,orderTotalPrice,orderPayment,orderSellerPrice,freightPrice,sellerDiscount,orderState,orderStateRemark,"
            //           + "deliveryType,invoiceInfo,invoiceInfo,orderStartTime,orderEndTime,consigneeInfo,itemInfoList,couponDetailList,couponDetailList,venderRemark,pin,balanceUsed,"
            //           + "modified,paymentConfirmTime,logisticsId,waybill,vatInfo,parentOrderId,orderType,storeOrder";
            //    });
            //获取订单交易明细
            //CreateMap<OrderTradeGetInput, PopOrderEnGetRequest>(MemberList.None)
            //    .ForMember(c => c.orderId, c => c.MapFrom(d => long.Parse(d.OrderId)))
            //    .AfterMap((input, request) =>
            //    {
            //        request.optionalFields = "ALL";
            //    });



            //https://open.jd.com/home/home#/doc/api?apiCateId=55&apiId=1948&apiName=jingdong.pop.order.shipment
            //CreateMap<TradeOrderDeliverInput, PopOrderShipmentRequest>(MemberList.None)
            //    .ForMember(c => c.orderId, c => c.MapFrom(d => d.OrderId))
            //    .ForMember(c => c.logiNo, c => c.MapFrom(d => d.LogiNo))
            //    .ForMember(c => c.logiCoprId, c => c.Ignore())
            //    .AfterMap((input, request) =>
            //    {
            //        //request.orderId=
            //    });

            #endregion
        }
    }
}