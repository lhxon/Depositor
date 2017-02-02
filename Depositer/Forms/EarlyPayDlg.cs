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
        }

        private void setDefaultImplemation()
        {
            if (GlobalObject.Debt.DebtType == DebtType.MEqualCaptial)
                iearyDebt = new ShortMonthsBigRepayS1(this.planBigRepayTimeDTP.Value);
            else if (GlobalObject.Debt.DebtType == DebtType.MEqualInterest)
                iearyDebt = new ShortMonthsBigRepayS2(this.planBigRepayTimeDTP.Value);
        }

        private void updateInterfaceImplemation()
        {
            if(shortTimeRB.Checked==true)
            {
                setDefaultImplemation();
            }
        }

        private IBigRepayDebt getShortTimeImplemation()
        {
            IBigRepayDebt iearyDebt;
            if (GlobalObject.Debt.DebtType == DebtType.MEqualCaptial)
                iearyDebt = new ShortMonthsBigRepayS1(this.planBigRepayTimeDTP.Value);
            else if (GlobalObject.Debt.DebtType == DebtType.MEqualInterest)
                iearyDebt = new ShortMonthsBigRepayS2(this.planBigRepayTimeDTP.Value);
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
            try
            {
                GlobalObject.GetGlobalDebtInstance();

                updateInterfaceImplemation();

                if (iearyDebt == null)
                {
                    IMessageBox.ShowWarning("请选择一种还款方式！");
                    return;
                }
                if (string.IsNullOrEmpty(planBigPayAmountTxt.Text))
                {
                    IMessageBox.ShowWarning("请填写计划还款金额！");
                    return;
                }

                if(  DateTime.Parse(this.planBigRepayTimeDTP.Value.ToString("yyyy-MM-01")) < DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")) )
                {
                    IMessageBox.ShowWarning("计划还贷时间早于当前时间！请设置一个以后的时间");
                    return;
                }

                detailTable = iearyDebt.Recalculate(Convert.ToDouble(planBigPayAmountTxt.Text));

                this.capInterTxt.Text = string.Format("{0} 元", (Math.Round(iearyDebt.LeftSumCapitalInterest, 2) * 1e4).ToString());
                this.capTxt.Text = string.Format("{0} 元", (Math.Round(iearyDebt.LeftSumCapital, 2) * 1e4).ToString());
                this.interTxt.Text = string.Format("{0} 元", (Math.Round(iearyDebt.LeftSumInterest, 2) * 1e4).ToString());
                double saveInter = GlobalObject.Debt.LeftInterestAt(DateTime.Now) - iearyDebt.LeftSumInterest;
                this.savedInterestTxt.Text = string.Format("{0} 元", (Math.Round(saveInter, 2) * 1e4).ToString());

                fillChart(this.chart1);
            }
            catch(Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }

        }

        private void paidDetailBtn_Click(object sender, EventArgs e)
        {
            DetailDebtDlg detailDlg = new DetailDebtDlg(detailTable);
            childFormShowPosition(this, detailDlg);
            detailDlg.ShowDialog();
        }

        private void EarlyPayDlg_Load(object sender, EventArgs e)
        {
            base.saveButton.Visible = false;
            setDefaultImplemation();
            GlobalObject.GetGlobalDebtInstance();
        }
    }
}
