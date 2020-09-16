using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace OrderPullService
{
    /// <summary>
    /// 店铺信息
    /// </summary>
    public class Shop : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 店铺
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Erp编码
        /// </summary>
        public string ErpCode { get; set; }

        /// <summary>
        /// 第三方平台的信息
        /// </summary>
        public virtual ShopPlatform Platform { get; set; }
        /// <summary>
        /// 店铺类型
        /// </summary>
        public ShopPlatformType ShopPlatformType { get; set; }

        /// <summary>
        /// 是否自动下单
        /// </summary>
        public bool AutoMatic { get; set; } = false;
        /// <summary>
        /// 是否自动同步
        /// </summary>
        public bool AutoSync { get; set; } = true;
        /// <summary>
        /// 是否自动审单
        /// </summary>
        public bool? AutoExamine { get; set; }

        /// <summary>
        /// 发货人
        /// </summary>
        public string SendName { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string SendTelPhone { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string SendMobilePhone { get; set; }
        /// <summary>
        /// 事业部编码  京东专用
        /// </summary>
        public string DeptNo { get; set; }

        /// <summary>
        /// 发货省
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 发货市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 发货区/县
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 发货详细地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string ReMark { get; set; }

        ///// <summary>
        ///// 添加第三方平台信息
        ///// </summary>
        ///// <returns></returns>
        //public virtual ShopPlatform SetPlatform(string name, string appKey, string appSecret, string httpApiUrl, bool isISV = false, string buyUrl = "")
        //{
        //    var platform = new ShopPlatform(Id, name, appKey, appSecret, httpApiUrl, isISV: isISV, buyUrl: buyUrl);
        //    if (Platform == null)
        //    {
        //        Platform = platform;
        //    }
        //    else
        //    {
        //        Platform.Name = platform.Name;
        //        Platform.AppKey = platform.AppKey;
        //        Platform.AppSecret = platform.AppSecret;
        //        Platform.HttpApiUrl = platform.HttpApiUrl;
        //        Platform.IsISV = platform.IsISV;
        //        Platform.BuyUrl = platform.BuyUrl;
        //    }
        //    return Platform;
        //}

        public virtual void UpdatePlatformSessionKey(string sessionKey)
        {
            this.Platform.SessionKey = sessionKey;
        }


    }

    

   
}
