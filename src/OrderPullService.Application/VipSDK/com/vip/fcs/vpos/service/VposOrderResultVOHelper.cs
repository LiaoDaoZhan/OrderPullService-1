using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vpos.service{
	
	
	
	public class VposOrderResultVOHelper : TBeanSerializer<VposOrderResultVO>
	{
		
		public static VposOrderResultVOHelper OBJ = new VposOrderResultVOHelper();
		
		public static VposOrderResultVOHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VposOrderResultVO structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("addTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetAddTime(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("orderMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderMoney(value);
					}
					
					
					
					
					
					if ("orderQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetOrderQuantity(value);
					}
					
					
					
					
					
					if ("currency".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCurrency(value);
					}
					
					
					
					
					
					if ("paySn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPaySn(value);
					}
					
					
					
					
					
					if ("payType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPayType(value);
					}
					
					
					
					
					
					if ("paymentTerm".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPaymentTerm(value);
					}
					
					
					
					
					
					if ("payMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPayMoney(value);
					}
					
					
					
					
					
					if ("extorderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExtorderSn(value);
					}
					
					
					
					
					
					if ("extaddTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetExtaddTime(value);
					}
					
					
					
					
					
					if ("saleType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSaleType(value);
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
		
		
		public void Write(VposOrderResultVO structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetAddTime() != null) {
				
				oprot.WriteFieldBegin("addTime");
				oprot.WriteI64((long)structs.GetAddTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("addTime can not be null!");
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetOrderMoney() != null) {
				
				oprot.WriteFieldBegin("orderMoney");
				oprot.WriteString(structs.GetOrderMoney());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderMoney can not be null!");
			}
			
			
			if(structs.GetOrderQuantity() != null) {
				
				oprot.WriteFieldBegin("orderQuantity");
				oprot.WriteI32((int)structs.GetOrderQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderQuantity can not be null!");
			}
			
			
			if(structs.GetCurrency() != null) {
				
				oprot.WriteFieldBegin("currency");
				oprot.WriteString(structs.GetCurrency());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPaySn() != null) {
				
				oprot.WriteFieldBegin("paySn");
				oprot.WriteString(structs.GetPaySn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("paySn can not be null!");
			}
			
			
			if(structs.GetPayType() != null) {
				
				oprot.WriteFieldBegin("payType");
				oprot.WriteString(structs.GetPayType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPaymentTerm() != null) {
				
				oprot.WriteFieldBegin("paymentTerm");
				oprot.WriteString(structs.GetPaymentTerm());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("paymentTerm can not be null!");
			}
			
			
			if(structs.GetPayMoney() != null) {
				
				oprot.WriteFieldBegin("payMoney");
				oprot.WriteString(structs.GetPayMoney());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("payMoney can not be null!");
			}
			
			
			if(structs.GetExtorderSn() != null) {
				
				oprot.WriteFieldBegin("extorderSn");
				oprot.WriteString(structs.GetExtorderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExtaddTime() != null) {
				
				oprot.WriteFieldBegin("extaddTime");
				oprot.WriteI64((long)structs.GetExtaddTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSaleType() != null) {
				
				oprot.WriteFieldBegin("saleType");
				oprot.WriteString(structs.GetSaleType());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("saleType can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VposOrderResultVO bean){
			
			
		}
		
	}
	
}