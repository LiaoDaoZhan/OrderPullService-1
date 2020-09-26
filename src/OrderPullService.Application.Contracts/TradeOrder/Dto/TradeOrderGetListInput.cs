using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OrderPullService.TradeOrder.Dto
{
    /// <summary>
    /// 交易订单获取请求参数
    /// </summary>
    public class TradeOrderGetListInput : PagedResultRequestDto
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 交易状态
        /// <see cref="https://open.taobao.com/doc.htm?docId=102856&docType=1"/>
        /// </summary>
        public string Status { get; set; }
        ///// <summary>
        ///// 页码
        ///// </summary>
        public int PageNo { get; set; }
        ///// <summary>
        ///// 最大返回数量
        ///// </summary>
        public int PageSize { get; set; }
    }
}
