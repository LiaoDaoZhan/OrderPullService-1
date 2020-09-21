using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService
{
    /// <summary>
    /// 交易号状态（和线上一致）
    /// </summary>
    public enum TradeStatus
    {
        /// <summary>
        /// //等待买家付款
        /// </summary>
        WAIT_BUYER_PAY = 1,
        /// <summary>
        /// 等待卖家发货
        /// </summary>
        WAIT_SELLER_SEND_GOODS = 2,
        /// <summary>
        /// 卖家部分发货
        /// </summary>
        SELLER_CONSIGNED_PART = 3,
        /// <summary>
        /// 等待买家确认收货
        /// </summary>
        WAIT_BUYER_CONFIRM_GOODS = 4,
        /// <summary>
        /// 买家已签收（货到付款专用）
        /// </summary>
        TRADE_BUYER_SIGNED = 5,
        /// <summary>
        /// 交易成功
        /// </summary>
        TRADE_FINISHED = 6,
        /// <summary>
        /// 交易关闭
        /// </summary>
        TRADE_CLOSED = 7,
        /// <summary>
        /// 交易被淘宝关闭
        /// </summary>
        TRADE_CLOSED_BY_TAOBAO = 8,
        /// <summary>
        /// 没有创建外部交易（支付宝交易）
        /// </summary>
        TRADE_NO_CREATE_PAY = 9,
        /// <summary>
        /// 余额宝0元购合约中
        /// </summary>
        WAIT_PRE_AUTH_CONFIRM = 10,
        /// <summary>
        /// 外卡支付付款确认中
        /// </summary>
        PAY_PENDING = 11,
        /// <summary>
        /// 所有买家未付款的交易（包含：WAIT_BUYER_PAY、TRADE_NO_CREATE_PAY）
        /// </summary>
        ALL_WAIT_PAY = 12,
        /// <summary>
        /// 所有关闭的交易（包含：TRADE_CLOSED、TRADE_CLOSED_BY_TAOBAO）
        /// </summary>
        ALL_CLOSED = 13,
        /// <summary>
        /// 该状态代表订单已付款但是处于禁止发货状态。 
        /// </summary>
        PAID_FORBID_CONSIGN = 14,
        /// <summary>
        /// 取消订单
        /// </summary>
        TRADE_CANCEL = 15,
        /// <summary>
        /// 妥投失败
        /// </summary>
        TRADE_RECEIVE_FAIL = 16,

        /// <summary>
        /// 资金处理  SMT
        /// </summary>
        FUND_PROCESSING = 17
    }
}
