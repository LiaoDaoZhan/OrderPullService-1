using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace OrderPullService
{
    [DependsOn(
        typeof(OrderPullServiceDomainModule),
        typeof(OrderPullServiceApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class OrderPullServiceApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<OrderPullServiceApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<OrderPullServiceApplicationModule>(validate: true);
            });
        }
    }
}
