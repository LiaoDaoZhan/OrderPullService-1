using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vpos.service{
	
	
	
	
	
	public class OrderQueryRequest {
		
		///<summary>
		/// 订单更新时间，查询时间范围的开始时间点，单位是秒。时间戳.示例:1572427369
		///</summary>
		
		private long? updateTimeBegin_;
		
		///<summary>
		/// 订单更新时间，查询时间范围的结束时间点，单位是秒。时间戳.示例:1572427379
		///</summary>
		
		private long? updateTimeEnd_;
		
		///<summary>
		/// 分页索引，即查询第几页数据，每页数据默认为50行，从第1页开始。示例: 1
		///</summary>
		
		private int? pageIndex_;
		
		///<summary>
		/// 门店编码，由唯品会提供。且用于授权
		///</summary>
		
		private string storeCode_;
		
		///<summary>
		/// 订单号 - 零售订单号(VPOS生成)
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 销售类型：SALE - 销售, RETURN - 客退. 示例: SALE
		///</summary>
		
		private string saleType_;
		
		public long? GetUpdateTimeBegin(){
			return this.updateTimeBegin_;
		}
		
		public void SetUpdateTimeBegin(long? value){
			this.updateTimeBegin_ = value;
		}
		public long? GetUpdateTimeEnd(){
			return this.updateTimeEnd_;
		}
		
		public void SetUpdateTimeEnd(long? value){
			this.updateTimeEnd_ = value;
		}
		public int? GetPageIndex(){
			return this.pageIndex_;
		}
		
		public void SetPageIndex(int? value){
			this.pageIndex_ = value;
		}
		public string GetStoreCode(){
			return this.storeCode_;
		}
		
		public void SetStoreCode(string value){
			this.storeCode_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetSaleType(){
			return this.saleType_;
		}
		
		public void SetSaleType(string value){
			this.saleType_ = value;
		}
		
	}
	
}