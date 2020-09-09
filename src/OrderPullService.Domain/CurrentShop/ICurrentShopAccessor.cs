using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.CurrentShop
{
    /// <summary>
    /// 当前店铺访问
    /// </summary>
    public interface ICurrentShopAccessor
    {
        ShopInfo Current { get; set; }
    }

    
}
