using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying{
	
	
	
	
	
	public class QueryCcPoItemReq {
		
		///<summary>
		/// 页码，默认1
		/// @sampleValue page 1
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页记录数，默认200，最大2000
		/// @sampleValue pageSize 20
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string purchaseNo_;
		
		///<summary>
		/// 所需字段，默认只返回id,barcode,costPrice,purchaseQuantity
		///</summary>
		
		private List<string> requiredFields_;
		
		///<summary>
		/// 只查有效出仓的（即出仓数大于0的)
		///</summary>
		
		private bool? effectiveDeliveredOnly_;
		
		///<summary>
		/// 条码集合，最大2000
		///</summary>
		
		private List<string> barcodeSet_;
		
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		public string GetPurchaseNo(){
			return this.purchaseNo_;
		}
		
		public void SetPurchaseNo(string value){
			this.purchaseNo_ = value;
		}
		public List<string> GetRequiredFields(){
			return this.requiredFields_;
		}
		
		public void SetRequiredFields(List<string> value){
			this.requiredFields_ = value;
		}
		public bool? GetEffectiveDeliveredOnly(){
			return this.effectiveDeliveredOnly_;
		}
		
		public void SetEffectiveDeliveredOnly(bool? value){
			this.effectiveDeliveredOnly_ = value;
		}
		public List<string> GetBarcodeSet(){
			return this.barcodeSet_;
		}
		
		public void SetBarcodeSet(List<string> value){
			this.barcodeSet_ = value;
		}
		
	}
	
}