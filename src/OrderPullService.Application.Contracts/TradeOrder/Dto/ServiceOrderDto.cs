using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.TradeOrder.Dto
{
    /// <summary>
    /// 订单服务
    /// </summary>
    public class ServiceOrderDto
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        public long ServiceId { get; set; }
        /// <summary>
        /// 服务详情地址
        /// </summary>
        public string ServiceDetailUrl { get; set; }
        
        /// <summary>
        /// 卖家昵称
        /// </summary>
        public string SellerNick { get; set; }
        
        /// <summary>
        /// 退款ID
        /// </summary>
        public string RefundId { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// 商品地址
        /// </summary>
        public string PicPath { get; set; }
        /// <summary>
        /// 付款
        /// </summary>
        public string Payment { get; set; }
        /// <summary>
        /// 订单标识字符串
        /// </summary>
        public string OidStr { get; set; }
        /// <summary>
        /// 订单标识
        /// </summary>
        public long Oid { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public long Num { get; set; }
        /// <summary>
        /// 订单对应的项目ID
        /// </summary>
        public long ItemOid { get; set; }
        
        public string EtVerifiedShopName { get; set; }
        
        public string EtShopName { get; set; }
        
        public string EtSerTime { get; set; }
        
        public string EtPlateNumber { get; set; }
        /// <summary>
        /// 购买者昵称
        /// </summary>
        public string BuyerNick { get; set; }
        
        public string AppleCareMpn { get; set; }
        /// <summary>
        /// apple care+
        /// </summary>
        public string AppleCareEmail { get; set; }
        
        public string TmserSpuCode { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public string TotalFee { get; set; }
    }
}
