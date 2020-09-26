using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.cabinet{
	
	
	
	
	
	public class LockerActionResult {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 推送结果 0=失败，1=成功，失败时要求重试
		///</summary>
		
		private string result_code_;
		
		///<summary>
		/// 结果信息
		///</summary>
		
		private string result_msg_;
		
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public string GetResult_code(){
			return this.result_code_;
		}
		
		public void SetResult_code(string value){
			this.result_code_ = value;
		}
		public string GetResult_msg(){
			return this.result_msg_;
		}
		
		public void SetResult_msg(string value){
			this.result_msg_ = value;
		}
		
	}
	
}