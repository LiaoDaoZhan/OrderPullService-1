using AutoMapper;
using OrderPullService.TradeOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Top.Api.Request;
using Volo.Abp.Data;

namespace OrderPullService.TopService
{
    public class TopAutoMapperProfile : Profile
    {
        public TopAutoMapperProfile()
        {
            //获取增量交易列表 传值
            CreateMap<TradeOrderGetListInput, TradesSoldIncrementGetRequest>(MemberList.None)
                .ForMember(c => c.StartModified, c => c.MapFrom(d => d.StartTime))
                .ForMember(c => c.EndModified, c => c.MapFrom(d => d.EndTime))
                .AfterMap((input, request) =>
                {
                    request.Fields = "tid";
                    request.PageNo = Convert.ToInt64(Math.Round((input.SkipCount / input.MaxResultCount) * 1m, 0));
                    request.PageSize = input.MaxResultCount;
                    ///是否存在下一页
                    //request.UseHasNext = true;
                });

            CreateMap<Top.Api.Domain.Trade, OrderTradeGetListOutput>(MemberList.None);

            CreateMap<Top.Api.Domain.Trade, OrderTradeOutput>(MemberList.None)
                .AfterMap((input, output) =>
                {
                    // 将当前对象存储
                    output.SetProperty("trade", input);
                })
                ;

            CreateMap<Top.Api.Domain.Order, TradeDetailDto>(MemberList.None)
                .AfterMap((input, output) =>
                {
                    // 将当前对象存储
                    output.SetProperty("detail", input);
                });

            //获取订单交易明细
            CreateMap<OrderTradeGetInput, TradeFullinfoGetRequest>(MemberList.None)
                .ForMember(c => c.Tid, c => c.MapFrom(d => long.Parse(d.Id)))
                .AfterMap((input, request) =>
                {
                    request.Fields = "tid,type,status,payment,orders,promotion_details";
                });


            //CreateMap<TradeOrderDeliverInput, LogisticsOnlineSendRequest>(MemberList.None)
            //    .ForMember(c => c.Tid, c => c.MapFrom(d => long.Parse(d.OrderId)))
            //    .ForMember(c => c.OutSid, c => c.MapFrom(d => d.LogiNo))
            //    .ForMember(c => c.IsSplit, c => c.Ignore())
            //    .AfterMap((input, request) =>
            //    {
            //        if (input.IsSplit) request.IsSplit = 1L;
            //        else request.IsSplit = 0L;
            //    });
        }
    }
}
