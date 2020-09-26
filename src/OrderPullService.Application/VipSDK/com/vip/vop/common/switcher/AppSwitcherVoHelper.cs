using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.common.switcher{
	
	
	
	public class AppSwitcherVoHelper : TBeanSerializer<AppSwitcherVo>
	{
		
		public static AppSwitcherVoHelper OBJ = new AppSwitcherVoHelper();
		
		public static AppSwitcherVoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AppSwitcherVo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("domainName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDomainName(value);
					}
					
					
					
					
					
					if ("moduleName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetModuleName(value);
					}
					
					
					
					
					
					if ("switchStat".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetSwitchStat(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateTime(value);
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
		
		
		public void Write(AppSwitcherVo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetDomainName() != null) {
				
				oprot.WriteFieldBegin("domainName");
				oprot.WriteString(structs.GetDomainName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("domainName can not be null!");
			}
			
			
			if(structs.GetModuleName() != null) {
				
				oprot.WriteFieldBegin("moduleName");
				oprot.WriteString(structs.GetModuleName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("moduleName can not be null!");
			}
			
			
			if(structs.GetSwitchStat() != null) {
				
				oprot.WriteFieldBegin("switchStat");
				oprot.WriteByte((byte)structs.GetSwitchStat()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("switchStat can not be null!");
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteString(structs.GetCreateTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AppSwitcherVo bean){
			
			
		}
		
	}
	
}