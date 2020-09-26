using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class GetOrderLabelRequest {
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 面单详情列表;最多200个面单
		///</summary>
		
		private List<vipapis.jitx.PrintDetail> print_details_;
		
		///<summary>
		/// 模版格式  JSON:返回JSON格式 HTML：返回HTML 
		///</summary>
		
		private string template_type_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public List<vipapis.jitx.PrintDetail> GetPrint_details(){
			return this.print_details_;
		}
		
		public void SetPrint_details(List<vipapis.jitx.PrintDetail> value){
			this.print_details_ = value;
		}
		public string GetTemplate_type(){
			return this.template_type_;
		}
		
		public void SetTemplate_type(string value){
			this.template_type_ = value;
		}
		
	}
	
}