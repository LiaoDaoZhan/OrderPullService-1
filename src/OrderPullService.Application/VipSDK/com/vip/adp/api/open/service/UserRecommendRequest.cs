using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class UserRecommendRequest {
		
		///<summary>
		/// 分页页码：从1开始
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 分页大小：默认20
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 请求id：调用方自行定义，用于追踪请求，单次请求唯一，建议使用UUID
		///</summary>
		
		private string requestId_;
		
		///<summary>
		/// 是否有货 1:有货 0:无货 默认1
		///</summary>
		
		private int? inStock_;
		
		///<summary>
		/// 商品售卖状态 1（在售）， 2（预热）， 3（在售+预热） 默认1
		///</summary>
		
		private int? goodsSaleStats_;
		
		///<summary>
		/// 筛选线下店商品：1只返线下店，0或者不传只返回特卖会
		///</summary>
		
		private int? offlineStore_;
		
		///<summary>
		/// 通用参数：能获取到则须传入
		///</summary>
		
		private com.vip.adp.api.open.service.CommonParams commonParams_;
		
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		public string GetRequestId(){
			return this.requestId_;
		}
		
		public void SetRequestId(string value){
			this.requestId_ = value;
		}
		public int? GetInStock(){
			return this.inStock_;
		}
		
		public void SetInStock(int? value){
			this.inStock_ = value;
		}
		public int? GetGoodsSaleStats(){
			return this.goodsSaleStats_;
		}
		
		public void SetGoodsSaleStats(int? value){
			this.goodsSaleStats_ = value;
		}
		public int? GetOfflineStore(){
			return this.offlineStore_;
		}
		
		public void SetOfflineStore(int? value){
			this.offlineStore_ = value;
		}
		public com.vip.adp.api.open.service.CommonParams GetCommonParams(){
			return this.commonParams_;
		}
		
		public void SetCommonParams(com.vip.adp.api.open.service.CommonParams value){
			this.commonParams_ = value;
		}
		
	}
	
}