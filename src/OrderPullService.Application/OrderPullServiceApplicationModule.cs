using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Z.EntityFramework.Extensions;
using OrderPullService.EntityFrameworkCore;

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

            // 批量操作的上下文工厂 避免单次插入订单量过大 这里采取批量插入 提升效率
            EntityFrameworkManager.ContextFactory = dbcontext => context.Services.GetServiceLazy<OrderPullServiceDbContext>().Value;
            
        }
    }
}
