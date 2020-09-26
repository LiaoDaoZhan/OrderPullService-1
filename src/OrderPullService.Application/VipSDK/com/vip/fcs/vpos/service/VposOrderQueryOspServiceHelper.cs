using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.fcs.vpos.service{
	
	
	public class VposOrderQueryOspServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryOrderSummaryByStoreCode_args {
			
			///<summary>
			/// 订单查询请求对象
			///</summary>
			
			private com.vip.fcs.vpos.service.OrderQueryRequest queryRequest_;
			
			public com.vip.fcs.vpos.service.OrderQueryRequest GetQueryRequest(){
				return this.queryRequest_;
			}
			
			public void SetQueryRequest(com.vip.fcs.vpos.service.OrderQueryRequest value){
				this.queryRequest_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.hermes.core.health.CheckResult success_;
			
			public com.vip.hermes.core.health.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.hermes.core.health.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryOrderSummaryByStoreCode_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.vpos.service.OrderQueryResponse success_;
			
			public com.vip.fcs.vpos.service.OrderQueryResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.vpos.service.OrderQueryResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class healthCheck_argsHelper : TBeanSerializer<healthCheck_args>
		{
			
			public static healthCheck_argsHelper OBJ = new healthCheck_argsHelper();
			
			public static healthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryOrderSummaryByStoreCode_argsHelper : TBeanSerializer<queryOrderSummaryByStoreCode_args>
		{
			
			public static queryOrderSummaryByStoreCode_argsHelper OBJ = new queryOrderSummaryByStoreCode_argsHelper();
			
			public static queryOrderSummaryByStoreCode_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryOrderSummaryByStoreCode_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vpos.service.OrderQueryRequest value;
					
					value = new com.vip.fcs.vpos.service.OrderQueryRequest();
					com.vip.fcs.vpos.service.OrderQueryRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetQueryRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryOrderSummaryByStoreCode_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetQueryRequest() != null) {
					
					oprot.WriteFieldBegin("queryRequest");
					
					com.vip.fcs.vpos.service.OrderQueryRequestHelper.getInstance().Write(structs.GetQueryRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryOrderSummaryByStoreCode_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_resultHelper : TBeanSerializer<healthCheck_result>
		{
			
			public static healthCheck_resultHelper OBJ = new healthCheck_resultHelper();
			
			public static healthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.hermes.core.health.CheckResult value;
					
					value = new com.vip.hermes.core.health.CheckResult();
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryOrderSummaryByStoreCode_resultHelper : TBeanSerializer<queryOrderSummaryByStoreCode_result>
		{
			
			public static queryOrderSummaryByStoreCode_resultHelper OBJ = new queryOrderSummaryByStoreCode_resultHelper();
			
			public static queryOrderSummaryByStoreCode_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryOrderSummaryByStoreCode_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.vpos.service.OrderQueryResponse value;
					
					value = new com.vip.fcs.vpos.service.OrderQueryResponse();
					com.vip.fcs.vpos.service.OrderQueryResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryOrderSummaryByStoreCode_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.vpos.service.OrderQueryResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryOrderSummaryByStoreCode_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class VposOrderQueryOspServiceClient : OspRestStub , VposOrderQueryOspService  {
			
			
			public VposOrderQueryOspServiceClient():base("com.vip.fcs.vpos.service.VposOrderQueryOspService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.hermes.core.health.CheckResult healthCheck() {
				
				send_healthCheck();
				return recv_healthCheck(); 
				
			}
			
			
			private void send_healthCheck(){
				
				InitInvocation("healthCheck");
				
				healthCheck_args args = new healthCheck_args();
				
				SendBase(args, healthCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.hermes.core.health.CheckResult recv_healthCheck(){
				
				healthCheck_result result = new healthCheck_result();
				ReceiveBase(result, healthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.fcs.vpos.service.OrderQueryResponse queryOrderSummaryByStoreCode(com.vip.fcs.vpos.service.OrderQueryRequest queryRequest_) {
				
				send_queryOrderSummaryByStoreCode(queryRequest_);
				return recv_queryOrderSummaryByStoreCode(); 
				
			}
			
			
			private void send_queryOrderSummaryByStoreCode(com.vip.fcs.vpos.service.OrderQueryRequest queryRequest_){
				
				InitInvocation("queryOrderSummaryByStoreCode");
				
				queryOrderSummaryByStoreCode_args args = new queryOrderSummaryByStoreCode_args();
				args.SetQueryRequest(queryRequest_);
				
				SendBase(args, queryOrderSummaryByStoreCode_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.vpos.service.OrderQueryResponse recv_queryOrderSummaryByStoreCode(){
				
				queryOrderSummaryByStoreCode_result result = new queryOrderSummaryByStoreCode_result();
				ReceiveBase(result, queryOrderSummaryByStoreCode_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}