using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.XhsService
{
    /// <summary>
    /// 请求返回结果
    /// </summary>
    internal class XhsResponse
    {
        public bool success { get; set; }
        /// <summary>
        /// 交易数据信息
        /// </summary>
        public string data { get; set; }
        public int error_code { get; set; }
        public string error_msg { get; set; }
    }

}
