using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class CommonParamsHelper : TBeanSerializer<CommonParams>
	{
		
		public static CommonParamsHelper OBJ = new CommonParamsHelper();
		
		public static CommonParamsHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CommonParams structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("plat".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPlat(value);
					}
					
					
					
					
					
					if ("deviceType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeviceType(value);
					}
					
					
					
					
					
					if ("deviceValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeviceValue(value);
					}
					
					
					
					
					
					if ("ip".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIp(value);
					}
					
					
					
					
					
					if ("longitude".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLongitude(value);
					}
					
					
					
					
					
					if ("latitude".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLatitude(value);
					}
					
					
					
					
					
					if ("deviceName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeviceName(value);
					}
					
					
					
					
					
					if ("osType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOsType(value);
					}
					
					
					
					
					
					if ("accessType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAccessType(value);
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
		
		
		public void Write(CommonParams structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPlat() != null) {
				
				oprot.WriteFieldBegin("plat");
				oprot.WriteI32((int)structs.GetPlat()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeviceType() != null) {
				
				oprot.WriteFieldBegin("deviceType");
				oprot.WriteString(structs.GetDeviceType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeviceValue() != null) {
				
				oprot.WriteFieldBegin("deviceValue");
				oprot.WriteString(structs.GetDeviceValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIp() != null) {
				
				oprot.WriteFieldBegin("ip");
				oprot.WriteString(structs.GetIp());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLongitude() != null) {
				
				oprot.WriteFieldBegin("longitude");
				oprot.WriteString(structs.GetLongitude());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLatitude() != null) {
				
				oprot.WriteFieldBegin("latitude");
				oprot.WriteString(structs.GetLatitude());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeviceName() != null) {
				
				oprot.WriteFieldBegin("deviceName");
				oprot.WriteString(structs.GetDeviceName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOsType() != null) {
				
				oprot.WriteFieldBegin("osType");
				oprot.WriteString(structs.GetOsType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAccessType() != null) {
				
				oprot.WriteFieldBegin("accessType");
				oprot.WriteString(structs.GetAccessType());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CommonParams bean){
			
			
		}
		
	}
	
}