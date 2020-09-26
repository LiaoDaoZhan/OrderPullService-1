using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vsizetable{
	
	
	
	public class SizetableConfigHelper : TBeanSerializer<SizetableConfig>
	{
		
		public static SizetableConfigHelper OBJ = new SizetableConfigHelper();
		
		public static SizetableConfigHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SizetableConfig structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("size_attr_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSize_attr_name(value);
					}
					
					
					
					
					
					if ("required".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRequired(value);
					}
					
					
					
					
					
					if ("threshold_start".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetThreshold_start(value);
					}
					
					
					
					
					
					if ("threshold_end".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetThreshold_end(value);
					}
					
					
					
					
					
					if ("other_value".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOther_value(value);
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
		
		
		public void Write(SizetableConfig structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSize_attr_name() != null) {
				
				oprot.WriteFieldBegin("size_attr_name");
				oprot.WriteString(structs.GetSize_attr_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRequired() != null) {
				
				oprot.WriteFieldBegin("required");
				oprot.WriteI32((int)structs.GetRequired()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetThreshold_start() != null) {
				
				oprot.WriteFieldBegin("threshold_start");
				oprot.WriteI32((int)structs.GetThreshold_start()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetThreshold_end() != null) {
				
				oprot.WriteFieldBegin("threshold_end");
				oprot.WriteI32((int)structs.GetThreshold_end()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOther_value() != null) {
				
				oprot.WriteFieldBegin("other_value");
				oprot.WriteString(structs.GetOther_value());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SizetableConfig bean){
			
			
		}
		
	}
	
}