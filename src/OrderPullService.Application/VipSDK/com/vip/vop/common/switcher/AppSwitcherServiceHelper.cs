using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.common.switcher{
	
	
	public class AppSwitcherServiceHelper {
		
		
		
		public class closeSwitcher_args {
			
			///<summary>
			/// 域名
			///</summary>
			
			private string domainName_;
			
			///<summary>
			/// 模块名
			///</summary>
			
			private string moduleName_;
			
			public string GetDomainName(){
				return this.domainName_;
			}
			
			public void SetDomainName(string value){
				this.domainName_ = value;
			}
			public string GetModuleName(){
				return this.moduleName_;
			}
			
			public void SetModuleName(string value){
				this.moduleName_ = value;
			}
			
		}
		
		
		
		
		public class createSwitcher_args {
			
			///<summary>
			/// 域名
			///</summary>
			
			private string domainName_;
			
			///<summary>
			/// 模块名
			///</summary>
			
			private string moduleName_;
			
			///<summary>
			/// 描述
			///</summary>
			
			private string remark_;
			
			public string GetDomainName(){
				return this.domainName_;
			}
			
			public void SetDomainName(string value){
				this.domainName_ = value;
			}
			public string GetModuleName(){
				return this.moduleName_;
			}
			
			public void SetModuleName(string value){
				this.moduleName_ = value;
			}
			public string GetRemark(){
				return this.remark_;
			}
			
			public void SetRemark(string value){
				this.remark_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class insertOrUpdate_args {
			
			///<summary>
			/// 应用模块开关
			///</summary>
			
			private com.vip.vop.common.switcher.AppSwitcherVo switcherVo_;
			
			public com.vip.vop.common.switcher.AppSwitcherVo GetSwitcherVo(){
				return this.switcherVo_;
			}
			
			public void SetSwitcherVo(com.vip.vop.common.switcher.AppSwitcherVo value){
				this.switcherVo_ = value;
			}
			
		}
		
		
		
		
		public class isOpenSwither_args {
			
			///<summary>
			/// 域名
			///</summary>
			
			private string domainName_;
			
			///<summary>
			/// 模块名
			///</summary>
			
			private string moduleName_;
			
			public string GetDomainName(){
				return this.domainName_;
			}
			
			public void SetDomainName(string value){
				this.domainName_ = value;
			}
			public string GetModuleName(){
				return this.moduleName_;
			}
			
			public void SetModuleName(string value){
				this.moduleName_ = value;
			}
			
		}
		
		
		
		
		public class listSwitcher_args {
			
			///<summary>
			/// 域名
			///</summary>
			
			private string domainName_;
			
			///<summary>
			/// 模块名
			///</summary>
			
			private string moduleName_;
			
			///<summary>
			/// 页码
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页记录数
			///</summary>
			
			private int? pageSize_;
			
			public string GetDomainName(){
				return this.domainName_;
			}
			
			public void SetDomainName(string value){
				this.domainName_ = value;
			}
			public string GetModuleName(){
				return this.moduleName_;
			}
			
			public void SetModuleName(string value){
				this.moduleName_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPageSize(){
				return this.pageSize_;
			}
			
			public void SetPageSize(int? value){
				this.pageSize_ = value;
			}
			
		}
		
		
		
		
		public class openSwitcher_args {
			
			///<summary>
			/// 域名
			///</summary>
			
			private string domainName_;
			
			///<summary>
			/// 模块名
			///</summary>
			
			private string moduleName_;
			
			public string GetDomainName(){
				return this.domainName_;
			}
			
			public void SetDomainName(string value){
				this.domainName_ = value;
			}
			public string GetModuleName(){
				return this.moduleName_;
			}
			
			public void SetModuleName(string value){
				this.moduleName_ = value;
			}
			
		}
		
		
		
		
		public class closeSwitcher_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class createSwitcher_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
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
		
		
		
		
		public class insertOrUpdate_result {
			
			
		}
		
		
		
		
		public class isOpenSwither_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class listSwitcher_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.common.switcher.ListSwitcherResponse success_;
			
			public com.vip.vop.common.switcher.ListSwitcherResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.common.switcher.ListSwitcherResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class openSwitcher_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class closeSwitcher_argsHelper : TBeanSerializer<closeSwitcher_args>
		{
			
			public static closeSwitcher_argsHelper OBJ = new closeSwitcher_argsHelper();
			
			public static closeSwitcher_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(closeSwitcher_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDomainName(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetModuleName(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(closeSwitcher_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetDomainName() != null) {
					
					oprot.WriteFieldBegin("domainName");
					oprot.WriteString(structs.GetDomainName());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("domainName can not be null!");
				}
				
				
				if(structs.GetModuleName() != null) {
					
					oprot.WriteFieldBegin("moduleName");
					oprot.WriteString(structs.GetModuleName());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("moduleName can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(closeSwitcher_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createSwitcher_argsHelper : TBeanSerializer<createSwitcher_args>
		{
			
			public static createSwitcher_argsHelper OBJ = new createSwitcher_argsHelper();
			
			public static createSwitcher_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createSwitcher_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDomainName(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetModuleName(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetRemark(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createSwitcher_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetDomainName() != null) {
					
					oprot.WriteFieldBegin("domainName");
					oprot.WriteString(structs.GetDomainName());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("domainName can not be null!");
				}
				
				
				if(structs.GetModuleName() != null) {
					
					oprot.WriteFieldBegin("moduleName");
					oprot.WriteString(structs.GetModuleName());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("moduleName can not be null!");
				}
				
				
				if(structs.GetRemark() != null) {
					
					oprot.WriteFieldBegin("remark");
					oprot.WriteString(structs.GetRemark());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createSwitcher_args bean){
				
				
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
		
		
		
		
		public class insertOrUpdate_argsHelper : TBeanSerializer<insertOrUpdate_args>
		{
			
			public static insertOrUpdate_argsHelper OBJ = new insertOrUpdate_argsHelper();
			
			public static insertOrUpdate_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(insertOrUpdate_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.common.switcher.AppSwitcherVo value;
					
					value = new com.vip.vop.common.switcher.AppSwitcherVo();
					com.vip.vop.common.switcher.AppSwitcherVoHelper.getInstance().Read(value, iprot);
					
					structs.SetSwitcherVo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(insertOrUpdate_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSwitcherVo() != null) {
					
					oprot.WriteFieldBegin("switcherVo");
					
					com.vip.vop.common.switcher.AppSwitcherVoHelper.getInstance().Write(structs.GetSwitcherVo(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("switcherVo can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(insertOrUpdate_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class isOpenSwither_argsHelper : TBeanSerializer<isOpenSwither_args>
		{
			
			public static isOpenSwither_argsHelper OBJ = new isOpenSwither_argsHelper();
			
			public static isOpenSwither_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(isOpenSwither_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDomainName(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetModuleName(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(isOpenSwither_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetDomainName() != null) {
					
					oprot.WriteFieldBegin("domainName");
					oprot.WriteString(structs.GetDomainName());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("domainName can not be null!");
				}
				
				
				if(structs.GetModuleName() != null) {
					
					oprot.WriteFieldBegin("moduleName");
					oprot.WriteString(structs.GetModuleName());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("moduleName can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(isOpenSwither_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listSwitcher_argsHelper : TBeanSerializer<listSwitcher_args>
		{
			
			public static listSwitcher_argsHelper OBJ = new listSwitcher_argsHelper();
			
			public static listSwitcher_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listSwitcher_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDomainName(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetModuleName(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPageSize(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listSwitcher_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetDomainName() != null) {
					
					oprot.WriteFieldBegin("domainName");
					oprot.WriteString(structs.GetDomainName());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetModuleName() != null) {
					
					oprot.WriteFieldBegin("moduleName");
					oprot.WriteString(structs.GetModuleName());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPageSize() != null) {
					
					oprot.WriteFieldBegin("pageSize");
					oprot.WriteI32((int)structs.GetPageSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listSwitcher_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class openSwitcher_argsHelper : TBeanSerializer<openSwitcher_args>
		{
			
			public static openSwitcher_argsHelper OBJ = new openSwitcher_argsHelper();
			
			public static openSwitcher_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(openSwitcher_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDomainName(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetModuleName(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(openSwitcher_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetDomainName() != null) {
					
					oprot.WriteFieldBegin("domainName");
					oprot.WriteString(structs.GetDomainName());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("domainName can not be null!");
				}
				
				
				if(structs.GetModuleName() != null) {
					
					oprot.WriteFieldBegin("moduleName");
					oprot.WriteString(structs.GetModuleName());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("moduleName can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(openSwitcher_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class closeSwitcher_resultHelper : TBeanSerializer<closeSwitcher_result>
		{
			
			public static closeSwitcher_resultHelper OBJ = new closeSwitcher_resultHelper();
			
			public static closeSwitcher_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(closeSwitcher_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(closeSwitcher_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(closeSwitcher_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createSwitcher_resultHelper : TBeanSerializer<createSwitcher_result>
		{
			
			public static createSwitcher_resultHelper OBJ = new createSwitcher_resultHelper();
			
			public static createSwitcher_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createSwitcher_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createSwitcher_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createSwitcher_result bean){
				
				
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
		
		
		
		
		public class insertOrUpdate_resultHelper : TBeanSerializer<insertOrUpdate_result>
		{
			
			public static insertOrUpdate_resultHelper OBJ = new insertOrUpdate_resultHelper();
			
			public static insertOrUpdate_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(insertOrUpdate_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(insertOrUpdate_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(insertOrUpdate_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class isOpenSwither_resultHelper : TBeanSerializer<isOpenSwither_result>
		{
			
			public static isOpenSwither_resultHelper OBJ = new isOpenSwither_resultHelper();
			
			public static isOpenSwither_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(isOpenSwither_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(isOpenSwither_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(isOpenSwither_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listSwitcher_resultHelper : TBeanSerializer<listSwitcher_result>
		{
			
			public static listSwitcher_resultHelper OBJ = new listSwitcher_resultHelper();
			
			public static listSwitcher_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listSwitcher_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.common.switcher.ListSwitcherResponse value;
					
					value = new com.vip.vop.common.switcher.ListSwitcherResponse();
					com.vip.vop.common.switcher.ListSwitcherResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listSwitcher_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.common.switcher.ListSwitcherResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listSwitcher_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class openSwitcher_resultHelper : TBeanSerializer<openSwitcher_result>
		{
			
			public static openSwitcher_resultHelper OBJ = new openSwitcher_resultHelper();
			
			public static openSwitcher_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(openSwitcher_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(openSwitcher_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(openSwitcher_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class AppSwitcherServiceClient : OspRestStub , AppSwitcherService  {
			
			
			public AppSwitcherServiceClient():base("com.vip.vop.common.switcher.AppSwitcherService","1.0.0") {
				
				
			}
			
			
			
			public bool? closeSwitcher(string domainName_,string moduleName_) {
				
				send_closeSwitcher(domainName_,moduleName_);
				return recv_closeSwitcher(); 
				
			}
			
			
			private void send_closeSwitcher(string domainName_,string moduleName_){
				
				InitInvocation("closeSwitcher");
				
				closeSwitcher_args args = new closeSwitcher_args();
				args.SetDomainName(domainName_);
				args.SetModuleName(moduleName_);
				
				SendBase(args, closeSwitcher_argsHelper.getInstance());
			}
			
			
			private bool? recv_closeSwitcher(){
				
				closeSwitcher_result result = new closeSwitcher_result();
				ReceiveBase(result, closeSwitcher_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? createSwitcher(string domainName_,string moduleName_,string remark_) {
				
				send_createSwitcher(domainName_,moduleName_,remark_);
				return recv_createSwitcher(); 
				
			}
			
			
			private void send_createSwitcher(string domainName_,string moduleName_,string remark_){
				
				InitInvocation("createSwitcher");
				
				createSwitcher_args args = new createSwitcher_args();
				args.SetDomainName(domainName_);
				args.SetModuleName(moduleName_);
				args.SetRemark(remark_);
				
				SendBase(args, createSwitcher_argsHelper.getInstance());
			}
			
			
			private bool? recv_createSwitcher(){
				
				createSwitcher_result result = new createSwitcher_result();
				ReceiveBase(result, createSwitcher_resultHelper.getInstance());
				
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
			
			
			public void insertOrUpdate(com.vip.vop.common.switcher.AppSwitcherVo switcherVo_) {
				
				send_insertOrUpdate(switcherVo_);
				recv_insertOrUpdate();
				
			}
			
			
			private void send_insertOrUpdate(com.vip.vop.common.switcher.AppSwitcherVo switcherVo_){
				
				InitInvocation("insertOrUpdate");
				
				insertOrUpdate_args args = new insertOrUpdate_args();
				args.SetSwitcherVo(switcherVo_);
				
				SendBase(args, insertOrUpdate_argsHelper.getInstance());
			}
			
			
			private void recv_insertOrUpdate(){
				
				insertOrUpdate_result result = new insertOrUpdate_result();
				ReceiveBase(result, insertOrUpdate_resultHelper.getInstance());
				
				
			}
			
			
			public bool? isOpenSwither(string domainName_,string moduleName_) {
				
				send_isOpenSwither(domainName_,moduleName_);
				return recv_isOpenSwither(); 
				
			}
			
			
			private void send_isOpenSwither(string domainName_,string moduleName_){
				
				InitInvocation("isOpenSwither");
				
				isOpenSwither_args args = new isOpenSwither_args();
				args.SetDomainName(domainName_);
				args.SetModuleName(moduleName_);
				
				SendBase(args, isOpenSwither_argsHelper.getInstance());
			}
			
			
			private bool? recv_isOpenSwither(){
				
				isOpenSwither_result result = new isOpenSwither_result();
				ReceiveBase(result, isOpenSwither_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.common.switcher.ListSwitcherResponse listSwitcher(string domainName_,string moduleName_,int? page_,int? pageSize_) {
				
				send_listSwitcher(domainName_,moduleName_,page_,pageSize_);
				return recv_listSwitcher(); 
				
			}
			
			
			private void send_listSwitcher(string domainName_,string moduleName_,int? page_,int? pageSize_){
				
				InitInvocation("listSwitcher");
				
				listSwitcher_args args = new listSwitcher_args();
				args.SetDomainName(domainName_);
				args.SetModuleName(moduleName_);
				args.SetPage(page_);
				args.SetPageSize(pageSize_);
				
				SendBase(args, listSwitcher_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.common.switcher.ListSwitcherResponse recv_listSwitcher(){
				
				listSwitcher_result result = new listSwitcher_result();
				ReceiveBase(result, listSwitcher_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? openSwitcher(string domainName_,string moduleName_) {
				
				send_openSwitcher(domainName_,moduleName_);
				return recv_openSwitcher(); 
				
			}
			
			
			private void send_openSwitcher(string domainName_,string moduleName_){
				
				InitInvocation("openSwitcher");
				
				openSwitcher_args args = new openSwitcher_args();
				args.SetDomainName(domainName_);
				args.SetModuleName(moduleName_);
				
				SendBase(args, openSwitcher_argsHelper.getInstance());
			}
			
			
			private bool? recv_openSwitcher(){
				
				openSwitcher_result result = new openSwitcher_result();
				ReceiveBase(result, openSwitcher_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}