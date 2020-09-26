using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.delivery{
	
	
	
	
	
	public class CancelDeliveryResp {
		
		///<summary>
		/// 处理结果码(SUCCESS-成功，FAILED-失败)
		///</summary>
		
		private string return_code_;
		
		///<summary>
		/// 处理结果描述
		///</summary>
		
		private string return_msg_;
		
		public string GetReturn_code(){
			return this.return_code_;
		}
		
		public void SetReturn_code(string value){
			this.return_code_ = value;
		}
		public string GetReturn_msg(){
			return this.return_msg_;
		}
		
		public void SetReturn_msg(string value){
			this.return_msg_ = value;
		}
		
	}
	
}