using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.cabinet{
	
	
	
	public class LockerActionResultHelper : TBeanSerializer<LockerActionResult>
	{
		
		public static LockerActionResultHelper OBJ = new LockerActionResultHelper();
		
		public static LockerActionResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(LockerActionResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("logistics_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLogistics_no(value);
					}
					
					
					
					
					
					if ("result_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResult_code(value);
					}
					
					
					
					
					
					if ("result_msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResult_msg(value);
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
		
		
		public void Write(LockerActionResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetLogistics_no() != null) {
				
				oprot.WriteFieldBegin("logistics_no");
				oprot.WriteString(structs.GetLogistics_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetResult_code() != null) {
				
				oprot.WriteFieldBegin("result_code");
				oprot.WriteString(structs.GetResult_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetResult_msg() != null) {
				
				oprot.WriteFieldBegin("result_msg");
				oprot.WriteString(structs.GetResult_msg());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(LockerActionResult bean){
			
			
		}
		
	}
	
}