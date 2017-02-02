using Depositer.Controller.Model.BusinessObject;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    /// <summary>
    /// 等额本息还款
    /// </summary>
    public class MEqualInterest : MDebt,IMDebt
    {

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public  double GetSumPayment()
        {
            return PaymentAt(OnDebtTime.AddMonths(-1)) * TimeLengthMonth;
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
        public  double FinishedPaymentSumAt(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
                time = OnDebtTime.AddMonths((int)TimeLengthMonth);

            int monthIndex = GetMonthIndex(time);

            return monthIndex * PaymentAt(time);
        }
        public  double PaymentAt(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
            {              
                return 0;
            }
            var payment = sumDebt * MonthDebtRate *
                 Math.Pow((1 + MonthDebtRate), TimeLengthMonth) /
                ((Math.Pow((1 + MonthDebtRate), TimeLengthMonth)) - 1);
            if (payment < 0)
                throw new LessOrEquZeroException("还款金额");
            return payment;

        }
        /// <summary>
        /// 某个月偿还的本金
        /// </summary>
        public  double PaymentCapitalMonth(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
            {
                return 0;
            }

            return PaymentAt(time) - PaymentInterestAt(time);
        }

        private Dictionary<int, double> dictInterBefore = new Dictionary<int, double>();

        /// <summary>
        /// 某个月偿还的利息
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public  double PaymentInterestAt(DateTime time)
        {
            try
            {
                if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
                {
                    return 0;
                }

                int monthIndex = GetMonthIndex(time);
                double inter = 0;
                if (monthIndex == 1)
                {
                    inter = sumDebt * MonthDebtRate;
                }
                else
                {
                    double beforeInterSum = 0;
                    for (int i = 1; i < monthIndex; i++)
                    {
                        if (!dictInterBefore.ContainsKey(i))
                            dictInterBefore.Add(i, PaymentInterestAt(OnDebtTime.AddMonths(i)));
                        beforeInterSum += dictInterBefore[i];
                    }
                    inter = (sumDebt - ((monthIndex - 1) * PaymentAt(OnDebtTime.AddMonths(monthIndex)) - beforeInterSum)) * MonthDebtRate;
                }
                if (inter < 0)
                    throw new LessOrEquZeroException("利息");
                if (!dictInterBefore.ContainsKey(monthIndex))
                {
                    dictInterBefore.Add(monthIndex, inter);
                }
                return inter;

            }

            catch(Exception ex)
            {
                throw ex;
            }

        }

        public double PaymentInterestAt(DateTime time, DateTime bigRepayTime, double sumDebt1)
        {
            try
            {
                if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
                {
                    return 0;
                }

                int monthIndex = GetMonthIndex(bigRepayTime,time);
                double inter = 0;
                if (monthIndex == 1)
                {
                    inter = sumDebt1 * MonthDebtRate;
                }
                else
                {
                    double beforeInterSum = 0;
                    for (int i = 1; i < monthIndex; i++)
                    {
                        if (!dictInterBefore.ContainsKey(i))
                            dictInterBefore.Add(i, PaymentInterestAt(OnDebtTime.AddMonths(i)));
                        beforeInterSum += dictInterBefore[i];
                    }
                    inter = (sumDebt1 - ((monthIndex - 1) * PaymentAt(OnDebtTime.AddMonths(monthIndex)) - beforeInterSum)) * MonthDebtRate;
                }
                if (inter < 0)
                    //throw new LessOrEquZeroException("利息");
                    return inter;
                if (!dictInterBefore.ContainsKey(monthIndex))
                {
                    dictInterBefore.Add(monthIndex, inter);
                }
                return inter;

            }
            catch(Exception ex)
            {
                throw ex;
            }
           
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
            int mi = GetMonthIndex(time);
            double sum =0;
            for(int i=1;i<=mi;i++)
                sum+=PaymentCapitalMonth(OnDebtTime.AddMonths(i));
            return sumDebt - sum;
        }

        public double LeftDebtAt(DateTime time)
        {
            if (OnDebtTime.AddMonths((int)TimeLengthMonth) < time) //如果贷款已经还完
                time = OnDebtTime.AddMonths((int)TimeLengthMonth);

            return GetSumPayment() - FinishedPaymentSumAt(time);
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
