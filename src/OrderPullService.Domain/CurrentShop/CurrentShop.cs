using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Threading;

namespace OrderPullService.CurrentShop
{
    /// <summary>
    /// 获取当前店铺的实现
    /// </summary>
    public class CurrentShop : ICurrentShop, Volo.Abp.DependencyInjection.ITransientDependency
    {
        protected IShopRepository ShopRepository { get; }

        public CurrentShop(IShopRepository shopRepository)
        {
            ShopRepository = shopRepository;
        }

#if SANBOX
      public string ApiUrl => "http://gw.api.tbsandbox.com/router/rest"; 
#else
        public string ApiUrl => "http://gw.api.taobao.com/router/rest";
#endif

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string Name => _currentShopAccessor.Current.Name;
        /// <summary>
        /// 第三方平台
        /// </summary>
        public ShopPlatformType Platform => _currentShopAccessor.Current.Platform;

        public string AppKey => _currentShopAccessor.Current.AppKey;

        public string AppSecret => _currentShopAccessor.Current.AppSecret;

        public string AppSessionKey => _currentShopAccessor.Current.AppSessionKey;

        public virtual Guid Id => _currentShopAccessor.Current.Id;

        private readonly ICurrentShopAccessor _currentShopAccessor;

        public CurrentShop(ICurrentShopAccessor currentShopAccessor)
        {
            _currentShopAccessor = currentShopAccessor;
        }

        public IDisposable ChangeAsync(Guid id)
        {
            //获取新的店铺key和秘钥
            var parentScope = _currentShopAccessor.Current;
            _currentShopAccessor.Current = AsyncHelper.RunSync(() => ShopRepository.FindShopInfoAsync(id));
            return new DisposeAction(() =>
            {
                _currentShopAccessor.Current = parentScope;
            });
        }

        //public IDisposable SetCurrentShop(Guid id, string name = null)
        //{
        //    //获取新的店铺key和秘钥
        //    var parentScope = _currentShopAccessor.Current;
        //    _currentShopAccessor.Current = new ShopInfo(id, name);
        //    return new DisposeAction(() =>
        //    {
        //        _currentShopAccessor.Current = parentScope;
        //    });
        //}

        public IDisposable Change(Guid id, string name, ShopPlatformType platform, string appKey, string appSecret, string appSessionKey)
        {
            //获取新的店铺key和秘钥
            var parentScope = _currentShopAccessor.Current;
            _currentShopAccessor.Current = new ShopInfo(id, name, platform, appKey, appSecret, appSessionKey);
            return new DisposeAction(() =>
            {
                _currentShopAccessor.Current = parentScope;
            });
        }
    }
}
