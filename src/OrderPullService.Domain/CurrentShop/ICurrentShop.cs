using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.CurrentShop
{
    /// <summary>
    /// 当前店铺信息
    /// </summary>
    public interface ICurrentShop
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// 店铺平台
        /// </summary>
        public ShopPlatformType Platform { get; }
        /// <summary>
        /// 当前店铺Key信息
        /// </summary>
        public string AppKey { get; }
        /// <summary>
        /// 当前店铺秘钥
        /// </summary>
        public string AppSecret { get; }
        /// <summary>
        /// 当前店铺会话
        /// </summary>
        public string AppSessionKey { get; }
        /// <summary>
        /// Api请求地址
        /// </summary>
        public string ApiUrl { get; }

        /// <summary>
        /// 更改店铺信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public IDisposable Change(Guid id);
        /// <summary>
        /// 更改店铺信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="AppKey"></param>
        /// <param name="AppSecret"></param>
        /// <param name="AppSessionKey"></param>
        /// <returns></returns>
        public IDisposable Change(Guid id,  string name, ShopPlatformType platform, string AppKey, string AppSecret, string AppSessionKey);
    }
}
