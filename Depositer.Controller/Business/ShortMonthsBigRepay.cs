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
    /// 提前大额还款，方法：缩短还款期限
    /// </summary>
    public abstract class ShortMonthsBigRepay : BaseBigRepay
    {
        protected DateTime _bigRepayTime;
        public ShortMonthsBigRepay(DateTime bigRepayTime)
        {
            _bigRepayTime = bigRepayTime;
        }

        /// <summary>
        /// 缩短本息
        /// </summary>
        /// <param name="bigRepayAmount">还款金额</param>
        /// <returns></returns>
        public DataTable Recalculate(double bigRepayAmount)
        {
            sumDebtAfterBigRepay = GlobalObject.Debt.SumDebt;
            sumDebtAfterBigRepay -= bigRepayAmount;
            sumDebtAfterBigRepay -= GlobalObject.Debt.FinishedCapitalSumAt(_bigRepayTime);
            if (sumDebtAfterBigRepay < 0)
            {
                IMessageBox.ShowWarning(string.Format("{0}万元即将全部还清所有贷款！", bigRepayAmount));
                return new DataTable();
            }
           
            FillDebtDatagridViewAfterTimeNow();
            return dataTableAfterNow;
        }

        /// <summary>
        /// 为贷款分析表填充数据
        /// </summary>
        protected void FillDebtDatagridViewAfterTimeNow()
        {
            dataTableAfterNow = new DataTable();
            debtAna.setTableStructure();
            dataTableAfterNow.Columns.AddRange(debtAna.dataColumns);
            sumCapital = 0;
            leftsum = 0;
            var bigRepayTime = DateTime.Parse(_bigRepayTime.ToString("yyyy-MM-01"));
            while (sumCapital < sumDebtAfterBigRepay * 1e4) //本金比较!!!
            {
                bigRepayTime = bigRepayTime.AddMonths(1);
                var row = dataTableAfterNow.NewRow();
                row["时间"] = string.Format("{0}-{1}", bigRepayTime.Year.ToString(), bigRepayTime.Month.ToString());
                double capital = PaymentCapitalMonthAfterBigPay(bigRepayTime);
                double interest = PaymentInterestMonthAfterBigPay(bigRepayTime);
                double capitalInterest = PaymentMonthAfterBigPay(bigRepayTime);
                row["本息（元）"] = Math.Round(capitalInterest * 1e4);
                row["本金（元）"] = Math.Round(capital * 1e4);
                row["利息（元）"] = Math.Round(interest * 1e4);
                row["利息率"] = (Math.Round((interest / capital) * 100, 0)).ToString() + "%";
                dataTableAfterNow.Rows.Add(row);
                sumCapital += Double.Parse(row["本金（元）"].ToString());
                sumInterest += Double.Parse(row["利息（元）"].ToString());
                //if (Double.Parse(row["利息（元）"].ToString())<0)
                //    row["利息（元）"]= 0;
                leftsum += Double.Parse(row["本息（元）"].ToString());
            }

        }

        /// <summary>
        /// 大额还贷每月偿还的利息
        /// </summary>
        /// <param name="monthIndex">大额还贷后的第一个月开始计时</param>
        /// <returns></returns>
        protected void MonthIndexOf(DateTime time)
        {

            monthIndex = GlobalObject.Debt.GetMonthIndex(_bigRepayTime, time);
        }
        protected int monthIndex;

        /// <summary>
        /// 大额还款后，每个月的还款情况
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        protected abstract double PaymentCapitalMonthAfterBigPay(DateTime month);

        protected abstract  double PaymentInterestMonthAfterBigPay(DateTime month);

        protected abstract double PaymentMonthAfterBigPay(DateTime month);

    }
}
