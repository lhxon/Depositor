using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Depositer.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 重新登入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reloginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 贷款设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void debtSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebtSettingDlg debtSetDlg = new DebtSettingDlg();
            debtSetDlg.ShowDialog();
        }

        /// <summary>
        /// 投资设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void incomeSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvestSettingDlg investSetDlg = new InvestSettingDlg();
            investSetDlg.ShowDialog();
        }

        /// <summary>
        /// 还贷分析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DebtAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillDebtDgv();
            this.debtDgview.DataSource = dataSet1;
        }
        private void fillDebtDgv()
        {
            var debt = DebtSettingDlg.Debt;
            DataColumn[] columns = new DataColumn[]{new DataColumn("debtDateTime",typeof(string)),
            new DataColumn("captialInterest",typeof(double)),new DataColumn("captial",typeof(double)),
                new DataColumn("interest",typeof(double)),new DataColumn("interest2sum",typeof(string))};
            var dataTable = new DataTable();
            dataTable.Columns.AddRange(columns);
            for(int i=1;i<debt.TimeLengthMonth+1;i++)
            {
                var row = dataTable.NewRow();
                var time = DateTime.Now.AddMonths(i);
                row["debtDateTime"] = string.Format("{0}-{1}", time.Year.ToString(), time.Month.ToString());
                row["captialInterest"] = Math.Round(debt.PaymentAt(i)*10000);
                row["captial"] = Math.Round(debt.PaymentCapitalMonth(i)*10000);
                row["interest"] = Math.Round(debt.PaymentInterestAt(i)*10000);
                row["interest2sum"] = (Math.Round((Double.Parse(row["interest"].ToString()) /
                                      Double.Parse(row["captialInterest"].ToString()))*100,2)).ToString()+"%";
                dataTable.Rows.Add(row);
            }
            dataSet1.Tables.Add(dataTable);
        }

    }
}
