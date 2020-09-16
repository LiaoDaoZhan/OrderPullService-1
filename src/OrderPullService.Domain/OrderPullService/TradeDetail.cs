using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace OrderPullService
{
    public class TradeDetail : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 主订单ID
        /// </summary>
        public Guid TradeId { get; set; }

        [ForeignKey(nameof(TradeId))]
        public Trade Trade { get; set; }
        /// <summary>
        /// 套餐的值。如：M8原装电池:便携支架:M8专用座充:莫凡保护袋
        /// </summary>
        public string ItemMealName { get; set; }
        /// <summary>
        /// 商品图片的绝对路径
        /// </summary>
        public string PicPath { get; set; }
        /// <summary>
        /// 卖家昵称
        /// </summary>
        public string SellerNick { get; set; }
        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 买家登录ID
        /// </summary>
        public string BuyerLoginId { get; set; }

        /// <summary>
        /// 退款状态。退款状态。可选值 WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意) WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货) WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货) SELLER_REFUSE_BUYER(卖家拒绝退款) CLOSED(退款关闭) SUCCESS(退款成功)
        /// </summary>
        public string RefundStatus { get; set; }
        /// <summary>
        /// 商家外部编码(可与商家外部系统对接)。外部商家自己定义的商品Item的id，可以通过taobao.items.custom.get获取商品的Item的信息
        /// </summary>
        public string OutId { get; set; }
        /// <summary>
        /// 订单快照URL
        /// </summary>
        public string SnapshotUrl { get; set; }
        /// <summary>
        /// 订单快照详细信息
        /// </summary>
        public string Snapshot { get; set; }
        /// <summary>
        /// 订单超时到期时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string TimeoutActionTim { get; set; }
        /// <summary>
        /// 买家是否已评价。可选值：true(已评价)，false(未评价)
        /// </summary>
        public bool BuyerRate { get; set; }
        /// <summary>
        /// 卖家是否已评价。可选值：true(已评价)，false(未评价)
        /// </summary>
        public bool SellerRate { get; set; }
        /// <summary>
        /// 子订单编号
        /// </summary>
        public string Oid { get; set; }
        /// <summary>
        /// 订单状态（请关注此状态，如果为TRADE_CLOSED_BY_TAOBAO状态，则不要对此订单进行发货，切记啊！）。可选值:TRADE_NO_CREATE_PAY(没有创建支付宝交易) WAIT_BUYER_PAY(等待买家付款) WAIT_SELLER_SEND_GOODS(等待卖家发货, 即:买家已付款) WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货, 即:卖家已发货) TRADE_BUYER_SIGNED(买家已签收, 货到付款专用) TRADE_FINISHED(交易成功) TRADE_CLOSED(付款以后用户退款成功，交易自动关闭) TRADE_CLOSED_BY_TAOBAO(付款以前，卖家或买家主动关闭交易)PAY_PENDING(国际信用卡支付付款确认中)
        /// </summary>
        public string Status { get; set; }

        public int? StateNum { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 交易类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 商品价格。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 发货方式
        /// smt:发货类型"SELLER_SEND_GOODS": 卖家发货; "WAREHOUSE_SEND_GOODS":仓库发货
        /// </summary>
        public string is_sh_ship { get; set; }

        /// <summary>
        /// 商品数字ID
        /// </summary>
        public string NumId { get; set; }
        /// <summary>
        /// tem_meal_id Number 2564854632套餐ID
        /// </summary>
        public string ItemMealId { get; set; }
        /// <summary>
        /// 商品的最小库存单位Sku的id.可以通过taobao.item.sku.get获取详细的Sku信息
        /// </summary>
        public string SkuId { get; set; }
        /// <summary>
        /// 购买数量。取值范围:大于零的整数
        /// </summary>
        public string Num { get; set; }
        /// <summary>
        /// 外部网店自己定义的Sku编号
        /// </summary>
        public string OutSkuId { get; set; }
        /// <summary>
        /// 子订单来源,如jhs(聚划算)、taobao(淘宝)、wap(无线)
        /// </summary>
        public string OrderFrom { get; set; }
        /// <summary>
        /// 应付金额（商品价格 * 商品数量 + 手工调整金额 - 子订单级订单优惠金额）。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        public string TotalFee { get; set; }
        /// <summary>
        /// 子订单实付金额。精确到2位小数，单位:元。如:200.07，表示:200元7分。对于多子订单的交易，计算公式如下：payment = price * num + adjust_fee - discount_fee ；单子订单交易，payment与主订单的payment一致，对于退款成功的子订单，由于主订单的优惠分摊金额，会造成该字段可能不为0.00元。建议使用退款前的实付金额减去退款单中的实际退款金额计算。
        /// </summary>
        public string Payment { get; set; }
        /// <summary>
        /// 子订单级订单优惠金额。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        public string DiscountFee { get; set; }
        /// <summary>
        /// 手工调整金额.格式为:1.01;单位:元;精确到小数点后两位.
        /// </summary>
        public string AdjustFee { get; set; }
        ///// <summary>
        ///// 订单修改时间，目前只有taobao.trade.ordersku.update会返回此字段。
        ///// </summary>
        //public string Modified { get; set; }
        /// <summary>
        /// SKU的值。如：机身颜色:黑色;手机套餐:官方标配
        /// </summary>
        public string SkuPropertiesName { get; set; }
        /// <summary>
        /// 子订单的交易结束时间说明：子订单有单独的结束时间，与主订单的结束时间可能有所不同，在有退款发起的时候或者是主订单分阶段付款的时候，子订单的结束时间会早于主订单的结束时间，所以开放这个字段便于订单结束状态的判断
        /// </summary>
        public string EndTime { get; set; }


    
        public bool? EnabledMark { get; set; }
        public string Description { get; set; }
        public int? SortCode { get; set; }


        //=========2019-10-31 LDZ  smt============
        /// <summary>
        /// 优惠金额
        /// </summary>
        public string Discount { get; set; }

        /// <summary>
        /// 销售单价
        /// </summary>
        public string oPrice { get; set; }

        /// <summary>
        /// 佣金比例
        /// </summary>
        public string EscrowFeeRate { get; set; }

        /// <summary>
        /// 佣金
        /// </summary>
        public string EscrowFee { get; set; }

        /// <summary>
        /// 联盟佣金比例
        /// </summary>
        public decimal? AfflicateFeeRate { get; set; }
        /// <summary>
        /// 联盟佣金费用
        /// </summary>
        public decimal? AfflicateFee { get; set; }

        /// <summary>
        /// 搭售数量
        /// </summary>
        public int? TyingNum { get; set; }

        public decimal? Cost { get; set; }

        public decimal? YJCost { get; set; }

        public decimal? YJBillingAmount { get; set; }
        /// <summary>
        /// 天猫费用
        /// </summary>
        public decimal? BillingAmount { get; set; }
        /// <summary>
        /// 打包费
        /// </summary>
        public decimal? PackAmount { get; set; }
        /// <summary>
        /// 运费
        /// </summary>
        public decimal? MailNoAmount { get; set; }
        /// <summary>
        /// 订单操作费
        /// </summary>
        public decimal? OrdeActionAmount { get; set; }

        public DateTime? PayTime { get; set; }
    }
}
