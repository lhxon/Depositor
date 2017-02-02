using Depositer.Controller.Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    /// <summary>
    /// 等额本金还款
    /// </summary>
    public class MEqualCaptial:MDebt,IMDebt
    {

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public  double GetSumPayment()
        {
            double sumPaymentAmount = 0.0;
            for (int i = 0; i < TimeLengthMonth; i++)
            {
                sumPaymentAmount += PaymentAt(OnDebtTime.AddMonths(i + 1));
            }
            return sumPaymentAmount;
        }

        /// <summary>
        /// 已经偿还的本金总和
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public double FinishedCapitalSumAt(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
                time = OnDebtTime.AddMonths((int)TimeLengthMonth);

            int monthIndex = GetMonthIndex(time);
            double sum = 0;
            for (int i = 1; i <= monthIndex; i++)
                sum += PaymentCapitalMonth(OnDebtTime.AddMonths(i));
            return sum;
        }

        /// <summary>
        /// 已经偿还的本金总和
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public double FinishedInterestSumAt(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
                time = OnDebtTime.AddMonths((int)TimeLengthMonth);

            int monthIndex = GetMonthIndex(time);
            double sum = 0;
            for (int i = 1; i <= monthIndex; i++)
                sum += PaymentInterestAt(OnDebtTime.AddMonths(i));
            return sum;
        }

        /// <summary>
        /// 截止到某个时间，已经偿还的金额
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public  double FinishedPaymentSumAt(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
                time = OnDebtTime.AddMonths((int)TimeLengthMonth);

            time = DateTime.Parse(time.ToString("yyyy-MM-01"));
            double paymentAmount = 0.0;
            for (DateTime i = OnDebtTime; i < time; i = i.AddMonths(1))
            {
                paymentAmount += PaymentAt(i.AddMonths(1));
            }
            return paymentAmount;
        }

        /// <summary>
        /// 显示某个月的下一个月的还款额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public double ShowPaymentNextTo(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
            {
                return 0;
            }

            int monthIndex = GetMonthIndex(time);
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
        public List<double> ShowPaymentNextTo(DateTime time, int showMonths)
        {
            var rtnList = new List<double>();
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
            {
                for (int i = 0; i < showMonths; i++)
                {
                    rtnList.Add(0);
                }
                return rtnList;
            }

            for (int i = 0; i < showMonths; i++)
            {
                rtnList.Add(ShowPaymentNextTo(time.AddMonths(i)));
            }
            return rtnList;
        }

        public  double PaymentAt(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
            {
                return 0;
            }

            return PaymentCapitalMonth(time) + PaymentInterestAt(time);
        }

        /// <summary>
        /// 每月偿还的本金
        /// </summary>
        public  double PaymentCapitalMonth(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
            {
                return 0;
            }

            return sumDebt / TimeLengthMonth;
        }

        /// <summary>
        /// 在某个月偿还的利息
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <param name="sumDebt">当前贷款数额</param>
        /// <returns></returns>
        public double PaymentInterestAt(DateTime time, DateTime bigRepayTime, double sumDebt1)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
            {
                return 0;
            }

            int monthIndex = GetMonthIndex(bigRepayTime, time);

            if (monthIndex < 0)
                throw new ArgumentException("月索引小于0");
            return (sumDebt1 - (monthIndex - 1) * PaymentCapitalMonth(time)) * MonthDebtRate;
        }

        /// <summary>
        /// 在某个月偿还的利息
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public  double PaymentInterestAt(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
            {
                return 0;
            }
            int monthIndex = GetMonthIndex(time);

            if (monthIndex < 0)
                throw new ArgumentException("月索引小于0");
            return (sumDebt - (monthIndex - 1) * PaymentCapitalMonth(OnDebtTime.AddMonths(monthIndex))) * MonthDebtRate;
        }

        public double LeftDebtAt(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
                time = OnDebtTime.AddMonths((int)TimeLengthMonth);

            return GetSumPayment() - FinishedPaymentSumAt(time);
        }

        /// <summary>
        /// 在某个月(已供完本月的)还剩余要还的本金
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public  double LeftCapitalAt(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
            {
                return 0;
            }

            int i = GetMonthIndex(time);
            return sumDebt - i*PaymentCapitalMonth(OnDebtTime.AddMonths(i)); 
        }

        /// <summary>
        /// 剩余的利息总和
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public double LeftInterestAt(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
                time = OnDebtTime.AddMonths((int)TimeLengthMonth);

            return LeftDebtAt(time) - LeftCapitalAt(time);
        } 

    }
}
