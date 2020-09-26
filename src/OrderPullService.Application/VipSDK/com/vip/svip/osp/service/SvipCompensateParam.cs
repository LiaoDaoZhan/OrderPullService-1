using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SvipCompensateParam {
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 赠送天数
		///</summary>
		
		private int? days_;
		
		///<summary>
		/// 唯一key
		///</summary>
		
		private string uniqueKey_;
		
		///<summary>
		/// 数据类型1试用，2正式权益,3付费已过期，4手工补偿不区分试用正式
		///</summary>
		
		private int? type_;
		
		///<summary>
		/// 操作人员
		///</summary>
		
		private string operator_;
		
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public int? GetDays(){
			return this.days_;
		}
		
		public void SetDays(int? value){
			this.days_ = value;
		}
		public string GetUniqueKey(){
			return this.uniqueKey_;
		}
		
		public void SetUniqueKey(string value){
			this.uniqueKey_ = value;
		}
		public int? GetType(){
			return this.type_;
		}
		
		public void SetType(int? value){
			this.type_ = value;
		}
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		
	}
	
}