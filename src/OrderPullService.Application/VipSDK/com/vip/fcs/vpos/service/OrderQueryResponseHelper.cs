using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vpos.service{
	
	
	
	public class OrderQueryResponseHelper : TBeanSerializer<OrderQueryResponse>
	{
		
		public static OrderQueryResponseHelper OBJ = new OrderQueryResponseHelper();
		
		public static OrderQueryResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderQueryResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("orderQueryRequest".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.fcs.vpos.service.OrderQueryRequest value;
						
						value = new com.vip.fcs.vpos.service.OrderQueryRequest();
						com.vip.fcs.vpos.service.OrderQueryRequestHelper.getInstance().Read(value, iprot);
						
						structs.SetOrderQueryRequest(value);
					}
					
					
					
					
					
					if ("orderQueryResult".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.fcs.vpos.service.VposOrderResultVO> value;
						
						value = new List<com.vip.fcs.vpos.service.VposOrderResultVO>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.fcs.vpos.service.VposOrderResultVO elem1;
								
								elem1 = new com.vip.fcs.vpos.service.VposOrderResultVO();
								com.vip.fcs.vpos.service.VposOrderResultVOHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrderQueryResult(value);
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
		
		
		public void Write(OrderQueryResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderQueryRequest() != null) {
				
				oprot.WriteFieldBegin("orderQueryRequest");
				
				com.vip.fcs.vpos.service.OrderQueryRequestHelper.getInstance().Write(structs.GetOrderQueryRequest(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderQueryResult() != null) {
				
				oprot.WriteFieldBegin("orderQueryResult");
				
				oprot.WriteListBegin();
				foreach(com.vip.fcs.vpos.service.VposOrderResultVO _item0 in structs.GetOrderQueryResult()){
					
					
					com.vip.fcs.vpos.service.VposOrderResultVOHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderQueryResponse bean){
			
			
		}
		
	}
	
}