using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class PackageDetail {
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 唯品会订单号，取order_sn值（注：合包发货则此字段必填，非合包则为空）
		///</summary>
		
		private string trade_id_;
		
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public string GetTrade_id(){
			return this.trade_id_;
		}
		
		public void SetTrade_id(string value){
			this.trade_id_ = value;
		}
		
	}
	
}