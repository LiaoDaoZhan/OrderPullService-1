using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class PrepayInfoHelper : TBeanSerializer<PrepayInfo>
	{
		
		public static PrepayInfoHelper OBJ = new PrepayInfoHelper();
		
		public static PrepayInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PrepayInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("isPrepay".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsPrepay(value);
					}
					
					
					
					
					
					if ("prepayPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayPrice(value);
					}
					
					
					
					
					
					if ("firstAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFirstAmount(value);
					}
					
					
					
					
					
					if ("lastAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLastAmount(value);
					}
					
					
					
					
					
					if ("prepayFavAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayFavAmount(value);
					}
					
					
					
					
					
					if ("deductionPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeductionPrice(value);
					}
					
					
					
					
					
					if ("prepayDiscount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayDiscount(value);
					}
					
					
					
					
					
					if ("prepayFirstStartTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPrepayFirstStartTime(value);
					}
					
					
					
					
					
					if ("prepayFirstEndTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPrepayFirstEndTime(value);
					}
					
					
					
					
					
					if ("prepayLastStartTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPrepayLastStartTime(value);
					}
					
					
					
					
					
					if ("prepayLastEndTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPrepayLastEndTime(value);
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
		
		
		public void Write(PrepayInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetIsPrepay() != null) {
				
				oprot.WriteFieldBegin("isPrepay");
				oprot.WriteI32((int)structs.GetIsPrepay()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayPrice() != null) {
				
				oprot.WriteFieldBegin("prepayPrice");
				oprot.WriteString(structs.GetPrepayPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFirstAmount() != null) {
				
				oprot.WriteFieldBegin("firstAmount");
				oprot.WriteString(structs.GetFirstAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLastAmount() != null) {
				
				oprot.WriteFieldBegin("lastAmount");
				oprot.WriteString(structs.GetLastAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayFavAmount() != null) {
				
				oprot.WriteFieldBegin("prepayFavAmount");
				oprot.WriteString(structs.GetPrepayFavAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeductionPrice() != null) {
				
				oprot.WriteFieldBegin("deductionPrice");
				oprot.WriteString(structs.GetDeductionPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayDiscount() != null) {
				
				oprot.WriteFieldBegin("prepayDiscount");
				oprot.WriteString(structs.GetPrepayDiscount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayFirstStartTime() != null) {
				
				oprot.WriteFieldBegin("prepayFirstStartTime");
				oprot.WriteI64((long)structs.GetPrepayFirstStartTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayFirstEndTime() != null) {
				
				oprot.WriteFieldBegin("prepayFirstEndTime");
				oprot.WriteI64((long)structs.GetPrepayFirstEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayLastStartTime() != null) {
				
				oprot.WriteFieldBegin("prepayLastStartTime");
				oprot.WriteI64((long)structs.GetPrepayLastStartTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayLastEndTime() != null) {
				
				oprot.WriteFieldBegin("prepayLastEndTime");
				oprot.WriteI64((long)structs.GetPrepayLastEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PrepayInfo bean){
			
			
		}
		
	}
	
}