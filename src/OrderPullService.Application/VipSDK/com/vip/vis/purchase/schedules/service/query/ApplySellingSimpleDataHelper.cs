using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	public class ApplySellingSimpleDataHelper : TBeanSerializer<ApplySellingSimpleData>
	{
		
		public static ApplySellingSimpleDataHelper OBJ = new ApplySellingSimpleDataHelper();
		
		public static ApplySellingSimpleDataHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ApplySellingSimpleData structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("shopCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetShopCode(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("vendorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorName(value);
					}
					
					
					
					
					
					if ("sellingMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSellingMode(value);
					}
					
					
					
					
					
					if ("b2cModeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetB2cModeId(value);
					}
					
					
					
					
					
					if ("sellArea".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellArea(value);
					}
					
					
					
					
					
					if ("sellTimeFromStr".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellTimeFromStr(value);
					}
					
					
					
					
					
					if ("sellTimeToStr".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellTimeToStr(value);
					}
					
					
					
					
					
					if ("isPos".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsPos(value);
					}
					
					
					
					
					
					if ("isStoreDelivery".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsStoreDelivery(value);
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
		
		
		public void Write(ApplySellingSimpleData structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteI64((long)structs.GetBrandId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShopCode() != null) {
				
				oprot.WriteFieldBegin("shopCode");
				oprot.WriteI64((long)structs.GetShopCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteI32((int)structs.GetVendorCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingMode() != null) {
				
				oprot.WriteFieldBegin("sellingMode");
				oprot.WriteByte((byte)structs.GetSellingMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetB2cModeId() != null) {
				
				oprot.WriteFieldBegin("b2cModeId");
				oprot.WriteI32((int)structs.GetB2cModeId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellArea() != null) {
				
				oprot.WriteFieldBegin("sellArea");
				oprot.WriteString(structs.GetSellArea());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeFromStr() != null) {
				
				oprot.WriteFieldBegin("sellTimeFromStr");
				oprot.WriteString(structs.GetSellTimeFromStr());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeToStr() != null) {
				
				oprot.WriteFieldBegin("sellTimeToStr");
				oprot.WriteString(structs.GetSellTimeToStr());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsPos() != null) {
				
				oprot.WriteFieldBegin("isPos");
				oprot.WriteByte((byte)structs.GetIsPos()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsStoreDelivery() != null) {
				
				oprot.WriteFieldBegin("isStoreDelivery");
				oprot.WriteByte((byte)structs.GetIsStoreDelivery()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ApplySellingSimpleData bean){
			
			
		}
		
	}
	
}