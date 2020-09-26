using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.cabinet{
	
	
	
	public class LockerActionHelper : TBeanSerializer<LockerAction>
	{
		
		public static LockerActionHelper OBJ = new LockerActionHelper();
		
		public static LockerActionHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(LockerAction structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("trade_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrade_id(value);
					}
					
					
					
					
					
					if ("locker_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLocker_code(value);
					}
					
					
					
					
					
					if ("expired_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetExpired_time(value);
					}
					
					
					
					
					
					if ("express_cabinet_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpress_cabinet_code(value);
					}
					
					
					
					
					
					if ("action_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAction_code(value);
					}
					
					
					
					
					
					if ("trace_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrace_code(value);
					}
					
					
					
					
					
					if ("locker_address".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLocker_address(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
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
		
		
		public void Write(LockerAction structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetLogistics_no() != null) {
				
				oprot.WriteFieldBegin("logistics_no");
				oprot.WriteString(structs.GetLogistics_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("logistics_no can not be null!");
			}
			
			
			if(structs.GetTrade_id() != null) {
				
				oprot.WriteFieldBegin("trade_id");
				oprot.WriteString(structs.GetTrade_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("trade_id can not be null!");
			}
			
			
			if(structs.GetLocker_code() != null) {
				
				oprot.WriteFieldBegin("locker_code");
				oprot.WriteString(structs.GetLocker_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpired_time() != null) {
				
				oprot.WriteFieldBegin("expired_time");
				oprot.WriteI64((long)structs.GetExpired_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpress_cabinet_code() != null) {
				
				oprot.WriteFieldBegin("express_cabinet_code");
				oprot.WriteString(structs.GetExpress_cabinet_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAction_code() != null) {
				
				oprot.WriteFieldBegin("action_code");
				oprot.WriteString(structs.GetAction_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("action_code can not be null!");
			}
			
			
			if(structs.GetTrace_code() != null) {
				
				oprot.WriteFieldBegin("trace_code");
				oprot.WriteString(structs.GetTrace_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLocker_address() != null) {
				
				oprot.WriteFieldBegin("locker_address");
				oprot.WriteString(structs.GetLocker_address());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(LockerAction bean){
			
			
		}
		
	}
	
}