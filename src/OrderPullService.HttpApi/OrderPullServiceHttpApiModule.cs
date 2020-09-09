using Localization.Resources.AbpUi;
using OrderPullService.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace OrderPullService
{
    [DependsOn(
        typeof(OrderPullServiceApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class OrderPullServiceHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(OrderPullServiceHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<OrderPullServiceResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
