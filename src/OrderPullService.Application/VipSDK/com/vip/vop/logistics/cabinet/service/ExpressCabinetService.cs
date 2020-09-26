using System;
using System.Collections.Generic;

namespace com.vip.vop.logistics.cabinet.service{
	
	
	public interface ExpressCabinetService {
		
		
		com.vip.vop.logistics.cabinet.GetShippingResp getShippingByLogisticsNos( com.vip.vop.logistics.cabinet.GetShippingReq shippingReq_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		List<com.vip.vop.logistics.cabinet.LockerActionResult> reportLockerAction( string carrier_code_,   List<com.vip.vop.logistics.cabinet.LockerAction> locker_actions_ );
		
		com.vip.vop.logistics.cabinet.ShipmentTraceResp reportTraces( com.vip.vop.logistics.cabinet.ExpressCabinetTraceReq traceReq_ );
		
	}
	
}