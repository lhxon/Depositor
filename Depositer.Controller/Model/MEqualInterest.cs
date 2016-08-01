﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    /// <summary>
    /// 等额本息还款
    /// </summary>
    public class MEqualInterest : MDebt
    {

        /// <summary>
        /// 获取某个月的还款金额
        /// </summary>        
        public override double PaymentAt(int monthIndex)
        {
            var payment = SumDebt * MonthDebtRate * Math.Pow((1 + MonthDebtRate), timelength) /
                ((Math.Pow((1 + MonthDebtRate), timelength)) - 1);
            if (payment < 0)
                throw new Exception("还款金额不能小于零！");
            return payment;
        }

        /// <summary>
        /// 某个月偿还的本金
        /// </summary>
        public override double PaymentCapitalMonth(int monthIndex)
        {
            return PaymentAt(monthIndex) - PaymentInterestAt(monthIndex);
        }

        /// <summary>
        /// 某个月偿还的利息
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double PaymentInterestAt(int monthIndex)
        {
            return (SumDebt - (monthIndex - 1) * PaymentAt(monthIndex)) * MonthDebtRate;
        }

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public override double GetSumPayment()
        {
            return PaymentAt(-1) * timelength;
        }

        /// <summary>
        /// 获取在某个月时已经还款的总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double FinishedPaymentAt(int monthIndex)
        {
            return monthIndex * PaymentAt(monthIndex);
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
