using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.inventory{
	
	
	
	
	
	public class OccupiedOrder {
		
		///<summary>
		/// 库存占用订单号
		///</summary>
		
		private string occupied_order_sn_;
		
		///<summary>
		/// 商品列表
		///</summary>
		
		private List<vipapis.inventory.OccupiedOrderDetail> barcodes_;
		
		///<summary>
		/// 销售区域
		///</summary>
		
		private string sale_warehouse_;
		
		///<summary>
		/// 订单的四级地址编码,（直发的订单可返回此字段，JIT订单不返回此字段）
		///</summary>
		
		private string address_code_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// hold标记，正向订单有返回，取消订单不返回， 0=正常hold单，1=hold单时间16天 没有返回则此字段则正常hold单
		///</summary>
		
		private byte? hold_flag_;
		
		public string GetOccupied_order_sn(){
			return this.occupied_order_sn_;
		}
		
		public void SetOccupied_order_sn(string value){
			this.occupied_order_sn_ = value;
		}
		public List<vipapis.inventory.OccupiedOrderDetail> GetBarcodes(){
			return this.barcodes_;
		}
		
		public void SetBarcodes(List<vipapis.inventory.OccupiedOrderDetail> value){
			this.barcodes_ = value;
		}
		public string GetSale_warehouse(){
			return this.sale_warehouse_;
		}
		
		public void SetSale_warehouse(string value){
			this.sale_warehouse_ = value;
		}
		public string GetAddress_code(){
			return this.address_code_;
		}
		
		public void SetAddress_code(string value){
			this.address_code_ = value;
		}
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public byte? GetHold_flag(){
			return this.hold_flag_;
		}
		
		public void SetHold_flag(byte? value){
			this.hold_flag_ = value;
		}
		
	}
	
}