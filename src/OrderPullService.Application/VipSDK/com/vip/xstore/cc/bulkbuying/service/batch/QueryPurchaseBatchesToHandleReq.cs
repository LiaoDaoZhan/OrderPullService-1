using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service.batch{
	
	
	
	
	
	public class QueryPurchaseBatchesToHandleReq {
		
		///<summary>
		/// 创建时间开始值
		///</summary>
		
		private System.DateTime? createTimeBegin_;
		
		///<summary>
		/// 创建时间结束值
		///</summary>
		
		private System.DateTime? createTimeEnd_;
		
		///<summary>
		/// 数量限制
		///</summary>
		
		private int? limt_;
		
		public System.DateTime? GetCreateTimeBegin(){
			return this.createTimeBegin_;
		}
		
		public void SetCreateTimeBegin(System.DateTime? value){
			this.createTimeBegin_ = value;
		}
		public System.DateTime? GetCreateTimeEnd(){
			return this.createTimeEnd_;
		}
		
		public void SetCreateTimeEnd(System.DateTime? value){
			this.createTimeEnd_ = value;
		}
		public int? GetLimt(){
			return this.limt_;
		}
		
		public void SetLimt(int? value){
			this.limt_ = value;
		}
		
	}
	
}