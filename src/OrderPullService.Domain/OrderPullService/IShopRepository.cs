using OrderPullService.CurrentShop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace OrderPullService
{

    public interface IShopRepository : IRepository<Shop, Guid>
    {
        Task<Shop> FindAsync(Guid id);

        Task<Shop> FindAsync(string name);

        Task<ShopInfo> FindShopInfoAsync(Guid id);
    }
}
