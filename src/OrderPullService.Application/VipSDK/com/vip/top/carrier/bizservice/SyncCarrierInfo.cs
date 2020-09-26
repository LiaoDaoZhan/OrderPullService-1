using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class SyncCarrierInfo {
		
		///<summary>
		/// 原仓仓库
		///</summary>
		
		private string fromWarehouse_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string custCode_;
		
		///<summary>
		/// 揽退单号
		///</summary>
		
		private string ltOrderNo_;
		
		///<summary>
		/// 揽换单关联编码
		///</summary>
		
		private string exchangeRelationNo_;
		
		///<summary>
		/// 客退单号
		///</summary>
		
		private string backSn_;
		
		public string GetFromWarehouse(){
			return this.fromWarehouse_;
		}
		
		public void SetFromWarehouse(string value){
			this.fromWarehouse_ = value;
		}
		public string GetCustCode(){
			return this.custCode_;
		}
		
		public void SetCustCode(string value){
			this.custCode_ = value;
		}
		public string GetLtOrderNo(){
			return this.ltOrderNo_;
		}
		
		public void SetLtOrderNo(string value){
			this.ltOrderNo_ = value;
		}
		public string GetExchangeRelationNo(){
			return this.exchangeRelationNo_;
		}
		
		public void SetExchangeRelationNo(string value){
			this.exchangeRelationNo_ = value;
		}
		public string GetBackSn(){
			return this.backSn_;
		}
		
		public void SetBackSn(string value){
			this.backSn_ = value;
		}
		
	}
	
}