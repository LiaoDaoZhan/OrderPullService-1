using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace OrderPullService
{
    [DependsOn(
        typeof(OrderPullServiceDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class OrderPullServiceApplicationContractsModule : AbpModule
    {

    }
}
