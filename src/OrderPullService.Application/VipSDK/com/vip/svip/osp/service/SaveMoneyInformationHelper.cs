using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class SaveMoneyInformationHelper : TBeanSerializer<SaveMoneyInformation>
	{
		
		public static SaveMoneyInformationHelper OBJ = new SaveMoneyInformationHelper();
		
		public static SaveMoneyInformationHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SaveMoneyInformation structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("discountSaveAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscountSaveAmount(value);
					}
					
					
					
					
					
					if ("discountSaveAmountType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetDiscountSaveAmountType(value);
					}
					
					
					
					
					
					if ("carriageSaveAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarriageSaveAmount(value);
					}
					
					
					
					
					
					if ("carriageSaveAmountType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetCarriageSaveAmountType(value);
					}
					
					
					
					
					
					if ("birthdaySaveAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBirthdaySaveAmount(value);
					}
					
					
					
					
					
					if ("birthdaySaveAmountType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetBirthdaySaveAmountType(value);
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
		
		
		public void Write(SaveMoneyInformation structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetDiscountSaveAmount() != null) {
				
				oprot.WriteFieldBegin("discountSaveAmount");
				oprot.WriteString(structs.GetDiscountSaveAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountSaveAmountType() != null) {
				
				oprot.WriteFieldBegin("discountSaveAmountType");
				oprot.WriteI32((int)structs.GetDiscountSaveAmountType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("discountSaveAmountType can not be null!");
			}
			
			
			if(structs.GetCarriageSaveAmount() != null) {
				
				oprot.WriteFieldBegin("carriageSaveAmount");
				oprot.WriteString(structs.GetCarriageSaveAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarriageSaveAmountType() != null) {
				
				oprot.WriteFieldBegin("carriageSaveAmountType");
				oprot.WriteI32((int)structs.GetCarriageSaveAmountType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("carriageSaveAmountType can not be null!");
			}
			
			
			if(structs.GetBirthdaySaveAmount() != null) {
				
				oprot.WriteFieldBegin("birthdaySaveAmount");
				oprot.WriteString(structs.GetBirthdaySaveAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBirthdaySaveAmountType() != null) {
				
				oprot.WriteFieldBegin("birthdaySaveAmountType");
				oprot.WriteI32((int)structs.GetBirthdaySaveAmountType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("birthdaySaveAmountType can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SaveMoneyInformation bean){
			
			
		}
		
	}
	
}