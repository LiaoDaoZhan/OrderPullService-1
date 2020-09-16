using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace OrderPullService
{
    [Owned]
    public class TradeInvoice
    {
        /// <summary>
        /// 发票：1电子发票 2：纸质发票
        /// 苏宁：01增值 02普通 04 电子发票
        /// </summary>
        public string InvoiceKind { get; set; }
        ///// <summary>
        ///// 发票类型：
        ///// </summary>
        //public string InvoiceTypeName { get; set; }
        /// <summary>
        /// 发票抬头：
        /// </summary>
        public string InvoiceTitle { get; set; }
        /// <summary>
        /// 发票内容
        /// </summary>
        public string InvoiceContent { get; set; }
        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public string TaxNum { get; set; }
        /// <summary>
        /// 银行
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 支行
        /// </summary>
        public string SubBankName { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string BankAccount { get; set; }
    }
}
