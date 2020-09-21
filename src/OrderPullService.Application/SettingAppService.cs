using OrderPullService.Setting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.SettingManagement;

namespace OrderPullService
{
    public class SettingAppService : ApplicationService, ISettingAppService
    {
        private ISettingManager _settingManager;
        public SettingAppService(ISettingManager settingManager)
        {
            _settingManager = settingManager;
        }
        public async Task<OrderPullServiceSettingDto> GetAsync()
        {
            OrderPullServiceSettingDto output = new OrderPullServiceSettingDto();
            output.EnableApproval = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.EnableApproval));
            output.EnableApprovalNoStockOrder = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.EnableApprovalNoStockOrder));

            output.LogisticsStrategy = await GetLogisticsStrategyAsync();
            output.AuditStrategy = await GetAuditStrategyAsync();
            output.ExpressPrintingStrategy = await GetExpressPrintingStrategyAsync();
            output.WarehouseStrategy = await GetWarehouseStrategyAsync();

            return output;
        }

        protected virtual async Task<OrderPullServiceWarehouseStrategyDto> GetWarehouseStrategyAsync()
        {
            OrderPullServiceWarehouseStrategyDto dto = new OrderPullServiceWarehouseStrategyDto();
            dto.MatchWarehouseAccordingToRegionInformation = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.WarehouseStrategy.MatchWarehouseAccordingToRegionInformation));
            return dto;
        }
        protected virtual async Task<OrderPullServiceExpressPrintingStrategyDto> GetExpressPrintingStrategyAsync()
        {
            OrderPullServiceExpressPrintingStrategyDto dto = new OrderPullServiceExpressPrintingStrategyDto();
            dto.PrintCount = Convert.ToInt32(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.ExpressPrintingStrategy.PrintCount));
            dto.DeliveryStepsPrinting = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.ExpressPrintingStrategy.DeliveryStepsPrinting));
            dto.OrderReceivingStepPrinting = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.ExpressPrintingStrategy.OrderReceivingStepPrinting));
            dto.SalesDeliveryStepPrinting = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.ExpressPrintingStrategy.SalesDeliveryStepPrinting));
            return dto;
        }

        protected virtual async Task<OrderPullServiceAuditStrategyDto> GetAuditStrategyAsync()
        {
            OrderPullServiceAuditStrategyDto dto = new OrderPullServiceAuditStrategyDto();
            dto.Enable = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.AuditStrategy.Enable));
            dto.CashOnDelivery = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.AuditStrategy.CashOnDelivery));
            dto.NoBuyerMessage = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.AuditStrategy.NoBuyerMessage));
            dto.NoSellerMessage = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.AuditStrategy.NoSellerMessage));
            dto.PaidOrders = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.AuditStrategy.PaidOrders));
            return dto;
        }
        protected virtual async Task<OrderPullServiceLogisticsStrategyDto> GetLogisticsStrategyAsync()
        {
            OrderPullServiceLogisticsStrategyDto dto = new OrderPullServiceLogisticsStrategyDto();
            dto.BuyerNotesMatchLogistics = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.LogisticsStrategy.BuyerNotesMatchLogistics));
            dto.ProductMatchingLogistics = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.LogisticsStrategy.ProductMatchingLogistics));
            dto.RegionalMatchingLogistics = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.LogisticsStrategy.RegionalMatchingLogistics));
            dto.SellerNotesMatchLogistics = Convert.ToBoolean(await _settingManager.GetOrNullForCurrentTenantAsync(OrderPullServiceSettings.LogisticsStrategy.SellerNotesMatchLogistics));
            return dto;
        }

        public async Task UpdateAsync(OrderPullServiceSettingDto input)
        {
            await SetForCurrentTenantAsync(OrderPullServiceSettings.EnableApproval, input.EnableApproval);
            await SetForCurrentTenantAsync(OrderPullServiceSettings.EnableApprovalNoStockOrder, input.EnableApprovalNoStockOrder);

            // AuditStrategy
            await SetForCurrentTenantAsync(OrderPullServiceSettings.AuditStrategy.CashOnDelivery, input.AuditStrategy.CashOnDelivery);
            await SetForCurrentTenantAsync(OrderPullServiceSettings.AuditStrategy.Enable, input.AuditStrategy.Enable);
            await SetForCurrentTenantAsync(OrderPullServiceSettings.AuditStrategy.NoBuyerMessage, input.AuditStrategy.NoBuyerMessage);
            await SetForCurrentTenantAsync(OrderPullServiceSettings.AuditStrategy.NoSellerMessage, input.AuditStrategy.NoSellerMessage);
            await SetForCurrentTenantAsync(OrderPullServiceSettings.AuditStrategy.PaidOrders, input.AuditStrategy.PaidOrders);

            // ExpressPrintingStrategy
            await SetForCurrentTenantAsync(OrderPullServiceSettings.ExpressPrintingStrategy.DeliveryStepsPrinting, input.ExpressPrintingStrategy.DeliveryStepsPrinting);
            await SetForCurrentTenantAsync(OrderPullServiceSettings.ExpressPrintingStrategy.OrderReceivingStepPrinting, input.ExpressPrintingStrategy.OrderReceivingStepPrinting);
            await SetForCurrentTenantAsync(OrderPullServiceSettings.ExpressPrintingStrategy.PrintCount, input.ExpressPrintingStrategy.PrintCount);
            await SetForCurrentTenantAsync(OrderPullServiceSettings.ExpressPrintingStrategy.SalesDeliveryStepPrinting, input.ExpressPrintingStrategy.SalesDeliveryStepPrinting);

            // WarehouseStrategy
            await SetForCurrentTenantAsync(OrderPullServiceSettings.WarehouseStrategy.MatchWarehouseAccordingToRegionInformation, input.WarehouseStrategy.MatchWarehouseAccordingToRegionInformation);

            // LogisticsStrategy
            await SetForCurrentTenantAsync(OrderPullServiceSettings.LogisticsStrategy.BuyerNotesMatchLogistics, input.LogisticsStrategy.BuyerNotesMatchLogistics);
            await SetForCurrentTenantAsync(OrderPullServiceSettings.LogisticsStrategy.ProductMatchingLogistics, input.LogisticsStrategy.ProductMatchingLogistics);
            await SetForCurrentTenantAsync(OrderPullServiceSettings.LogisticsStrategy.RegionalMatchingLogistics, input.LogisticsStrategy.RegionalMatchingLogistics);
            await SetForCurrentTenantAsync(OrderPullServiceSettings.LogisticsStrategy.SellerNotesMatchLogistics, input.LogisticsStrategy.SellerNotesMatchLogistics);

        }

        protected virtual async Task SetForCurrentTenantAsync(string key,object value)
        {
            await _settingManager.SetForCurrentTenantAsync(key, value.ToString());
        }
    }
}
