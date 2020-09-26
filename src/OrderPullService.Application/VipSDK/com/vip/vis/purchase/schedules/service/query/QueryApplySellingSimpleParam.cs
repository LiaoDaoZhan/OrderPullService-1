using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class QueryApplySellingSimpleParam {
		
		///<summary>
		/// 档期ID列表
		///</summary>
		
		private List<long?> brandIdList_;
		
		///<summary>
		/// 采购协议编码 (合作编码)，和档期ID只支持一个，如果同时存在已合作编码为准
		///</summary>
		
		private long? shopCode_;
		
		///<summary>
		/// 分仓列表，只与采购协议编码 (合作编码)，配合使用
		///</summary>
		
		private List<string> warehouseCodeList_;
		
		public List<long?> GetBrandIdList(){
			return this.brandIdList_;
		}
		
		public void SetBrandIdList(List<long?> value){
			this.brandIdList_ = value;
		}
		public long? GetShopCode(){
			return this.shopCode_;
		}
		
		public void SetShopCode(long? value){
			this.shopCode_ = value;
		}
		public List<string> GetWarehouseCodeList(){
			return this.warehouseCodeList_;
		}
		
		public void SetWarehouseCodeList(List<string> value){
			this.warehouseCodeList_ = value;
		}
		
	}
	
}