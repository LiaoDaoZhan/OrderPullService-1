using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vsizetable{
	
	
	
	public class CategorySizetableConfigHelper : TBeanSerializer<CategorySizetableConfig>
	{
		
		public static CategorySizetableConfigHelper OBJ = new CategorySizetableConfigHelper();
		
		public static CategorySizetableConfigHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CategorySizetableConfig structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("category_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCategory_id(value);
					}
					
					
					
					
					
					if ("category_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategory_name(value);
					}
					
					
					
					
					
					if ("size_type_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSize_type_id(value);
					}
					
					
					
					
					
					if ("size_type_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSize_type_name(value);
					}
					
					
					
					
					
					if ("sizetableConfigs".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.vsizetable.SizetableConfig> value;
						
						value = new List<vipapis.vsizetable.SizetableConfig>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.vsizetable.SizetableConfig elem0;
								
								elem0 = new vipapis.vsizetable.SizetableConfig();
								vipapis.vsizetable.SizetableConfigHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSizetableConfigs(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(CategorySizetableConfig structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCategory_id() != null) {
				
				oprot.WriteFieldBegin("category_id");
				oprot.WriteI32((int)structs.GetCategory_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategory_name() != null) {
				
				oprot.WriteFieldBegin("category_name");
				oprot.WriteString(structs.GetCategory_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSize_type_id() != null) {
				
				oprot.WriteFieldBegin("size_type_id");
				oprot.WriteI32((int)structs.GetSize_type_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSize_type_name() != null) {
				
				oprot.WriteFieldBegin("size_type_name");
				oprot.WriteString(structs.GetSize_type_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSizetableConfigs() != null) {
				
				oprot.WriteFieldBegin("sizetableConfigs");
				
				oprot.WriteListBegin();
				foreach(vipapis.vsizetable.SizetableConfig _item0 in structs.GetSizetableConfigs()){
					
					
					vipapis.vsizetable.SizetableConfigHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CategorySizetableConfig bean){
			
			
		}
		
	}
	
}