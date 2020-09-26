using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.delivery{
	
	
	
	
	
	public class CreatePoDeliveryReq {
		
		///<summary>
		/// 供应商ID
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// po单号列表
		///</summary>
		
		private List<string> po_nos_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 供应商发货仓库(如果是承运商=唯品会，则必填)
		///</summary>
		
		private string delivery_warehouse_;
		
		///<summary>
		/// 送货仓库
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 送货时间
		/// @sampleValue delivery_time 2014-07-01 10:00:00
		///</summary>
		
		private string delivery_time_;
		
		///<summary>
		/// 要求到货时间(必须是当天或者明天)；</br>空运(delivery_method=2)</br>可选的时间段：9:00:00,16:00:00,18:00:00，23:59:00,20:00:00 ；</br>汽运（delivery_method=1)</br>可选的时间段：2:00:00,9:00:00,16:00:00,19:00:00,20:00:00，22:00:00，23:59:00,10:00:00 (如果是承运商=唯品会，则允许空)
		/// @sampleValue arrival_time 2014-07-01 09:00:00
		///</summary>
		
		private string arrival_time_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 配送方式 ;1=汽运,2=空运 (如果是承运商=唯品会，则允许空)
		/// @sampleValue delivery_method 1：汽运,2：空运
		///</summary>
		
		private string delivery_method_;
		
		///<summary>
		/// 门店编码
		///</summary>
		
		private string store_sn_;
		
		///<summary>
		/// 1. OXO  2. 仓中仓; 3: 预调拨，不填，则为普通JIT类型
		///</summary>
		
		private int? jit_type_;
		
		///<summary>
		/// 是否航空禁运,0-不禁运，1-禁运，默认为0，对于承运商为唯品会时，必填
		///</summary>
		
		private int? is_air_embargo_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public List<string> GetPo_nos(){
			return this.po_nos_;
		}
		
		public void SetPo_nos(List<string> value){
			this.po_nos_ = value;
		}
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public string GetDelivery_warehouse(){
			return this.delivery_warehouse_;
		}
		
		public void SetDelivery_warehouse(string value){
			this.delivery_warehouse_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetDelivery_time(){
			return this.delivery_time_;
		}
		
		public void SetDelivery_time(string value){
			this.delivery_time_ = value;
		}
		public string GetArrival_time(){
			return this.arrival_time_;
		}
		
		public void SetArrival_time(string value){
			this.arrival_time_ = value;
		}
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public string GetDelivery_method(){
			return this.delivery_method_;
		}
		
		public void SetDelivery_method(string value){
			this.delivery_method_ = value;
		}
		public string GetStore_sn(){
			return this.store_sn_;
		}
		
		public void SetStore_sn(string value){
			this.store_sn_ = value;
		}
		public int? GetJit_type(){
			return this.jit_type_;
		}
		
		public void SetJit_type(int? value){
			this.jit_type_ = value;
		}
		public int? GetIs_air_embargo(){
			return this.is_air_embargo_;
		}
		
		public void SetIs_air_embargo(int? value){
			this.is_air_embargo_ = value;
		}
		
	}
	
}