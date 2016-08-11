using Depositer.Controller.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depositer.Controller.Business
{
    /// <summary>
    /// 等额本息
    /// </summary>
    public class ShortMonthNumbersBigRepay3:ShortMonthNumbersBigRepay
    {
        public override double PaymentCapitalMonthAfterBigPay(DateTime month)
        {
            return PaymentMonthAfterBigPay(month) - PaymentInterestMonthAfterBigPay(month);
        }

        public override double PaymentInterestMonthAfterBigPay(DateTime month)
        {
            if (!(GlobalObject.Debt is MEqualInterest))
                throw new Exception("当前选择的贷款类型不是等额本息！");
            MonthIndexOf(month);
            return (GlobalObject.Debt as MEqualInterest).PaymentInterestAt(monthIndex, sumDebtAfterBigRepay);
        }

        public override double PaymentMonthAfterBigPay(DateTime month)
        {
            return GlobalObject.Debt.PaymentAt(month);
        }
    }
}
