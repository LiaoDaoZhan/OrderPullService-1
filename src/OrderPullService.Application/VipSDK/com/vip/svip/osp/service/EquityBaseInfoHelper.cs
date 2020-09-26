using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class EquityBaseInfoHelper : TBeanSerializer<EquityBaseInfo>
	{
		
		public static EquityBaseInfoHelper OBJ = new EquityBaseInfoHelper();
		
		public static EquityBaseInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(EquityBaseInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("vpid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVpid(value);
					}
					
					
					
					
					
					if ("nickName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNickName(value);
					}
					
					
					
					
					
					if ("userStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetUserStatus(value);
					}
					
					
					
					
					
					if ("canTrial".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetCanTrial(value);
					}
					
					
					
					
					
					if ("canOpen".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetCanOpen(value);
					}
					
					
					
					
					
					if ("expireTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetExpireTime(value);
					}
					
					
					
					
					
					if ("remainingDays".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetRemainingDays(value);
					}
					
					
					
					
					
					if ("userLv".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserLv(value);
					}
					
					
					
					
					
					if ("saveMoneyInformation".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.svip.osp.service.SaveMoneyInformation value;
						
						value = new com.vip.svip.osp.service.SaveMoneyInformation();
						com.vip.svip.osp.service.SaveMoneyInformationHelper.getInstance().Read(value, iprot);
						
						structs.SetSaveMoneyInformation(value);
					}
					
					
					
					
					
					if ("price".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrice(value);
					}
					
					
					
					
					
					if ("updating".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetUpdating(value);
					}
					
					
					
					
					
					if ("imminentExpiry".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetImminentExpiry(value);
					}
					
					
					
					
					
					if ("specialTag".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSpecialTag(value);
					}
					
					
					
					
					
					if ("rebateText".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRebateText(value);
					}
					
					
					
					
					
					if ("countDownMS".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCountDownMS(value);
					}
					
					
					
					
					
					if ("vipFigureUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipFigureUrl(value);
					}
					
					
					
					
					
					if ("openType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetOpenType(value);
					}
					
					
					
					
					
					if ("birthGiftInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.svip.osp.service.BirthGiftInfo value;
						
						value = new com.vip.svip.osp.service.BirthGiftInfo();
						com.vip.svip.osp.service.BirthGiftInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetBirthGiftInfo(value);
					}
					
					
					
					
					
					if ("totalAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTotalAmount(value);
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
		
		
		public void Write(EquityBaseInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetVpid() != null) {
				
				oprot.WriteFieldBegin("vpid");
				oprot.WriteString(structs.GetVpid());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNickName() != null) {
				
				oprot.WriteFieldBegin("nickName");
				oprot.WriteString(structs.GetNickName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserStatus() != null) {
				
				oprot.WriteFieldBegin("userStatus");
				oprot.WriteI32((int)structs.GetUserStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userStatus can not be null!");
			}
			
			
			if(structs.GetCanTrial() != null) {
				
				oprot.WriteFieldBegin("canTrial");
				oprot.WriteBool((bool)structs.GetCanTrial());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("canTrial can not be null!");
			}
			
			
			if(structs.GetCanOpen() != null) {
				
				oprot.WriteFieldBegin("canOpen");
				oprot.WriteBool((bool)structs.GetCanOpen());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("canOpen can not be null!");
			}
			
			
			if(structs.GetExpireTime() != null) {
				
				oprot.WriteFieldBegin("expireTime");
				oprot.WriteI64((long)structs.GetExpireTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("expireTime can not be null!");
			}
			
			
			if(structs.GetRemainingDays() != null) {
				
				oprot.WriteFieldBegin("remainingDays");
				oprot.WriteI32((int)structs.GetRemainingDays()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("remainingDays can not be null!");
			}
			
			
			if(structs.GetUserLv() != null) {
				
				oprot.WriteFieldBegin("userLv");
				oprot.WriteString(structs.GetUserLv());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSaveMoneyInformation() != null) {
				
				oprot.WriteFieldBegin("saveMoneyInformation");
				
				com.vip.svip.osp.service.SaveMoneyInformationHelper.getInstance().Write(structs.GetSaveMoneyInformation(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrice() != null) {
				
				oprot.WriteFieldBegin("price");
				oprot.WriteString(structs.GetPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdating() != null) {
				
				oprot.WriteFieldBegin("updating");
				oprot.WriteI32((int)structs.GetUpdating()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("updating can not be null!");
			}
			
			
			if(structs.GetImminentExpiry() != null) {
				
				oprot.WriteFieldBegin("imminentExpiry");
				oprot.WriteBool((bool)structs.GetImminentExpiry());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("imminentExpiry can not be null!");
			}
			
			
			if(structs.GetSpecialTag() != null) {
				
				oprot.WriteFieldBegin("specialTag");
				oprot.WriteString(structs.GetSpecialTag());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRebateText() != null) {
				
				oprot.WriteFieldBegin("rebateText");
				oprot.WriteString(structs.GetRebateText());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCountDownMS() != null) {
				
				oprot.WriteFieldBegin("countDownMS");
				oprot.WriteI64((long)structs.GetCountDownMS()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("countDownMS can not be null!");
			}
			
			
			if(structs.GetVipFigureUrl() != null) {
				
				oprot.WriteFieldBegin("vipFigureUrl");
				oprot.WriteString(structs.GetVipFigureUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOpenType() != null) {
				
				oprot.WriteFieldBegin("openType");
				oprot.WriteI32((int)structs.GetOpenType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("openType can not be null!");
			}
			
			
			if(structs.GetBirthGiftInfo() != null) {
				
				oprot.WriteFieldBegin("birthGiftInfo");
				
				com.vip.svip.osp.service.BirthGiftInfoHelper.getInstance().Write(structs.GetBirthGiftInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalAmount() != null) {
				
				oprot.WriteFieldBegin("totalAmount");
				oprot.WriteString(structs.GetTotalAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(EquityBaseInfo bean){
			
			
		}
		
	}
	
}