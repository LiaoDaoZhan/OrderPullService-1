using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace OrderPullService
{
    /// <summary>
    /// 交易优惠信息
    /// </summary>
    public class TradePromotion: AggregateRoot<Guid>,IMultiTenant
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        public string DiscountFee { get; set; }
        /// <summary>
        /// 赠品标识
        /// </summary>
        public string GiftItemId { get; set; }
        /// <summary>
        /// 赠品名称
        /// </summary>
        public string GiftItemName { get; set; }
        /// <summary>
        /// 赠品数量
        /// </summary>
        public string GiftItemNum { get; set; }

        [ForeignKey(nameof(TardeId))]
        public Trade Trade { get; set; }
        /// <summary>
        /// 交易Id
        /// </summary>
        public Guid TardeId { get; set; }
        /// <summary>
        /// 订单原始Id
        /// </summary>
        //public long TradeOriId { get; set; }
        /// <summary>
        /// 活动说明
        /// </summary>
        public string PromotionDesc { get; set; }
        /// <summary>
        /// 活动标识
        /// </summary>
        public string PromotionId { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
        public string PromotionName { get; set; }
        /// <summary>
        /// 租户
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// 店铺Id
        /// </summary>
        public Guid ShopId { get; set; }

        public void SetId(Guid id)
        {
            Id = Id;
        }
    }
}
