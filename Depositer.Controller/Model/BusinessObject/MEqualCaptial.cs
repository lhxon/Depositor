using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    /// <summary>
    /// 等额本金还款
    /// </summary>
    public class MEqualCaptial:MDebt
    {
        /// <summary>
        /// 获取某个月的还款金额
        /// </summary>
        /// 异常：monthIndex小于零
        /// <param name="monthIndex">还款月的编号，从1开始</param>
        /// <returns></returns>
        public override double PaymentAt(int monthIndex)
        {
            if (monthIndex < 0)
                throw new ArgumentException("月索引小于0");
            return PaymentCapitalMonth(monthIndex) + PaymentInterestAt(monthIndex);
        }

        public override double PaymentAt(DateTime time)
        {
            return PaymentAt(GetMonthIndex(time));
        }
        /// <summary>
        /// 每月偿还的本金
        /// </summary>
        public override double PaymentCapitalMonth(int monthIndex)
        {
            return sumDebt / TimeLengthMonth;
        }
        /// <summary>
        /// 每月偿还的本金
        /// </summary>
        public override double PaymentCapitalMonth(DateTime time)
        {
            int i = GetMonthIndex(time); 
            return PaymentCapitalMonth(i);
        }
        /// <summary>
        /// 在某个月偿还的利息
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double PaymentInterestAt(int monthIndex)
        {
            if (monthIndex < 0)
                throw new ArgumentException("月索引小于0");
            return (sumDebt - (monthIndex - 1) * PaymentCapitalMonth(monthIndex)) * MonthDebtRate;
        }

        /// <summary>
        /// 在某个月偿还的利息
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <param name="sumDebt">当前贷款数额</param>
        /// <returns></returns>
        public double PaymentInterestAt(int monthIndex,double sumDebt1)
        {
            if (monthIndex < 0)
                throw new ArgumentException("月索引小于0");
            return (sumDebt1 - (monthIndex - 1) * PaymentCapitalMonth(monthIndex)) * MonthDebtRate;
        }
        /// <summary>
        /// 在某个月偿还的利息
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double PaymentInterestAt(DateTime time)
        {
            int i = GetMonthIndex(time);
            return PaymentInterestAt(i);
        }

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public override double GetSumPayment()
        {
            double sumPaymentAmount = 0.0;
            for (int i = 0; i < TimeLengthMonth; i++)
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
        public override double FinishedPaymentSumAt(int monthIndex)
        {
            if (monthIndex < 0)
                throw new ArgumentException("月索引小于0");
            double paymentAmount = 0.0;
            for (int i = 0; i < monthIndex; i++)
            {
                paymentAmount += PaymentAt(i + 1);
            }
            return paymentAmount;
        }
        public override double FinishedPaymentSumAt(DateTime time)
        {
            return FinishedPaymentSumAt(GetMonthIndex(time));
        }

        /// <summary>
        /// 在某个月(已供完本月的)还剩余要还的本金
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public override double LeftCapitalAt(DateTime time)
        {
            int i = GetMonthIndex(time);
            return sumDebt - i*PaymentCapitalMonth(i); 
        }
        /// <summary>
        /// 显示某个月的下一个月的还款额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public double ShowPaymentNextTo(int monthIndex)
        {
            if (monthIndex < 0)
                throw new ArgumentException("月索引小于0");
            double capital = sumDebt / TimeLengthMonth;//还款本金是不变的
            double interest = 0.0; 
            interest = (sumDebt - monthIndex * capital) * MonthDebtRate;
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
            if (monthIndex < 0 || showMonths<0)
                throw new ArgumentException("月索引或月数小于0");
            var rtnList = new List<double>();
            for (int i = 0; i < showMonths; i++)
            {
                rtnList.Add(ShowPaymentNextTo(monthIndex + i));
            }
            return rtnList;
        }
    }
}
