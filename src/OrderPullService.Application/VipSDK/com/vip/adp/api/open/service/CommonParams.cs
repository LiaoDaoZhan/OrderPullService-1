using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class CommonParams {
		
		///<summary>
		/// 用户平台：1-PC,2-APP,3-小程序,不传默认为APP
		///</summary>
		
		private int? plat_;
		
		///<summary>
		/// 设备号类型：IMEI，IDFA，OAID，有则传入
		///</summary>
		
		private string deviceType_;
		
		///<summary>
		/// 设备号MD5加密后的值，有则传入
		///</summary>
		
		private string deviceValue_;
		
		///<summary>
		/// 用户ip地址
		///</summary>
		
		private string ip_;
		
		///<summary>
		/// 经度 如:29.590961456298828
		///</summary>
		
		private string longitude_;
		
		///<summary>
		/// 纬度 如:106.51573181152344
		///</summary>
		
		private string latitude_;
		
		///<summary>
		/// 设备名：如iphone7
		///</summary>
		
		private string deviceName_;
		
		///<summary>
		/// 设备操作系统，例如：OS_8.1.2
		///</summary>
		
		private string osType_;
		
		///<summary>
		/// 网络类型: 填0、2、3、4（0: WIFI,2: 2G,3: 3G,4: 4G）
		///</summary>
		
		private string accessType_;
		
		public int? GetPlat(){
			return this.plat_;
		}
		
		public void SetPlat(int? value){
			this.plat_ = value;
		}
		public string GetDeviceType(){
			return this.deviceType_;
		}
		
		public void SetDeviceType(string value){
			this.deviceType_ = value;
		}
		public string GetDeviceValue(){
			return this.deviceValue_;
		}
		
		public void SetDeviceValue(string value){
			this.deviceValue_ = value;
		}
		public string GetIp(){
			return this.ip_;
		}
		
		public void SetIp(string value){
			this.ip_ = value;
		}
		public string GetLongitude(){
			return this.longitude_;
		}
		
		public void SetLongitude(string value){
			this.longitude_ = value;
		}
		public string GetLatitude(){
			return this.latitude_;
		}
		
		public void SetLatitude(string value){
			this.latitude_ = value;
		}
		public string GetDeviceName(){
			return this.deviceName_;
		}
		
		public void SetDeviceName(string value){
			this.deviceName_ = value;
		}
		public string GetOsType(){
			return this.osType_;
		}
		
		public void SetOsType(string value){
			this.osType_ = value;
		}
		public string GetAccessType(){
			return this.accessType_;
		}
		
		public void SetAccessType(string value){
			this.accessType_ = value;
		}
		
	}
	
}