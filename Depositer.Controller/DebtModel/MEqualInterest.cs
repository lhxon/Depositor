using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depositer.Controller.Model
{
    /// <summary>
    /// 等额本息还款
    /// </summary>
    public class EqualInterestModel : DebtModel
    {
        /// <summary>
        /// 某个月偿还的本金
        /// </summary>
        public double PaymentCaptialMonth(int monthIndex)
        {
            return PaymentMonth - PaymentInterestMonth(monthIndex);
        }

        /// <summary>
        /// 某个月偿还的利息
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public double PaymentInterestMonth(int monthIndex)
        {
            return (SumDebt - (monthIndex - 1) * PaymentMonth) * MonthDebtRate;
        }


        /// <summary>
        /// 获取某个月的还款金额
        /// </summary>        
        public double PaymentMonth
        {
            get
            {
                var payment = SumDebt * MonthDebtRate * Math.Pow
                ((1 + MonthDebtRate), DebtMonths) / ((Math.Pow
                ((1 + MonthDebtRate), DebtMonths)) - 1);
                if (payment < 0)
                    throw new Exception("还款金额不能小于零！");
                return payment;
            }

        }

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public override double GetSumPayment()
        {
            return PaymentMonth * DebtMonths;
        }

        /// <summary>
        /// 获取在某个月时已经还款的总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double FinishedPaymentAt(int monthIndex)
        {
            return monthIndex * PaymentMonth;
        }

        /// <summary>
        /// 剩余还款总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double LeftDebtAt(int monthIndex)
        {
            return GetSumPayment() - FinishedPaymentAt(monthIndex);
        }

    }
}
