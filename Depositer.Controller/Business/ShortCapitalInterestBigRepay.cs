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
    /// 部分大额还款，缩短本息
    /// </summary>
    public class ShortCapitalInterestBigRepay : BigRepayDebtBase,IBigRepayDebt
    {
        /// <summary>
        /// 缩短本息
        /// </summary>
        /// <param name="bigRepayAmount"></param>
        /// <returns></returns>
        public DataTable Recalculate(double bigRepayAmount)
        {
            sumDebt = GlobalObject.Debt.SumDebt;
            sumDebt -= bigRepayAmount;
            sumDebt -= GlobalObject.Debt.FinishedPaymentSumAt(DateTime.Now);
            GlobalObject.Debt.SumDebt = sumDebt;
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
            leftsum = 0;
            int i = 0;
            var time = DateTimeExtension.ReturnYearMonth(DateTime.Now);
            while (sumCapital < sumDebt * 1e4)
            {
                time = time.AddMonths(1);
                var row = dataTableAfterNow.NewRow();
                debtAna.setRowData(row, time);
                dataTableAfterNow.Rows.Add(row);
                sumCapital += Double.Parse(row["本金（元）"].ToString());
                sumInterest += Double.Parse(row["利息（元）"].ToString());
                ++i;
                leftsum += Double.Parse(row["本息（元）"].ToString());
            }
        }
    }
}
