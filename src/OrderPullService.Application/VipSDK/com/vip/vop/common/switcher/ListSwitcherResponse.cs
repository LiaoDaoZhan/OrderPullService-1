using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.common.switcher{
	
	
	
	
	
	public class ListSwitcherResponse {
		
		///<summary>
		/// 开关列表
		///</summary>
		
		private List<com.vip.vop.common.switcher.AppSwitcherVo> switchers_;
		
		///<summary>
		/// 模块名
		///</summary>
		
		private int? total_;
		
		public List<com.vip.vop.common.switcher.AppSwitcherVo> GetSwitchers(){
			return this.switchers_;
		}
		
		public void SetSwitchers(List<com.vip.vop.common.switcher.AppSwitcherVo> value){
			this.switchers_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		
	}
	
}