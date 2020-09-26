using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class SyncCarrierInfoHelper : TBeanSerializer<SyncCarrierInfo>
	{
		
		public static SyncCarrierInfoHelper OBJ = new SyncCarrierInfoHelper();
		
		public static SyncCarrierInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SyncCarrierInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("fromWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFromWarehouse(value);
					}
					
					
					
					
					
					if ("custCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCode(value);
					}
					
					
					
					
					
					if ("ltOrderNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLtOrderNo(value);
					}
					
					
					
					
					
					if ("exchangeRelationNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExchangeRelationNo(value);
					}
					
					
					
					
					
					if ("backSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBackSn(value);
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
		
		
		public void Write(SyncCarrierInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetFromWarehouse() != null) {
				
				oprot.WriteFieldBegin("fromWarehouse");
				oprot.WriteString(structs.GetFromWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustCode() != null) {
				
				oprot.WriteFieldBegin("custCode");
				oprot.WriteString(structs.GetCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLtOrderNo() != null) {
				
				oprot.WriteFieldBegin("ltOrderNo");
				oprot.WriteString(structs.GetLtOrderNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExchangeRelationNo() != null) {
				
				oprot.WriteFieldBegin("exchangeRelationNo");
				oprot.WriteString(structs.GetExchangeRelationNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBackSn() != null) {
				
				oprot.WriteFieldBegin("backSn");
				oprot.WriteString(structs.GetBackSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SyncCarrierInfo bean){
			
			
		}
		
	}
	
}