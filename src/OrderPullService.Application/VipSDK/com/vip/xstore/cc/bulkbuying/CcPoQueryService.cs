using System;
using System.Collections.Generic;

namespace com.vip.xstore.cc.bulkbuying{
	
	
	public interface CcPoQueryService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.xstore.cc.bulkbuying.CcPo queryCcPo( string purchaseNo_ );
		
		com.vip.xstore.cc.bulkbuying.QueryCcPoItemResp queryCcPoItem( com.vip.xstore.cc.bulkbuying.QueryCcPoItemReq req_ );
		
		List<com.vip.xstore.cc.bulkbuying.CcPo> queryCcPos( List<string> purchaseNos_ );
		
		List<com.vip.xstore.cc.bulkbuying.CcPo> queryPoListByBizBatchNo( com.vip.xstore.cc.bulkbuying.QueryPoListByBizBatchNoReq req_ );
		
	}
	
}