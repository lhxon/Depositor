using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depositer.Controller.Model
{

    public abstract class DebtModel
    {

        private double sumDebt;
        /// <summary>
        /// 总贷款数
        /// </summary>
        public double SumDebt
        {
            get { return sumDebt; }
            set
            {
                if (value < 0)
                    throw new Exception("贷款数不能小于零！");
                sumDebt = value;
            }
        }

        private double yearDebtRate;
        /// <summary>
        /// 贷款年利率
        /// </summary>
        public double YearDebtRate 
        {
            get { return yearDebtRate; }
            set
            {
                if (value < 0)
                    throw new Exception("贷款年利率不能小于零！");
                yearDebtRate = value;
            }
        }

        /// <summary>
        /// 贷款月利率
        /// </summary>
        public double MonthDebtRate 
        {
            get { return YearDebtRate / 12; }
        }

        private int debtYears;
        /// <summary>
        /// 贷款总年数
        /// </summary>
        public int DebtYears
        {
            get { return debtYears; }
            set
            {
                if (value < 0)
                    throw new Exception("贷款总年数不能小于零");
                debtYears = value;
            }
        }

        /// <summary>
        /// 贷款总月数
        /// </summary>
        public int DebtMonths
        {
            get { return DebtYears * 12; }
        }

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public abstract double GetSumPayment();

        /// <summary>
        /// 获取在某个月时已经还款的总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public abstract double FinishedPaymentAt(int monthIndex);

        /// <summary>
        /// 剩余还款总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public abstract double LeftDebtAt(int monthIndex);

       
    }
}
