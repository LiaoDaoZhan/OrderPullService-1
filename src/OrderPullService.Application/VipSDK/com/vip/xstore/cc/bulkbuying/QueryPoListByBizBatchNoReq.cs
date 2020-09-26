using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying{
	
	
	
	
	
	public class QueryPoListByBizBatchNoReq {
		
		///<summary>
		/// 订单来源
		///</summary>
		
		private string source_;
		
		///<summary>
		/// 业务批次号
		///</summary>
		
		private string bizBatchNo_;
		
		public string GetSource(){
			return this.source_;
		}
		
		public void SetSource(string value){
			this.source_ = value;
		}
		public string GetBizBatchNo(){
			return this.bizBatchNo_;
		}
		
		public void SetBizBatchNo(string value){
			this.bizBatchNo_ = value;
		}
		
	}
	
}