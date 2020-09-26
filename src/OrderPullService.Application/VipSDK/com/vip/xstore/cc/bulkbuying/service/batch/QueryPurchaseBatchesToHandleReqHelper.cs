using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service.batch{
	
	
	
	public class QueryPurchaseBatchesToHandleReqHelper : TBeanSerializer<QueryPurchaseBatchesToHandleReq>
	{
		
		public static QueryPurchaseBatchesToHandleReqHelper OBJ = new QueryPurchaseBatchesToHandleReqHelper();
		
		public static QueryPurchaseBatchesToHandleReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryPurchaseBatchesToHandleReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("createTimeBegin".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTimeBegin(value);
					}
					
					
					
					
					
					if ("createTimeEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTimeEnd(value);
					}
					
					
					
					
					
					if ("limt".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetLimt(value);
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
		
		
		public void Write(QueryPurchaseBatchesToHandleReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCreateTimeBegin() != null) {
				
				oprot.WriteFieldBegin("createTimeBegin");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTimeBegin())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTimeEnd() != null) {
				
				oprot.WriteFieldBegin("createTimeEnd");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTimeEnd())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLimt() != null) {
				
				oprot.WriteFieldBegin("limt");
				oprot.WriteI32((int)structs.GetLimt()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryPurchaseBatchesToHandleReq bean){
			
			
		}
		
	}
	
}