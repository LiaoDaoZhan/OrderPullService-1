using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.delivery{
	
	
	
	public class CancelDeliveryRespHelper : TBeanSerializer<CancelDeliveryResp>
	{
		
		public static CancelDeliveryRespHelper OBJ = new CancelDeliveryRespHelper();
		
		public static CancelDeliveryRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CancelDeliveryResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("return_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturn_code(value);
					}
					
					
					
					
					
					if ("return_msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturn_msg(value);
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
		
		
		public void Write(CancelDeliveryResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetReturn_code() != null) {
				
				oprot.WriteFieldBegin("return_code");
				oprot.WriteString(structs.GetReturn_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturn_msg() != null) {
				
				oprot.WriteFieldBegin("return_msg");
				oprot.WriteString(structs.GetReturn_msg());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CancelDeliveryResp bean){
			
			
		}
		
	}
	
}