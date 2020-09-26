using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class SimilarRecommendRequestHelper : TBeanSerializer<SimilarRecommendRequest>
	{
		
		public static SimilarRecommendRequestHelper OBJ = new SimilarRecommendRequestHelper();
		
		public static SimilarRecommendRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SimilarRecommendRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("goodsId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsId(value);
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
					
					
					
					
					
					if ("commonParams".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.adp.api.open.service.CommonParams value;
						
						value = new com.vip.adp.api.open.service.CommonParams();
						com.vip.adp.api.open.service.CommonParamsHelper.getInstance().Read(value, iprot);
						
						structs.SetCommonParams(value);
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
		
		
		public void Write(SimilarRecommendRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGoodsId() != null) {
				
				oprot.WriteFieldBegin("goodsId");
				oprot.WriteString(structs.GetGoodsId());
				
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
			
			
			if(structs.GetCommonParams() != null) {
				
				oprot.WriteFieldBegin("commonParams");
				
				com.vip.adp.api.open.service.CommonParamsHelper.getInstance().Write(structs.GetCommonParams(), oprot);
				
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
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SimilarRecommendRequest bean){
			
			
		}
		
	}
	
}