using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.cabinet{
	
	
	
	
	
	public class LockerAction {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 交易号
		///</summary>
		
		private string trade_id_;
		
		///<summary>
		/// 快递柜寄件码/取件码(当actionCode为510和533时必填)
		///</summary>
		
		private string locker_code_;
		
		///<summary>
		/// 寄件码失效时间（精确单位：毫秒)
		///</summary>
		
		private long? expired_time_;
		
		///<summary>
		/// 柜机编码
		///</summary>
		
		private string express_cabinet_code_;
		
		///<summary>
		/// 操作行为码<br>1001=推送寄件码<br>1002=推送取件码<br>2001=寄件码失效<br>2002=会员寄件开门<br>2003=会员寄件关门<br>2004=会员投递入柜<br>2005=寄件码获取失败<br>2006=取件码获取失败<br>2011=快递员开门取件<br>2012=快递员取件完成关门<br>2021=快件被快递员拿走<br>2022=快递员验货失败，放回快递柜<br>2031=会员取回开门<br>2032=会员取回关门<br>2033=会员取回返件<br>2041=更换格口
		///</summary>
		
		private string action_code_;
		
		///<summary>
		/// 承运商轨迹编码(承运商/运营商内部的原始行为码)
		/// @sampleValue trace_code 
		///</summary>
		
		private string trace_code_;
		
		///<summary>
		/// 快递柜地址 (当会员投递入柜 ，推送【2004 会员投递入柜 】状态码时，此值为必填；)
		///</summary>
		
		private string locker_address_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public string GetTrade_id(){
			return this.trade_id_;
		}
		
		public void SetTrade_id(string value){
			this.trade_id_ = value;
		}
		public string GetLocker_code(){
			return this.locker_code_;
		}
		
		public void SetLocker_code(string value){
			this.locker_code_ = value;
		}
		public long? GetExpired_time(){
			return this.expired_time_;
		}
		
		public void SetExpired_time(long? value){
			this.expired_time_ = value;
		}
		public string GetExpress_cabinet_code(){
			return this.express_cabinet_code_;
		}
		
		public void SetExpress_cabinet_code(string value){
			this.express_cabinet_code_ = value;
		}
		public string GetAction_code(){
			return this.action_code_;
		}
		
		public void SetAction_code(string value){
			this.action_code_ = value;
		}
		public string GetTrace_code(){
			return this.trace_code_;
		}
		
		public void SetTrace_code(string value){
			this.trace_code_ = value;
		}
		public string GetLocker_address(){
			return this.locker_address_;
		}
		
		public void SetLocker_address(string value){
			this.locker_address_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		
	}
	
}