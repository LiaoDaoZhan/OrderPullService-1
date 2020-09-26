using System;
using System.Collections.Generic;

namespace com.vip.fcs.vpos.service{
	
	
	public interface VposOrderQueryOspService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.fcs.vpos.service.OrderQueryResponse queryOrderSummaryByStoreCode( com.vip.fcs.vpos.service.OrderQueryRequest queryRequest_ );
		
	}
	
}