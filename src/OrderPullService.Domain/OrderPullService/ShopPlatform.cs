using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace OrderPullService
{
    /// <summary>
    /// 商店对应的平台信息包含对接api等信息
    /// </summary>
    [Owned]
    public class ShopPlatform
    {
        public ShopPlatform()
        {

        }
        public ShopPlatform(Guid shopId, string name, string appKey, string appSecret, string httpApiUrl, string sessionKey="", bool isISV=false, string buyUrl="")
        {
            ShopId = shopId;
            Name = name;
            IsISV = isISV;
            BuyUrl = buyUrl;
            AppKey = appKey;
            AppSecret = appSecret;
            HttpApiUrl = httpApiUrl;
            SessionKey = sessionKey;
        }

        public Guid ShopId { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否是服务商
        /// </summary>
        public bool IsISV { get; set; } = false;

        /// <summary>
        /// 订购链接--是服务商才用
        /// </summary>
        public string BuyUrl { get; set; }
        /// <summary>
        /// key
        /// </summary>
        public string AppKey { get; set; }
        /// <summary>
        /// 秘钥
        /// </summary>
        public string AppSecret { get; set; }
        /// <summary>
        /// api请求地址
        /// </summary>
        public string HttpApiUrl { get; set; }

        public string SessionKey { get; set; }


        //public override object[] GetKeys()
        //{
        //    //一个店铺只允许一个对接信息
        //    return new object[] { ShopId, Id };
        //}
    }
}
