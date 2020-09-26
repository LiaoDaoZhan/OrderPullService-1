using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying{
	
	
	
	public class CcPoItemHelper : TBeanSerializer<CcPoItem>
	{
		
		public static CcPoItemHelper OBJ = new CcPoItemHelper();
		
		public static CcPoItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CcPoItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("po".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPo(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("vSpuId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetVSpuId(value);
					}
					
					
					
					
					
					if ("vSkuId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetVSkuId(value);
					}
					
					
					
					
					
					if ("costPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetCostPrice(value);
					}
					
					
					
					
					
					if ("tagPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetTagPrice(value);
					}
					
					
					
					
					
					if ("deliverWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliverWarehouse(value);
					}
					
					
					
					
					
					if ("purchaseQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPurchaseQuantity(value);
					}
					
					
					
					
					
					if ("disabilityLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDisabilityLevel(value);
					}
					
					
					
					
					
					if ("subDisabilityLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSubDisabilityLevel(value);
					}
					
					
					
					
					
					if ("age".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAge(value);
					}
					
					
					
					
					
					if ("holdQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetHoldQuantity(value);
					}
					
					
					
					
					
					if ("deliveredQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDeliveredQuantity(value);
					}
					
					
					
					
					
					if ("receivedQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetReceivedQuantity(value);
					}
					
					
					
					
					
					if ("barcodeOrigin".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcodeOrigin(value);
					}
					
					
					
					
					
					if ("prodName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProdName(value);
					}
					
					
					
					
					
					if ("vipPurchasePrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetVipPurchasePrice(value);
					}
					
					
					
					
					
					if ("costPriceCny".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetCostPriceCny(value);
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
		
		
		public void Write(CcPoItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPo() != null) {
				
				oprot.WriteFieldBegin("po");
				oprot.WriteString(structs.GetPo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVSpuId() != null) {
				
				oprot.WriteFieldBegin("vSpuId");
				oprot.WriteI64((long)structs.GetVSpuId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVSkuId() != null) {
				
				oprot.WriteFieldBegin("vSkuId");
				oprot.WriteI64((long)structs.GetVSkuId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCostPrice() != null) {
				
				oprot.WriteFieldBegin("costPrice");
				oprot.WriteDouble((double)structs.GetCostPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTagPrice() != null) {
				
				oprot.WriteFieldBegin("tagPrice");
				oprot.WriteDouble((double)structs.GetTagPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliverWarehouse() != null) {
				
				oprot.WriteFieldBegin("deliverWarehouse");
				oprot.WriteString(structs.GetDeliverWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseQuantity() != null) {
				
				oprot.WriteFieldBegin("purchaseQuantity");
				oprot.WriteI32((int)structs.GetPurchaseQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDisabilityLevel() != null) {
				
				oprot.WriteFieldBegin("disabilityLevel");
				oprot.WriteString(structs.GetDisabilityLevel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSubDisabilityLevel() != null) {
				
				oprot.WriteFieldBegin("subDisabilityLevel");
				oprot.WriteString(structs.GetSubDisabilityLevel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAge() != null) {
				
				oprot.WriteFieldBegin("age");
				oprot.WriteI32((int)structs.GetAge()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHoldQuantity() != null) {
				
				oprot.WriteFieldBegin("holdQuantity");
				oprot.WriteI32((int)structs.GetHoldQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveredQuantity() != null) {
				
				oprot.WriteFieldBegin("deliveredQuantity");
				oprot.WriteI32((int)structs.GetDeliveredQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceivedQuantity() != null) {
				
				oprot.WriteFieldBegin("receivedQuantity");
				oprot.WriteI32((int)structs.GetReceivedQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcodeOrigin() != null) {
				
				oprot.WriteFieldBegin("barcodeOrigin");
				oprot.WriteString(structs.GetBarcodeOrigin());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProdName() != null) {
				
				oprot.WriteFieldBegin("prodName");
				oprot.WriteString(structs.GetProdName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipPurchasePrice() != null) {
				
				oprot.WriteFieldBegin("vipPurchasePrice");
				oprot.WriteDouble((double)structs.GetVipPurchasePrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCostPriceCny() != null) {
				
				oprot.WriteFieldBegin("costPriceCny");
				oprot.WriteDouble((double)structs.GetCostPriceCny());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CcPoItem bean){
			
			
		}
		
	}
	
}