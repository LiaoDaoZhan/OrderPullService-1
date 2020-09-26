using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class QueryGoodsRequestHelper : TBeanSerializer<QueryGoodsRequest>
	{
		
		public static QueryGoodsRequestHelper OBJ = new QueryGoodsRequestHelper();
		
		public static QueryGoodsRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryGoodsRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("keyword".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetKeyword(value);
					}
					
					
					
					
					
					if ("fieldName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFieldName(value);
					}
					
					
					
					
					
					if ("order".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrder(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
					}
					
					
					
					
					
					if ("requestId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRequestId(value);
					}
					
					
					
					
					
					if ("priceStart".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPriceStart(value);
					}
					
					
					
					
					
					if ("priceEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPriceEnd(value);
					}
					
					
					
					
					
					if ("queryReputation".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetQueryReputation(value);
					}
					
					
					
					
					
					if ("queryStoreServiceCapability".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetQueryStoreServiceCapability(value);
					}
					
					
					
					
					
					if ("queryStock".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetQueryStock(value);
					}
					
					
					
					
					
					if ("queryActivity".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetQueryActivity(value);
					}
					
					
					
					
					
					if ("queryPrepay".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetQueryPrepay(value);
					}
					
					
					
					
					
					if ("commonParams".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.adp.api.open.service.CommonParams value;
						
						value = new com.vip.adp.api.open.service.CommonParams();
						com.vip.adp.api.open.service.CommonParamsHelper.getInstance().Read(value, iprot);
						
						structs.SetCommonParams(value);
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
		
		
		public void Write(QueryGoodsRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetKeyword() != null) {
				
				oprot.WriteFieldBegin("keyword");
				oprot.WriteString(structs.GetKeyword());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("keyword can not be null!");
			}
			
			
			if(structs.GetFieldName() != null) {
				
				oprot.WriteFieldBegin("fieldName");
				oprot.WriteString(structs.GetFieldName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder() != null) {
				
				oprot.WriteFieldBegin("order");
				oprot.WriteI32((int)structs.GetOrder()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("page can not be null!");
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRequestId() != null) {
				
				oprot.WriteFieldBegin("requestId");
				oprot.WriteString(structs.GetRequestId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("requestId can not be null!");
			}
			
			
			if(structs.GetPriceStart() != null) {
				
				oprot.WriteFieldBegin("priceStart");
				oprot.WriteString(structs.GetPriceStart());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPriceEnd() != null) {
				
				oprot.WriteFieldBegin("priceEnd");
				oprot.WriteString(structs.GetPriceEnd());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQueryReputation() != null) {
				
				oprot.WriteFieldBegin("queryReputation");
				oprot.WriteBool((bool)structs.GetQueryReputation());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQueryStoreServiceCapability() != null) {
				
				oprot.WriteFieldBegin("queryStoreServiceCapability");
				oprot.WriteBool((bool)structs.GetQueryStoreServiceCapability());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQueryStock() != null) {
				
				oprot.WriteFieldBegin("queryStock");
				oprot.WriteBool((bool)structs.GetQueryStock());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQueryActivity() != null) {
				
				oprot.WriteFieldBegin("queryActivity");
				oprot.WriteBool((bool)structs.GetQueryActivity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQueryPrepay() != null) {
				
				oprot.WriteFieldBegin("queryPrepay");
				oprot.WriteBool((bool)structs.GetQueryPrepay());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommonParams() != null) {
				
				oprot.WriteFieldBegin("commonParams");
				
				com.vip.adp.api.open.service.CommonParamsHelper.getInstance().Write(structs.GetCommonParams(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryGoodsRequest bean){
			
			
		}
		
	}
	
}