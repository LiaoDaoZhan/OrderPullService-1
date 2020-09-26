using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	
	
	public class TmsOrderModifyRequest {
		
		///<summary>
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		///</summary>
		
		private int? isJitX_;
		
		///<summary>
		/// 是否匹配给第三方承运商标识，0：不给第三方承运商，1：给第三方承运商
		///</summary>
		
		private int? thirdCarrierFlag_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public int? GetIsJitX(){
			return this.isJitX_;
		}
		
		public void SetIsJitX(int? value){
			this.isJitX_ = value;
		}
		public int? GetThirdCarrierFlag(){
			return this.thirdCarrierFlag_;
		}
		
		public void SetThirdCarrierFlag(int? value){
			this.thirdCarrierFlag_ = value;
		}
		
	}
	
}