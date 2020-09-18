using Volo.Abp.Settings;

namespace OrderPullService
{
    /* These setting definitions will be visible to clients that has a OrderManagement.Application.Contracts
     * reference. Settings those should be hidden from clients should be defined in the OrderManagement.Application
     * package.
     */
    public class OrderPullServiceSettingDefinitionProvider : SettingDefinitionProvider {
        public override void Define (ISettingDefinitionContext context) {

            // 审核策略
            context.Add (new SettingDefinition (OrderPullServiceSettings.AuditStrategy.Enable, true.ToString()));

            context.Add(new SettingDefinition(OrderPullServiceSettings.AuditStrategy.NoBuyerMessage, true.ToString()));

            context.Add(new SettingDefinition(OrderPullServiceSettings.AuditStrategy.NoSellerMessage, true.ToString()));

            context.Add(new SettingDefinition(OrderPullServiceSettings.AuditStrategy.NoSellerMessage, true.ToString()));

            context.Add(new SettingDefinition(OrderPullServiceSettings.AuditStrategy.CashOnDelivery, false.ToString()));

            context.Add(new SettingDefinition(OrderPullServiceSettings.AuditStrategy.PaidOrders, true.ToString()));

            // 启用审批 通常是审批流 这里是单流程审批
            context.Add(new SettingDefinition(OrderPullServiceSettings.EnableApproval, true.ToString()));

            // 是否允许无货订单进行审批
            context.Add(new SettingDefinition(OrderPullServiceSettings.EnableApprovalNoStockOrder, false.ToString()));

            // 仓库策略
            context.Add(new SettingDefinition(OrderPullServiceSettings.WarehouseStrategy.MatchWarehouseAccordingToRegionInformation,false.ToString()));

            // 物流策略
            context.Add(new SettingDefinition(OrderPullServiceSettings.LogisticsStrategy.BuyerNotesMatchLogistics, false.ToString()));
            context.Add(new SettingDefinition(OrderPullServiceSettings.LogisticsStrategy.ProductMatchingLogistics, false.ToString()));
            context.Add(new SettingDefinition(OrderPullServiceSettings.LogisticsStrategy.RegionalMatchingLogistics, false.ToString()));
            context.Add(new SettingDefinition(OrderPullServiceSettings.LogisticsStrategy.SellerNotesMatchLogistics, false.ToString()));

            // 快递打印策略
            context.Add(new SettingDefinition(OrderPullServiceSettings.ExpressPrintingStrategy.PrintCount, "1"));
            context.Add(new SettingDefinition(OrderPullServiceSettings.ExpressPrintingStrategy.SalesDeliveryStepPrinting, false.ToString()));
            context.Add(new SettingDefinition(OrderPullServiceSettings.ExpressPrintingStrategy.OrderReceivingStepPrinting,false.ToString()));
            context.Add(new SettingDefinition(OrderPullServiceSettings.ExpressPrintingStrategy.DeliveryStepsPrinting,false.ToString()));

        }
    }
}