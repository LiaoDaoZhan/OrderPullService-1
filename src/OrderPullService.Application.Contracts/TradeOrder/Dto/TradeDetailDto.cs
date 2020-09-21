using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.TradeOrder.Dto
{
    public partial class TradeDetailDto : Volo.Abp.Data.IHasExtraProperties
    {
        public TradeDetailDto()
        {
            ExtraProperties = new Dictionary<string, object>();
        }
        //public string OsGiftCount { get; set; }
        
        //public string OsSortNum { get; set; }
        //public string OutItemId { get; set; }
        //public string OutUniqueId { get; set; }
        //public string OuterIid { get; set; }
        //public string OuterSkuId { get; set; }
        //public string OsFgItemId { get; set; }
        //public string PartMjzDiscount { get; set; }
        //public string Penalty { get; set; }
        /// <summary>
        /// 商品图片路径
        /// </summary>
        public string PicPath { get; set; }
        //public string PlatformSubsidyFee { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// 信用购履约结束时间
        /// </summary>
        public string PromiseEndTime { get; set; }
        /// <summary>
        /// 时效服务字段，服务字段，会有多个服务值，以英文半角逗号","切割
        /// </summary>
        public string PromiseService { get; set; }
        /// <summary>
        /// 使用淘金币的数量，以分为单位，和订单标propoint中间那一段一样
        /// </summary>
        public string Propoint { get; set; }
        /// <summary>
        /// 子订单实付金额。精确到2位小数，单位:元。如:200.07，表示:200元7分。对于多子订单的交易，计算公式如下：payment = price * num + adjust_fee - discount_fee ；单子订单交易，payment与主订单的payment一致，对于退款成功的子订单，由于主订单的优惠分摊金额，会造成该字段可能不为0.00元。建议使用退款前的实付金额减去退款单中的实际退款金额计算。
        /// </summary>
        public string Payment { get; set; }
        //public string RechargeFee { get; set; }
        /// <summary>
        /// 预约配送，用户预约时间
        /// </summary>
        public string OsDate { get; set; }
        /// <summary>
        /// 预约配送，用户预约时间段
        /// </summary>
        public string OsRange { get; set; }
        //public string OrderTaking { get; set; }
        //public string ModifyAddress { get; set; }
        //public string MonthPayment { get; set; }
        //public string NrOuterIid { get; set; }
        //public string NrReduceInvFail { get; set; }
        //public string RetailStoreId { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public long Num { get; set; }
        /// <summary>
        /// 商品数字ID
        /// </summary>
        public long NumIid { get; set; }
        /// <summary>
        /// 订单详情标识
        /// </summary>
        public long Oid { get; set; }
        /// <summary>
        /// 	经销商货品商家编码
        /// </summary>
        public string OmniJxsOuterid { get; set; }
        /// <summary>
        /// 子订单扩展属性: is_free_down_payment:是否免首付：true：是，false：否，可选字段 car_back_payment:返还免首付金额，单位：分， car_ref_activity_id:服务商传入活动ID，依赖外部服务商传入
        /// </summary>
        public string OrderAttr { get; set; }
        /// <summary>
        /// 子订单来源,如jhs(聚划算)、taobao(淘宝)、wap(无线)
        /// </summary>
        public string OrderFrom { get; set; }
        /// <summary>
        /// 	交易修改时间(用户对订单的任何修改都会更新此字段)。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime Modified { get; set; }
        /// <summary>
        /// 最近退款ID
        /// </summary>
        public string RefundId { get; set; }
        /// <summary>
        /// 天猫国际官网直供子订单关税税费
        /// </summary>
        public string SubOrderTaxFee { get; set; }
        /// <summary>
        /// 	天猫国际子订单计税优惠金额
        /// </summary>
        public string SubOrderTaxPromotionFee { get; set; }
        /// <summary>
        /// 天猫国际官网直供子订单关税税率
        /// </summary>
        public string SubOrderTaxRate { get; set; }

        //public string TailPayment { get; set; }
        /// <summary>
        /// 天猫国际订单包税金额
        /// </summary>
        public string TaxCouponDiscount { get; set; }
        /// <summary>
        /// 	天猫国际订单是否包税
        /// </summary>
        public bool TaxFree { get; set; }
        /// <summary>
        /// 买家修改地址时间
        /// </summary>
        public string TiModifyAddressTime { get; set; }
        /// <summary>
        /// 	发货的仓库编码
        /// </summary>
        public string StoreCode { get; set; }
        #region 门票类信息
        /// <summary>
        /// 	门票有效期的key
        /// </summary>
        public string TicketExpdateKey { get; set; }
        /// <summary>
        /// 	对应门票有效期的外部id
        /// </summary>
        public string TicketOuterId { get; set; }
        #endregion
        /// <summary>
        /// 	订单超时到期时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string TimeoutActionTime { get; set; }
        /// <summary>
        /// 时效服务身份，如tmallPromise代表天猫时效承诺
        /// </summary>
        public string TimingPromise { get; set; }
        /// <summary>
        /// 	商品标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 支持家装类物流的类型
        /// </summary>
        public string TmserSpuCode { get; set; }
        /// <summary>
        /// 	商品金额（商品价格乘以数量的总金额）。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        public decimal TotalFee { get; set; }
        /// <summary>
        /// 交易类型列表，同时查询多种交易类型可用逗号分隔。默认同时查询
        /// guarantee_trade,
        /// auto_delivery,
        /// ec,
        /// cod的4种交易类型的数据 可选值 fixed(一口价) auction(拍卖) guarantee_trade(一口价、拍卖) auto_delivery(自动发货) independent_simple_trade(旺店入门版交易) independent_shop_trade(旺店标准版交易) ec(直冲) cod(货到付款) fenxiao(分销) game_equipment(游戏装备) shopex_trade(ShopEX交易) netcn_trade(万网交易) external_trade(统一外部交易)o2o_offlinetrade（O2O交易）step (万人团)nopaid(无付款订单)pre_auth_type(预授权0元购机交易)
        /// </summary>
        public string Type { get; set; }

        //public string WsBankApplyNo { get; set; }
       
        /// <summary>
        /// 退款状态。退款状态。可选值 WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意) WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货) WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货) SELLER_REFUSE_BUYER(卖家拒绝退款) CLOSED(退款关闭) SUCCESS(退款成功)
        /// </summary>
        public string RefundStatus { get; set; }
        /// <summary>
        /// 订单状态（请关注此状态，如果为TRADE_CLOSED_BY_TAOBAO状态，则不要对此订单进行发货，切记啊！）。可选值:
        /// TRADE_NO_CREATE_PAY(没有创建支付宝交易)
        /// WAIT_BUYER_PAY(等待买家付款)
        ///WAIT_SELLER_SEND_GOODS(等待卖家发货, 即:买家已付款)
        ///WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货, 即:卖家已发货)
        ///TRADE_BUYER_SIGNED(买家已签收, 货到付款专用)
        /// TRADE_FINISHED(交易成功)
        ///TRADE_CLOSED(付款以后用户退款成功，交易自动关闭)
        ///TRADE_CLOSED_BY_TAOBAO(付款以前，卖家或买家主动关闭交易)
        ///PAY_PENDING(国际信用卡支付付款确认中)
        /// </summary>
        public string Status { get; set; }
        //public string SortInfo { get; set; }
        /// <summary>
        /// 新零售全渠道订单：商家自有货品编码
        /// </summary>
        public string RtOmniOuterScId { get; set; }
        /// <summary>
        /// 	新零售全渠道订单：后端货品ID
        /// </summary>
        public string RtOmniScId { get; set; }
        //public string STariffFee { get; set; }
        /// <summary>
        /// 卖家昵称
        /// </summary>
        public string SellerNick { get; set; }
        /// <summary>
        /// 卖家是否已评价。可选值:true(已评价),false(未评价)
        /// </summary>
        public bool SellerRate { get; set; }
        /// <summary>
        /// 卖家类型，可选值为：B（商城商家），C（普通卖家）
        /// </summary>
        public string SellerType { get; set; }
        /// <summary>
        /// 	服务详情的URL地址
        /// </summary>
        public string ServiceDetailUrl { get; set; }
        /// <summary>
        /// 	特殊的退款类型，比如直播返现、价保
        /// </summary>
        public string SpecialRefundType { get; set; }
        /// <summary>
        /// 服务费用
        /// </summary>
        public string ServiceFee { get; set; }
        /// <summary>
        /// 	仓储信息
        /// </summary>
        public string Shipper { get; set; }
        /// <summary>
        /// 	创建交易时的物流方式（交易完成前，物流方式有可能改变，但系统里的这个字段一直不变）。可选值：free(卖家包邮),post(平邮),express(快递),ems(EMS),virtual(虚拟发货)，25(次日必达)，26(预约配送)。
        /// </summary>
        public string ShippingType { get; set; }
        /// <summary>
        /// 	最晚签收时间
        /// </summary>
        public string SignTime { get; set; }
        /// <summary>
        /// 商品的最小库存单位Sku的id.可以通过taobao.item.sku.get获取详细的Sku信息
        /// </summary>
        public string SkuId { get; set; }
        /// <summary>
        /// SKU的值。如：机身颜色:黑色;手机套餐:官方标配
        /// </summary>
        public string SkuPropertiesName { get; set; }
        /// <summary>
        /// 	订单快照详细信息
        /// </summary>
        public string Snapshot { get; set; }
        /// <summary>
        /// 	订单快照URL
        /// </summary>
        public string SnapshotUrl { get; set; }
        /// <summary>
        /// 	服务数字id
        /// </summary>
        public long ServiceId { get; set; }
        #region 面单信息
        //public string Xxx { get; set; }
        /// <summary>
        /// 	免单资格属性 	true_免单原因
        /// </summary>
        public string MdQualification { get; set; }
        /// <summary>
        /// 面单金额
        /// </summary>

        public string MdFee { get; set; }

        #endregion
        /// <summary>
        /// 物流公司
        /// </summary>
        public string LogisticsCompany { get; set; }
        //public string ClCarTaker { get; set; }
        //public string ClCarTakerIDNum { get; set; }
        //public string ClCarTakerIdNum { get; set; }
        //public string ClCarTakerPhone { get; set; }
        //public string ClDownPayment { get; set; }
        //public string ClDownPaymentRatio { get; set; }
        //public string ClInstallmentNum { get; set; }
        //public long Cid { get; set; }
        //public string ClMonthPayment { get; set; }
        //public string ClTailPayment { get; set; }
        /// <summary>
        /// 值为1，且bizCode不为tmall.daogoubao.cloudstore时，为旗舰店订单
        /// </summary>
        public string CloudStore { get; set; }
        //public string CloudStoreBindPos { get; set; }
        //public string CloudStoreToken { get; set; }
        //public string ClServiceFee { get; set; }
        //public string CarTakerPhone { get; set; }
        //public string CarTakerId { get; set; }      
        //public string CarTakerIdNum { get; set; }


        /// <summary>
        /// 天猫搭配宝
        /// </summary>
        public string ComboId { get; set; }
        /// <summary>
        /// 	卖家发货时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? ConsignTime { get; set; }
        /// <summary>
        /// 有值表示信用购订单；1表示信用购一期；2表示信用购二期；3表示信用购三期
        /// </summary>
        public string CreditBuy { get; set; }
     
        /// <summary>
        /// 手工优惠金额
        /// </summary>
        public string AdjustFee { get; set; }
        
        public string AssemblyItem { get; set; }
        /// <summary>
        /// 	价格
        /// </summary>
        public string AssemblyPrice { get; set; }
        /// <summary>
        /// 	主商品订单id
        /// </summary>
        public string AssemblyRela { get; set; }
        /// <summary>
        /// 捆绑的子订单号，表示该子订单要和捆绑的子订单一起发货，用于卖家子订单捆绑发货
        /// </summary>
        public long BindOid { get; set; }
        /// <summary>
        /// bind_oid字段的升级，支持返回绑定的多个子订单，多个子订单以半角逗号分隔 
        /// </summary>
        public string BindOids { get; set; }
        /// <summary>
        /// bind_oids字段的升级，在交易成功和交易关闭状态下也能获取到，支持返回绑定的多个子订单，多个子订单以半角逗号分隔
        /// </summary>
        public string BindOidsAllStatus { get; set; }

        /// <summary>
        /// 为tmall.daogoubao.cloudstore时表示云店链路
        /// </summary>
        public string BizCode { get; set; }
        /// <summary>
        /// 	同城购门店id
        /// </summary>
        public string BrandLightShopStoreId { get; set; }
       /// <summary>
       /// 购买者昵称
       /// </summary>
        public string BuyerNick { get; set; }
        /// <summary>
        /// 买家是否已评价。可选值:true(已评价),false(未评价)。如买家只评价未打分，此字段仍返回false
        /// </summary>
        public bool BuyerRate { get; set; }

        //public string CalPenalty { get; set; }

        //public string CarStoreCode { get; set; }

        //public string CarStoreName { get; set; }

        //public string CarTaker { get; set; }
        /// <summary>
        /// 同城购订单source
        /// </summary>
        public string BrandLightShopSource { get; set; }

        /// <summary>
        /// 定制信息
        /// </summary>
        public string Customization { get; set; }
        /// <summary>
        /// 最晚发货时间
        /// </summary>
        public string DeliveryTime { get; set; }
              
        public string InstallmentNum { get; set; }
        /// <summary>
        /// 库存类型：6为在途
        /// </summary>
        public string InvType { get; set; }
        /// <summary>
        /// 子订单所在包裹的运单号
        /// </summary>
        public string InvoiceNo { get; set; }
        /// <summary>
        /// 表示订单交易是否含有对应的代销采购单。如果该订单中存在一个对应的代销采购单，那么该值为true；反之，该值为false。
        /// </summary>
        public bool IsDaixiao { get; set; }
        /// <summary>
        /// 	子订单优惠贬值
        /// </summary>
        public bool IsDevalueFee { get; set; }
        /// <summary>
        /// 是否商家承担手续费
        /// </summary>
        public bool IsFqgSFee { get; set; }
        /// <summary>
        /// 	云店是否扣拥
        /// </summary>
        public string HjSettleNoCommission { get; set; }
       /// <summary>
       /// 是否为考拉订单
       /// </summary>
        public bool IsKaola { get; set; }
        /// <summary>
        /// 是否是服务订单，是返回true，否返回false。
        /// </summary>
        public bool IsServiceOrder { get; set; }
        /// <summary>
        /// 	是否发货
        /// </summary>
        public bool IsShShip { get; set; }
        /// <summary>
        /// 子订单是否是www订单
        /// </summary>
        public bool IsWww { get; set; }
        /// <summary>
        /// 	套餐ID
        /// </summary>
        public long ItemMealId { get; set; }
       /// <summary>
       /// 套餐名称
       /// </summary>
        public string ItemMealName { get; set; }
       /// <summary>
       /// 套餐备注
       /// </summary>
        public string ItemMemo { get; set; }
       /// <summary>
       /// 套餐对应的订单详情Id
       /// </summary>
        public long ItemOid { get; set; }
        /// <summary>
        /// 是否超卖
        /// </summary>
        public bool IsOversold { get; set; }
        /// <summary>
        /// 物流截单时间，分钟
        /// </summary>
        public string CutoffMinutes { get; set; }
        /// <summary>
        /// 花呗分期期数
        /// </summary>
        public long FqgNum { get; set; }
        /// <summary>
        /// 单履行内容，如喵鲜生极速达：storeId,phone
        /// </summary>
        public string FTerm { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public string DiscountFee { get; set; }

        /// <summary>
        /// 最晚揽收时间
        /// </summary>
        public string CollectTime { get; set; }
        /// <summary>
        /// 最晚派送时间
        /// </summary>
        public string DispatchTime { get; set; }
        /// <summary>
        /// 分摊之后的实付金额
        /// </summary>
        public string DivideOrderFee { get; set; }
       
        //public string DownPayment { get; set; }
       
        //public string DownPaymentRatio { get; set; }
           /// <summary>
           /// 结束时间
           /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// 预计送达时间 yyyyMMdd	
        /// </summary>
        public string EsDate { get; set; }

        /// <summary>
        /// 预计送达时间 格式 hh:mm-hh:mm
        /// </summary>
        public string EsRange { get; set; }

        /// <summary>
        /// 子订单预计发货时间
        /// </summary>
        public string EstimateConTime { get; set; }
        
        //public string EtPlateNumber { get; set; }
        
        //public string EtSerTime { get; set; }
        
        //public string EtShopName { get; set; }
        
        //public string EtVerifiedShopName { get; set; }
        
        /// <summary>
        /// 扩展信息
        /// </summary>
        public string ExtendInfo { get; set; }
        /// <summary>
        /// 订单履行状态，如喵鲜生极速达：分单完成
        /// </summary>
        public string FStatus { get; set; }
        /// <summary>
        /// 物流时效，相对时间，单位是天
        /// </summary>
        public string EsTime { get; set; }
        ///// <summary>
        ///// 征集预售订单征集状态：1（征集中），2（征集成功），3（征集失败）
        ///// </summary>
        //public string ZhengjiStatus { get; set; }
        
        public Dictionary<string, object> ExtraProperties { get;protected set; }
    }
}
