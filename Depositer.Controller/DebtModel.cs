using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depositer.Controller
{

    public abstract class DebtModel
    {
        /// <summary>
        /// 总贷款数
        /// </summary>
        public double SumDebt { get; set; }

        /// <summary>
        /// 每月偿还的本金
        /// </summary>
        public double PaymentCapitalMonth { get; virtual protected set; }

        /// <summary>
        /// 每月偿还的利息
        /// </summary>
        public double PaymentInterestMonth { get; virtual protected set; }

        /// <summary>
        /// 贷款年利率
        /// </summary>
        public double YearDebtRate { get; set; }

        /// <summary>
        /// 贷款月利率
        /// </summary>
        public double MonthDebtRate 
        {
            get { return YearDebtRate / 12; }
        }

        /// <summary>
        /// 贷款总年数
        /// </summary>
        public int DebtYears { get; set; }

        /// <summary>
        /// 贷款总月数
        /// </summary>
        public int DebtMonths
        {
            get { return DebtYears * 12; }
        }

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public abstract double GetSumPaymentAmount();

        /// <summary>
        /// 获取在某个月时已经还款的总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public abstract double FinishedPaymentAmountAt(int monthIndex);

        /// <summary>
        /// 剩余还款总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public abstract double LeftDebtAt(int monthIndex);

    }
}
