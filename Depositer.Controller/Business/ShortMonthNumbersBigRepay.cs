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
    /// 部分还款，缩短还款期限
    /// </summary>
    public class ShortMonthNumbersBigRepay : BaseBigRepay, IBigRepayDebt
    {
        /// <summary>
        /// 缩短本息
        /// </summary>
        /// <param name="bigRepayAmount">还款金额</param>
        /// <returns></returns>
        public DataTable Recalculate(double bigRepayAmount)
        {
            sumDebtAfterBigRepay = GlobalObject.Debt.SumDebt;
            sumDebtAfterBigRepay -= bigRepayAmount;
            sumDebtAfterBigRepay -= GlobalObject.Debt.FinishedCapitalSumAt(DateTime.Now);
            if (sumDebtAfterBigRepay < 0)
            {
                IMessageBox.ShowWarning(string.Format("{0}万元即将全部还清所有贷款！", bigRepayAmount));
                return new DataTable();
            }
            sumCapital = 0;
            FillDebtDatagridViewAfterTimeNow();
            return dataTableAfterNow;
        }

        /// <summary>
        /// 大额还贷每月偿还的利息
        /// </summary>
        /// <param name="monthIndex">大额还贷后的第一个月开始计时</param>
        /// <returns></returns>
        protected void MonthIndexOf(DateTime time)
        {
            var bigrepay = GlobalObject.Debt.BigRepayTime;
            bigrepay = DateTime.Now;
            monthIndex = GlobalObject.Debt.GetMonthIndex(bigrepay, time);
        }
        private int monthIndex;

        /// <summary>
        /// 为贷款分析表填充数据
        /// </summary>
        protected void FillDebtDatagridViewAfterTimeNow()
        {
            dataTableAfterNow = new DataTable();
            debtAna.setTableStructure();
            dataTableAfterNow.Columns.AddRange(debtAna.dataColumns);
            leftsum = 0;
            int i = 0;
            var time = DateTimeExtension.ReturnYearMonth(DateTime.Now);
            while (sumCapital < sumDebtAfterBigRepay * 1e4)
            {
                time = time.AddMonths(1);
                var row = dataTableAfterNow.NewRow();
                setRowData(row, time);
                dataTableAfterNow.Rows.Add(row);
                sumCapital += Double.Parse(row["本金（元）"].ToString());
                sumInterest += Double.Parse(row["利息（元）"].ToString());
                ++i;
                leftsum += Double.Parse(row["本息（元）"].ToString());
            }
        }

        /// <summary>
        /// 设置行数据
        /// </summary>
        /// <param name="row"></param>
        /// <param name="i">从贷款日算起第几个月</param>
        /// <param name="time"></param>
        private void setRowData(DataRow row, DateTime time)
        {
            row["时间"] = string.Format("{0}-{1}", time.Year.ToString(), time.Month.ToString());
            double capital = PaymentCapitalMonthAfterBigPay(time);
            double interest = PaymentInterestMonthAfterBigPay(time);
            double capitalInterest = PaymentMonthAfterBigPay(time);
            row["本息（元）"] = Math.Round(capitalInterest * 1e4);
            row["本金（元）"] = Math.Round(capital * 1e4);
            row["利息（元）"] = Math.Round(interest * 1e4);
            row["利息率"] = (Math.Round((interest /capital) * 100, 0)).ToString() + "%";                                
        }

        /// <summary>
        /// 大额还款后，每月偿还本金
        /// </summary>
        /// <param name="month">自从大额还贷后开始编号的月份</param>
        /// <returns>本金</returns>
        public abstract double PaymentCapitalMonthAfterBigPay(DateTime month);
        /// <summary>
        /// 大额还款后，每月偿还利息
        /// </summary>
        /// <param name="month">自从大额还贷后开始编号的月份</param>
        /// <returns>利息</returns>
        public abstract double PaymentInterestMonthAfterBigPay(DateTime month);
        /// <summary>
        /// 大额还款后，每月偿还本息
        /// </summary>
        /// <param name="month">自从大额还贷后开始编号的月份</param>
        /// <returns>本息</returns>
        public abstract double PaymentMonthAfterBigPay(DateTime month);

    }
}
