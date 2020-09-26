using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.closePo.service{
	
	
	
	
	
	public class ItemReceiveInfo {
		
		///<summary>
		/// 条码
		///</summary>
		
		private string itemBarCode_;
		
		///<summary>
		/// 明细的已收货数量
		///</summary>
		
		private int? recAmount_;
		
		///<summary>
		/// 明细上的采购数量
		///</summary>
		
		private int? purchaseAmount_;
		
		///<summary>
		/// 品牌编码
		///</summary>
		
		private string brandSn_;
		
		///<summary>
		/// 分类信息
		///</summary>
		
		private int? cat3Code_;
		
		///<summary>
		/// 买手组信息
		///</summary>
		
		private string buyerGroupCode_;
		
		///<summary>
		/// 采购含税价格
		///</summary>
		
		private double? priceWithTax_;
		
		public string GetItemBarCode(){
			return this.itemBarCode_;
		}
		
		public void SetItemBarCode(string value){
			this.itemBarCode_ = value;
		}
		public int? GetRecAmount(){
			return this.recAmount_;
		}
		
		public void SetRecAmount(int? value){
			this.recAmount_ = value;
		}
		public int? GetPurchaseAmount(){
			return this.purchaseAmount_;
		}
		
		public void SetPurchaseAmount(int? value){
			this.purchaseAmount_ = value;
		}
		public string GetBrandSn(){
			return this.brandSn_;
		}
		
		public void SetBrandSn(string value){
			this.brandSn_ = value;
		}
		public int? GetCat3Code(){
			return this.cat3Code_;
		}
		
		public void SetCat3Code(int? value){
			this.cat3Code_ = value;
		}
		public string GetBuyerGroupCode(){
			return this.buyerGroupCode_;
		}
		
		public void SetBuyerGroupCode(string value){
			this.buyerGroupCode_ = value;
		}
		public double? GetPriceWithTax(){
			return this.priceWithTax_;
		}
		
		public void SetPriceWithTax(double? value){
			this.priceWithTax_ = value;
		}
		
	}
	
}