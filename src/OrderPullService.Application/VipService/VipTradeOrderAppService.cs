﻿using OrderPullService.TradeOrder;
using OrderPullService.TradeOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace OrderPullService.VipService
{
    /// <summary>
    /// 唯品汇
    /// </summary>
    [RemoteService(IsEnabled = false, IsMetadataEnabled = false)]//禁用api方式访问
    public class VipTradeOrderAppService : OrderPullServiceAppService, ITradeOrderAppService
    {
        public Task<OrderTradeOutput> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<OrderTradeGetListOutput>> GetListAsync(TradeOrderGetListInput input)
        {
            throw new NotImplementedException();
        }
    }
}
