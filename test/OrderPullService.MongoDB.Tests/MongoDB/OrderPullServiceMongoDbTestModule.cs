using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace OrderPullService.MongoDB
{
    [DependsOn(
        typeof(OrderPullServiceTestBaseModule),
        typeof(OrderPullServiceMongoDbModule)
        )]
    public class OrderPullServiceMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionString = MongoDbFixture.ConnectionString.EnsureEndsWith('/') +
                                   "Db_" +
                                    Guid.NewGuid().ToString("N");

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}