using Elsa.Expressions;
using Elsa.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.Workflows
{
    public class CustomerServiceExpression:Volo.Abp.MultiTenancy.IMultiTenant, IWorkflowExpression<CustomerServiceExpression>
    {
        /// <summary>
        /// 交易订单Id
        /// </summary>
        public Guid TradeId { get; set; }
        /// <summary>
        /// 租户id
        /// </summary>
        public Guid? TenantId { get; set; }

        public string Syntax => "CustomerService";

        public string Expression => throw new NotImplementedException();
    }
}
