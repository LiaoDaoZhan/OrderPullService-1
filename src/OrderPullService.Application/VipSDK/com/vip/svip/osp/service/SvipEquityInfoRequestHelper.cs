using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class SvipEquityInfoRequestHelper : TBeanSerializer<SvipEquityInfoRequest>
	{
		
		public static SvipEquityInfoRequestHelper OBJ = new SvipEquityInfoRequestHelper();
		
		public static SvipEquityInfoRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SvipEquityInfoRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("needSaveAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetNeedSaveAmount(value);
					}
					
					
					
					
					
					if ("needFigureUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetNeedFigureUrl(value);
					}
					
					
					
					
					
					if ("needRebate".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetNeedRebate(value);
					}
					
					
					
					
					
					if ("needPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetNeedPrice(value);
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
		
		
		public void Write(SvipEquityInfoRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetNeedSaveAmount() != null) {
				
				oprot.WriteFieldBegin("needSaveAmount");
				oprot.WriteBool((bool)structs.GetNeedSaveAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNeedFigureUrl() != null) {
				
				oprot.WriteFieldBegin("needFigureUrl");
				oprot.WriteBool((bool)structs.GetNeedFigureUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNeedRebate() != null) {
				
				oprot.WriteFieldBegin("needRebate");
				oprot.WriteBool((bool)structs.GetNeedRebate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNeedPrice() != null) {
				
				oprot.WriteFieldBegin("needPrice");
				oprot.WriteBool((bool)structs.GetNeedPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SvipEquityInfoRequest bean){
			
			
		}
		
	}
	
}