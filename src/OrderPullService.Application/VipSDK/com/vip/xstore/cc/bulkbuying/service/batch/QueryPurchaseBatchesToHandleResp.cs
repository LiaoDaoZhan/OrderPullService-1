using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service.batch{
	
	
	
	
	
	public class QueryPurchaseBatchesToHandleResp {
		
		///<summary>
		/// 待处理的采购批次列表
		///</summary>
		
		private List<com.vip.xstore.cc.bulkbuying.service.batch.PurchaseBatchToHandle> purchaseBatchList_;
		
		public List<com.vip.xstore.cc.bulkbuying.service.batch.PurchaseBatchToHandle> GetPurchaseBatchList(){
			return this.purchaseBatchList_;
		}
		
		public void SetPurchaseBatchList(List<com.vip.xstore.cc.bulkbuying.service.batch.PurchaseBatchToHandle> value){
			this.purchaseBatchList_ = value;
		}
		
	}
	
}