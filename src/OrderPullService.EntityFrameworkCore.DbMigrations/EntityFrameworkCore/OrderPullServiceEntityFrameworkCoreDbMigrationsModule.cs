using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace OrderPullService.EntityFrameworkCore
{
    [DependsOn(
        typeof(OrderPullServiceEntityFrameworkCoreModule)
        )]
    public class OrderPullServiceEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<OrderPullServiceMigrationDbContext>();
        }
    }
}
