using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.XhsService
{
    public class TradeList
    {
        /// <summary>
        /// 查询当前页，从1开始计数
        /// </summary>
        public int current_page { get; set; }
        /// <summary>
        /// 分页大小，默认50
        /// </summary>
        public int page_size { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int total_page { get; set; }
        /// <summary>
        /// 结果总数
        /// </summary>
        public int total_number { get; set; }
        /// <summary>
        /// 订单列表
        /// </summary>
        public List<Trade> package_list { get; set; }

    }
}
