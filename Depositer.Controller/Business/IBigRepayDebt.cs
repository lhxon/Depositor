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
    /// 大额还款模型类
    /// </summary>
    public interface IBigRepayDebt
    {
        /// <summary>
        /// 一次大额后，重新计算每月还的本金
        /// </summary>
        /// <param name="bigRepayAmount">大额还款金额</param>
        DataTable Recalculate(double bigRepayAmount);
    }

    /// <summary>
    /// 一次付清所有剩余贷款
    /// </summary>
    public class OnePayAllLeft:IBigRepayDebt
    {
        public DataTable Recalculate(double bigRepayAmount)
        {
            return new DataTable();
        }
     
    }

    /// <summary>
    /// 大额还款后，缩短还贷年限
    /// </summary>
    public class ShortDebtYears:IBigRepayDebt
    {
        private DebtAnalysis debtAna = new DebtAnalysis();
        private DataTable dataTableAfterNow;
        private double sumDebt;
        public DataTable Recalculate(double bigRepayAmount)
        {
            sumDebt = MGlobal.Debt.SumDebt;
            sumDebt -= bigRepayAmount;
            sumDebt -= debtAna.FinishedRepay();
            if (sumDebt < 0)
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
        private void FillDebtDatagridViewAfterTimeNow()
        {
            dataTableAfterNow = new DataTable();
            debtAna.setTableStructure();
            dataTableAfterNow.Columns.AddRange(debtAna.dataColumns);
            double sum = 0;
            int i = 0;
            var time = DateTimeExtension.ReturnYearMonth(DateTime.Now);
            while (sum < sumDebt)
            {
                time = time.AddMonths(1);
                var row = dataTableAfterNow.NewRow();
                debtAna.setRowData(row, i, time);
                dataTableAfterNow.Rows.Add(row);
                ++i;
                sum += Double.Parse(row["本息（元）"].ToString()) / 1e4;
            }
            var rowLast = dataTableAfterNow.NewRow();
            time = time.AddMonths(1);
            rowLast["时间"] = string.Format("{0}-{1}", time.Year.ToString(), time.Month.ToString());
            rowLast["本息（元）"] = Math.Round(sum - sumDebt);
            rowLast["本金（元）"] = 0;
            rowLast["利息（元）"] = 0;
            rowLast["利息率"] = 0;
        }
    }

    /// <summary>
    /// 大额还款后，减少每月的本息
    /// </summary>
    public class ShortMonthCaptialInterest:IBigRepayDebt
    {
        public DataTable Recalculate(double bigRepayAmount)
        {
            return new DataTable(); ;
        }
    }


}
