using Depositer.Controller.Business;
using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Depositer.Forms
{
    public partial class MainForm : Form
    {

        private XMLTools xmlTools = new XMLTools();
        private DebtAnalysis debtAnal;
        private IBigRepayDebt ibigRepayDebt;
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
                //加载贷款设置数据
                xmlTools.ReadFromXML("DebtSetting.xml", typeof(MDebt));
                var debtDict = xmlTools.XmlAttributeDict;
                var mobject = MRoot.ConvertDictToMObject(xmlTools.XmlAttributeDict, debtDict["DebtType"].ToString());
                GlobalObject.Debt = mobject as MDebt;

                debtAnal = new DebtAnalysis();
                //加载投资设置数据
                xmlTools.ReadFromXML("InvestmentSetting.xml", typeof(MDebt));
                var investDict = xmlTools.XmlAttributeDict;
                var invobject = MRoot.ConvertDictToMObject(xmlTools.XmlAttributeDict, "MInvestment");
                GlobalObject.Investment = invobject as MInvestment;
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
                debtAnal.FillDebtDatagridViewBeforeTimeNow(this.debtDgv1);
                debtAnal.FillDebtDatagridViewAfterTimeNow();
                this.debtDgv2.DataSource = debtAnal.DataTableAfterNow;
                DataGridViewDesign.SetDebtDataGirdViewFormat(this.debtDgv2);               
                double finishedAmount = GlobalObject.Debt.FinishedPaymentSumAt(DateTime.Now);
                double unfinishedAmount = GlobalObject.Debt.LeftDebtAt(DateTime.Now);
                double finishedCapital = GlobalObject.Debt.FinishedCapitalSumAt(DateTime.Now);
                double unfinishedCapital = GlobalObject.Debt.SumDebt - finishedCapital;
                double finishedInterest = GlobalObject.Debt.FinishedInterestSumAt(DateTime.Now);
                double unfinishedInterest = GlobalObject.Debt.LeftInterestAt(DateTime.Now) - finishedInterest;
                this.capInterAgoLb.Text = string.Format("{0}万", Math.Round(finishedAmount, 2));
                //this.textBoxAgoScale.Text = string.Format("{0}%",Math.Round(debtAnal.FinishedAmountScale()*100,0));
                this.capInterAfterLb.Text = string.Format("{0}万",Math.Round(unfinishedAmount,2));
                this.capAgoLb.Text = string.Format("{0}万", Math.Round(finishedCapital, 2));
                this.capAfterLb.Text = string.Format("{0}万", Math.Round(unfinishedCapital, 2));
                this.interestAgoLb.Text = string.Format("{0}万", Math.Round(finishedInterest, 2));
                this.interestAfterLb.Text = string.Format("{0}万", Math.Round(unfinishedInterest,2));
            }
            catch (Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }
        }

        /// <summary>
        /// 贷款分析筛选changed事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxFilterDebt_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFilterDebt.Checked==true)
            {
                if (dateTimePicker2.Value < dateTimePicker1.Value)
                {
                    IMessageBox.ShowWarning("终止时间不能小于起始时间！");
                    return;
                }
                try
                {
                    var filterDtBeforeNow = debtAnal.FilterDebtItem(debtAnal.DataTableBeforeNow,
                        DateTimeExtension.ReturnYearMonth(dateTimePicker1.Value),
                        DateTimeExtension.ReturnYearMonth(dateTimePicker2.Value));
                    this.debtDgv1.DataSource = filterDtBeforeNow;
                    var filterDtAfterNow = debtAnal.FilterDebtItem(debtAnal.DataTableAfterNow,
                        DateTimeExtension.ReturnYearMonth(dateTimePicker1.Value),
                        DateTimeExtension.ReturnYearMonth(dateTimePicker2.Value) );
                    this.debtDgv2.DataSource = filterDtAfterNow;
                }
                catch(Exception ex)
                {
                    IMessageBox.ShowWarning(ex.Message);
                }

            }
            else //全部显示
            {
                try
                {
                    this.debtDgv1.DataSource = debtAnal.DataTableBeforeNow;
                    this.debtDgv2.DataSource = debtAnal.DataTableAfterNow;
                }
                catch(Exception ex)
                {
                    IMessageBox.ShowWarning(ex.Message);
                }
            }

        }

        /// <summary>
        /// 投资分析:考虑一年内大额还款，以及月供；投资的收益
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void investAnalysisBtn_Click(object sender, EventArgs e)
        {

            

        }

        /// <summary>
        /// 大额还款按钮响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bigRepayAfterBtn_Click(object sender, EventArgs e)
        {
            if(ibigRepayDebt==null)
            {
                IMessageBox.ShowWarning("请选择一种还款方式！");
                return;
            }
            bigRepayDgv.DataSource = ibigRepayDebt.Recalculate(GlobalObject.Investment.Saving / 10000);//MGlobal.Investment.Saving
            DataGridViewDesign.SetDebtDataGirdViewFormat(this.bigRepayDgv);
            this.bigRepayCapInterLb.Text = string.Format("{0}万",ibigRepayDebt.LeftSumCapitalInterest.ToString());
            this.bigRepayCapLb.Text = string.Format("{0}万",ibigRepayDebt.LeftSumCapital.ToString());
            this.bigRepayInterLb.Text = string.Format("{0}万",ibigRepayDebt.LeftSumInterest.ToString());
        }

        /// <summary>
        /// 大额还款的方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem==null)
            {
                IMessageBox.ShowWarning("请选择一种还款方式！");
                return;
            }
            int i = comboBox1.SelectedIndex;
            switch(i)
            {
                case 0:

                break;
                case 1:
                ibigRepayDebt = new ShortYearsBigRepay();
                break;
                case 2:

                break;
                case 3:

                break;
                case 4:

                break;
            }

        }      
    }
}
