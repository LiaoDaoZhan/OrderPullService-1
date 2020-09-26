using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying{
	
	
	
	
	
	public class CcPoItem {
		
		///<summary>
		/// 主键
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 唯品会po，废弃
		///</summary>
		
		private string po_;
		
		///<summary>
		/// 供应商编码，废弃
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// pdc vendorProductId，废弃
		///</summary>
		
		private long? vSpuId_;
		
		///<summary>
		/// pdc vendorSkuId，废弃
		///</summary>
		
		private long? vSkuId_;
		
		///<summary>
		/// 成本价
		///</summary>
		
		private double? costPrice_;
		
		///<summary>
		/// 吊牌价
		///</summary>
		
		private double? tagPrice_;
		
		///<summary>
		/// 仓库编码，废弃
		///</summary>
		
		private string deliverWarehouse_;
		
		///<summary>
		/// 采购数量
		///</summary>
		
		private int? purchaseQuantity_;
		
		///<summary>
		/// 残次大类等级
		///</summary>
		
		private string disabilityLevel_;
		
		///<summary>
		/// 残次小类等级，废弃
		///</summary>
		
		private string subDisabilityLevel_;
		
		///<summary>
		/// 库龄，废弃
		///</summary>
		
		private int? age_;
		
		///<summary>
		/// 占用数量，废弃
		///</summary>
		
		private int? holdQuantity_;
		
		///<summary>
		/// 已出仓数量
		///</summary>
		
		private int? deliveredQuantity_;
		
		///<summary>
		/// 已收货数量
		///</summary>
		
		private int? receivedQuantity_;
		
		///<summary>
		/// 原始商品条码
		///</summary>
		
		private string barcodeOrigin_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string prodName_;
		
		///<summary>
		/// VIP采购价
		///</summary>
		
		private double? vipPurchasePrice_;
		
		///<summary>
		/// 成本价(人民币)
		///</summary>
		
		private double? costPriceCny_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetPo(){
			return this.po_;
		}
		
		public void SetPo(string value){
			this.po_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public long? GetVSpuId(){
			return this.vSpuId_;
		}
		
		public void SetVSpuId(long? value){
			this.vSpuId_ = value;
		}
		public long? GetVSkuId(){
			return this.vSkuId_;
		}
		
		public void SetVSkuId(long? value){
			this.vSkuId_ = value;
		}
		public double? GetCostPrice(){
			return this.costPrice_;
		}
		
		public void SetCostPrice(double? value){
			this.costPrice_ = value;
		}
		public double? GetTagPrice(){
			return this.tagPrice_;
		}
		
		public void SetTagPrice(double? value){
			this.tagPrice_ = value;
		}
		public string GetDeliverWarehouse(){
			return this.deliverWarehouse_;
		}
		
		public void SetDeliverWarehouse(string value){
			this.deliverWarehouse_ = value;
		}
		public int? GetPurchaseQuantity(){
			return this.purchaseQuantity_;
		}
		
		public void SetPurchaseQuantity(int? value){
			this.purchaseQuantity_ = value;
		}
		public string GetDisabilityLevel(){
			return this.disabilityLevel_;
		}
		
		public void SetDisabilityLevel(string value){
			this.disabilityLevel_ = value;
		}
		public string GetSubDisabilityLevel(){
			return this.subDisabilityLevel_;
		}
		
		public void SetSubDisabilityLevel(string value){
			this.subDisabilityLevel_ = value;
		}
		public int? GetAge(){
			return this.age_;
		}
		
		public void SetAge(int? value){
			this.age_ = value;
		}
		public int? GetHoldQuantity(){
			return this.holdQuantity_;
		}
		
		public void SetHoldQuantity(int? value){
			this.holdQuantity_ = value;
		}
		public int? GetDeliveredQuantity(){
			return this.deliveredQuantity_;
		}
		
		public void SetDeliveredQuantity(int? value){
			this.deliveredQuantity_ = value;
		}
		public int? GetReceivedQuantity(){
			return this.receivedQuantity_;
		}
		
		public void SetReceivedQuantity(int? value){
			this.receivedQuantity_ = value;
		}
		public string GetBarcodeOrigin(){
			return this.barcodeOrigin_;
		}
		
		public void SetBarcodeOrigin(string value){
			this.barcodeOrigin_ = value;
		}
		public string GetProdName(){
			return this.prodName_;
		}
		
		public void SetProdName(string value){
			this.prodName_ = value;
		}
		public double? GetVipPurchasePrice(){
			return this.vipPurchasePrice_;
		}
		
		public void SetVipPurchasePrice(double? value){
			this.vipPurchasePrice_ = value;
		}
		public double? GetCostPriceCny(){
			return this.costPriceCny_;
		}
		
		public void SetCostPriceCny(double? value){
			this.costPriceCny_ = value;
		}
		
	}
	
}