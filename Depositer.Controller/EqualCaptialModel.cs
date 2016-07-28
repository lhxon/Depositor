using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depositer.Controller
{
    /// <summary>
    /// 等额本金还款
    /// </summary>
    public class EqualCaptialModel:DebtModel
    {
        /// <summary>
        /// 获取某个月的还款金额
        /// </summary>
        /// <param name="monthIndex">还款月的编号，从1开始</param>
        /// <returns></returns>
        public double PaymentAmountAt(int monthIndex)
        {
            PaymentCapitalMonth = SumDebt / DebtMonths; //还款本金是不变的
            PaymentInterestMonth = (SumDebt - (monthIndex - 1) * PaymentCapitalMonth) * MonthDebtRate;
            return PaymentCapitalMonth + PaymentInterestMonth;
        }

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public override double GetSumPaymentAmount()
        {
            double sumPaymentAmount = 0.0;
            for (int i = 0; i < DebtMonths; i++)
            {              
                sumPaymentAmount += PaymentAmountAt(i + 1);
            }
            return sumPaymentAmount;
        }

        /// <summary>
        /// 获取在某个月时已经还款的总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double FinishedPaymentAmountAt(int monthIndex)
        {
            double paymentAmount = 0.0;
            for (int i = 0; i < monthIndex; i++)
            {
                paymentAmount += PaymentAmountAt(i + 1);
            }
            return paymentAmount;
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

        /// <summary>
        /// 显示某个月的下一个月的还款额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public double ShowPaymentAmountNextTo(int monthIndex)
        {
            double capital = 0.0;
            double interest = 0.0;
            capital = SumDebt / DebtMonths; //还款本金是不变的
            interest = (SumDebt - monthIndex * capital) * MonthDebtRate;
            return capital + interest;
        }

        /// <summary>
        /// 显示某个月的下多个月的还款额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <param name="showMonths"></param>
        /// <returns></returns>
        public List<double> ShowPaymentAmountNextTo(int monthIndex,int showMonths)
        {
            var rtnList = new List<double>();
            for (int i = 0; i < showMonths; i++)
            {
                rtnList.Add(ShowPaymentAmountNextTo(monthIndex + i));
            }
            return rtnList;
        }
    }
}
