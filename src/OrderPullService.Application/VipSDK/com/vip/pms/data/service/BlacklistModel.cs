using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class BlacklistModel {
		
		///<summary>
		/// 同步类型：新增 or 删除
		///</summary>
		
		private com.vip.pms.data.service.SyncType? syncType_;
		
		///<summary>
		/// 黑名单ID集合
		///</summary>
		
		private List<string> blacklistIds_;
		
		///<summary>
		/// 黑名单类型
		///</summary>
		
		private com.vip.pms.data.service.BlackListType? blackListType_;
		
		///<summary>
		/// 销售模式：0-自营 1-直发 2-海淘
		///</summary>
		
		private List<int?> salesModes_;
		
		///<summary>
		/// 促销类型：21-权益价；300-优惠券
		///</summary>
		
		private int? promoType_;
		
		///<summary>
		/// 黑名单作用范围：1-不参与优惠; 2-选购列表和详情不展示优惠
		///</summary>
		
		private int? effectType_;
		
		public com.vip.pms.data.service.SyncType? GetSyncType(){
			return this.syncType_;
		}
		
		public void SetSyncType(com.vip.pms.data.service.SyncType? value){
			this.syncType_ = value;
		}
		public List<string> GetBlacklistIds(){
			return this.blacklistIds_;
		}
		
		public void SetBlacklistIds(List<string> value){
			this.blacklistIds_ = value;
		}
		public com.vip.pms.data.service.BlackListType? GetBlackListType(){
			return this.blackListType_;
		}
		
		public void SetBlackListType(com.vip.pms.data.service.BlackListType? value){
			this.blackListType_ = value;
		}
		public List<int?> GetSalesModes(){
			return this.salesModes_;
		}
		
		public void SetSalesModes(List<int?> value){
			this.salesModes_ = value;
		}
		public int? GetPromoType(){
			return this.promoType_;
		}
		
		public void SetPromoType(int? value){
			this.promoType_ = value;
		}
		public int? GetEffectType(){
			return this.effectType_;
		}
		
		public void SetEffectType(int? value){
			this.effectType_ = value;
		}
		
	}
	
}