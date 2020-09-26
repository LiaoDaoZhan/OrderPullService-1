using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vsizetable{
	
	
	
	
	
	public class CategorySizetableConfig {
		
		///<summary>
		/// 类目ID
		///</summary>
		
		private int? category_id_;
		
		///<summary>
		/// 类目名称
		///</summary>
		
		private string category_name_;
		
		///<summary>
		/// 尺码类ID
		///</summary>
		
		private int? size_type_id_;
		
		///<summary>
		/// 尺码类名称
		///</summary>
		
		private string size_type_name_;
		
		///<summary>
		/// 尺码表配置信息集合
		///</summary>
		
		private List<vipapis.vsizetable.SizetableConfig> sizetableConfigs_;
		
		public int? GetCategory_id(){
			return this.category_id_;
		}
		
		public void SetCategory_id(int? value){
			this.category_id_ = value;
		}
		public string GetCategory_name(){
			return this.category_name_;
		}
		
		public void SetCategory_name(string value){
			this.category_name_ = value;
		}
		public int? GetSize_type_id(){
			return this.size_type_id_;
		}
		
		public void SetSize_type_id(int? value){
			this.size_type_id_ = value;
		}
		public string GetSize_type_name(){
			return this.size_type_name_;
		}
		
		public void SetSize_type_name(string value){
			this.size_type_name_ = value;
		}
		public List<vipapis.vsizetable.SizetableConfig> GetSizetableConfigs(){
			return this.sizetableConfigs_;
		}
		
		public void SetSizetableConfigs(List<vipapis.vsizetable.SizetableConfig> value){
			this.sizetableConfigs_ = value;
		}
		
	}
	
}