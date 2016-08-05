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
                xmlTools.ReadFromXML("DebtSetting.xml", typeof(MDebt));
                var debtDict = xmlTools.XmlAttributeDict;
                var mobject = MBase.ConvertDictToMObject(xmlTools.XmlAttributeDict, debtDict["DebtType"].ToString());
                MGlobal.Debt = mobject as MDebt;
                debtAnal = new DebtAnalysis();
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
                debtAnal.SetDebtDataGirdViewFormat(this.debtDgv2);
                this.capInterAgoLb.Text = string.Format("{0}万", Math.Round(debtAnal.FinishedRepay(), 2));
                //this.textBoxAgoScale.Text = string.Format("{0}%",Math.Round(debtAnal.FinishedAmountScale()*100,0));
                this.capInterAfterLb.Text = string.Format("{0}万",Math.Round(debtAnal.UnFinishedRepay(),2));
                this.capAgoLb.Text = string.Format("{0}万", Math.Round(debtAnal.FinishedCaptialAmount(), 2));
                this.capAfterLb.Text = string.Format("{0}万", Math.Round(debtAnal.UnFinishedCaptialAmount(), 2));
                this.interestAgoLb.Text = string.Format("{0}万", Math.Round(debtAnal.FinishedInterestAmount(), 2));
                this.interestAfterLb.Text = string.Format("{0}万", Math.Round(debtAnal.UnFinishedInterestAmount(),2));
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
<<<<<<< HEAD
            

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
            bigRepayDgv.DataSource = ibigRepayDebt.Recalculate(10);//MGlobal.Investment.Saving
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
                ibigRepayDebt = new ShortDebtYears();
                break;
                case 2:

                break;
                case 3:

                break;
                case 4:

                break;
            }
=======

>>>>>>> 79b1ac8dc8a03f93c7d284d2e1f3c04b0c7f190a

        }
      
    }
}
