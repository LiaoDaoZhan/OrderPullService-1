using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.closePo.service{
	
	
	
	public class ItemReceiveInfoHelper : TBeanSerializer<ItemReceiveInfo>
	{
		
		public static ItemReceiveInfoHelper OBJ = new ItemReceiveInfoHelper();
		
		public static ItemReceiveInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ItemReceiveInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("itemBarCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetItemBarCode(value);
					}
					
					
					
					
					
					if ("recAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRecAmount(value);
					}
					
					
					
					
					
					if ("purchaseAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPurchaseAmount(value);
					}
					
					
					
					
					
					if ("brandSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandSn(value);
					}
					
					
					
					
					
					if ("cat3Code".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCat3Code(value);
					}
					
					
					
					
					
					if ("buyerGroupCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerGroupCode(value);
					}
					
					
					
					
					
					if ("priceWithTax".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetPriceWithTax(value);
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
		
		
		public void Write(ItemReceiveInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetItemBarCode() != null) {
				
				oprot.WriteFieldBegin("itemBarCode");
				oprot.WriteString(structs.GetItemBarCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRecAmount() != null) {
				
				oprot.WriteFieldBegin("recAmount");
				oprot.WriteI32((int)structs.GetRecAmount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseAmount() != null) {
				
				oprot.WriteFieldBegin("purchaseAmount");
				oprot.WriteI32((int)structs.GetPurchaseAmount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandSn() != null) {
				
				oprot.WriteFieldBegin("brandSn");
				oprot.WriteString(structs.GetBrandSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCat3Code() != null) {
				
				oprot.WriteFieldBegin("cat3Code");
				oprot.WriteI32((int)structs.GetCat3Code()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerGroupCode() != null) {
				
				oprot.WriteFieldBegin("buyerGroupCode");
				oprot.WriteString(structs.GetBuyerGroupCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPriceWithTax() != null) {
				
				oprot.WriteFieldBegin("priceWithTax");
				oprot.WriteDouble((double)structs.GetPriceWithTax());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ItemReceiveInfo bean){
			
			
		}
		
	}
	
}