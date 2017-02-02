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

namespace Depositer.Forms
{
    /// <summary>
    /// 贷款分析界面
    /// </summary>
    public partial class DebtAnalysisDlg : BaseDlg
    {
        private DebtAnalysis debtAnal = new DebtAnalysis();

        public DebtAnalysisDlg()
        {
            InitializeComponent();
            base.saveButton.Visible = false;

        }

        private void DebtAnalysisDlg_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalObject.GetGlobalDebtInstance();

                double finishedAmount = GlobalObject.Debt.FinishedPaymentSumAt(DateTime.Now);
                if (finishedAmount < 0) finishedAmount = 0;
                double unfinishedAmount = GlobalObject.Debt.LeftDebtAt(DateTime.Now);
                if (unfinishedAmount < 0) unfinishedAmount = 0;
                double finishedCapital = GlobalObject.Debt.FinishedCapitalSumAt(DateTime.Now);
                if (finishedCapital < 0) finishedCapital = 0;
                double unfinishedCapital = GlobalObject.Debt.SumDebt - finishedCapital;
                if (unfinishedCapital <= 0) unfinishedCapital = 0;
                double finishedInterest = GlobalObject.Debt.FinishedInterestSumAt(DateTime.Now);
                if (finishedInterest < 0) finishedInterest = 0;
                double unfinishedInterest = GlobalObject.Debt.LeftInterestAt(DateTime.Now);
                if (unfinishedCapital <= 0|| unfinishedInterest < 0) unfinishedInterest = 0;

                this.capInterTxt.Text = string.Format("{0} 元", Math.Round(finishedAmount * 1e4, 0));
                this.capTxt.Text = string.Format("{0} 元", Math.Round(finishedCapital * 1e4, 0));
                this.interTxt.Text = string.Format("{0} 元", Math.Round(finishedInterest * 1e4, 0));

                this.unPaidCapInterTxt.Text = string.Format("{0} 元", Math.Round(unfinishedAmount * 1e4, 0));
                this.unPaidCapTxt.Text = string.Format("{0} 元", Math.Round(unfinishedCapital * 1e4, 0));
                this.unPaidInterTxt.Text = string.Format("{0} 元", Math.Round(unfinishedInterest * 1e4, 0));
            }
            catch(Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }
        }

        private void paidDetailBtn_Click(object sender, EventArgs e)
        {
            DetailDebtDlg detailPaid = new DetailDebtDlg(true);
            base.childFormShowPosition(this, detailPaid);          
            detailPaid.ShowDialog();

        }

        private void unPaidDetailBtn_Click(object sender, EventArgs e)
        {
            DetailDebtDlg detailPaid = new DetailDebtDlg(false);
            base.childFormShowPosition(this, detailPaid);
            detailPaid.Show();
        }

        

    }
}
