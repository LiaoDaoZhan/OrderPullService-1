using System;
using System.Collections.Generic;

namespace com.vip.vop.common.switcher{
	
	
	public interface AppSwitcherService {
		
		
		bool? closeSwitcher( string domainName_,   string moduleName_ );
		
		bool? createSwitcher( string domainName_,   string moduleName_,   string remark_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		void insertOrUpdate( com.vip.vop.common.switcher.AppSwitcherVo switcherVo_ );
		
		bool? isOpenSwither( string domainName_,   string moduleName_ );
		
		com.vip.vop.common.switcher.ListSwitcherResponse listSwitcher( string domainName_,   string moduleName_,   int? page_,   int? pageSize_ );
		
		bool? openSwitcher( string domainName_,   string moduleName_ );
		
	}
	
}