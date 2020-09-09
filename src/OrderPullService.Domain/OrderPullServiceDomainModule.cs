using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace OrderPullService
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(OrderPullServiceDomainSharedModule)
    )]
    public class OrderPullServiceDomainModule : AbpModule
    {

    }
}
