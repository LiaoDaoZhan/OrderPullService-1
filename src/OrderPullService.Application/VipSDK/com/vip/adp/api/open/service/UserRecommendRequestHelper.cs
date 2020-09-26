using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class UserRecommendRequestHelper : TBeanSerializer<UserRecommendRequest>
	{
		
		public static UserRecommendRequestHelper OBJ = new UserRecommendRequestHelper();
		
		public static UserRecommendRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UserRecommendRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
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
					
					
					
					
					
					if ("inStock".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetInStock(value);
					}
					
					
					
					
					
					if ("goodsSaleStats".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetGoodsSaleStats(value);
					}
					
					
					
					
					
					if ("offlineStore".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOfflineStore(value);
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
		
		
		public void Write(UserRecommendRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
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
			
			
			if(structs.GetInStock() != null) {
				
				oprot.WriteFieldBegin("inStock");
				oprot.WriteI32((int)structs.GetInStock()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsSaleStats() != null) {
				
				oprot.WriteFieldBegin("goodsSaleStats");
				oprot.WriteI32((int)structs.GetGoodsSaleStats()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOfflineStore() != null) {
				
				oprot.WriteFieldBegin("offlineStore");
				oprot.WriteI32((int)structs.GetOfflineStore()); 
				
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
		
		
		public void Validate(UserRecommendRequest bean){
			
			
		}
		
	}
	
}