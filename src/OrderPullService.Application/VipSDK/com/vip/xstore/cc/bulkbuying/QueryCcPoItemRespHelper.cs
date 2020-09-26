using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying{
	
	
	
	public class QueryCcPoItemRespHelper : TBeanSerializer<QueryCcPoItemResp>
	{
		
		public static QueryCcPoItemRespHelper OBJ = new QueryCcPoItemRespHelper();
		
		public static QueryCcPoItemRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryCcPoItemResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.bulkbuying.CcPoItem> value;
						
						value = new List<com.vip.xstore.cc.bulkbuying.CcPoItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.bulkbuying.CcPoItem elem0;
								
								elem0 = new com.vip.xstore.cc.bulkbuying.CcPoItem();
								com.vip.xstore.cc.bulkbuying.CcPoItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItems(value);
					}
					
					
					
					
					
					if ("hasNext".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetHasNext(value);
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
		
		
		public void Write(QueryCcPoItemResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetItems() != null) {
				
				oprot.WriteFieldBegin("items");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.bulkbuying.CcPoItem _item0 in structs.GetItems()){
					
					
					com.vip.xstore.cc.bulkbuying.CcPoItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHasNext() != null) {
				
				oprot.WriteFieldBegin("hasNext");
				oprot.WriteBool((bool)structs.GetHasNext());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("hasNext can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryCcPoItemResp bean){
			
			
		}
		
	}
	
}