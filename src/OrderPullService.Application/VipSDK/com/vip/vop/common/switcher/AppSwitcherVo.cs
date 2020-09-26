using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.common.switcher{
	
	
	
	
	
	public class AppSwitcherVo {
		
		///<summary>
		/// 域名
		///</summary>
		
		private string domainName_;
		
		///<summary>
		/// 模块名
		///</summary>
		
		private string moduleName_;
		
		///<summary>
		/// 开关状态 0-关闭（默认） 1-开启
		///</summary>
		
		private byte? switchStat_;
		
		///<summary>
		/// 描述
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private string createTime_;
		
		public string GetDomainName(){
			return this.domainName_;
		}
		
		public void SetDomainName(string value){
			this.domainName_ = value;
		}
		public string GetModuleName(){
			return this.moduleName_;
		}
		
		public void SetModuleName(string value){
			this.moduleName_ = value;
		}
		public byte? GetSwitchStat(){
			return this.switchStat_;
		}
		
		public void SetSwitchStat(byte? value){
			this.switchStat_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public string GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(string value){
			this.createTime_ = value;
		}
		
	}
	
}