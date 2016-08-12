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
    public class ShortMonthNumbersBigRepay:BigRepayDebtBase,IBigRepayDebt
    {
        /// <summary>
        /// 缩短本息
        /// </summary>
        /// <param name="bigRepayAmount">还款金额</param>
        /// <returns></returns>
        public DataTable Recalculate(double bigRepayAmount)
        {
            sumDebt = GlobalObject.Debt.SumDebt;
            sumDebt -= bigRepayAmount;
            sumDebt -= GlobalObject.Debt.FinishedCapitalSumAt(DateTime.Now);
            sumDebtAfterBigRepay = sumDebt;
            if (sumDebt < 0)
            {
                IMessageBox.ShowWarning(string.Format("{0}万元即将全部还清所有贷款！", bigRepayAmount));
                return new DataTable();
            }
            sumCapital = 0;
            FillDebtDatagridViewAfterTimeNow();           
            return dataTableAfterNow;
        }

        private double sumDebtAfterBigRepay;
        /// <summary>
        /// 大额还款后的总贷款
        /// </summary>
        public double SumDebtAfterBigRepay 
        {
            get { return sumDebtAfterBigRepay; }
        }

        /// <summary>
        /// 大额还款后，每月所还的本金       
        /// </summary>
        public double PaymentCapitalMonth(DateTime time)
        {
            //GlobalObject.Debt.BigRepayTime = DateTime.Now;
            //var after1month = GlobalObject.Debt.BigRepayTime.AddMonths(1);
            var paymentCapitalMonth = GlobalObject.Debt.PaymentCapitalMonth(time);
            return paymentCapitalMonth;
            
        }

        /// <summary>
        /// 大额还贷每月偿还的利息
        /// </summary>
        /// <param name="monthIndex">大额还贷后的第一个月开始计时</param>
        /// <returns></returns>
        private double PaymentInterestAt(DateTime time)
        {
            var bigrepay = GlobalObject.Debt.BigRepayTime;
            bigrepay = DateTime.Now;
            int monthIndex = GlobalObject.Debt.GetMonthIndex(bigrepay, time);
            if(GlobalObject.Debt.DebtType== DebtType.MEqualCaptial)
                return (sumDebtAfterBigRepay - monthIndex * PaymentCapitalMonth(time)) * GlobalObject.Debt.MonthDebtRate;
            else

        }

        /// <summary>
        /// 为贷款分析表填充数据
        /// </summary>
        private void FillDebtDatagridViewAfterTimeNow()
        {
            dataTableAfterNow = new DataTable();
            debtAna.setTableStructure();
            dataTableAfterNow.Columns.AddRange(debtAna.dataColumns);
            leftsum = 0;
            int i = 0;
            var time = DateTimeExtension.ReturnYearMonth(DateTime.Now);
            while (sumCapital < sumDebt * 1e4)
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
            double capital = PaymentCapitalMonth(time);
            double interest = PaymentInterestAt(time);
            double capitalInterest = capital + interest;
            row["本息（元）"] = Math.Round(capitalInterest * 1e4);
            row["本金（元）"] = Math.Round(capital * 1e4);
            row["利息（元）"] = Math.Round(interest * 1e4);
            row["利息率"] = (Math.Round((interest /capital) * 100, 0)).ToString() + "%";                                
        }
    }
}
