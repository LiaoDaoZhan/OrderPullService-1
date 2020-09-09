using OrderPullService.Localization;
using Volo.Abp.Application.Services;

namespace OrderPullService
{
    public abstract class OrderPullServiceAppService : ApplicationService
    {
        protected OrderPullServiceAppService()
        {
            LocalizationResource = typeof(OrderPullServiceResource);
            ObjectMapperContext = typeof(OrderPullServiceApplicationModule);
        }
    }
}
