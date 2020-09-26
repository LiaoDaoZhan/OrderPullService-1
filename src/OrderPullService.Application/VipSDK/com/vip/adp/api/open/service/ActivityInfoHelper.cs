using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class ActivityInfoHelper : TBeanSerializer<ActivityInfo>
	{
		
		public static ActivityInfoHelper OBJ = new ActivityInfoHelper();
		
		public static ActivityInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ActivityInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("actType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetActType(value);
					}
					
					
					
					
					
					if ("actName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActName(value);
					}
					
					
					
					
					
					if ("beginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetBeginTime(value);
					}
					
					
					
					
					
					if ("endTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetEndTime(value);
					}
					
					
					
					
					
					if ("foreShowBeginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetForeShowBeginTime(value);
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
		
		
		public void Write(ActivityInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetActType() != null) {
				
				oprot.WriteFieldBegin("actType");
				oprot.WriteI32((int)structs.GetActType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActName() != null) {
				
				oprot.WriteFieldBegin("actName");
				oprot.WriteString(structs.GetActName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBeginTime() != null) {
				
				oprot.WriteFieldBegin("beginTime");
				oprot.WriteI64((long)structs.GetBeginTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEndTime() != null) {
				
				oprot.WriteFieldBegin("endTime");
				oprot.WriteI64((long)structs.GetEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetForeShowBeginTime() != null) {
				
				oprot.WriteFieldBegin("foreShowBeginTime");
				oprot.WriteI64((long)structs.GetForeShowBeginTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ActivityInfo bean){
			
			
		}
		
	}
	
}