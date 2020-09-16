using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace OrderPullService.OrderPullService
{
    /// <summary>
    /// 店铺的交易订单处理策略
    /// </summary>
    public class TradesStrategy : FullAuditedAggregateRoot<Guid>
    {

    }
}
