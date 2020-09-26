using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class ThirdOpenSvipRequest {
		
		///<summary>
		/// userIp
		///</summary>
		
		private string userIp_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 流水号
		///</summary>
		
		private string serial_;
		
		///<summary>
		/// 会员类型(1:季卡 2:年卡)
		///</summary>
		
		private int? thirdMemberType_;
		
		///<summary>
		/// 唯品会用户openId
		///</summary>
		
		private string openId_;
		
		///<summary>
		/// 第三方帐号名
		///</summary>
		
		private string thirdAcct_;
		
		///<summary>
		/// 第三方帐号类型,1电话，2openid
		///</summary>
		
		private int? thirdAcctType_;
		
		///<summary>
		/// 唯品会svip类型(1:年卡2季卡)
		///</summary>
		
		private int? svipType_;
		
		///<summary>
		/// 验签
		///</summary>
		
		private string dataSign_;
		
		///<summary>
		/// 开通来源，ios,android
		///</summary>
		
		private string source_;
		
		///<summary>
		/// 由唯品会分配的渠道号
		///</summary>
		
		private string channel_;
		
		///<summary>
		/// 唯品会分配token
		///</summary>
		
		private string svipToken_;
		
		public string GetUserIp(){
			return this.userIp_;
		}
		
		public void SetUserIp(string value){
			this.userIp_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetSerial(){
			return this.serial_;
		}
		
		public void SetSerial(string value){
			this.serial_ = value;
		}
		public int? GetThirdMemberType(){
			return this.thirdMemberType_;
		}
		
		public void SetThirdMemberType(int? value){
			this.thirdMemberType_ = value;
		}
		public string GetOpenId(){
			return this.openId_;
		}
		
		public void SetOpenId(string value){
			this.openId_ = value;
		}
		public string GetThirdAcct(){
			return this.thirdAcct_;
		}
		
		public void SetThirdAcct(string value){
			this.thirdAcct_ = value;
		}
		public int? GetThirdAcctType(){
			return this.thirdAcctType_;
		}
		
		public void SetThirdAcctType(int? value){
			this.thirdAcctType_ = value;
		}
		public int? GetSvipType(){
			return this.svipType_;
		}
		
		public void SetSvipType(int? value){
			this.svipType_ = value;
		}
		public string GetDataSign(){
			return this.dataSign_;
		}
		
		public void SetDataSign(string value){
			this.dataSign_ = value;
		}
		public string GetSource(){
			return this.source_;
		}
		
		public void SetSource(string value){
			this.source_ = value;
		}
		public string GetChannel(){
			return this.channel_;
		}
		
		public void SetChannel(string value){
			this.channel_ = value;
		}
		public string GetSvipToken(){
			return this.svipToken_;
		}
		
		public void SetSvipToken(string value){
			this.svipToken_ = value;
		}
		
	}
	
}