using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vpos.service{
	
	
	
	
	
	public class VposOrderResultVO {
		
		///<summary>
		/// 订单时间，时间戳,示例:1572427369000
		///</summary>
		
		private long? addTime_;
		
		///<summary>
		/// 订单号 - 零售订单号(VPOS生成),订单唯一标识。示例:A00119071000002
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 订单商品金额,示例:80.00
		///</summary>
		
		private string orderMoney_;
		
		///<summary>
		/// 商品数量,示例:1
		///</summary>
		
		private int? orderQuantity_;
		
		///<summary>
		/// 币种，默认CNY,示例:CNY
		///</summary>
		
		private string currency_;
		
		///<summary>
		/// 支付交易号,示例:CNY
		///</summary>
		
		private string paySn_;
		
		///<summary>
		/// 支付方式,示例:ALIPAY
		///</summary>
		
		private string payType_;
		
		///<summary>
		/// 支付方式说明,示例:支付宝
		///</summary>
		
		private string paymentTerm_;
		
		///<summary>
		/// 实际支付金额,示例:48.00
		///</summary>
		
		private string payMoney_;
		
		///<summary>
		/// 对应的原销售订单号,如果是客退单，该字段必填. 示例:A00119071000003
		///</summary>
		
		private string extorderSn_;
		
		///<summary>
		/// 原销售时间,时间戳,如果是客退单，该字段必填. 示例:1572427369000
		///</summary>
		
		private long? extaddTime_;
		
		///<summary>
		/// 销售类型：SALE - 销售, RETURN - 客退. 示例: SALE
		///</summary>
		
		private string saleType_;
		
		public long? GetAddTime(){
			return this.addTime_;
		}
		
		public void SetAddTime(long? value){
			this.addTime_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetOrderMoney(){
			return this.orderMoney_;
		}
		
		public void SetOrderMoney(string value){
			this.orderMoney_ = value;
		}
		public int? GetOrderQuantity(){
			return this.orderQuantity_;
		}
		
		public void SetOrderQuantity(int? value){
			this.orderQuantity_ = value;
		}
		public string GetCurrency(){
			return this.currency_;
		}
		
		public void SetCurrency(string value){
			this.currency_ = value;
		}
		public string GetPaySn(){
			return this.paySn_;
		}
		
		public void SetPaySn(string value){
			this.paySn_ = value;
		}
		public string GetPayType(){
			return this.payType_;
		}
		
		public void SetPayType(string value){
			this.payType_ = value;
		}
		public string GetPaymentTerm(){
			return this.paymentTerm_;
		}
		
		public void SetPaymentTerm(string value){
			this.paymentTerm_ = value;
		}
		public string GetPayMoney(){
			return this.payMoney_;
		}
		
		public void SetPayMoney(string value){
			this.payMoney_ = value;
		}
		public string GetExtorderSn(){
			return this.extorderSn_;
		}
		
		public void SetExtorderSn(string value){
			this.extorderSn_ = value;
		}
		public long? GetExtaddTime(){
			return this.extaddTime_;
		}
		
		public void SetExtaddTime(long? value){
			this.extaddTime_ = value;
		}
		public string GetSaleType(){
			return this.saleType_;
		}
		
		public void SetSaleType(string value){
			this.saleType_ = value;
		}
		
	}
	
}