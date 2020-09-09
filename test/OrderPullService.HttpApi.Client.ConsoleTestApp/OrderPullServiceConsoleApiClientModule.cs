using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace OrderPullService
{
    [DependsOn(
        typeof(OrderPullServiceHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class OrderPullServiceConsoleApiClientModule : AbpModule
    {
        
    }
}
