using OrderPullService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OrderPullService.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(OrderPullServiceEntityFrameworkCoreDbMigrationsModule)
        )]
    public class OrderPullServiceDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
