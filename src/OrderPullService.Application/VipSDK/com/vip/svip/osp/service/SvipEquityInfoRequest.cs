using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SvipEquityInfoRequest {
		
		///<summary>
		/// 是否需要节省金额信息(默认true)
		///</summary>
		
		private bool? needSaveAmount_;
		
		///<summary>
		/// 是否需要头像信息 (默认true)
		///</summary>
		
		private bool? needFigureUrl_;
		
		///<summary>
		/// 是否需要后返信息 (默认true)
		///</summary>
		
		private bool? needRebate_;
		
		///<summary>
		/// 是否需要SVIP价格信息 (默认true)
		///</summary>
		
		private bool? needPrice_;
		
		public bool? GetNeedSaveAmount(){
			return this.needSaveAmount_;
		}
		
		public void SetNeedSaveAmount(bool? value){
			this.needSaveAmount_ = value;
		}
		public bool? GetNeedFigureUrl(){
			return this.needFigureUrl_;
		}
		
		public void SetNeedFigureUrl(bool? value){
			this.needFigureUrl_ = value;
		}
		public bool? GetNeedRebate(){
			return this.needRebate_;
		}
		
		public void SetNeedRebate(bool? value){
			this.needRebate_ = value;
		}
		public bool? GetNeedPrice(){
			return this.needPrice_;
		}
		
		public void SetNeedPrice(bool? value){
			this.needPrice_ = value;
		}
		
	}
	
}