using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class ActivityInfo {
		
		///<summary>
		/// 活动类型:18-唯品快抢
		///</summary>
		
		private int? actType_;
		
		///<summary>
		/// 活动名称
		///</summary>
		
		private string actName_;
		
		///<summary>
		/// 开始时间：时间戳，单位毫秒
		///</summary>
		
		private long? beginTime_;
		
		///<summary>
		/// 结束时间：时间戳，单位毫秒
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// 预热开始时间：时间戳，单位毫秒
		///</summary>
		
		private long? foreShowBeginTime_;
		
		public int? GetActType(){
			return this.actType_;
		}
		
		public void SetActType(int? value){
			this.actType_ = value;
		}
		public string GetActName(){
			return this.actName_;
		}
		
		public void SetActName(string value){
			this.actName_ = value;
		}
		public long? GetBeginTime(){
			return this.beginTime_;
		}
		
		public void SetBeginTime(long? value){
			this.beginTime_ = value;
		}
		public long? GetEndTime(){
			return this.endTime_;
		}
		
		public void SetEndTime(long? value){
			this.endTime_ = value;
		}
		public long? GetForeShowBeginTime(){
			return this.foreShowBeginTime_;
		}
		
		public void SetForeShowBeginTime(long? value){
			this.foreShowBeginTime_ = value;
		}
		
	}
	
}