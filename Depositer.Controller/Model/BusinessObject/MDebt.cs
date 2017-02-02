using Depositer.Controller.Model.BusinessObject;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    /// <summary>
    /// 
    /// </summary>
    [XMLAttribute("SumDebt")]
    [XMLAttribute("DebtType")]  
    [XMLAttribute("OnDebtTime")]
    [XMLAttribute("BigTimes")]
    public abstract class MDebt:MRoot,IMRoot
    {
        protected double sumDebt = 0d;

        /// <summary>
        /// 总贷款数
        /// 异常 LessOrEquZeroException
        /// </summary>
        public double SumDebt
        {
            get { return sumDebt; }
            set
            {
                if (value <= 0)
                    throw new LessOrEquZeroException(value);
                sumDebt = value;
            }
        }

        /// <summary>
        /// 贷款月利率
        /// </summary>
        public double MonthDebtRate 
        {
            get { return YearRate / 12; }
        }

        /// <summary>
        /// 贷款日期
        /// </summary>
        public DateTime OnDebtTime { get; set; }

        /// <summary>
        /// 贷款类型
        /// </summary>
        public DebtType DebtType { get; set; }

        /// <summary>
        /// 时间从还款日算起（默认）是第几个月
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public int GetMonthIndex(DateTime time)
        {
            if (time < OnDebtTime)
                return 0;
                //throw new ArgumentException("开始还贷时间在当前时间后！");
            var time1 = DateTime.Parse(time.ToString("yyyy-MM-01"));
            var tmptime = OnDebtTime;
            int i = 0;
            while (tmptime < time1)
            {
                tmptime = tmptime.AddMonths(1);
                ++i;
            }
            return i;
        }

        /// <summary>
        /// 时间从大额还款日算起（默认）是第几个月
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public int GetMonthIndex(DateTime startTime, DateTime time)
        {
            if (time < OnDebtTime)
                throw new ArgumentException("月索引小于0");
            if (time < startTime)
                throw new ArgumentException("前者时间不能大于后者");
            var time1 = new DateTime(time.Year, time.Month, 1);
            var tmptime = startTime;
            int i = 0;
            while (tmptime < time1)
            {
                tmptime = tmptime.AddMonths(1);
                ++i;
            }
            return i;
        }

       
    }
}
