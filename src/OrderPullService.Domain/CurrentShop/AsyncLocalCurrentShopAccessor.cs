using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Volo.Abp.DependencyInjection;

namespace OrderPullService.CurrentShop
{
    /// <summary>
    /// 基于异步上下文的本地变量(AsyncLocal)
    /// </summary>
    public class AsyncLocalCurrentShopAccessor : ICurrentShopAccessor, ISingletonDependency
    {
        public ShopInfo Current
        {
            get => _currentScope.Value;
            set => _currentScope.Value = value;
        }

        private readonly AsyncLocal<ShopInfo> _currentScope;

        public AsyncLocalCurrentShopAccessor()
        {
            _currentScope = new AsyncLocal<ShopInfo>();
        }
    }
}
