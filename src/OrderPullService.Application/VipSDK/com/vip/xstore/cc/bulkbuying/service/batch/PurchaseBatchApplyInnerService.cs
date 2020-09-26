using System;
using System.Collections.Generic;

namespace com.vip.xstore.cc.bulkbuying.service.batch{
	
	
	public interface PurchaseBatchApplyInnerService {
		
		
		com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyResp createPurchaseOrdersByApply( com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyReq req_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleResp queryPurchaseBatchesToHandle( com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleReq req_ );
		
	}
	
}