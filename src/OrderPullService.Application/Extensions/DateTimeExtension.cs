using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPullService.Extensions
{
    public static class DateTimeExtension
    {
        /// <summary>
        /// 转换指定时间得到对应的时间戳
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="millisecond">精度（毫秒）设置 true，则生成13位的时间戳；精度（秒）设置为 false，则生成10位的时间戳；默认为 true </param>
        /// <returns>返回对应的时间戳</returns>
        public static long ToTimestampLong(this DateTime dateTime, bool millisecond = true)
        {
            var ts = dateTime.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return millisecond ? Convert.ToInt64(ts.TotalMilliseconds) : Convert.ToInt64(ts.TotalSeconds);
        }
    }
}
