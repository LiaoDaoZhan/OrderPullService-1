using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.XhsService
{
    public class ItemDetail
    {
        /// <summary>
        /// 商品条码
        /// </summary>
        public string barcode { get; set; }

        /// <summary>
        /// 小红书编码
        /// </summary>
        public string skucode { get; set; }

        /// <summary>
        /// 商品编名称
        /// </summary>
        public string item_name { get; set; }

        /// <summary>
        /// 购买数量    
        /// </summary>
        public string qty { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        public string price { get; set; }

        /// <summary>
        /// 实际支付价格
        /// </summary>
        public string pay_price { get; set; }
        /// <summary>
        /// 单件商品商家承担的优惠，一般包括商家配置的薯券和商家设置的促销，例如限时特价，满减和任选等。
        /// </summary>
        public string merchant_discount { get; set; }
        /// <summary>
        /// 单件商品小红书承担的优惠，一般为全场通用薯券，例如新人薯券，全场通用券等。
        /// </summary>
        public string red_discount { get; set; }


    }
}
