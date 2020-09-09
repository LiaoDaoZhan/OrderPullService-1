using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.Deliver.Dto
{
    /// <summary>
    /// 创建发货请求内容
    /// </summary>
    public class TradeOrderDeliverInput: Volo.Abp.Data.IHasExtraProperties
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// 物流号
        /// </summary>
        public string LogiNo { get; set; }
        /// <summary>
        /// 物流公司编号
        /// </summary>
        public string CompanyCode { get; set; }
        /// <summary>
        /// 表明是否是拆单
        /// </summary>
        public bool IsSplit { get; set; } = false;

        public Dictionary<string, object> ExtraProperties { get;protected set; }
    }
}
