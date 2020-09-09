using OrderPullService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OrderPullService
{
    public abstract class OrderPullServiceController : AbpController
    {
        protected OrderPullServiceController()
        {
            LocalizationResource = typeof(OrderPullServiceResource);
        }
    }
}
