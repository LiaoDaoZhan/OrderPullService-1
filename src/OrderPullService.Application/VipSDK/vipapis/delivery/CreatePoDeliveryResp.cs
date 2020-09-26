using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.delivery{
	
	
	
	
	
	public class CreatePoDeliveryResp {
		
		///<summary>
		/// 入库单号
		///</summary>
		
		private string storage_no_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 配送方式 1：汽运,2：空运;默认值：1 
		///</summary>
		
		private string delivery_method_;
		
		///<summary>
		/// 要求到货时间 
		/// @sampleValue arrival_time 2014-07-01 10:00:00
		///</summary>
		
		private string arrival_time_;
		
		public string GetStorage_no(){
			return this.storage_no_;
		}
		
		public void SetStorage_no(string value){
			this.storage_no_ = value;
		}
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public string GetDelivery_method(){
			return this.delivery_method_;
		}
		
		public void SetDelivery_method(string value){
			this.delivery_method_ = value;
		}
		public string GetArrival_time(){
			return this.arrival_time_;
		}
		
		public void SetArrival_time(string value){
			this.arrival_time_ = value;
		}
		
	}
	
}