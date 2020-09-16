using OrderPullService.CurrentShop;
using OrderPullService.Localization;
using Volo.Abp.Application.Services;

namespace OrderPullService
{
    public abstract class OrderPullServiceAppService : ApplicationService
    {
        private ICurrentShop _currentShop;
        /// <summary>
        /// 当前店铺信息
        /// </summary>
        public ICurrentShop CurrentShop => LazyGetRequiredService(ref _currentShop);

        protected OrderPullServiceAppService()
        {
            LocalizationResource = typeof(OrderPullServiceResource);
            ObjectMapperContext = typeof(OrderPullServiceApplicationModule);
        }
    }
}
