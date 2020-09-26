using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class BirthGiftInfo {
		
		///<summary>
		/// 生日礼状态码 110001:已领取生日礼
		///110002:没有配置生日礼活动奖励
		///110003:满足领取条件，用户未领取生日礼
		///110004:不满足领取条件，用户不可领取
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 生日礼奖品列表
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 用户生日 M月d日
		///</summary>
		
		private string birthday_;
		
		///<summary>
		/// 生日礼奖品列表
		///</summary>
		
		private List<com.vip.svip.osp.service.BirthGiftPrize> prizeList_;
		
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		public string GetBirthday(){
			return this.birthday_;
		}
		
		public void SetBirthday(string value){
			this.birthday_ = value;
		}
		public List<com.vip.svip.osp.service.BirthGiftPrize> GetPrizeList(){
			return this.prizeList_;
		}
		
		public void SetPrizeList(List<com.vip.svip.osp.service.BirthGiftPrize> value){
			this.prizeList_ = value;
		}
		
	}
	
}