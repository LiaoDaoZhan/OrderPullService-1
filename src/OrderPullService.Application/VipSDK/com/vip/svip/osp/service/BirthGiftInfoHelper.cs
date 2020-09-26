using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class BirthGiftInfoHelper : TBeanSerializer<BirthGiftInfo>
	{
		
		public static BirthGiftInfoHelper OBJ = new BirthGiftInfoHelper();
		
		public static BirthGiftInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BirthGiftInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMsg(value);
					}
					
					
					
					
					
					if ("birthday".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBirthday(value);
					}
					
					
					
					
					
					if ("prizeList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.svip.osp.service.BirthGiftPrize> value;
						
						value = new List<com.vip.svip.osp.service.BirthGiftPrize>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.svip.osp.service.BirthGiftPrize elem0;
								
								elem0 = new com.vip.svip.osp.service.BirthGiftPrize();
								com.vip.svip.osp.service.BirthGiftPrizeHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPrizeList(value);
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
		
		
		public void Write(BirthGiftInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI32((int)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("status can not be null!");
			}
			
			
			if(structs.GetMsg() != null) {
				
				oprot.WriteFieldBegin("msg");
				oprot.WriteString(structs.GetMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBirthday() != null) {
				
				oprot.WriteFieldBegin("birthday");
				oprot.WriteString(structs.GetBirthday());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrizeList() != null) {
				
				oprot.WriteFieldBegin("prizeList");
				
				oprot.WriteListBegin();
				foreach(com.vip.svip.osp.service.BirthGiftPrize _item0 in structs.GetPrizeList()){
					
					
					com.vip.svip.osp.service.BirthGiftPrizeHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BirthGiftInfo bean){
			
			
		}
		
	}
	
}