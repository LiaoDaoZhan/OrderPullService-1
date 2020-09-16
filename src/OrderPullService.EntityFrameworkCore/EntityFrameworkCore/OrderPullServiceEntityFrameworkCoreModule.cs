using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OrderPullService.EntityFrameworkCore
{
    [DependsOn(
        typeof(OrderPullServiceDomainModule),
        typeof(AbpEntityFrameworkCoreModule),
        typeof(Volo.Abp.TenantManagement.EntityFrameworkCore.AbpTenantManagementEntityFrameworkCoreModule)
    )]
    public class OrderPullServiceEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<OrderPullServiceDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<Shop, EfCoreShopRepository>();
            });

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer();

            });
        }
    }
}