using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depositer.Lib
{
    public class DateTimeExtension
    {
        /// <summary>
        /// 返回time.yyyy-time.MM-1日期
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static DateTime ReturnYearMonth(DateTime time)
        {
            return new DateTime(time.Year, time.Month,1);
        }
    }
}
