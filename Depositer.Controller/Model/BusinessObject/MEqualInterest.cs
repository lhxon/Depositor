using Depositer.Lib;
using System;
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
        /// 获取某个月的还款金额，与参数monthIndex无关，为了接口统一才这样写的
        /// </summary>        
        public override double PaymentAt(int monthIndex)
        {
            var payment = sumDebt * MonthDebtRate * 
                Math.Pow((1 + MonthDebtRate), TimeLengthMonth) /
                ((Math.Pow((1 + MonthDebtRate), TimeLengthMonth)) - 1);                
            if (payment < 0)
                throw new LessOrEquZeroException("还款金额");
            return payment;
        }
        public override double PaymentAt(DateTime time)
        {
            return PaymentAt(GetMonthIndex(time));
        }
        /// <summary>
        /// 某个月偿还的本金
        /// </summary>
        public override double PaymentCapitalMonth(int monthIndex)
        {
            return PaymentAt(monthIndex) - PaymentInterestAt(monthIndex);
        }
        /// <summary>
        /// 某个月偿还的本金
        /// </summary>
        public override double PaymentCapitalMonth(DateTime time)
        {
            int i = GetMonthIndex(time);
            return PaymentAt(i) - PaymentInterestAt(i);
        }
        /// <summary>
        /// 某个月偿还的利息
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double PaymentInterestAt(int monthIndex)
        {
            //if (interest < 0)
            //    throw new LessOrEquZeroException("利息"); 
            if (monthIndex == 1)
                return sumDebt*MonthDebtRate;
            return interest;
        }

        public double PaymentInterestAt(int monthIndex, double sumDebt1)
        {            
            //if (interest < 0)
            //    throw new LessOrEquZeroException("利息");
            if (monthIndex == 1)
                return 0;
            double interest = (sumDebt1 - 2 * PaymentAt(1) + PaymentInterestAt(monthIndex - 1,sumDebt1)) * MonthDebtRate;
            return interest;
            
        }
        /// <summary>
        /// 某个月偿还的利息
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
            return PaymentAt(-1) * TimeLengthMonth;
        }

        /// <summary>
        /// 获取在某个月时已经还款的总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public override double FinishedPaymentSumAt(int monthIndex)
        {
            return monthIndex * PaymentAt(monthIndex);
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
            int mi = GetMonthIndex(time);
            double sum =0;
            for(int i=1;i<=mi;i++)
                sum+=PaymentCapitalMonth(i);
            return sumDebt - sum;
        }
    }
}
