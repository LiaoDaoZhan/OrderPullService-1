using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vsizetable{
	
	
	
	
	
	public class SizetableConfig {
		
		///<summary>
		/// 尺码表属性名称
		///</summary>
		
		private string size_attr_name_;
		
		///<summary>
		/// 是否必填，0：非必填，1：必填
		///</summary>
		
		private int? required_;
		
		///<summary>
		/// 阀值起始值
		///</summary>
		
		private int? threshold_start_;
		
		///<summary>
		/// 阀值终止值
		///</summary>
		
		private int? threshold_end_;
		
		///<summary>
		/// 其他离散枚举值，多个用分号分隔
		///</summary>
		
		private string other_value_;
		
		public string GetSize_attr_name(){
			return this.size_attr_name_;
		}
		
		public void SetSize_attr_name(string value){
			this.size_attr_name_ = value;
		}
		public int? GetRequired(){
			return this.required_;
		}
		
		public void SetRequired(int? value){
			this.required_ = value;
		}
		public int? GetThreshold_start(){
			return this.threshold_start_;
		}
		
		public void SetThreshold_start(int? value){
			this.threshold_start_ = value;
		}
		public int? GetThreshold_end(){
			return this.threshold_end_;
		}
		
		public void SetThreshold_end(int? value){
			this.threshold_end_ = value;
		}
		public string GetOther_value(){
			return this.other_value_;
		}
		
		public void SetOther_value(string value){
			this.other_value_ = value;
		}
		
	}
	
}