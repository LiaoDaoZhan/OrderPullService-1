using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying{
	
	
	
	
	
	public class QueryCcPoItemResp {
		
		///<summary>
		/// 采购单明细列表
		///</summary>
		
		private List<com.vip.xstore.cc.bulkbuying.CcPoItem> items_;
		
		///<summary>
		/// 是否有下一页
		///</summary>
		
		private bool? hasNext_;
		
		public List<com.vip.xstore.cc.bulkbuying.CcPoItem> GetItems(){
			return this.items_;
		}
		
		public void SetItems(List<com.vip.xstore.cc.bulkbuying.CcPoItem> value){
			this.items_ = value;
		}
		public bool? GetHasNext(){
			return this.hasNext_;
		}
		
		public void SetHasNext(bool? value){
			this.hasNext_ = value;
		}
		
	}
	
}