using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class ThirdCreatSvipTokenRequest {
		
		///<summary>
		/// openId
		///</summary>
		
		private string openId_;
		
		///<summary>
		/// 用户ip
		///</summary>
		
		private string userIp_;
		
		///<summary>
		/// 渠道号
		///</summary>
		
		private string channel_;
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? userId_;
		
		public string GetOpenId(){
			return this.openId_;
		}
		
		public void SetOpenId(string value){
			this.openId_ = value;
		}
		public string GetUserIp(){
			return this.userIp_;
		}
		
		public void SetUserIp(string value){
			this.userIp_ = value;
		}
		public string GetChannel(){
			return this.channel_;
		}
		
		public void SetChannel(string value){
			this.channel_ = value;
		}
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		
	}
	
}