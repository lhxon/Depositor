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
    /// 缩短还款周期，并且贷款方式为等额本金（每个月偿还的金额中本金固定）
    /// </summary>
    public class ShortMonthsBigRepayS1 : ShortMonthsBigRepay, IBigRepayDebt
    {
        public ShortMonthsBigRepayS1(DateTime bigRepayTime)
            : base(bigRepayTime)
        {

        }
        protected override double PaymentCapitalMonthAfterBigPay(DateTime month)
        {
            MonthIndexOf(month);
            return GlobalObject.Debt.PaymentCapitalMonth(month);
        }

        protected override double PaymentInterestMonthAfterBigPay(DateTime month)
        {
            MonthIndexOf(month);
            if (!(GlobalObject.Debt is MEqualCaptial))
                throw new Exception("当前选择的贷款类型不是等额本金！");

            return (GlobalObject.Debt as MEqualCaptial).PaymentInterestAt(month, _bigRepayTime,sumDebtAfterBigRepay);
        }

        protected override double PaymentMonthAfterBigPay(DateTime month)
        {
            MonthIndexOf(month);
            return PaymentCapitalMonthAfterBigPay(month) + PaymentInterestMonthAfterBigPay(month);
        }


    }
}
