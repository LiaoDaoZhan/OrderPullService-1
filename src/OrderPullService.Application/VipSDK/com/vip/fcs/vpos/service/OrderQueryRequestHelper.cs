using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vpos.service{
	
	
	
	public class OrderQueryRequestHelper : TBeanSerializer<OrderQueryRequest>
	{
		
		public static OrderQueryRequestHelper OBJ = new OrderQueryRequestHelper();
		
		public static OrderQueryRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderQueryRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("updateTimeBegin".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdateTimeBegin(value);
					}
					
					
					
					
					
					if ("updateTimeEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdateTimeEnd(value);
					}
					
					
					
					
					
					if ("pageIndex".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPageIndex(value);
					}
					
					
					
					
					
					if ("storeCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreCode(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("saleType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSaleType(value);
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
		
		
		public void Write(OrderQueryRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUpdateTimeBegin() != null) {
				
				oprot.WriteFieldBegin("updateTimeBegin");
				oprot.WriteI64((long)structs.GetUpdateTimeBegin()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("updateTimeBegin can not be null!");
			}
			
			
			if(structs.GetUpdateTimeEnd() != null) {
				
				oprot.WriteFieldBegin("updateTimeEnd");
				oprot.WriteI64((long)structs.GetUpdateTimeEnd()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("updateTimeEnd can not be null!");
			}
			
			
			if(structs.GetPageIndex() != null) {
				
				oprot.WriteFieldBegin("pageIndex");
				oprot.WriteI32((int)structs.GetPageIndex()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pageIndex can not be null!");
			}
			
			
			if(structs.GetStoreCode() != null) {
				
				oprot.WriteFieldBegin("storeCode");
				oprot.WriteString(structs.GetStoreCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("storeCode can not be null!");
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSaleType() != null) {
				
				oprot.WriteFieldBegin("saleType");
				oprot.WriteString(structs.GetSaleType());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("saleType can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderQueryRequest bean){
			
			
		}
		
	}
	
}