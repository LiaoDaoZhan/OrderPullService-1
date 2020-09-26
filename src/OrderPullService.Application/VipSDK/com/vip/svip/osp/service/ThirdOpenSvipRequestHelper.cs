using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class ThirdOpenSvipRequestHelper : TBeanSerializer<ThirdOpenSvipRequest>
	{
		
		public static ThirdOpenSvipRequestHelper OBJ = new ThirdOpenSvipRequestHelper();
		
		public static ThirdOpenSvipRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ThirdOpenSvipRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("userIp".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserIp(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("serial".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSerial(value);
					}
					
					
					
					
					
					if ("thirdMemberType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetThirdMemberType(value);
					}
					
					
					
					
					
					if ("openId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpenId(value);
					}
					
					
					
					
					
					if ("thirdAcct".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetThirdAcct(value);
					}
					
					
					
					
					
					if ("thirdAcctType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetThirdAcctType(value);
					}
					
					
					
					
					
					if ("svipType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSvipType(value);
					}
					
					
					
					
					
					if ("dataSign".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDataSign(value);
					}
					
					
					
					
					
					if ("source".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSource(value);
					}
					
					
					
					
					
					if ("channel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetChannel(value);
					}
					
					
					
					
					
					if ("svipToken".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSvipToken(value);
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
		
		
		public void Write(ThirdOpenSvipRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUserIp() != null) {
				
				oprot.WriteFieldBegin("userIp");
				oprot.WriteString(structs.GetUserIp());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSerial() != null) {
				
				oprot.WriteFieldBegin("serial");
				oprot.WriteString(structs.GetSerial());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetThirdMemberType() != null) {
				
				oprot.WriteFieldBegin("thirdMemberType");
				oprot.WriteI32((int)structs.GetThirdMemberType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOpenId() != null) {
				
				oprot.WriteFieldBegin("openId");
				oprot.WriteString(structs.GetOpenId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetThirdAcct() != null) {
				
				oprot.WriteFieldBegin("thirdAcct");
				oprot.WriteString(structs.GetThirdAcct());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetThirdAcctType() != null) {
				
				oprot.WriteFieldBegin("thirdAcctType");
				oprot.WriteI32((int)structs.GetThirdAcctType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSvipType() != null) {
				
				oprot.WriteFieldBegin("svipType");
				oprot.WriteI32((int)structs.GetSvipType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataSign() != null) {
				
				oprot.WriteFieldBegin("dataSign");
				oprot.WriteString(structs.GetDataSign());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSource() != null) {
				
				oprot.WriteFieldBegin("source");
				oprot.WriteString(structs.GetSource());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannel() != null) {
				
				oprot.WriteFieldBegin("channel");
				oprot.WriteString(structs.GetChannel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSvipToken() != null) {
				
				oprot.WriteFieldBegin("svipToken");
				oprot.WriteString(structs.GetSvipToken());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ThirdOpenSvipRequest bean){
			
			
		}
		
	}
	
}