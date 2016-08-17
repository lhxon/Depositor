using Depositer.Controller.Business;
using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Depositer.Forms
{
    public partial class MainForm : BaseForm
    {

        private XMLTools xmlTools = new XMLTools();
        private DebtAnalysis debtAnal;
        public MainForm()
        {
            InitializeComponent();
            base.saveButton.Visible = false;
            base.closeBtn.Visible = false;
        }

        protected override void CloseButtionCall()
        {
            this.Close();
        }

        // Load事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalObject.GetGlobalDebtInstance();
                debtAnal = new DebtAnalysis();
                GlobalObject.GetGlobalInvestInstance();
            }
            catch(Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }
        }
     
        //重新登入系统
        private void reloginToolStripBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //退出
        private void exitToolStripBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //贷款设置
        private void debtSettingToolStripBtn_Click(object sender, EventArgs e)
        {
            DebtSettingDlg debtSetDlg = new DebtSettingDlg();
            debtSetDlg.ShowDialog();
        }

        //投资设置
        private void investToolStripBtn_Click(object sender, EventArgs e)
        {
            InvestSettingDlg investSetDlg = new InvestSettingDlg();
            investSetDlg.ShowDialog();
        }

        //贷款分析
        private void DebtAnalysisToolStripBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DebtAnalysisDlg debtAnaDlg = new DebtAnalysisDlg();
                debtAnaDlg.ShowDialog();
                
            }
            catch (Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }
        }

        //大额还贷分析
        private void EarlyBigPayToolStripBtn_Click(object sender, EventArgs e)
        {
            EarlyPayDlg earlyDlg = new EarlyPayDlg();
            earlyDlg.ShowDialog();
        }      

    }
}
