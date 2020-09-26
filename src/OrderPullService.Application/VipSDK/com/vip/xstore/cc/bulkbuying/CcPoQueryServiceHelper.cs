using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.xstore.cc.bulkbuying{
	
	
	public class CcPoQueryServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryCcPo_args {
			
			///<summary>
			/// 采购单号
			///</summary>
			
			private string purchaseNo_;
			
			public string GetPurchaseNo(){
				return this.purchaseNo_;
			}
			
			public void SetPurchaseNo(string value){
				this.purchaseNo_ = value;
			}
			
		}
		
		
		
		
		public class queryCcPoItem_args {
			
			///<summary>
			/// 查询采购单明细
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.QueryCcPoItemReq req_;
			
			public com.vip.xstore.cc.bulkbuying.QueryCcPoItemReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.bulkbuying.QueryCcPoItemReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class queryCcPos_args {
			
			///<summary>
			/// 采购单号
			///</summary>
			
			private List<string> purchaseNos_;
			
			public List<string> GetPurchaseNos(){
				return this.purchaseNos_;
			}
			
			public void SetPurchaseNos(List<string> value){
				this.purchaseNos_ = value;
			}
			
		}
		
		
		
		
		public class queryPoListByBizBatchNo_args {
			
			///<summary>
			/// 根据业务批次号查询采购单列表请求
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.QueryPoListByBizBatchNoReq req_;
			
			public com.vip.xstore.cc.bulkbuying.QueryPoListByBizBatchNoReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.bulkbuying.QueryPoListByBizBatchNoReq value){
				this.req_ = value;
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
		
		
		
		
		public class queryCcPo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.CcPo success_;
			
			public com.vip.xstore.cc.bulkbuying.CcPo GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.CcPo value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryCcPoItem_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.QueryCcPoItemResp success_;
			
			public com.vip.xstore.cc.bulkbuying.QueryCcPoItemResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.QueryCcPoItemResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryCcPos_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.bulkbuying.CcPo> success_;
			
			public List<com.vip.xstore.cc.bulkbuying.CcPo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.bulkbuying.CcPo> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryPoListByBizBatchNo_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.bulkbuying.CcPo> success_;
			
			public List<com.vip.xstore.cc.bulkbuying.CcPo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.bulkbuying.CcPo> value){
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
		
		
		
		
		public class queryCcPo_argsHelper : TBeanSerializer<queryCcPo_args>
		{
			
			public static queryCcPo_argsHelper OBJ = new queryCcPo_argsHelper();
			
			public static queryCcPo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCcPo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPurchaseNo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryCcPo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPurchaseNo() != null) {
					
					oprot.WriteFieldBegin("purchaseNo");
					oprot.WriteString(structs.GetPurchaseNo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("purchaseNo can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCcPo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryCcPoItem_argsHelper : TBeanSerializer<queryCcPoItem_args>
		{
			
			public static queryCcPoItem_argsHelper OBJ = new queryCcPoItem_argsHelper();
			
			public static queryCcPoItem_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCcPoItem_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.QueryCcPoItemReq value;
					
					value = new com.vip.xstore.cc.bulkbuying.QueryCcPoItemReq();
					com.vip.xstore.cc.bulkbuying.QueryCcPoItemReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryCcPoItem_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.bulkbuying.QueryCcPoItemReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCcPoItem_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryCcPos_argsHelper : TBeanSerializer<queryCcPos_args>
		{
			
			public static queryCcPos_argsHelper OBJ = new queryCcPos_argsHelper();
			
			public static queryCcPos_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCcPos_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadSetBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadSetEnd();
					
					structs.SetPurchaseNos(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryCcPos_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPurchaseNos() != null) {
					
					oprot.WriteFieldBegin("purchaseNos");
					
					oprot.WriteSetBegin();
					foreach(string _item0 in structs.GetPurchaseNos()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteSetEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("purchaseNos can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCcPos_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPoListByBizBatchNo_argsHelper : TBeanSerializer<queryPoListByBizBatchNo_args>
		{
			
			public static queryPoListByBizBatchNo_argsHelper OBJ = new queryPoListByBizBatchNo_argsHelper();
			
			public static queryPoListByBizBatchNo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPoListByBizBatchNo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.QueryPoListByBizBatchNoReq value;
					
					value = new com.vip.xstore.cc.bulkbuying.QueryPoListByBizBatchNoReq();
					com.vip.xstore.cc.bulkbuying.QueryPoListByBizBatchNoReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPoListByBizBatchNo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.bulkbuying.QueryPoListByBizBatchNoReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPoListByBizBatchNo_args bean){
				
				
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
		
		
		
		
		public class queryCcPo_resultHelper : TBeanSerializer<queryCcPo_result>
		{
			
			public static queryCcPo_resultHelper OBJ = new queryCcPo_resultHelper();
			
			public static queryCcPo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCcPo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.CcPo value;
					
					value = new com.vip.xstore.cc.bulkbuying.CcPo();
					com.vip.xstore.cc.bulkbuying.CcPoHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryCcPo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.CcPoHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCcPo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryCcPoItem_resultHelper : TBeanSerializer<queryCcPoItem_result>
		{
			
			public static queryCcPoItem_resultHelper OBJ = new queryCcPoItem_resultHelper();
			
			public static queryCcPoItem_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCcPoItem_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.QueryCcPoItemResp value;
					
					value = new com.vip.xstore.cc.bulkbuying.QueryCcPoItemResp();
					com.vip.xstore.cc.bulkbuying.QueryCcPoItemRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryCcPoItem_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.QueryCcPoItemRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCcPoItem_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryCcPos_resultHelper : TBeanSerializer<queryCcPos_result>
		{
			
			public static queryCcPos_resultHelper OBJ = new queryCcPos_resultHelper();
			
			public static queryCcPos_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCcPos_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.bulkbuying.CcPo> value;
					
					value = new List<com.vip.xstore.cc.bulkbuying.CcPo>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.bulkbuying.CcPo elem0;
							
							elem0 = new com.vip.xstore.cc.bulkbuying.CcPo();
							com.vip.xstore.cc.bulkbuying.CcPoHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(queryCcPos_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.bulkbuying.CcPo _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.bulkbuying.CcPoHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCcPos_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPoListByBizBatchNo_resultHelper : TBeanSerializer<queryPoListByBizBatchNo_result>
		{
			
			public static queryPoListByBizBatchNo_resultHelper OBJ = new queryPoListByBizBatchNo_resultHelper();
			
			public static queryPoListByBizBatchNo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPoListByBizBatchNo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.bulkbuying.CcPo> value;
					
					value = new List<com.vip.xstore.cc.bulkbuying.CcPo>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.bulkbuying.CcPo elem1;
							
							elem1 = new com.vip.xstore.cc.bulkbuying.CcPo();
							com.vip.xstore.cc.bulkbuying.CcPoHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
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
			
			
			public void Write(queryPoListByBizBatchNo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.bulkbuying.CcPo _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.bulkbuying.CcPoHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPoListByBizBatchNo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class CcPoQueryServiceClient : OspRestStub , CcPoQueryService  {
			
			
			public CcPoQueryServiceClient():base("com.vip.xstore.cc.bulkbuying.CcPoQueryService","1.0.0") {
				
				
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
			
			
			public com.vip.xstore.cc.bulkbuying.CcPo queryCcPo(string purchaseNo_) {
				
				send_queryCcPo(purchaseNo_);
				return recv_queryCcPo(); 
				
			}
			
			
			private void send_queryCcPo(string purchaseNo_){
				
				InitInvocation("queryCcPo");
				
				queryCcPo_args args = new queryCcPo_args();
				args.SetPurchaseNo(purchaseNo_);
				
				SendBase(args, queryCcPo_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.CcPo recv_queryCcPo(){
				
				queryCcPo_result result = new queryCcPo_result();
				ReceiveBase(result, queryCcPo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.bulkbuying.QueryCcPoItemResp queryCcPoItem(com.vip.xstore.cc.bulkbuying.QueryCcPoItemReq req_) {
				
				send_queryCcPoItem(req_);
				return recv_queryCcPoItem(); 
				
			}
			
			
			private void send_queryCcPoItem(com.vip.xstore.cc.bulkbuying.QueryCcPoItemReq req_){
				
				InitInvocation("queryCcPoItem");
				
				queryCcPoItem_args args = new queryCcPoItem_args();
				args.SetReq(req_);
				
				SendBase(args, queryCcPoItem_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.QueryCcPoItemResp recv_queryCcPoItem(){
				
				queryCcPoItem_result result = new queryCcPoItem_result();
				ReceiveBase(result, queryCcPoItem_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.xstore.cc.bulkbuying.CcPo> queryCcPos(List<string> purchaseNos_) {
				
				send_queryCcPos(purchaseNos_);
				return recv_queryCcPos(); 
				
			}
			
			
			private void send_queryCcPos(List<string> purchaseNos_){
				
				InitInvocation("queryCcPos");
				
				queryCcPos_args args = new queryCcPos_args();
				args.SetPurchaseNos(purchaseNos_);
				
				SendBase(args, queryCcPos_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.bulkbuying.CcPo> recv_queryCcPos(){
				
				queryCcPos_result result = new queryCcPos_result();
				ReceiveBase(result, queryCcPos_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.xstore.cc.bulkbuying.CcPo> queryPoListByBizBatchNo(com.vip.xstore.cc.bulkbuying.QueryPoListByBizBatchNoReq req_) {
				
				send_queryPoListByBizBatchNo(req_);
				return recv_queryPoListByBizBatchNo(); 
				
			}
			
			
			private void send_queryPoListByBizBatchNo(com.vip.xstore.cc.bulkbuying.QueryPoListByBizBatchNoReq req_){
				
				InitInvocation("queryPoListByBizBatchNo");
				
				queryPoListByBizBatchNo_args args = new queryPoListByBizBatchNo_args();
				args.SetReq(req_);
				
				SendBase(args, queryPoListByBizBatchNo_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.bulkbuying.CcPo> recv_queryPoListByBizBatchNo(){
				
				queryPoListByBizBatchNo_result result = new queryPoListByBizBatchNo_result();
				ReceiveBase(result, queryPoListByBizBatchNo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}