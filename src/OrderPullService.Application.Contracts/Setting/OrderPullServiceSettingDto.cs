using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.Setting
{
    public class OrderPullServiceSettingDto
    {
        public bool EnableApproval { get; set; }

        public bool EnableApprovalNoStockOrder { get; set; }


        public OrderPullServiceLogisticsStrategyDto LogisticsStrategy { get; set; }

        public OrderPullServiceAuditStrategyDto AuditStrategy { get; set; }

        public OrderPullServiceWarehouseStrategyDto WarehouseStrategy { get; set; }

        public OrderPullServiceExpressPrintingStrategyDto ExpressPrintingStrategy { get; set; }
    }

    public class OrderPullServiceExpressPrintingStrategyDto
    {
        public int PrintCount { get; set; }

        public bool OrderReceivingStepPrinting { get; set; }

        public bool SalesDeliveryStepPrinting { get; set; }

        public bool DeliveryStepsPrinting { get; set; }
    }

    public class OrderPullServiceWarehouseStrategyDto
    {
        public bool MatchWarehouseAccordingToRegionInformation { get; set; }
    }

    public class OrderPullServiceLogisticsStrategyDto
    {
        public bool SellerNotesMatchLogistics { get; set; }

        public bool ProductMatchingLogistics { get; set; }

        public bool RegionalMatchingLogistics { get; set; }

        public bool BuyerNotesMatchLogistics { get; set; }
    }

    public class OrderPullServiceAuditStrategyDto
    {
        public bool PaidOrders { get; set; }

        public bool CashOnDelivery { get; set; }

        public bool NoBuyerMessage { get; set; }

        public bool NoSellerMessage { get; set; }
        public bool Enable { get; set; }
    }
}
