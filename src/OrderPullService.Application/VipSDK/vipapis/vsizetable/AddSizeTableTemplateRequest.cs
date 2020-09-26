using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vsizetable{
	
	
	
	
	
	public class AddSizeTableTemplateRequest {
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 是否为标准尺码表标识位，1：为标准尺码表，2：自定义尺码表
		///</summary>
		
		private short? type_;
		
		///<summary>
		/// 尺码表模板名称
		///</summary>
		
		private string template_name_;
		
		///<summary>
		/// 尺码表温馨提示
		///</summary>
		
		private string tips_;
		
		///<summary>
		/// 尺码表模板类型。例：0：文胸，1：成人上装，2：成人裤装 等
		///</summary>
		
		private int? template_type_;
		
		///<summary>
		/// 自定义尺码表的html内容,当type=2, 此项必填
		///</summary>
		
		private string html_;
		
		///<summary>
		/// 尺码表明细信息，注：当type=1时，此项必填
		///</summary>
		
		private List<vipapis.vsizetable.SizeDetailSummary> size_detail_summaries_;
		
		///<summary>
		/// 三级类目ID
		///</summary>
		
		private int? third_category_id_;
		
		///<summary>
		/// 三级类目名称
		///</summary>
		
		private string third_category_name_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public short? GetType(){
			return this.type_;
		}
		
		public void SetType(short? value){
			this.type_ = value;
		}
		public string GetTemplate_name(){
			return this.template_name_;
		}
		
		public void SetTemplate_name(string value){
			this.template_name_ = value;
		}
		public string GetTips(){
			return this.tips_;
		}
		
		public void SetTips(string value){
			this.tips_ = value;
		}
		public int? GetTemplate_type(){
			return this.template_type_;
		}
		
		public void SetTemplate_type(int? value){
			this.template_type_ = value;
		}
		public string GetHtml(){
			return this.html_;
		}
		
		public void SetHtml(string value){
			this.html_ = value;
		}
		public List<vipapis.vsizetable.SizeDetailSummary> GetSize_detail_summaries(){
			return this.size_detail_summaries_;
		}
		
		public void SetSize_detail_summaries(List<vipapis.vsizetable.SizeDetailSummary> value){
			this.size_detail_summaries_ = value;
		}
		public int? GetThird_category_id(){
			return this.third_category_id_;
		}
		
		public void SetThird_category_id(int? value){
			this.third_category_id_ = value;
		}
		public string GetThird_category_name(){
			return this.third_category_name_;
		}
		
		public void SetThird_category_name(string value){
			this.third_category_name_ = value;
		}
		
	}
	
}