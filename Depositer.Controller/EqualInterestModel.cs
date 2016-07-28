using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depositer.Controller
{
    public class EqualInterestModel : DebtModel
    {
        /// <summary>
        /// 获取某个月的还款金额
        /// </summary>        
        /// <returns></returns>
        public double PaymentAmountMonth()
        {
            return SumDebt * MonthDebtRate * Math.Pow
               ((1 + MonthDebtRate), DebtMonths) / ((Math.Pow
               ((1 + MonthDebtRate), DebtMonths)) - 1);
        }

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public override double GetSumPaymentAmount()
        {
            return PaymentAmountMonth() * DebtMonths;
        }

        /// <summary>
        /// 获取在某个月时已经还款的总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double FinishedPaymentAmountAt(int monthIndex)
        {
            return monthIndex * PaymentAmountMonth();
        }

        /// <summary>
        /// 剩余还款总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double LeftDebtAt(int monthIndex)
        {
            return GetSumPaymentAmount() - FinishedPaymentAmountAt(monthIndex);
        }

    }
}
