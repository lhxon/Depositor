using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depositer.Controller.Model
{
    public class MEarnings
    {
        /// <summary>
        /// 投资金额
        /// </summary>
        public double InvestmentAmount { get; set; }

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
            }
        }

        private double monthRate;
        /// <summary>
        /// 投资月利率
        /// </summary>
        public double MonthRate
        {
            get
            {
                monthRate = yearRate / 12;
                return monthRate;
            }
        }

        private double dayRate;
        /// <summary>
        /// 投资日利率
        /// </summary>
        public double DayRate
        {
            get
            {
                dayRate = yearRate / 365;
                return dayRate;
            }
        }

        private TimeType investTimeType;
        /// <summary>
        /// 投资的时长类型
        /// </summary>
        public TimeType InverstTimeType
        {
            get { return InverstTimeType; }
            set { investTimeType = value; }
        }

        private double investTimeLength;
        /// <summary>
        /// 投资时长
        /// </summary>
        public double InvestTimeLength 
        {
            get { return investTimeLength; }
            set 
            {
                if(value<0)
                    throw new Exception("投资时长不能小于零！");
                 investTimeLength = value;
            }
        }

        private double incomeAmount;
        /// <summary>
        /// 收益
        /// </summary>
        public double IncomeAmount 
        {
            get {return incomeAmount;}
            set 
            {
                incomeAmount = getIncomeAmount();
                incomeAmount = value;
            }
        }

        /// <summary>
        /// 投资收益
        /// </summary>
        /// <returns></returns>
        private double getIncomeAmount()
        {
            if (InverstTimeType == TimeType.Year)
                return investTimeLength * yearRate;
            else if (InverstTimeType == TimeType.Month)
                return investTimeLength * monthRate;
            else
                return investTimeLength * dayRate;
        }
    }
}
