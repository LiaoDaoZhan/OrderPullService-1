using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
// 引用这个类实现对扩展属性的管理
using Volo.Abp.ObjectExtending;

namespace OrderPullService.CurrentShop
{
    /// <summary>
    /// 店铺信息
    /// </summary>
    public class ShopInfo: IHasExtraProperties
    {
        public ShopInfo(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        public ShopInfo(Guid id, string name, string appKey, string appSecret, string appSessionKey)
        {
            Id = id;
            Name = name;
            AppKey = appKey;
            AppSecret = appSecret;
            AppSessionKey = appSessionKey;
        }

        public string Name { get; set; }

        public string Platform { get; set; }

        public Guid Id { get; set; }

        public string AppKey { get; set; }

        public string AppSecret { get; set; }

        public string AppSessionKey { get; set; }
        /// <summary>
        /// 扩展属性
        /// </summary>
        public Dictionary<string, object> ExtraProperties { get; protected set; }
    }
}
