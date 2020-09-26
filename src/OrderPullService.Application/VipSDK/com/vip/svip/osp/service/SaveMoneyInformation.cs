using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SaveMoneyInformation {
		
		///<summary>
		/// 折扣节省金额，正常返回状态返回可靠值，否则返回预测值
		///</summary>
		
		private string discountSaveAmount_;
		
		///<summary>
		/// 节省金额类型 0 预测节省金额  1 实际节省金额 2预测节省金额平均值
		///</summary>
		
		private int? discountSaveAmountType_;
		
		///<summary>
		/// 邮费节省金额，正常返回状态返回可靠值，否则返回预测值
		///</summary>
		
		private string carriageSaveAmount_;
		
		///<summary>
		/// 节省金额类型 0 预测节省金额  1 实际节省金额 2预测节省金额平均值
		///</summary>
		
		private int? carriageSaveAmountType_;
		
		///<summary>
		/// 生日好礼节省金额，正常返回状态返回可靠值，否则返回预测值
		///</summary>
		
		private string birthdaySaveAmount_;
		
		///<summary>
		/// 节省金额类型 0 预测节省金额  1 实际节省金额 2预测节省金额平均值
		///</summary>
		
		private int? birthdaySaveAmountType_;
		
		public string GetDiscountSaveAmount(){
			return this.discountSaveAmount_;
		}
		
		public void SetDiscountSaveAmount(string value){
			this.discountSaveAmount_ = value;
		}
		public int? GetDiscountSaveAmountType(){
			return this.discountSaveAmountType_;
		}
		
		public void SetDiscountSaveAmountType(int? value){
			this.discountSaveAmountType_ = value;
		}
		public string GetCarriageSaveAmount(){
			return this.carriageSaveAmount_;
		}
		
		public void SetCarriageSaveAmount(string value){
			this.carriageSaveAmount_ = value;
		}
		public int? GetCarriageSaveAmountType(){
			return this.carriageSaveAmountType_;
		}
		
		public void SetCarriageSaveAmountType(int? value){
			this.carriageSaveAmountType_ = value;
		}
		public string GetBirthdaySaveAmount(){
			return this.birthdaySaveAmount_;
		}
		
		public void SetBirthdaySaveAmount(string value){
			this.birthdaySaveAmount_ = value;
		}
		public int? GetBirthdaySaveAmountType(){
			return this.birthdaySaveAmountType_;
		}
		
		public void SetBirthdaySaveAmountType(int? value){
			this.birthdaySaveAmountType_ = value;
		}
		
	}
	
}