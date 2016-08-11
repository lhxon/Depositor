using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depositer.Controller.Business
{
    /// <summary>
    /// 等额本金
    /// </summary>
    public class ShortMonthsBigRepayS1:ShortMonthsBigRepay
    {

        public override double PaymentCapitalMonthAfterBigPay(DateTime month)
        {
            MonthIndexOf(month);
            return GlobalObject.Debt.PaymentCapitalMonth(month);
        }

        public override double PaymentInterestMonthAfterBigPay(DateTime month)
        {
            MonthIndexOf(month);
            if (!(GlobalObject.Debt is MEqualCaptial))
                throw new Exception("当前选择的贷款类型不是等额本金！");

            return (GlobalObject.Debt as MEqualCaptial).PaymentInterestAt(monthIndex, sumDebtAfterBigRepay);
        }

        public override double PaymentMonthAfterBigPay(DateTime month)
        {
           MonthIndexOf(month);
           return PaymentCapitalMonthAfterBigPay(month) + PaymentInterestMonthAfterBigPay(month);
        }
    }
}
