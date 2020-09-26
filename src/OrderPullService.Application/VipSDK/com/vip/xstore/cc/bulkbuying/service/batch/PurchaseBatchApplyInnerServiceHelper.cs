using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.xstore.cc.bulkbuying.service.batch{
	
	
	public class PurchaseBatchApplyInnerServiceHelper {
		
		
		
		public class createPurchaseOrdersByApply_args {
			
			///<summary>
			/// 创建采购单请求
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyReq req_;
			
			public com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryPurchaseBatchesToHandle_args {
			
			///<summary>
			/// 查询待处理的采购批次列表请求
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleReq req_;
			
			public com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class createPurchaseOrdersByApply_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyResp success_;
			
			public com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyResp value){
				this.success_ = value;
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
		
		
		
		
		public class queryPurchaseBatchesToHandle_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleResp success_;
			
			public com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class createPurchaseOrdersByApply_argsHelper : TBeanSerializer<createPurchaseOrdersByApply_args>
		{
			
			public static createPurchaseOrdersByApply_argsHelper OBJ = new createPurchaseOrdersByApply_argsHelper();
			
			public static createPurchaseOrdersByApply_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createPurchaseOrdersByApply_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyReq value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyReq();
					com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createPurchaseOrdersByApply_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createPurchaseOrdersByApply_args bean){
				
				
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
		
		
		
		
		public class queryPurchaseBatchesToHandle_argsHelper : TBeanSerializer<queryPurchaseBatchesToHandle_args>
		{
			
			public static queryPurchaseBatchesToHandle_argsHelper OBJ = new queryPurchaseBatchesToHandle_argsHelper();
			
			public static queryPurchaseBatchesToHandle_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPurchaseBatchesToHandle_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleReq value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleReq();
					com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPurchaseBatchesToHandle_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPurchaseBatchesToHandle_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createPurchaseOrdersByApply_resultHelper : TBeanSerializer<createPurchaseOrdersByApply_result>
		{
			
			public static createPurchaseOrdersByApply_resultHelper OBJ = new createPurchaseOrdersByApply_resultHelper();
			
			public static createPurchaseOrdersByApply_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createPurchaseOrdersByApply_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyResp value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyResp();
					com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createPurchaseOrdersByApply_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createPurchaseOrdersByApply_result bean){
				
				
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
		
		
		
		
		public class queryPurchaseBatchesToHandle_resultHelper : TBeanSerializer<queryPurchaseBatchesToHandle_result>
		{
			
			public static queryPurchaseBatchesToHandle_resultHelper OBJ = new queryPurchaseBatchesToHandle_resultHelper();
			
			public static queryPurchaseBatchesToHandle_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPurchaseBatchesToHandle_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleResp value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleResp();
					com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPurchaseBatchesToHandle_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPurchaseBatchesToHandle_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class PurchaseBatchApplyInnerServiceClient : OspRestStub , PurchaseBatchApplyInnerService  {
			
			
			public PurchaseBatchApplyInnerServiceClient():base("com.vip.xstore.cc.bulkbuying.service.batch.PurchaseBatchApplyInnerService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyResp createPurchaseOrdersByApply(com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyReq req_) {
				
				send_createPurchaseOrdersByApply(req_);
				return recv_createPurchaseOrdersByApply(); 
				
			}
			
			
			private void send_createPurchaseOrdersByApply(com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyReq req_){
				
				InitInvocation("createPurchaseOrdersByApply");
				
				createPurchaseOrdersByApply_args args = new createPurchaseOrdersByApply_args();
				args.SetReq(req_);
				
				SendBase(args, createPurchaseOrdersByApply_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.batch.CreatePurchaseOrdersByApplyResp recv_createPurchaseOrdersByApply(){
				
				createPurchaseOrdersByApply_result result = new createPurchaseOrdersByApply_result();
				ReceiveBase(result, createPurchaseOrdersByApply_resultHelper.getInstance());
				
				return result.GetSuccess();
				
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
			
			
			public com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleResp queryPurchaseBatchesToHandle(com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleReq req_) {
				
				send_queryPurchaseBatchesToHandle(req_);
				return recv_queryPurchaseBatchesToHandle(); 
				
			}
			
			
			private void send_queryPurchaseBatchesToHandle(com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleReq req_){
				
				InitInvocation("queryPurchaseBatchesToHandle");
				
				queryPurchaseBatchesToHandle_args args = new queryPurchaseBatchesToHandle_args();
				args.SetReq(req_);
				
				SendBase(args, queryPurchaseBatchesToHandle_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.batch.QueryPurchaseBatchesToHandleResp recv_queryPurchaseBatchesToHandle(){
				
				queryPurchaseBatchesToHandle_result result = new queryPurchaseBatchesToHandle_result();
				ReceiveBase(result, queryPurchaseBatchesToHandle_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}