using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    [XMLAttribute("InvestmentAmount")]
    [XMLAttribute("YearRate")]
    [XMLAttribute("TimeType")]
    [XMLAttribute("TimeLength")]
    public class MEarnings
    {
        private double inverstmentAmount;
        /// <summary>
        /// 投资金额
        /// </summary>
        public double InvestmentAmount 
        {
            get { return inverstmentAmount; }
            set 
            {
                inverstmentAmount = value;
                inverstmentAmount *= 10000;
            }
        }

        private double yearRate;
        /// <summary>
        /// 投资年利率
        /// </summary>
        public double YearRate 
        {
            get { return yearRate; }
            set 
            {
                if (value < 0)
                    throw new Exception("年利率不能小于零！");
                yearRate = value;
                yearRate /= 100;
            }
        }

        /// <summary>
        /// 投资月利率
        /// </summary>
        public double MonthRate
        {
            get
            {
                return yearRate / 12;
            }
        }


        /// <summary>
        /// 投资日利率
        /// </summary>
        public double DayRate
        {
            get
            {
                return yearRate / 365;
            }
        }

        private TimeType timeType;
        /// <summary>
        /// 投资的时长类型
        /// </summary>
        public TimeType TimeType
        {
            get { return timeType; }
            set {timeType = value; }
        }

        private double investTimeLength;
        /// <summary>
        /// 投资时长
        /// </summary>
        public double TimeLength 
        {
            get { return investTimeLength; }
            set 
            {
                if (value <= 0)
                    throw new LessOrEquZeroException(value);
                investTimeLength = value;
            }
        }

        /// <summary>
        /// 投资收益
        /// </summary>
        /// <returns></returns>
        public double GetIncomeAmount()
        {
            if (TimeType == TimeType.Year)
                return investTimeLength * yearRate;
            else if (TimeType == TimeType.Month)
                return investTimeLength * MonthRate;
            else
                return investTimeLength * DayRate;
        }
    }
}
