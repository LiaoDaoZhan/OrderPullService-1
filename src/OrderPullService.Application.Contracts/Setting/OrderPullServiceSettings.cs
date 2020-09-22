namespace OrderPullService
{
    public static class OrderPullServiceSettings
    {
        public const string GroupName = "OrderPullService";

        /// <summary>
        /// 免审策略
        /// </summary>
        public static class AuditStrategy
        {
            
            public const string Enable = GroupName + ".AuditPolicy.Enable";
            /// <summary>
            /// 已审核订单
            /// </summary>
            public const string PaidOrders = Enable + ".PaidOrders";
            /// <summary>
            /// 货到付款
            /// </summary>
            public const string CashOnDelivery = Enable + ".CashOnDelivery";
            /// <summary>
            /// 无买家留言
            /// </summary>
            public const string NoBuyerMessage = Enable + ".NoBuyerMessage";
            /// <summary>
            /// 无卖家留言
            /// </summary>
            public const string NoSellerMessage = Enable + ".NoSellerMessage";
        }

        /// <summary>
        /// 启用审批
        /// </summary>
        public const string EnableApproval=GroupName+ ".EnableApproval";


        /// <summary>
        /// 是否允许无货订单进行审批
        /// </summary>
        public const string EnableApprovalNoStockOrder = GroupName + ".EnableApprovalNoStockOrder";

        /// <summary>
        /// 仓库策略
        /// </summary>
        public static class WarehouseStrategy
        {

            const string Name = GroupName+ ".WarehouseStrategy";

            /// <summary>
            /// 按照区域信息匹配仓库
            /// </summary>
            public const string MatchWarehouseAccordingToRegionInformation = Name + ".MatchWarehouseAccordingToRegionInformation";

        }

        /// <summary>
        /// 物流策略
        /// </summary>
        public static class LogisticsStrategy
        {

            const string Name = GroupName + ".LogisticsStrategy";
            
            /// <summary>
            /// 卖家备注匹配物流
            /// </summary>
            public const string SellerNotesMatchLogistics = Name + ".SellerNotesMatchLogistics";

            /// <summary>
            /// 商品信息匹配物流
            /// </summary>
            public const string ProductMatchingLogistics = Name + ".ProductMatchingLogistics";
            /// <summary>
            /// 区域匹配物流
            /// </summary>
            public const string RegionalMatchingLogistics = Name + ".RegionalMatchingLogistics";
            /// <summary>
            /// 买家备注匹配物流
            /// </summary>
            public const string BuyerNotesMatchLogistics = Name + ".BuyerNotesMatchLogistics";

        }

        /// <summary>
        /// 快递打印策略
        /// </summary>
        public static class ExpressPrintingStrategy
        {
            const string Name = GroupName+ ".ExpressPrintingStrategy";
            /// <summary>
            /// 快递打印次数
            /// </summary>
            public const string PrintCount = Name + ".PrintCount";
            /// <summary>
            /// 接单步骤打印
            /// </summary>
            public const string OrderReceivingStepPrinting = Name+ ".OrderReceivingStepPrinting";
            
            /// <summary>
            /// 销售出库步骤打印
            /// </summary>
            public const string SalesDeliveryStepPrinting = Name + ".SalesDeliveryStepPrinting";

            /// <summary>
            /// 发货步骤打印
            /// </summary>
            public const string DeliveryStepsPrinting = Name + ".DeliveryStepsPrinting";


        }



    }
}