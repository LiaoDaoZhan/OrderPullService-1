using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.TradeOrder.Dto
{
    public class TradeDetailDto : Volo.Abp.Data.IHasExtraProperties
    {
        public Dictionary<string, object> ExtraProperties { get;protected set; }
    }
}
