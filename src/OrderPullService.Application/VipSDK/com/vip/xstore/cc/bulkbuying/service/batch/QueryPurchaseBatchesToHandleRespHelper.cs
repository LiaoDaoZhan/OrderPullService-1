using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service.batch{
	
	
	
	public class QueryPurchaseBatchesToHandleRespHelper : TBeanSerializer<QueryPurchaseBatchesToHandleResp>
	{
		
		public static QueryPurchaseBatchesToHandleRespHelper OBJ = new QueryPurchaseBatchesToHandleRespHelper();
		
		public static QueryPurchaseBatchesToHandleRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryPurchaseBatchesToHandleResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("purchaseBatchList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.bulkbuying.service.batch.PurchaseBatchToHandle> value;
						
						value = new List<com.vip.xstore.cc.bulkbuying.service.batch.PurchaseBatchToHandle>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.bulkbuying.service.batch.PurchaseBatchToHandle elem0;
								
								elem0 = new com.vip.xstore.cc.bulkbuying.service.batch.PurchaseBatchToHandle();
								com.vip.xstore.cc.bulkbuying.service.batch.PurchaseBatchToHandleHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPurchaseBatchList(value);
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
		
		
		public void Write(QueryPurchaseBatchesToHandleResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPurchaseBatchList() != null) {
				
				oprot.WriteFieldBegin("purchaseBatchList");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.bulkbuying.service.batch.PurchaseBatchToHandle _item0 in structs.GetPurchaseBatchList()){
					
					
					com.vip.xstore.cc.bulkbuying.service.batch.PurchaseBatchToHandleHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryPurchaseBatchesToHandleResp bean){
			
			
		}
		
	}
	
}