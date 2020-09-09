using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.XhsService
{
    public class TradeDetail
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string package_id { get; set; }
        /// <summary>
        /// 客户下单时间
        /// </summary>
        public long time { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary>
        public long? pay_time { get; set; }

        /// <summary>
        /// 确认收货时间
        /// </summary>
        public long? confirm_time { get; set; }

        /// <summary>
        /// 快递公司编码
        /// </summary>
        public string express_company_code { get; set; }

        /// <summary>
        /// 快递号码
        /// </summary>
        public string express_no { get; set; }

        /// <summary>
        /// 状态 ，waiting待打包和打包中(APP端显示为待配货和配货中),shipped已发货,received收件人已签收
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 收件人姓名，当订单状态为shipped,recieved;或物流模式为red_express,red_domestic_trade, red_standard，此项为脱敏显示
        /// </summary>
        public string receiver_name { get; set; }

        /// <summary>
        /// 收件人电话，当订单状态为shipped,recieved;或物流模式为red_express,red_domestic_trade, red_standard，此项为脱敏显示
        /// </summary>
        public string receiver_phone { get; set; }
        /// <summary>
        /// 收件人地址，当订单状态为shipped,recieved;或物流模式为red_express,red_domestic_trade, red_standard，此项为脱敏显示
        /// </summary>
        public string receiver_address { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        public string district { get; set; }

        /// <summary>
        /// 订单支付金额(包含运费)
        /// </summary>
        public double pay_amount { get; set; }

        public List<ItemDetail> item_list { get; set; }

        /// <summary>
        /// 买家真实姓名
        /// </summary>
        public string buyer_name { get; set; }
    }
}
