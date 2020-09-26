using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class ApplySellingSimpleData {
		
		///<summary>
		/// 档期ID
		///</summary>
		
		private long? brandId_;
		
		///<summary>
		/// 采购协议编码
		///</summary>
		
		private long? shopCode_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private int? vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 合作模式
		///</summary>
		
		private byte? sellingMode_;
		
		///<summary>
		/// 销售模式
		///</summary>
		
		private int? b2cModeId_;
		
		///<summary>
		/// 分仓
		///</summary>
		
		private string sellArea_;
		
		///<summary>
		/// 档期有效开始时间
		///</summary>
		
		private string sellTimeFromStr_;
		
		///<summary>
		/// 档期有效结束时间
		///</summary>
		
		private string sellTimeToStr_;
		
		///<summary>
		/// 是否对接POS系统 0 否 1 是， 采购协议服务默认为1
		///</summary>
		
		private byte? isPos_;
		
		///<summary>
		/// 是否店发 0 仓发 1 店发
		///</summary>
		
		private byte? isStoreDelivery_;
		
		public long? GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(long? value){
			this.brandId_ = value;
		}
		public long? GetShopCode(){
			return this.shopCode_;
		}
		
		public void SetShopCode(long? value){
			this.shopCode_ = value;
		}
		public int? GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(int? value){
			this.vendorCode_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public byte? GetSellingMode(){
			return this.sellingMode_;
		}
		
		public void SetSellingMode(byte? value){
			this.sellingMode_ = value;
		}
		public int? GetB2cModeId(){
			return this.b2cModeId_;
		}
		
		public void SetB2cModeId(int? value){
			this.b2cModeId_ = value;
		}
		public string GetSellArea(){
			return this.sellArea_;
		}
		
		public void SetSellArea(string value){
			this.sellArea_ = value;
		}
		public string GetSellTimeFromStr(){
			return this.sellTimeFromStr_;
		}
		
		public void SetSellTimeFromStr(string value){
			this.sellTimeFromStr_ = value;
		}
		public string GetSellTimeToStr(){
			return this.sellTimeToStr_;
		}
		
		public void SetSellTimeToStr(string value){
			this.sellTimeToStr_ = value;
		}
		public byte? GetIsPos(){
			return this.isPos_;
		}
		
		public void SetIsPos(byte? value){
			this.isPos_ = value;
		}
		public byte? GetIsStoreDelivery(){
			return this.isStoreDelivery_;
		}
		
		public void SetIsStoreDelivery(byte? value){
			this.isStoreDelivery_ = value;
		}
		
	}
	
}