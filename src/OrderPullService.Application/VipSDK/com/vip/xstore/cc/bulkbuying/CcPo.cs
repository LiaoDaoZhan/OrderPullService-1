using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying{
	
	
	
	
	
	public class CcPo {
		
		///<summary>
		/// 公司编码(xstorebuy/maxxbuy)
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 采购清单编号
		///</summary>
		
		private string purchaseNo_;
		
		///<summary>
		/// 采购类型,0=内采，1=外采
		///</summary>
		
		private byte? purchaseType_;
		
		///<summary>
		/// 销售订单编号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 采购员工号
		///</summary>
		
		private string buyerNo_;
		
		///<summary>
		/// 采购员OA账号
		///</summary>
		
		private string buyerId_;
		
		///<summary>
		/// 采购员名称
		///</summary>
		
		private string buyerName_;
		
		///<summary>
		/// 库存属性，0=SI，1=VI
		///</summary>
		
		private byte? stockProps_;
		
		///<summary>
		/// 发货仓库，对于内采，复用改字段存储收货仓库编码
		///</summary>
		
		private string deliveryWarehouse_;
		
		///<summary>
		/// 残次等级
		///</summary>
		
		private string disabilityLevel_;
		
		///<summary>
		/// 采购员部门id
		///</summary>
		
		private string deptId_;
		
		///<summary>
		/// 采购员部门名称
		///</summary>
		
		private string deptName_;
		
		///<summary>
		/// 出仓时间
		///</summary>
		
		private System.DateTime? deliveryTime_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private System.DateTime? createTime_;
		
		///<summary>
		/// 更新时间
		///</summary>
		
		private System.DateTime? updateTime_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 审批通过时间
		///</summary>
		
		private System.DateTime? approvalTime_;
		
		///<summary>
		/// 币种:CNY、USD、EUR、JPY、AUD
		///</summary>
		
		private string currency_;
		
		///<summary>
		/// 商务对接人OA帐号
		///</summary>
		
		private string bizLinkerId_;
		
		///<summary>
		/// 商务对接人名称
		///</summary>
		
		private string bizLinkerName_;
		
		///<summary>
		/// 商务对接人所属部门id
		///</summary>
		
		private string bizLinkerDeptId_;
		
		///<summary>
		/// 商务对接人所属部门名称
		///</summary>
		
		private string bizLinkerDeptName_;
		
		///<summary>
		/// 有效出仓行数
		///</summary>
		
		private int? totalDeliveredLineQty_;
		
		///<summary>
		/// 合作模式
		///</summary>
		
		private string cooperationMode_;
		
		///<summary>
		/// 收货仓库
		///</summary>
		
		private string receiveWarehouse_;
		
		///<summary>
		/// 跟进部门编码
		///</summary>
		
		private string followDeptId_;
		
		///<summary>
		/// 跟进部门名称
		///</summary>
		
		private string followDeptName_;
		
		///<summary>
		/// 结算方式
		///</summary>
		
		private string settleSegment_;
		
		///<summary>
		/// 签约主体
		///</summary>
		
		private string partyCode_;
		
		///<summary>
		/// 收货类型(0:大仓收货,1:门店收货,2:大仓分货)
		///</summary>
		
		private byte? receivingType_;
		
		///<summary>
		/// 结算模式 1-供货价 2-扣点 0-无（默认值）
		///</summary>
		
		private byte? settlementMode_;
		
		///<summary>
		/// 扣点(0~1之间，2位小数)
		///</summary>
		
		private double? deduction_;
		
		///<summary>
		/// 审批状态描述
		///</summary>
		
		private string approvalStatusDesc_;
		
		///<summary>
		/// 本位币汇率
		///</summary>
		
		private double? conversionCnyRate_;
		
		///<summary>
		/// 审核状态，0=草稿，1=待审批，2=审批通过，3=已驳回, 4=已取消，9=已关闭，10=提交中，15=提交失败
		///</summary>
		
		private byte? approvalStatus_;
		
		///<summary>
		/// 是否已下发WOP
		///</summary>
		
		private bool? distributedToWop_;
		
		///<summary>
		/// 是否3PL
		///</summary>
		
		private bool? is3PL_;
		
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public string GetPurchaseNo(){
			return this.purchaseNo_;
		}
		
		public void SetPurchaseNo(string value){
			this.purchaseNo_ = value;
		}
		public byte? GetPurchaseType(){
			return this.purchaseType_;
		}
		
		public void SetPurchaseType(byte? value){
			this.purchaseType_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetBuyerNo(){
			return this.buyerNo_;
		}
		
		public void SetBuyerNo(string value){
			this.buyerNo_ = value;
		}
		public string GetBuyerId(){
			return this.buyerId_;
		}
		
		public void SetBuyerId(string value){
			this.buyerId_ = value;
		}
		public string GetBuyerName(){
			return this.buyerName_;
		}
		
		public void SetBuyerName(string value){
			this.buyerName_ = value;
		}
		public byte? GetStockProps(){
			return this.stockProps_;
		}
		
		public void SetStockProps(byte? value){
			this.stockProps_ = value;
		}
		public string GetDeliveryWarehouse(){
			return this.deliveryWarehouse_;
		}
		
		public void SetDeliveryWarehouse(string value){
			this.deliveryWarehouse_ = value;
		}
		public string GetDisabilityLevel(){
			return this.disabilityLevel_;
		}
		
		public void SetDisabilityLevel(string value){
			this.disabilityLevel_ = value;
		}
		public string GetDeptId(){
			return this.deptId_;
		}
		
		public void SetDeptId(string value){
			this.deptId_ = value;
		}
		public string GetDeptName(){
			return this.deptName_;
		}
		
		public void SetDeptName(string value){
			this.deptName_ = value;
		}
		public System.DateTime? GetDeliveryTime(){
			return this.deliveryTime_;
		}
		
		public void SetDeliveryTime(System.DateTime? value){
			this.deliveryTime_ = value;
		}
		public System.DateTime? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(System.DateTime? value){
			this.createTime_ = value;
		}
		public System.DateTime? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(System.DateTime? value){
			this.updateTime_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public System.DateTime? GetApprovalTime(){
			return this.approvalTime_;
		}
		
		public void SetApprovalTime(System.DateTime? value){
			this.approvalTime_ = value;
		}
		public string GetCurrency(){
			return this.currency_;
		}
		
		public void SetCurrency(string value){
			this.currency_ = value;
		}
		public string GetBizLinkerId(){
			return this.bizLinkerId_;
		}
		
		public void SetBizLinkerId(string value){
			this.bizLinkerId_ = value;
		}
		public string GetBizLinkerName(){
			return this.bizLinkerName_;
		}
		
		public void SetBizLinkerName(string value){
			this.bizLinkerName_ = value;
		}
		public string GetBizLinkerDeptId(){
			return this.bizLinkerDeptId_;
		}
		
		public void SetBizLinkerDeptId(string value){
			this.bizLinkerDeptId_ = value;
		}
		public string GetBizLinkerDeptName(){
			return this.bizLinkerDeptName_;
		}
		
		public void SetBizLinkerDeptName(string value){
			this.bizLinkerDeptName_ = value;
		}
		public int? GetTotalDeliveredLineQty(){
			return this.totalDeliveredLineQty_;
		}
		
		public void SetTotalDeliveredLineQty(int? value){
			this.totalDeliveredLineQty_ = value;
		}
		public string GetCooperationMode(){
			return this.cooperationMode_;
		}
		
		public void SetCooperationMode(string value){
			this.cooperationMode_ = value;
		}
		public string GetReceiveWarehouse(){
			return this.receiveWarehouse_;
		}
		
		public void SetReceiveWarehouse(string value){
			this.receiveWarehouse_ = value;
		}
		public string GetFollowDeptId(){
			return this.followDeptId_;
		}
		
		public void SetFollowDeptId(string value){
			this.followDeptId_ = value;
		}
		public string GetFollowDeptName(){
			return this.followDeptName_;
		}
		
		public void SetFollowDeptName(string value){
			this.followDeptName_ = value;
		}
		public string GetSettleSegment(){
			return this.settleSegment_;
		}
		
		public void SetSettleSegment(string value){
			this.settleSegment_ = value;
		}
		public string GetPartyCode(){
			return this.partyCode_;
		}
		
		public void SetPartyCode(string value){
			this.partyCode_ = value;
		}
		public byte? GetReceivingType(){
			return this.receivingType_;
		}
		
		public void SetReceivingType(byte? value){
			this.receivingType_ = value;
		}
		public byte? GetSettlementMode(){
			return this.settlementMode_;
		}
		
		public void SetSettlementMode(byte? value){
			this.settlementMode_ = value;
		}
		public double? GetDeduction(){
			return this.deduction_;
		}
		
		public void SetDeduction(double? value){
			this.deduction_ = value;
		}
		public string GetApprovalStatusDesc(){
			return this.approvalStatusDesc_;
		}
		
		public void SetApprovalStatusDesc(string value){
			this.approvalStatusDesc_ = value;
		}
		public double? GetConversionCnyRate(){
			return this.conversionCnyRate_;
		}
		
		public void SetConversionCnyRate(double? value){
			this.conversionCnyRate_ = value;
		}
		public byte? GetApprovalStatus(){
			return this.approvalStatus_;
		}
		
		public void SetApprovalStatus(byte? value){
			this.approvalStatus_ = value;
		}
		public bool? GetDistributedToWop(){
			return this.distributedToWop_;
		}
		
		public void SetDistributedToWop(bool? value){
			this.distributedToWop_ = value;
		}
		public bool? GetIs3PL(){
			return this.is3PL_;
		}
		
		public void SetIs3PL(bool? value){
			this.is3PL_ = value;
		}
		
	}
	
}