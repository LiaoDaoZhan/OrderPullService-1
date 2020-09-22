using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.LaZaDaService.Dto
{
    public class TradeList
    {
        public long count { get;set; }
        public List<Trade> orders { get; set; }
    }
}
