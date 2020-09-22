using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace OrderPullService.Data
{
    public class OrderPullServiceDataSeeder : IDataSeedContributor, ITransientDependency
    {
        public IRepository<Shop, Guid> Shop { get; set; }
        //public OrderPullServiceDataSeeder(IRepository<Shop, Guid> shop)
        //{
        //    _shop = shop;
        //}
        public async Task SeedAsync(DataSeedContext context)
        {
            if (!(await Shop.AnyAsync()))
            {
                var shop = new Shop();
                shop.Name = "测试的店铺";
                shop.Platform = new ShopPlatform
                {
                    AppKey = "23710332",
                    AppSecret = "e7c54c38fc070f12d3e8650b876d8ef2",
                    SessionKey = "6102b04e52ae12d3dfdbcf8f6bd8727805b2fd3d9cd16234072237246"
                };
                shop.ShopPlatformType = ShopPlatformType.TMall;
                await Shop.InsertAsync(shop);
            }
        }
    }
}
