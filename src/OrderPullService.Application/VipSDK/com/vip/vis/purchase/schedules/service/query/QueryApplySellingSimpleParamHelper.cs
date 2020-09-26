using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	public class QueryApplySellingSimpleParamHelper : TBeanSerializer<QueryApplySellingSimpleParam>
	{
		
		public static QueryApplySellingSimpleParamHelper OBJ = new QueryApplySellingSimpleParamHelper();
		
		public static QueryApplySellingSimpleParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryApplySellingSimpleParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("brandIdList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<long?> value;
						
						value = new List<long?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								long elem0;
								elem0 = iprot.ReadI64(); 
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetBrandIdList(value);
					}
					
					
					
					
					
					if ("shopCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetShopCode(value);
					}
					
					
					
					
					
					if ("warehouseCodeList".Equals(schemeField.Trim())){
						
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
						
						structs.SetWarehouseCodeList(value);
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
		
		
		public void Write(QueryApplySellingSimpleParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBrandIdList() != null) {
				
				oprot.WriteFieldBegin("brandIdList");
				
				oprot.WriteListBegin();
				foreach(long _item0 in structs.GetBrandIdList()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShopCode() != null) {
				
				oprot.WriteFieldBegin("shopCode");
				oprot.WriteI64((long)structs.GetShopCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouseCodeList() != null) {
				
				oprot.WriteFieldBegin("warehouseCodeList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetWarehouseCodeList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryApplySellingSimpleParam bean){
			
			
		}
		
	}
	
}