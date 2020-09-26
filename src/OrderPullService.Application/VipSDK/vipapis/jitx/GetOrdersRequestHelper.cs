using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class GetOrdersRequestHelper : TBeanSerializer<GetOrdersRequest>
	{
		
		public static GetOrdersRequestHelper OBJ = new GetOrdersRequestHelper();
		
		public static GetOrdersRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetOrdersRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("vendor_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetVendor_id(value);
					}
					
					
					
					
					
					if ("order_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem1;
								elem1 = iprot.ReadString();
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrder_status(value);
					}
					
					
					
					
					
					if ("start_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetStart_time(value);
					}
					
					
					
					
					
					if ("end_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetEnd_time(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("limit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetLimit(value);
					}
					
					
					
					
					
					if ("cooperation_nos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								string elem2;
								elem2 = iprot.ReadString();
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetCooperation_nos(value);
					}
					
					
					
					
					
					if ("delivery_warehouse_codes".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								string elem3;
								elem3 = iprot.ReadString();
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetDelivery_warehouse_codes(value);
					}
					
					
					
					
					
					if ("order_types".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<int?> value;
						
						value = new List<int?>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								int elem4;
								elem4 = iprot.ReadI32(); 
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetOrder_types(value);
					}
					
					
					
					
					
					if ("is_forbidden_delivery".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIs_forbidden_delivery(value);
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
		
		
		public void Write(GetOrdersRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetVendor_id() != null) {
				
				oprot.WriteFieldBegin("vendor_id");
				oprot.WriteI32((int)structs.GetVendor_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendor_id can not be null!");
			}
			
			
			if(structs.GetOrder_status() != null) {
				
				oprot.WriteFieldBegin("order_status");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetOrder_status()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStart_time() != null) {
				
				oprot.WriteFieldBegin("start_time");
				oprot.WriteI64((long)structs.GetStart_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("start_time can not be null!");
			}
			
			
			if(structs.GetEnd_time() != null) {
				
				oprot.WriteFieldBegin("end_time");
				oprot.WriteI64((long)structs.GetEnd_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("end_time can not be null!");
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLimit() != null) {
				
				oprot.WriteFieldBegin("limit");
				oprot.WriteI32((int)structs.GetLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCooperation_nos() != null) {
				
				oprot.WriteFieldBegin("cooperation_nos");
				
				oprot.WriteSetBegin();
				foreach(string _item0 in structs.GetCooperation_nos()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDelivery_warehouse_codes() != null) {
				
				oprot.WriteFieldBegin("delivery_warehouse_codes");
				
				oprot.WriteSetBegin();
				foreach(string _item0 in structs.GetDelivery_warehouse_codes()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder_types() != null) {
				
				oprot.WriteFieldBegin("order_types");
				
				oprot.WriteSetBegin();
				foreach(int _item0 in structs.GetOrder_types()){
					
					oprot.WriteI32((int)_item0); 
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_forbidden_delivery() != null) {
				
				oprot.WriteFieldBegin("is_forbidden_delivery");
				oprot.WriteI32((int)structs.GetIs_forbidden_delivery()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetOrdersRequest bean){
			
			
		}
		
	}
	
}