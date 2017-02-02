using Depositer.Controller.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depositer.Controller.Business
{
    /// <summary>
    /// 等额本息:每个月偿还的本息固定
    /// </summary>
    public class ShortMonthsBigRepayS2 : ShortMonthsBigRepay, IBigRepayDebt
    {
        public ShortMonthsBigRepayS2(DateTime bigRepayTime)
            : base(bigRepayTime)
        {
            
        }
        protected override  double PaymentCapitalMonthAfterBigPay(DateTime month)
        {
            return PaymentMonthAfterBigPay(month) - PaymentInterestMonthAfterBigPay(month);
        }

        protected override double PaymentInterestMonthAfterBigPay(DateTime month)
        {
            if (!(GlobalObject.Debt is MEqualInterest))
                throw new Exception("当前选择的贷款类型不是等额本息！");
            MonthIndexOf(month);

            return (GlobalObject.Debt as MEqualInterest).PaymentInterestAt(month, _bigRepayTime,sumDebtAfterBigRepay);
        }

        protected override double PaymentMonthAfterBigPay(DateTime month)
        {
            return GlobalObject.Debt.PaymentAt(month);
        }

    }
}
