using Volo.Abp.Modularity;

namespace OrderPullService
{
    [DependsOn(
        typeof(OrderPullServiceApplicationModule),
        typeof(OrderPullServiceDomainTestModule)
        )]
    public class OrderPullServiceApplicationTestModule : AbpModule
    {

    }
}
