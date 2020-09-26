using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class SimilarRecommendRequest {
		
		///<summary>
		/// 商品id
		///</summary>
		
		private string goodsId_;
		
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
		/// 通用参数：能获取到则须传入
		///</summary>
		
		private com.vip.adp.api.open.service.CommonParams commonParams_;
		
		///<summary>
		/// 是否查询商品评价信息:默认不查询，该数据在详情页有返回，没有特殊需求，建议不查询，影响接口性能
		///</summary>
		
		private bool? queryReputation_;
		
		///<summary>
		/// 是否查询店铺服务能力信息：默认不查询，该数据在详情页有返回，没有特殊需求，建议不查询，影响接口性能
		///</summary>
		
		private bool? queryStoreServiceCapability_;
		
		///<summary>
		/// 是否查询库存:默认不查询
		///</summary>
		
		private bool? queryStock_;
		
		///<summary>
		/// 是否查询商品活动信息:默认不查询
		///</summary>
		
		private bool? queryActivity_;
		
		///<summary>
		/// 是否查询商品预付信息:默认不查询
		///</summary>
		
		private bool? queryPrepay_;
		
		public string GetGoodsId(){
			return this.goodsId_;
		}
		
		public void SetGoodsId(string value){
			this.goodsId_ = value;
		}
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
		public com.vip.adp.api.open.service.CommonParams GetCommonParams(){
			return this.commonParams_;
		}
		
		public void SetCommonParams(com.vip.adp.api.open.service.CommonParams value){
			this.commonParams_ = value;
		}
		public bool? GetQueryReputation(){
			return this.queryReputation_;
		}
		
		public void SetQueryReputation(bool? value){
			this.queryReputation_ = value;
		}
		public bool? GetQueryStoreServiceCapability(){
			return this.queryStoreServiceCapability_;
		}
		
		public void SetQueryStoreServiceCapability(bool? value){
			this.queryStoreServiceCapability_ = value;
		}
		public bool? GetQueryStock(){
			return this.queryStock_;
		}
		
		public void SetQueryStock(bool? value){
			this.queryStock_ = value;
		}
		public bool? GetQueryActivity(){
			return this.queryActivity_;
		}
		
		public void SetQueryActivity(bool? value){
			this.queryActivity_ = value;
		}
		public bool? GetQueryPrepay(){
			return this.queryPrepay_;
		}
		
		public void SetQueryPrepay(bool? value){
			this.queryPrepay_ = value;
		}
		
	}
	
}