using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Depositer.Forms
{
    public partial class MainForm : Form
    {

        private XMLTools xmlTools = new XMLTools();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                xmlTools.ReadFromXML("DebtSetting.xml", typeof(MDebt));
                var debtDict = xmlTools.XmlAttributeDict;
                var mobject = MBase.ConvertDictToMObject(xmlTools.XmlAttributeDict, debtDict["DebtType"].ToString());
                MGlobal.Debt = mobject as MDebt;

            }
            catch(Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }
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
        private void debtAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fillDebtDgv();
            }
            catch (Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }
        }
        private void fillDebtDgv()
        {
            var debt = MGlobal.Debt;
            if (debt == null)
                throw new ArgumentException("请先进行贷款设置！");
            DataColumn[] columns = new DataColumn[]{new DataColumn("时间",typeof(string)),
            new DataColumn("本息（元）",typeof(double)),new DataColumn("本金（元）",typeof(double)),
                new DataColumn("利息（元）",typeof(double)),new DataColumn("利息率",typeof(string))};
            var dataTable = new DataTable();
            dataTable.Columns.AddRange(columns);
            for(int i=1;i<debt.TimeLengthMonth+1;i++)
            {
                var row = dataTable.NewRow();
                var time = DateTime.Now.AddMonths(i);
                row["时间"] = string.Format("{0}-{1}", time.Year.ToString(), time.Month.ToString());
                row["本息（元）"] = Math.Round(debt.PaymentAt(i)*10000);
                row["本金（元）"] = Math.Round(debt.PaymentCapitalMonth(i)*10000);
                row["利息（元）"] = Math.Round(debt.PaymentInterestAt(i)*10000);
                row["利息率"] = (Math.Round((Double.Parse(row["利息（元）"].ToString()) /
                                      Double.Parse(row["本息（元）"].ToString())) * 100, 0)).ToString() + "%";
                dataTable.Rows.Add(row);
            }
            this.debtDgview.DataSource = dataTable;
        }


    }
}
