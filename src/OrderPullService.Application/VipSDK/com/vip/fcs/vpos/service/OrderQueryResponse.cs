using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vpos.service{
	
	
	
	
	
	public class OrderQueryResponse {
		
		///<summary>
		/// 订单查询参数，与请求一致
		///</summary>
		
		private com.vip.fcs.vpos.service.OrderQueryRequest orderQueryRequest_;
		
		///<summary>
		/// 订单查询结果，如果返回结果记录数小于50则没有下一页
		///</summary>
		
		private List<com.vip.fcs.vpos.service.VposOrderResultVO> orderQueryResult_;
		
		public com.vip.fcs.vpos.service.OrderQueryRequest GetOrderQueryRequest(){
			return this.orderQueryRequest_;
		}
		
		public void SetOrderQueryRequest(com.vip.fcs.vpos.service.OrderQueryRequest value){
			this.orderQueryRequest_ = value;
		}
		public List<com.vip.fcs.vpos.service.VposOrderResultVO> GetOrderQueryResult(){
			return this.orderQueryResult_;
		}
		
		public void SetOrderQueryResult(List<com.vip.fcs.vpos.service.VposOrderResultVO> value){
			this.orderQueryResult_ = value;
		}
		
	}
	
}