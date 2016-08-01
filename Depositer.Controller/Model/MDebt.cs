using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    [XMLAttribute("SumDebt")]
    [XMLAttribute("YearRate")]
    [XMLAttribute("TimeType")]
    [XMLAttribute("TimeLength")]
    [XMLAttribute("DebtType")]  
    public abstract class MDebt
    {
        private double sumDebt = 0d;

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

        private double yearRate;
        /// <summary>
        /// 贷款年利率
        /// 异常 LessOrEquZeroException
        /// </summary>
        public double YearRate 
        {
            get { return yearRate; }
            set
            {
                if (value < 0)
                    throw new LessOrEquZeroException(value);
                yearRate = value;
                yearRate /= 100;
            }
        }

        /// <summary>
        /// 贷款月利率
        /// </summary>
        public double MonthDebtRate 
        {
            get { return YearRate / 12; }
        }

        protected double timelength;
        /// <summary>
        /// 贷款时长
        /// 异常 LessOrEquZeroException
        /// </summary>
        public double TimeLength 
        {
            get { return timelength; }
            set
            {
                if (value <= 0)
                    throw new LessOrEquZeroException(value);
                timelength = value;
                //if (TimeType == TimeType.Year) debtMonths = value * 12;
                //else if (TimeType == TimeType.Day) debtMonths = value / 30;
                //else if (TimeType == TimeType.Month) debtMonths = value;
            }
        }

        /// <summary>
        /// 贷款类型
        /// </summary>
        public DebtType DebtType { get; set; }

        /// <summary>
        /// 贷款时间类型
        /// </summary>
        public TimeType TimeType { get; set; }

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public abstract double GetSumPayment();

        /// <summary>
        /// 获取在某个月时已经还款的总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public abstract double FinishedPaymentAt(int monthIndex);

        /// <summary>
        /// 剩余还款总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public abstract double LeftDebtAt(int monthIndex);       
    }
}
