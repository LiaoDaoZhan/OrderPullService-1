using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.delivery{
	
	
	
	
	
	public class ShipPackage {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transport_no_;
		
		///<summary>
		/// 包裹明细
		///</summary>
		
		private List<vipapis.marketplace.delivery.ShipPackageProduct> package_product_list_;
		
		///<summary>
		/// 承运商编码，传该字段表示订单使用分批发货方式，则ShipInfo中的carrier_code和carrier_name无效
		///</summary>
		
		private string carrier_code_;
		
		public string GetTransport_no(){
			return this.transport_no_;
		}
		
		public void SetTransport_no(string value){
			this.transport_no_ = value;
		}
		public List<vipapis.marketplace.delivery.ShipPackageProduct> GetPackage_product_list(){
			return this.package_product_list_;
		}
		
		public void SetPackage_product_list(List<vipapis.marketplace.delivery.ShipPackageProduct> value){
			this.package_product_list_ = value;
		}
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		
	}
	
}