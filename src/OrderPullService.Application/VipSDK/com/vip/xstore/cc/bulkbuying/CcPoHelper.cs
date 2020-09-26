using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying{
	
	
	
	public class CcPoHelper : TBeanSerializer<CcPo>
	{
		
		public static CcPoHelper OBJ = new CcPoHelper();
		
		public static CcPoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CcPo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("companyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompanyCode(value);
					}
					
					
					
					
					
					if ("purchaseNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseNo(value);
					}
					
					
					
					
					
					if ("purchaseType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetPurchaseType(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("buyerNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerNo(value);
					}
					
					
					
					
					
					if ("buyerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerId(value);
					}
					
					
					
					
					
					if ("buyerName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerName(value);
					}
					
					
					
					
					
					if ("stockProps".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetStockProps(value);
					}
					
					
					
					
					
					if ("deliveryWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliveryWarehouse(value);
					}
					
					
					
					
					
					if ("disabilityLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDisabilityLevel(value);
					}
					
					
					
					
					
					if ("deptId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeptId(value);
					}
					
					
					
					
					
					if ("deptName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeptName(value);
					}
					
					
					
					
					
					if ("deliveryTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetDeliveryTime(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("vendorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorName(value);
					}
					
					
					
					
					
					if ("approvalTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetApprovalTime(value);
					}
					
					
					
					
					
					if ("currency".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCurrency(value);
					}
					
					
					
					
					
					if ("bizLinkerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizLinkerId(value);
					}
					
					
					
					
					
					if ("bizLinkerName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizLinkerName(value);
					}
					
					
					
					
					
					if ("bizLinkerDeptId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizLinkerDeptId(value);
					}
					
					
					
					
					
					if ("bizLinkerDeptName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizLinkerDeptName(value);
					}
					
					
					
					
					
					if ("totalDeliveredLineQty".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotalDeliveredLineQty(value);
					}
					
					
					
					
					
					if ("cooperationMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCooperationMode(value);
					}
					
					
					
					
					
					if ("receiveWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiveWarehouse(value);
					}
					
					
					
					
					
					if ("followDeptId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFollowDeptId(value);
					}
					
					
					
					
					
					if ("followDeptName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFollowDeptName(value);
					}
					
					
					
					
					
					if ("settleSegment".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSettleSegment(value);
					}
					
					
					
					
					
					if ("partyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPartyCode(value);
					}
					
					
					
					
					
					if ("receivingType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetReceivingType(value);
					}
					
					
					
					
					
					if ("settlementMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSettlementMode(value);
					}
					
					
					
					
					
					if ("deduction".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetDeduction(value);
					}
					
					
					
					
					
					if ("approvalStatusDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApprovalStatusDesc(value);
					}
					
					
					
					
					
					if ("conversionCnyRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetConversionCnyRate(value);
					}
					
					
					
					
					
					if ("approvalStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetApprovalStatus(value);
					}
					
					
					
					
					
					if ("distributedToWop".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetDistributedToWop(value);
					}
					
					
					
					
					
					if ("is3PL".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIs3PL(value);
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
		
		
		public void Write(CcPo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCompanyCode() != null) {
				
				oprot.WriteFieldBegin("companyCode");
				oprot.WriteString(structs.GetCompanyCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseNo() != null) {
				
				oprot.WriteFieldBegin("purchaseNo");
				oprot.WriteString(structs.GetPurchaseNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseType() != null) {
				
				oprot.WriteFieldBegin("purchaseType");
				oprot.WriteByte((byte)structs.GetPurchaseType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerNo() != null) {
				
				oprot.WriteFieldBegin("buyerNo");
				oprot.WriteString(structs.GetBuyerNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerId() != null) {
				
				oprot.WriteFieldBegin("buyerId");
				oprot.WriteString(structs.GetBuyerId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerName() != null) {
				
				oprot.WriteFieldBegin("buyerName");
				oprot.WriteString(structs.GetBuyerName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStockProps() != null) {
				
				oprot.WriteFieldBegin("stockProps");
				oprot.WriteByte((byte)structs.GetStockProps()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryWarehouse() != null) {
				
				oprot.WriteFieldBegin("deliveryWarehouse");
				oprot.WriteString(structs.GetDeliveryWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDisabilityLevel() != null) {
				
				oprot.WriteFieldBegin("disabilityLevel");
				oprot.WriteString(structs.GetDisabilityLevel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeptId() != null) {
				
				oprot.WriteFieldBegin("deptId");
				oprot.WriteString(structs.GetDeptId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeptName() != null) {
				
				oprot.WriteFieldBegin("deptName");
				oprot.WriteString(structs.GetDeptName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryTime() != null) {
				
				oprot.WriteFieldBegin("deliveryTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetDeliveryTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetUpdateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApprovalTime() != null) {
				
				oprot.WriteFieldBegin("approvalTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetApprovalTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCurrency() != null) {
				
				oprot.WriteFieldBegin("currency");
				oprot.WriteString(structs.GetCurrency());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBizLinkerId() != null) {
				
				oprot.WriteFieldBegin("bizLinkerId");
				oprot.WriteString(structs.GetBizLinkerId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBizLinkerName() != null) {
				
				oprot.WriteFieldBegin("bizLinkerName");
				oprot.WriteString(structs.GetBizLinkerName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBizLinkerDeptId() != null) {
				
				oprot.WriteFieldBegin("bizLinkerDeptId");
				oprot.WriteString(structs.GetBizLinkerDeptId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBizLinkerDeptName() != null) {
				
				oprot.WriteFieldBegin("bizLinkerDeptName");
				oprot.WriteString(structs.GetBizLinkerDeptName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalDeliveredLineQty() != null) {
				
				oprot.WriteFieldBegin("totalDeliveredLineQty");
				oprot.WriteI32((int)structs.GetTotalDeliveredLineQty()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCooperationMode() != null) {
				
				oprot.WriteFieldBegin("cooperationMode");
				oprot.WriteString(structs.GetCooperationMode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiveWarehouse() != null) {
				
				oprot.WriteFieldBegin("receiveWarehouse");
				oprot.WriteString(structs.GetReceiveWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFollowDeptId() != null) {
				
				oprot.WriteFieldBegin("followDeptId");
				oprot.WriteString(structs.GetFollowDeptId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFollowDeptName() != null) {
				
				oprot.WriteFieldBegin("followDeptName");
				oprot.WriteString(structs.GetFollowDeptName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSettleSegment() != null) {
				
				oprot.WriteFieldBegin("settleSegment");
				oprot.WriteString(structs.GetSettleSegment());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPartyCode() != null) {
				
				oprot.WriteFieldBegin("partyCode");
				oprot.WriteString(structs.GetPartyCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceivingType() != null) {
				
				oprot.WriteFieldBegin("receivingType");
				oprot.WriteByte((byte)structs.GetReceivingType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSettlementMode() != null) {
				
				oprot.WriteFieldBegin("settlementMode");
				oprot.WriteByte((byte)structs.GetSettlementMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeduction() != null) {
				
				oprot.WriteFieldBegin("deduction");
				oprot.WriteDouble((double)structs.GetDeduction());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApprovalStatusDesc() != null) {
				
				oprot.WriteFieldBegin("approvalStatusDesc");
				oprot.WriteString(structs.GetApprovalStatusDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetConversionCnyRate() != null) {
				
				oprot.WriteFieldBegin("conversionCnyRate");
				oprot.WriteDouble((double)structs.GetConversionCnyRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApprovalStatus() != null) {
				
				oprot.WriteFieldBegin("approvalStatus");
				oprot.WriteByte((byte)structs.GetApprovalStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDistributedToWop() != null) {
				
				oprot.WriteFieldBegin("distributedToWop");
				oprot.WriteBool((bool)structs.GetDistributedToWop());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("distributedToWop can not be null!");
			}
			
			
			if(structs.GetIs3PL() != null) {
				
				oprot.WriteFieldBegin("is3PL");
				oprot.WriteBool((bool)structs.GetIs3PL());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("is3PL can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CcPo bean){
			
			
		}
		
	}
	
}