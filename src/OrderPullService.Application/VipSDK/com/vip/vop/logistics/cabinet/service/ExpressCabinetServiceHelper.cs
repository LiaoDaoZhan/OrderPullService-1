using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.logistics.cabinet.service{
	
	
	public class ExpressCabinetServiceHelper {
		
		
		
		public class getShippingByLogisticsNos_args {
			
			///<summary>
			/// 获取运单信息请求
			///</summary>
			
			private com.vip.vop.logistics.cabinet.GetShippingReq shippingReq_;
			
			public com.vip.vop.logistics.cabinet.GetShippingReq GetShippingReq(){
				return this.shippingReq_;
			}
			
			public void SetShippingReq(com.vip.vop.logistics.cabinet.GetShippingReq value){
				this.shippingReq_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class reportLockerAction_args {
			
			///<summary>
			/// 承运商编码（唯品会）
			///</summary>
			
			private string carrier_code_;
			
			///<summary>
			/// 快递柜日志信息 （最大20）
			///</summary>
			
			private List<com.vip.vop.logistics.cabinet.LockerAction> locker_actions_;
			
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			public List<com.vip.vop.logistics.cabinet.LockerAction> GetLocker_actions(){
				return this.locker_actions_;
			}
			
			public void SetLocker_actions(List<com.vip.vop.logistics.cabinet.LockerAction> value){
				this.locker_actions_ = value;
			}
			
		}
		
		
		
		
		public class reportTraces_args {
			
			///<summary>
			/// 快递柜运单轨迹请求
			///</summary>
			
			private com.vip.vop.logistics.cabinet.ExpressCabinetTraceReq traceReq_;
			
			public com.vip.vop.logistics.cabinet.ExpressCabinetTraceReq GetTraceReq(){
				return this.traceReq_;
			}
			
			public void SetTraceReq(com.vip.vop.logistics.cabinet.ExpressCabinetTraceReq value){
				this.traceReq_ = value;
			}
			
		}
		
		
		
		
		public class getShippingByLogisticsNos_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.logistics.cabinet.GetShippingResp success_;
			
			public com.vip.vop.logistics.cabinet.GetShippingResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.logistics.cabinet.GetShippingResp value){
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
		
		
		
		
		public class reportLockerAction_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.logistics.cabinet.LockerActionResult> success_;
			
			public List<com.vip.vop.logistics.cabinet.LockerActionResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.logistics.cabinet.LockerActionResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class reportTraces_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.logistics.cabinet.ShipmentTraceResp success_;
			
			public com.vip.vop.logistics.cabinet.ShipmentTraceResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.logistics.cabinet.ShipmentTraceResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class getShippingByLogisticsNos_argsHelper : TBeanSerializer<getShippingByLogisticsNos_args>
		{
			
			public static getShippingByLogisticsNos_argsHelper OBJ = new getShippingByLogisticsNos_argsHelper();
			
			public static getShippingByLogisticsNos_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getShippingByLogisticsNos_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.cabinet.GetShippingReq value;
					
					value = new com.vip.vop.logistics.cabinet.GetShippingReq();
					com.vip.vop.logistics.cabinet.GetShippingReqHelper.getInstance().Read(value, iprot);
					
					structs.SetShippingReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getShippingByLogisticsNos_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetShippingReq() != null) {
					
					oprot.WriteFieldBegin("shippingReq");
					
					com.vip.vop.logistics.cabinet.GetShippingReqHelper.getInstance().Write(structs.GetShippingReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("shippingReq can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getShippingByLogisticsNos_args bean){
				
				
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
		
		
		
		
		public class reportLockerAction_argsHelper : TBeanSerializer<reportLockerAction_args>
		{
			
			public static reportLockerAction_argsHelper OBJ = new reportLockerAction_argsHelper();
			
			public static reportLockerAction_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportLockerAction_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.cabinet.LockerAction> value;
					
					value = new List<com.vip.vop.logistics.cabinet.LockerAction>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.cabinet.LockerAction elem0;
							
							elem0 = new com.vip.vop.logistics.cabinet.LockerAction();
							com.vip.vop.logistics.cabinet.LockerActionHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetLocker_actions(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportLockerAction_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("carrier_code can not be null!");
				}
				
				
				if(structs.GetLocker_actions() != null) {
					
					oprot.WriteFieldBegin("locker_actions");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.cabinet.LockerAction _item0 in structs.GetLocker_actions()){
						
						
						com.vip.vop.logistics.cabinet.LockerActionHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("locker_actions can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportLockerAction_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class reportTraces_argsHelper : TBeanSerializer<reportTraces_args>
		{
			
			public static reportTraces_argsHelper OBJ = new reportTraces_argsHelper();
			
			public static reportTraces_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportTraces_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.cabinet.ExpressCabinetTraceReq value;
					
					value = new com.vip.vop.logistics.cabinet.ExpressCabinetTraceReq();
					com.vip.vop.logistics.cabinet.ExpressCabinetTraceReqHelper.getInstance().Read(value, iprot);
					
					structs.SetTraceReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportTraces_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetTraceReq() != null) {
					
					oprot.WriteFieldBegin("traceReq");
					
					com.vip.vop.logistics.cabinet.ExpressCabinetTraceReqHelper.getInstance().Write(structs.GetTraceReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("traceReq can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportTraces_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getShippingByLogisticsNos_resultHelper : TBeanSerializer<getShippingByLogisticsNos_result>
		{
			
			public static getShippingByLogisticsNos_resultHelper OBJ = new getShippingByLogisticsNos_resultHelper();
			
			public static getShippingByLogisticsNos_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getShippingByLogisticsNos_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.cabinet.GetShippingResp value;
					
					value = new com.vip.vop.logistics.cabinet.GetShippingResp();
					com.vip.vop.logistics.cabinet.GetShippingRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getShippingByLogisticsNos_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.logistics.cabinet.GetShippingRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getShippingByLogisticsNos_result bean){
				
				
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
		
		
		
		
		public class reportLockerAction_resultHelper : TBeanSerializer<reportLockerAction_result>
		{
			
			public static reportLockerAction_resultHelper OBJ = new reportLockerAction_resultHelper();
			
			public static reportLockerAction_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportLockerAction_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.cabinet.LockerActionResult> value;
					
					value = new List<com.vip.vop.logistics.cabinet.LockerActionResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.cabinet.LockerActionResult elem0;
							
							elem0 = new com.vip.vop.logistics.cabinet.LockerActionResult();
							com.vip.vop.logistics.cabinet.LockerActionResultHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportLockerAction_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.cabinet.LockerActionResult _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.logistics.cabinet.LockerActionResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportLockerAction_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class reportTraces_resultHelper : TBeanSerializer<reportTraces_result>
		{
			
			public static reportTraces_resultHelper OBJ = new reportTraces_resultHelper();
			
			public static reportTraces_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportTraces_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.cabinet.ShipmentTraceResp value;
					
					value = new com.vip.vop.logistics.cabinet.ShipmentTraceResp();
					com.vip.vop.logistics.cabinet.ShipmentTraceRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportTraces_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.logistics.cabinet.ShipmentTraceRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportTraces_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class ExpressCabinetServiceClient : OspRestStub , ExpressCabinetService  {
			
			
			public ExpressCabinetServiceClient():base("com.vip.vop.logistics.cabinet.service.ExpressCabinetService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.vop.logistics.cabinet.GetShippingResp getShippingByLogisticsNos(com.vip.vop.logistics.cabinet.GetShippingReq shippingReq_) {
				
				send_getShippingByLogisticsNos(shippingReq_);
				return recv_getShippingByLogisticsNos(); 
				
			}
			
			
			private void send_getShippingByLogisticsNos(com.vip.vop.logistics.cabinet.GetShippingReq shippingReq_){
				
				InitInvocation("getShippingByLogisticsNos");
				
				getShippingByLogisticsNos_args args = new getShippingByLogisticsNos_args();
				args.SetShippingReq(shippingReq_);
				
				SendBase(args, getShippingByLogisticsNos_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.logistics.cabinet.GetShippingResp recv_getShippingByLogisticsNos(){
				
				getShippingByLogisticsNos_result result = new getShippingByLogisticsNos_result();
				ReceiveBase(result, getShippingByLogisticsNos_resultHelper.getInstance());
				
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
			
			
			public List<com.vip.vop.logistics.cabinet.LockerActionResult> reportLockerAction(string carrier_code_,List<com.vip.vop.logistics.cabinet.LockerAction> locker_actions_) {
				
				send_reportLockerAction(carrier_code_,locker_actions_);
				return recv_reportLockerAction(); 
				
			}
			
			
			private void send_reportLockerAction(string carrier_code_,List<com.vip.vop.logistics.cabinet.LockerAction> locker_actions_){
				
				InitInvocation("reportLockerAction");
				
				reportLockerAction_args args = new reportLockerAction_args();
				args.SetCarrier_code(carrier_code_);
				args.SetLocker_actions(locker_actions_);
				
				SendBase(args, reportLockerAction_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.logistics.cabinet.LockerActionResult> recv_reportLockerAction(){
				
				reportLockerAction_result result = new reportLockerAction_result();
				ReceiveBase(result, reportLockerAction_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.logistics.cabinet.ShipmentTraceResp reportTraces(com.vip.vop.logistics.cabinet.ExpressCabinetTraceReq traceReq_) {
				
				send_reportTraces(traceReq_);
				return recv_reportTraces(); 
				
			}
			
			
			private void send_reportTraces(com.vip.vop.logistics.cabinet.ExpressCabinetTraceReq traceReq_){
				
				InitInvocation("reportTraces");
				
				reportTraces_args args = new reportTraces_args();
				args.SetTraceReq(traceReq_);
				
				SendBase(args, reportTraces_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.logistics.cabinet.ShipmentTraceResp recv_reportTraces(){
				
				reportTraces_result result = new reportTraces_result();
				ReceiveBase(result, reportTraces_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}