using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying{
	
	
	
	public class QueryPoListByBizBatchNoReqHelper : TBeanSerializer<QueryPoListByBizBatchNoReq>
	{
		
		public static QueryPoListByBizBatchNoReqHelper OBJ = new QueryPoListByBizBatchNoReqHelper();
		
		public static QueryPoListByBizBatchNoReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryPoListByBizBatchNoReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("source".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSource(value);
					}
					
					
					
					
					
					if ("bizBatchNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizBatchNo(value);
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
		
		
		public void Write(QueryPoListByBizBatchNoReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSource() != null) {
				
				oprot.WriteFieldBegin("source");
				oprot.WriteString(structs.GetSource());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("source can not be null!");
			}
			
			
			if(structs.GetBizBatchNo() != null) {
				
				oprot.WriteFieldBegin("bizBatchNo");
				oprot.WriteString(structs.GetBizBatchNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bizBatchNo can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryPoListByBizBatchNoReq bean){
			
			
		}
		
	}
	
}