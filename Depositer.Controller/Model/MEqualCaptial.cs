﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    /// <summary>
    /// 等额本金还款
    /// </summary>
    public class MEqualCaptial:MDebt
    {
        private double paymentCapitalMonth;
        private double timeLengthMonth
        {
            get { return converttimeLengthToMonth(); }
        }
        private double converttimeLengthToMonth()
        {
            if (TimeType == TimeType.Year)
                return timelength * 12;
            else if (TimeType == TimeType.Day)
                return timelength / 30;
            else if (TimeType == TimeType.Month)
                return timelength;
            else
                throw new ArgumentException("未设置时间类型！");
        }
        /// <summary>
        /// 每月偿还的本金
        /// </summary>
        public double PaymentCapitalMonth 
        {
            get 
            {
                paymentCapitalMonth = SumDebt / timeLengthMonth; //月
                return paymentCapitalMonth;
            }
        }

        /// <summary>
        /// 在某个月偿还的利息
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public double PaymentInterestAt(int monthIndex)
        {
            return (SumDebt - (monthIndex - 1) * PaymentCapitalMonth) * MonthDebtRate;
        }

        /// <summary>
        /// 获取某个月的还款金额
        /// </summary>
        /// <param name="monthIndex">还款月的编号，从1开始</param>
        /// <returns></returns>
        public double PaymentAt(int monthIndex)
        {
            paymentCapitalMonth = SumDebt / timeLengthMonth; //还款本金是不变的
            var paymentInterestMonth = PaymentInterestAt(monthIndex);
            return PaymentCapitalMonth + paymentInterestMonth;
        }

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public override double GetSumPayment()
        {
            double sumPaymentAmount = 0.0;
            for (int i = 0; i < timeLengthMonth; i++)
            {              
                sumPaymentAmount += PaymentAt(i + 1);
            }
            return sumPaymentAmount;
        }

        /// <summary>
        /// 获取在某个月时已经还款的总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double FinishedPaymentAt(int monthIndex)
        {
            double paymentAmount = 0.0;
            for (int i = 0; i < monthIndex; i++)
            {
                paymentAmount += PaymentAt(i + 1);
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
            return GetSumPayment() - FinishedPaymentAt(monthIndex);
        }

        /// <summary>
        /// 显示某个月的下一个月的还款额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public double ShowPaymentNextTo(int monthIndex)
        {
            double capital = SumDebt / timeLengthMonth;//还款本金是不变的
            double interest = 0.0; 
            interest = (SumDebt - monthIndex * capital) * MonthDebtRate;
            return capital + interest;
        }

        /// <summary>
        /// 显示某个月的下多个月的还款额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <param name="showMonths"></param>
        /// <returns></returns>
        public List<double> ShowPaymentNextTo(int monthIndex,int showMonths)
        {
            var rtnList = new List<double>();
            for (int i = 0; i < showMonths; i++)
            {
                rtnList.Add(ShowPaymentNextTo(monthIndex + i));
            }
            return rtnList;
        }
    }
}