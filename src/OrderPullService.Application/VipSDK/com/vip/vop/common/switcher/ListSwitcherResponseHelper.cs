using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.common.switcher{
	
	
	
	public class ListSwitcherResponseHelper : TBeanSerializer<ListSwitcherResponse>
	{
		
		public static ListSwitcherResponseHelper OBJ = new ListSwitcherResponseHelper();
		
		public static ListSwitcherResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ListSwitcherResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("switchers".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.common.switcher.AppSwitcherVo> value;
						
						value = new List<com.vip.vop.common.switcher.AppSwitcherVo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.common.switcher.AppSwitcherVo elem0;
								
								elem0 = new com.vip.vop.common.switcher.AppSwitcherVo();
								com.vip.vop.common.switcher.AppSwitcherVoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSwitchers(value);
					}
					
					
					
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
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
		
		
		public void Write(ListSwitcherResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSwitchers() != null) {
				
				oprot.WriteFieldBegin("switchers");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.common.switcher.AppSwitcherVo _item0 in structs.GetSwitchers()){
					
					
					com.vip.vop.common.switcher.AppSwitcherVoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ListSwitcherResponse bean){
			
			
		}
		
	}
	
}