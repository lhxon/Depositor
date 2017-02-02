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

                var startPage = new StartPageForm();
                startPage.MdiParent = this;
                startPage.Dock = DockStyle.Fill;
                startPage.Show();
            }
            catch (Exception ex)
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
            try
            {
                closeOpenedForm(typeof(DebtSettingDlg), this);
                DebtSettingDlg debtSetDlg = new DebtSettingDlg();
                debtSetDlg.MdiParent = this;
                debtSetDlg.Dock = DockStyle.Fill;
                debtSetDlg.Show();
            }
            catch(Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }
        }


        //贷款分析
        private void DebtAnalysisToolStripBtn_Click(object sender, EventArgs e)
        {
            try
            {
                closeOpenedForm(typeof(DebtAnalysisDlg), this);
                DebtAnalysisDlg debtAnaDlg = new DebtAnalysisDlg();
                debtAnaDlg.MdiParent = this;
                debtAnaDlg.Dock = DockStyle.Fill;
                debtAnaDlg.Show();
            }
            catch (Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }
        }

        //大额还贷分析
        private void EarlyBigPayToolStripBtn_Click(object sender, EventArgs e)
        {
            try
            {
                closeOpenedForm(typeof(EarlyPayDlg), this);
                EarlyPayDlg earlyDlg = new EarlyPayDlg();
                earlyDlg.MdiParent = this;
                earlyDlg.Dock = DockStyle.Fill;
                earlyDlg.Show();
            }
            catch (Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }

        }


    }
}
