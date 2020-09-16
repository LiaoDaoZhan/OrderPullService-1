using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace OrderPullService
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(OrderPullServiceDomainSharedModule),
        typeof(Volo.Abp.EntityFrameworkCore.AbpEntityFrameworkCoreModule),
         typeof(AbpTenantManagementDomainModule)
    )]
    public class OrderPullServiceDomainModule : AbpModule
    {

    }
}
