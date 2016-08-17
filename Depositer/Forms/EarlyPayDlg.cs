using Depositer.Controller.Business;
using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Depositer.Forms
{
    public partial class EarlyPayDlg : BaseDlg
    {
        private IBigRepayDebt iearyDebt;
        private DataTable detailTable;
        public EarlyPayDlg()
        {
            InitializeComponent();
            base.saveButton.Visible = false;
            setDefaultImplemation();
        }

        private void setDefaultImplemation()
        {
            if (GlobalObject.Debt.DebtType == DebtType.MEqualCaptial)
                iearyDebt = new ShortMonthsBigRepayS1();
            else if (GlobalObject.Debt.DebtType == DebtType.MEqualInterest)
                iearyDebt = new ShortMonthsBigRepayS2();
        }

        private IBigRepayDebt getShortTimeImplemation()
        {
            IBigRepayDebt iearyDebt;
            if (GlobalObject.Debt.DebtType == DebtType.MEqualCaptial)
                iearyDebt = new ShortMonthsBigRepayS1();
            else if (GlobalObject.Debt.DebtType == DebtType.MEqualInterest)
                iearyDebt = new ShortMonthsBigRepayS2();
            else
                throw new Exception("为配置贷款类型！");
            return iearyDebt;
        }

        private void fillChart(Chart chart1)
        {
            Series ser = new Series("利息对比");
            ser.Points.AddXY("还贷前", Math.Round(GlobalObject.Debt.LeftInterestAt(DateTime.Now),2));
            ser.Points.AddXY("还贷后", Math.Round(iearyDebt.LeftSumInterest,2) );
            double savedInter = GlobalObject.Debt.LeftInterestAt(DateTime.Now) - iearyDebt.LeftSumInterest;
            ser.Points.AddXY("节省", Math.Round(savedInter,2));
            this.chart1.Series.Clear();
            ser.IsValueShownAsLabel = true;
            this.chart1.Series.Add(ser);
            this.chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        protected override void CloseButtionCall()
        {
            this.Close();
        }

        private void shortTimeRB_CheckedChanged(object sender, EventArgs e)
        {
            if(shortTimeRB.Checked==true)
            {
                iearyDebt = getShortTimeImplemation();
            }
            else
            {
                shortMonthMoneyRB.Checked = true;
            }
        }

        private void shortMonthMoneyRB_CheckedChanged(object sender, EventArgs e)
        {
            if(shortMonthMoneyRB.Checked==true)
            {
                //waiting
            }
            else
            {
                shortTimeRB.Checked = true;
            }
        }

        private void calcuBtn_Click(object sender, EventArgs e)
        {
            GlobalObject.GetGlobalDebtInstance();

            if (iearyDebt == null)
            {
                IMessageBox.ShowWarning("请选择一种还款方式！");
                return;
            }

            detailTable = iearyDebt.Recalculate(GlobalObject.Investment.Saving / 1e4);//default investing money

            this.capInterTxt.Text = string.Format("{0} 元", (Math.Round(iearyDebt.LeftSumCapitalInterest,2)*1e4).ToString());
            this.capTxt.Text = string.Format("{0} 元", (Math.Round(iearyDebt.LeftSumCapital,2)*1e4).ToString());
            this.interTxt.Text = string.Format("{0} 元", (Math.Round(iearyDebt.LeftSumInterest,2)*1e4).ToString());
            double saveInter = GlobalObject.Debt.LeftInterestAt(DateTime.Now) - iearyDebt.LeftSumInterest;
            this.savedInterestTxt.Text = string.Format("{0} 元", (Math.Round(saveInter,2)*1e4).ToString());

            fillChart(this.chart1);
        }

        private void paidDetailBtn_Click(object sender, EventArgs e)
        {
            DetailDebtDlg detailDlg = new DetailDebtDlg(detailTable);
            detailDlg.ShowDialog();
        }


    }
}
