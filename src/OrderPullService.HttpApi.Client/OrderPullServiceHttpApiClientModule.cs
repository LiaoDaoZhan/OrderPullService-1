using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace OrderPullService
{
    [DependsOn(
        typeof(OrderPullServiceApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class OrderPullServiceHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "OrderPullService";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(OrderPullServiceApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
