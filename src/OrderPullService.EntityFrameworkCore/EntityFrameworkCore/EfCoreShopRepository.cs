using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderPullService.CurrentShop;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OrderPullService.EntityFrameworkCore
{
    public class EfCoreShopRepository : EfCoreRepository<IOrderPullServiceDbContext, Shop, Guid>, IShopRepository
    {
        public EfCoreShopRepository(IDbContextProvider<IOrderPullServiceDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
        public Task<Shop> FindAsync(Guid id)
        {
            return GetQueryable().AsNoTracking().Include(c => c.Platform).FirstOrDefaultAsync(c => c.Id == id);
        }

       

        public Task<Shop> FindAsync(string name)
        {
            return GetQueryable().AsNoTracking().Include(c => c.Platform).FirstOrDefaultAsync(c => c.Name == name);
        }

        public async Task<ShopInfo> FindShopInfoAsync(Guid id)
        {
            var shop = await GetQueryable().AsNoTracking().Include(c => c.Platform).Where(c => c.Id == id).FirstOrDefaultAsync();
            if (shop == null)
                return null;

            var shopInfo= new ShopInfo(shop.Id, shop.Name,shop.ShopPlatformType, shop.Platform.AppKey, shop.Platform.AppSecret, shop.Platform.SessionKey);
            shopInfo.TenantId = shop.TenantId;
            return shopInfo;
        }
    }
}
