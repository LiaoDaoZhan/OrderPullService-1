using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace OrderPullService
{
    /// <summary>
    /// 交易订单
    /// </summary>
    public class Trade : FullAuditedAggregateRoot<Guid>
    {
        public string OriTradeId { get; set; }
        /// <summary>
        ///  //F_States 1:未下单 2:已下单 3:交易/订单数据异常 5：状态异常 6：未知
        /// </summary>
        public string SellStates { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public Guid ShopId { get; set; }
        /// <summary>
        /// 卖家昵称
        /// </summary>
        public string SellerNick { get; set; }
        /// <summary>
        /// 商品图片绝对途径
        /// </summary>
        public string PicPath { get; set; }
        /// <summary>
        /// 实付金额。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        public string Payment { get; set; }


        /// <summary>
        /// 卖家是否已评价。可选值:true(已评价),false(未评价)
        /// </summary>
        public bool SellerRate { get; set; }
        /// <summary>
        /// 邮费。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        public string PostFee { get; set; }
        /// <summary>
        /// 收货人的姓名
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人的所在省份
        /// </summary>
        public string ReceiverState { get; set; }

        /// <summary>
        /// 收货人的详细地址
        /// </summary>
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 收货人的邮编
        /// </summary>
        public string ReceiverZip { get; set; }

        /// <summary>
        /// 收货人的手机号码
        /// </summary>
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收货人的电话号码
        /// </summary>
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 卖家发货时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string ConsignTime { get; set; }

        /// <summary>
        /// 卖家实际收到的支付宝打款金额（由于子订单可以部分确认收货，这个金额会随着子订单的确认收货而不断增加，交易成功后等于买家实付款减去退款金额）。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        public string ReceivedPayment { get; set; }

        /// <summary>
        /// 收货人国籍
        /// </summary>
        public string ReceiverCountry { get; set; }

        /// <summary>
        /// 收货人街道地址
        /// </summary>
        public string ReceiverTown { get; set; }

        /// <summary>
        /// 交易编号 (父订单的交易编号)
        /// </summary>
        public string Tid { get; set; }


        /// <summary>
        /// 币种  空默认为RMB
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 商品数字编号
        /// </summary>
        public string ItemNumber { get; set; }

        /// <summary>
        /// 交易状态。可选值: * TRADE_NO_CREATE_PAY(没有创建支付宝交易) * WAIT_BUYER_PAY(等待买家付款) * SELLER_CONSIGNED_PART(卖家部分发货) * WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款) * WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货) * TRADE_BUYER_SIGNED(买家已签收,货到付款专用) *  (交易成功) * TRADE_CLOSED(付款以后用户退款成功，交易自动关闭) * TRADE_CLOSED_BY_TAOBAO(付款以前，卖家或买家主动关闭交易) * PAY_PENDING(国际信用卡支付付款确认中) * WAIT_PRE_AUTH_CONFIRM(0元购合约中)	* PAID_FORBID_CONSIGN(拼团中订单，已付款但禁止发货)
        /// =======
        /// 速卖通：PLACE_ORDER_SUCCESS:等待买家付款; IN_CANCEL:买家申请取消; WAIT_SELLER_SEND_GOODS:等待您发货; SELLER_PART_SEND_GOODS:部分发货; WAIT_BUYER_ACCEPT_GOODS:等待买家收货; FUND_PROCESSING:买卖家达成一致，资金处理中； IN_ISSUE:含纠纷中的订单; IN_FROZEN:冻结中的订单; WAIT_SELLER_EXAMINE_MONEY:等待您确认金额; RISK_CONTROL:订单处于风控24小时中，从买家在线支付完成后开始，持续24小时。 以上状态查询可分别做单独查询，不传订单状态查询订单信息不包含（FINISH，已结束订单状态） FINISH:已结束的订单，需单独查询。
        /// </summary>
        public string Status { get; set; }


        /// <summary>
        /// 交易号状态的中文解释 
        /// </summary>
        public string Statu_CN { get; set; }

        /// <summary>
        /// 交易标题，以店铺名作为此标题的值。注:taobao.trades.get接口返回的Trade中的title是商品名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 交易类型列表，同时查询多种交易类型可用逗号分隔。默认同时查询guarantee_trade, auto_delivery, ec, cod的4种交易类型的数据 可选值 fixed(一口价) auction(拍卖) guarantee_trade(一口价、拍卖) auto_delivery(自动发货) independent_simple_trade(旺店入门版交易) independent_shop_trade(旺店标准版交易) ec(直冲) cod(货到付款) fenxiao(分销) game_equipment(游戏装备) shopex_trade(ShopEX交易) netcn_trade(万网交易) external_trade(统一外部交易)o2o_offlinetrade（O2O交易）step (万人团)nopaid(无付款订单)pre_auth_type(预授权0元购机交易)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 商品价格。精确到2位小数；单位：元。如：200.07，表示：200元7分
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 商品金额（商品价格乘以数量的总金额）。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        public string TotalFee { get; set; }

        /// <summary>
        /// 交易创建时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// 付款时间。格式:yyyy-MM-dd HH:mm:ss。订单的付款时间即为物流订单的创建时间。
        /// </summary>
        public DateTime? PayTime { get; set; }
        /// <summary>
        /// 交易修改时间(用户对订单的任何修改都会更新此字段)。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string Modified { get; set; }

        /// <summary>
        /// 交易结束时间。交易成功时间(更新交易状态为成功的同时更新)/确认收货时间或者交易关闭时间 。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 买家留言
        /// </summary>
        public string BuyerMessage { get; set; }

        /// <summary>
        /// 买家备注（与淘宝网上订单的买家备注对应，只有买家才能查看该字段
        /// </summary>
        public string BuyerMemo { get; set; }

        /// <summary>
        /// 买家备注旗帜（与淘宝网上订单的买家备注旗帜对应，只有买家才能查看该字段）红、黄、绿、蓝、紫 分别对应 1、2、3、4、5
        /// </summary>
        public string BuyerFlag { get; set; }

        /// <summary>
        /// 卖家备注旗帜（与淘宝网上订单的卖家备注旗帜对应，只有卖家才能查看该字段）红、黄、绿、蓝、紫 分别对应 1、2、3、4、5
        /// </summary>
        public string SellerFlag { get; set; }

        /// <summary>
        /// 卖家备注（与淘宝网上订单的卖家备注对应，只有卖家才能查看该字段）
        /// </summary>
        public string SellerMemo { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerNick { get; set; }


        /// <summary>
        /// 买家登录Id
        /// </summary>
        public string BuyerLoginId { get; set; }


        /// <summary>
        /// 卖家手工调整金额，精确到2位小数，单位：元。如：200.07，表示：200元7分。来源于订单价格修改，如果有多笔子订单的时候，这个为0，单笔的话则跟[order].adjust_fee一样
        /// </summary>
        public string AdjustFee { get; set; }

        /// <summary>
        /// 交易内部来源。WAP(手机);HITAO(嗨淘);TOP(TOP平台);TAOBAO(普通淘宝);JHS(聚划算)一笔订单可能同时有以上多个标记，则以逗号分隔
        /// </summary>
        public string TradeFrom { get; set; }

        /// <summary>
        /// 买家是否已评价。可选值:true(已评价),false(未评价)。如买家只评价未打分，此字段仍返回false
        /// </summary>
        public bool BuyerRate { get; set; }
        /// <summary>
        /// 收货人的所在城市注：因为国家对于城市和地区的划分的有：省直辖市和省直辖县级行政区（区级别的）划分的，淘宝这边根据这个差异保存在不同字段里面比如：广东广州：广州属于一个直辖市是放在的receiver_city的字段里面；而河南济源：济源属于省直辖县级行政区划分，是区级别的，放在了receiver_district里面建议：程序依赖于城市字段做物流等判断的操作，最好加一个判断逻辑：如果返回值里面只有receiver_district参数，该参数作为城市
        /// </summary>
        public string ReceiverCity { get; set; }

        /// <summary>
        /// 收货人的所在地区注：因为国家对于城市和地区的划分的有：省直辖市和省直辖县级行政区（区级别的）划分的，淘宝这边根据这个差异保存在不同字段里面比如：广东广州：广州属于一个直辖市是放在的receiver_city的字段里面；而河南济源：济源属于省直辖县级行政区划分，是区级别的，放在了receiver_district里面建议：程序依赖于城市字段做物流等判断的操作，最好加一个判断逻辑：如果返回值里面只有receiver_district参数，该参数作为城市
        /// </summary>
        public string ReceiverDistrict { get; set; }

        /// <summary>
        /// 发货仓库 0：普通仓库 1：菜鸟仓库 2：京东仓库
        /// </summary>
        public int DeliveryWarehouse { get; set; }

        public TradeInvoice Invoice { get; set; }

        /// <summary>
        /// 是否开具发票
        /// </summary>
        public bool? IsInvoice { get; set; }

        /// <summary>
        /// 是否已经被使用
        /// </summary>
        public bool? IsUse { get; set; }

        /// <summary>
        /// 交易号来源平台
        /// （京东，天猫(淘宝),苏宁）
        /// </summary>
        public string Source { get; set; }

        public bool? EnabledMark { get; set; }
        public string Description { get; set; }

        public int? SortCode { get; set; }

        /// <summary>
        /// 返回的报文
        /// </summary>
        public string ReponseData { get; set; }


        /// <summary>
        /// 时效服务身份，如tmallPromise代表天猫时效承诺
        /// </summary>
        public string TimingPromise { get; set; }

        /// <summary>
        /// 时效：天,
        /// 相对到达时间，单位为天，0当日达，1次日达，2三日达，3四日达，4五日达
        /// </summary>
        public string EsTime { get; set; }

        /// <summary>
        /// 承诺服务类型，会有多个服务值，以英文半角逗号","切割，其中 tmallpromise.arrival.timing代表到货承诺时效 tmallpromise.consign.timing代表发货承诺时效
        /// </summary>
        public string PromiseService { get; set; }


        /// <summary>
        /// 最晚发货时间，日期，格式2019-04-12 16:00:00 时间等同于最晚揽收时间；
        /// </summary>
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 交易状态，详情查看交易号状态枚举TradeState
        /// </summary>
        public int? StateNum { get; set; }


        //========2019-10-31 LDZ smt=======
        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime? SendTime { get; set; }
        /// <summary>
        /// 放款金额
        /// </summary>
        public string LoanAmount { get; set; }
        /// <summary>
        /// 放款时间
        /// </summary>
        public string LoanTime { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 妥投时间
        /// </summary>
        public string GmtReceived { get; set; }


        /// <summary>
        /// 快递费用的佣金比例
        /// </summary>
        public string EscrowFeeEpxressRate { get; set; }



        /// <summary>
        /// 快递费用佣金
        /// </summary>
        public string EscrowFeeEpxress { get; set; }


        /// <summary>
        /// 佣金
        /// </summary>
        public string EscrowFee { get; set; }


        /// <summary>
        /// 联盟佣金
        /// </summary>
        public decimal? AfflicateFee { get; set; }
        /// <summary>
        /// 订单自动处理结果标志
        /// </summary>
        public bool AutoDealFlag { get; set; }

        public string Mailno { get; set; }


        /// <summary>
        /// 更新为总的订单操作费用  包含 订单操作费+包装物料费+正向配送费
        /// </summary>
        public decimal? BillingAmount { get; set; }


        /// <summary>
        /// 包装物料费
        /// </summary>
        public decimal? PackAmount { get; set; }

        /// <summary>
        /// 正向配送费
        /// </summary>
        public decimal? MailNoAmount { get; set; }

        /// <summary>
        /// 订单操作费
        /// </summary>
        public decimal? OrdeActionAmount { get; set; }


        /// <summary>
        /// 预计运费 速卖通
        /// </summary>
        public decimal? YJYunFei { get; set; }

        /// <summary>
        /// 妥投状态
        /// </summary>
        public string ReceiveStatus { get; set; }


        /// <summary>
        /// 妥投失败原因
        /// </summary>
        public string RecvStatusDesc { get; set; }


        /// <summary>
        /// 物流状态
        /// </summary>
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 是否修改收货信息
        /// </summary>
        public bool? IsChangeInfo { get; set; }

        /// <summary>
        /// 资金冻结状态
        /// </summary>
        public string FrozenStatus { get; set; }

        /// <summary>
        /// 资金状态
        /// </summary>
        public string FundStatus { get; set; }


        /// <summary>
        /// 纠纷状态
        /// </summary>
        public string IssueStatus { get; set; }

        /// <summary>
        /// 纠纷信息类型
        /// </summary>
        public string IssueInfoModel { get; set; }

        /// <summary>
        ///纠纷信息状态
        /// </summary>
        public string IssueInfoStatus { get; set; }

        /// <summary>
        /// 纠纷创建时间
        /// </summary>
        public string IssueInfoTime { get; set; }

        /// <summary>
        /// 订单结束原因
        /// </summary>
        public string OrderEndReason { get; set; }


        /// <summary>
        /// 退款现金金额(不包括coupon)
        /// </summary>
        public string RefundCashAmt { get; set; }


        /// <summary>
        /// 退款coupon金额
        /// </summary>
        public string RefundCouponAmt { get; set; }


        public string RefundReason { get; set; }

        public string RefundStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RefundTime { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string RefundType { get; set; }

        public string CancelRequestReason { get; set; }

        public virtual IList<TradeDetail> Details { get; set; }
    }
}
