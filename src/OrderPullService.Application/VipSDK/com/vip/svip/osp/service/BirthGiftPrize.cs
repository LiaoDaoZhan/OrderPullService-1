using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class BirthGiftPrize {
		
		///<summary>
		/// 奖品名称
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 奖品类型:COUPON:优惠劵 POINT：唯品币
		///</summary>
		
		private string type_;
		
		///<summary>
		/// 奖品值, 如50元优惠劵，则value=50
		///</summary>
		
		private string value_;
		
		///<summary>
		/// 移动端图片url
		///</summary>
		
		private string app_img_url_;
		
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		public string GetType(){
			return this.type_;
		}
		
		public void SetType(string value){
			this.type_ = value;
		}
		public string GetValue(){
			return this.value_;
		}
		
		public void SetValue(string value){
			this.value_ = value;
		}
		public string GetApp_img_url(){
			return this.app_img_url_;
		}
		
		public void SetApp_img_url(string value){
			this.app_img_url_ = value;
		}
		
	}
	
}