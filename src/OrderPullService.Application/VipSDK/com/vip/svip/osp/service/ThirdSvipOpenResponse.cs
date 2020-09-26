using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class ThirdSvipOpenResponse {
		
		///<summary>
		///</summary>
		
		private int? code_;
		
		///<summary>
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 会员到期日期
		///</summary>
		
		private string expireTime_;
		
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		public string GetExpireTime(){
			return this.expireTime_;
		}
		
		public void SetExpireTime(string value){
			this.expireTime_ = value;
		}
		
	}
	
}