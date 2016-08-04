using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    [XMLAttribute("InvestmentAmount")]
    public class MInvestment:MBase
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

        /// <summary>
        /// 投资月利率
        /// </summary>
        public double MonthRate
        {
            get
            {
                return YearRate / 12;
            }
        }


        /// <summary>
        /// 投资日利率
        /// </summary>
        public double DayRate
        {
            get
            {
                return YearRate / 365;
            }
        }

        /// <summary>
        /// 投资收益
        /// </summary>
        /// <returns></returns>
        public double GetIncomeAmount()
        {
            if (TimeType == TimeType.Year)
                return timelength * YearRate;
            else if (TimeType == TimeType.Month)
                return timelength * MonthRate;
            else
                return timelength * DayRate;
        }
    }
}
