using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class UnionSvipGoodsRequest {
		
		///<summary>
		/// userId
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 联合卡类型
		///</summary>
		
		private int? bizType_;
		
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public int? GetBizType(){
			return this.bizType_;
		}
		
		public void SetBizType(int? value){
			this.bizType_ = value;
		}
		
	}
	
}