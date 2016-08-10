using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    [XMLAttribute("InvestmentAmount")]
    [XMLAttribute("MakingMoneyMonth")]
    [XMLAttribute("Saving")]
    public class MInvestment:MRoot
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
                return TimeLength * YearRate;
            else if (TimeType == TimeType.Month)
                return TimeLength * MonthRate;
            else
                return TimeLength * DayRate;
        }

        /// <summary>
        /// 月盈余数额
        /// </summary>
        public double MakingMoneyMonth { get; set; }

        /// <summary>
        /// 积蓄
        /// </summary>
        public double Saving { get; set; }
    }
}
