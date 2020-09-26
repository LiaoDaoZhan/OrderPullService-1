using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class EquityBaseInfo {
		
		///<summary>
		/// 虚拟商品id
		///</summary>
		
		private string vpid_;
		
		///<summary>
		/// 用户名
		///</summary>
		
		private string nickName_;
		
		///<summary>
		/// 用户状态
		///</summary>
		
		private int? userStatus_;
		
		///<summary>
		/// 是否可试用
		///</summary>
		
		private bool? canTrial_;
		
		///<summary>
		/// 是否可开通
		///</summary>
		
		private bool? canOpen_;
		
		///<summary>
		/// 试用|付费 到期时间
		///</summary>
		
		private long? expireTime_;
		
		///<summary>
		/// 剩余天数
		///</summary>
		
		private int? remainingDays_;
		
		///<summary>
		/// 用户等级
		///</summary>
		
		private string userLv_;
		
		///<summary>
		/// 当用户订单优惠金额大于或等于用户平均优惠金额时返回0， 否则返回1
		///</summary>
		
		private com.vip.svip.osp.service.SaveMoneyInformation saveMoneyInformation_;
		
		///<summary>
		/// 会员价格
		///</summary>
		
		private string price_;
		
		///<summary>
		/// 权益升级状态,其实就是风控
		///</summary>
		
		private int? updating_;
		
		///<summary>
		/// 是否即将过期的状态: 后台配置的剩余m天 
		///</summary>
		
		private bool? imminentExpiry_;
		
		///<summary>
		/// SVIP特别标识名称
		///</summary>
		
		private string specialTag_;
		
		///<summary>
		/// 后返文案
		///</summary>
		
		private string rebateText_;
		
		///<summary>
		/// 到期剩余毫秒值( > 0 时, 有效)
		///</summary>
		
		private long? countDownMS_;
		
		///<summary>
		/// 唯品会头像
		///</summary>
		
		private string vipFigureUrl_;
		
		///<summary>
		/// 开通类型
		///</summary>
		
		private int? openType_;
		
		///<summary>
		/// SVIP生日礼
		///</summary>
		
		private com.vip.svip.osp.service.BirthGiftInfo birthGiftInfo_;
		
		///<summary>
		/// 购物总金额
		///</summary>
		
		private string totalAmount_;
		
		public string GetVpid(){
			return this.vpid_;
		}
		
		public void SetVpid(string value){
			this.vpid_ = value;
		}
		public string GetNickName(){
			return this.nickName_;
		}
		
		public void SetNickName(string value){
			this.nickName_ = value;
		}
		public int? GetUserStatus(){
			return this.userStatus_;
		}
		
		public void SetUserStatus(int? value){
			this.userStatus_ = value;
		}
		public bool? GetCanTrial(){
			return this.canTrial_;
		}
		
		public void SetCanTrial(bool? value){
			this.canTrial_ = value;
		}
		public bool? GetCanOpen(){
			return this.canOpen_;
		}
		
		public void SetCanOpen(bool? value){
			this.canOpen_ = value;
		}
		public long? GetExpireTime(){
			return this.expireTime_;
		}
		
		public void SetExpireTime(long? value){
			this.expireTime_ = value;
		}
		public int? GetRemainingDays(){
			return this.remainingDays_;
		}
		
		public void SetRemainingDays(int? value){
			this.remainingDays_ = value;
		}
		public string GetUserLv(){
			return this.userLv_;
		}
		
		public void SetUserLv(string value){
			this.userLv_ = value;
		}
		public com.vip.svip.osp.service.SaveMoneyInformation GetSaveMoneyInformation(){
			return this.saveMoneyInformation_;
		}
		
		public void SetSaveMoneyInformation(com.vip.svip.osp.service.SaveMoneyInformation value){
			this.saveMoneyInformation_ = value;
		}
		public string GetPrice(){
			return this.price_;
		}
		
		public void SetPrice(string value){
			this.price_ = value;
		}
		public int? GetUpdating(){
			return this.updating_;
		}
		
		public void SetUpdating(int? value){
			this.updating_ = value;
		}
		public bool? GetImminentExpiry(){
			return this.imminentExpiry_;
		}
		
		public void SetImminentExpiry(bool? value){
			this.imminentExpiry_ = value;
		}
		public string GetSpecialTag(){
			return this.specialTag_;
		}
		
		public void SetSpecialTag(string value){
			this.specialTag_ = value;
		}
		public string GetRebateText(){
			return this.rebateText_;
		}
		
		public void SetRebateText(string value){
			this.rebateText_ = value;
		}
		public long? GetCountDownMS(){
			return this.countDownMS_;
		}
		
		public void SetCountDownMS(long? value){
			this.countDownMS_ = value;
		}
		public string GetVipFigureUrl(){
			return this.vipFigureUrl_;
		}
		
		public void SetVipFigureUrl(string value){
			this.vipFigureUrl_ = value;
		}
		public int? GetOpenType(){
			return this.openType_;
		}
		
		public void SetOpenType(int? value){
			this.openType_ = value;
		}
		public com.vip.svip.osp.service.BirthGiftInfo GetBirthGiftInfo(){
			return this.birthGiftInfo_;
		}
		
		public void SetBirthGiftInfo(com.vip.svip.osp.service.BirthGiftInfo value){
			this.birthGiftInfo_ = value;
		}
		public string GetTotalAmount(){
			return this.totalAmount_;
		}
		
		public void SetTotalAmount(string value){
			this.totalAmount_ = value;
		}
		
	}
	
}