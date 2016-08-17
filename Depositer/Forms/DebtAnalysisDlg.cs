using Depositer.Controller.Business;
using Depositer.Controller.Model;
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
            GlobalObject.GetGlobalDebtInstance();

            double finishedAmount = GlobalObject.Debt.FinishedPaymentSumAt(DateTime.Now);
            double unfinishedAmount = GlobalObject.Debt.LeftDebtAt(DateTime.Now);
            double finishedCapital = GlobalObject.Debt.FinishedCapitalSumAt(DateTime.Now);
            double unfinishedCapital = GlobalObject.Debt.SumDebt - finishedCapital;
            double finishedInterest = GlobalObject.Debt.FinishedInterestSumAt(DateTime.Now);
            double unfinishedInterest = GlobalObject.Debt.LeftInterestAt(DateTime.Now);
            
            this.capInterTxt.Text = string.Format("{0} 元", Math.Round(finishedAmount*1e4, 2));
            this.capTxt.Text = string.Format("{0} 元", Math.Round(finishedCapital*1e4, 2));
            this.interTxt.Text = string.Format("{0} 元", Math.Round(finishedInterest*1e4, 2));
           
            this.unPaidCapInterTxt.Text = string.Format("{0} 元", Math.Round(unfinishedAmount*1e4, 2));
            this.unPaidCapTxt.Text = string.Format("{0} 元", Math.Round(unfinishedCapital*1e4, 2));
            this.unPaidInterTxt.Text = string.Format("{0} 元", Math.Round(unfinishedInterest*1e4, 2));
        }


        private void paidDetailBtn_Click(object sender, EventArgs e)
        {
            DetailDebtDlg detailPaid = new DetailDebtDlg(true);
            detailPaid.ShowDialog();
        }

        private void unPaidDetailBtn_Click(object sender, EventArgs e)
        {
            DetailDebtDlg detailPaid = new DetailDebtDlg(false);
            detailPaid.ShowDialog();
        }


    }
}
