using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class PrepayInfo {
		
		///<summary>
		/// 是否预付商品:0-否，1-是
		///</summary>
		
		private int? isPrepay_;
		
		///<summary>
		/// 预付到手价：元
		///</summary>
		
		private string prepayPrice_;
		
		///<summary>
		/// 预付首款金额：元
		///</summary>
		
		private string firstAmount_;
		
		///<summary>
		/// 预付尾款金额：元
		///</summary>
		
		private string lastAmount_;
		
		///<summary>
		/// 预付优惠金额: 元
		///</summary>
		
		private string prepayFavAmount_;
		
		///<summary>
		/// 抵扣价格(首款+优惠金额)：元
		///</summary>
		
		private string deductionPrice_;
		
		///<summary>
		/// 预付折扣：(唯品价-优惠金额)/唯品价 保留两位小数的数字字符串
		///</summary>
		
		private string prepayDiscount_;
		
		///<summary>
		/// 首款支付开始时间:时间戳,单位毫秒
		///</summary>
		
		private long? prepayFirstStartTime_;
		
		///<summary>
		/// 首款支付结束时间:时间戳,单位毫秒
		///</summary>
		
		private long? prepayFirstEndTime_;
		
		///<summary>
		/// 尾款支付开始时间:时间戳,单位毫秒
		///</summary>
		
		private long? prepayLastStartTime_;
		
		///<summary>
		/// 尾款支付结束时间:时间戳,单位毫秒
		///</summary>
		
		private long? prepayLastEndTime_;
		
		public int? GetIsPrepay(){
			return this.isPrepay_;
		}
		
		public void SetIsPrepay(int? value){
			this.isPrepay_ = value;
		}
		public string GetPrepayPrice(){
			return this.prepayPrice_;
		}
		
		public void SetPrepayPrice(string value){
			this.prepayPrice_ = value;
		}
		public string GetFirstAmount(){
			return this.firstAmount_;
		}
		
		public void SetFirstAmount(string value){
			this.firstAmount_ = value;
		}
		public string GetLastAmount(){
			return this.lastAmount_;
		}
		
		public void SetLastAmount(string value){
			this.lastAmount_ = value;
		}
		public string GetPrepayFavAmount(){
			return this.prepayFavAmount_;
		}
		
		public void SetPrepayFavAmount(string value){
			this.prepayFavAmount_ = value;
		}
		public string GetDeductionPrice(){
			return this.deductionPrice_;
		}
		
		public void SetDeductionPrice(string value){
			this.deductionPrice_ = value;
		}
		public string GetPrepayDiscount(){
			return this.prepayDiscount_;
		}
		
		public void SetPrepayDiscount(string value){
			this.prepayDiscount_ = value;
		}
		public long? GetPrepayFirstStartTime(){
			return this.prepayFirstStartTime_;
		}
		
		public void SetPrepayFirstStartTime(long? value){
			this.prepayFirstStartTime_ = value;
		}
		public long? GetPrepayFirstEndTime(){
			return this.prepayFirstEndTime_;
		}
		
		public void SetPrepayFirstEndTime(long? value){
			this.prepayFirstEndTime_ = value;
		}
		public long? GetPrepayLastStartTime(){
			return this.prepayLastStartTime_;
		}
		
		public void SetPrepayLastStartTime(long? value){
			this.prepayLastStartTime_ = value;
		}
		public long? GetPrepayLastEndTime(){
			return this.prepayLastEndTime_;
		}
		
		public void SetPrepayLastEndTime(long? value){
			this.prepayLastEndTime_ = value;
		}
		
	}
	
}