using OrderPullService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OrderPullService
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(OrderPullServiceEntityFrameworkCoreTestModule)
        )]
    public class OrderPullServiceDomainTestModule : AbpModule
    {
        
    }
}
