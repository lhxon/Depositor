using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Forms
{
    public partial class DebtSettingDlg : BaseDlg
    {
        private MDebt debt = new MEqualCaptial();

        public DebtSettingDlg()
        {
            InitializeComponent();
        }
        
        protected override void SaveButtonCall()
        {
            try
            {
                BuildDebtModelInstance();
                UpdateXML("DebtSetting.xml",debt);
                IsSavedOK = true;
            }
            catch(Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }
            base.SaveButtonCall();
        }

        /// <summary>
        /// 构建贷款对象的实例
        /// 异常包括 ：ArgumentNullException LessOrEquZeroException FormatException
        /// </summary>
        private void BuildDebtModelInstance()
        {
            if(string.IsNullOrEmpty(comboBox1.Text))
                throw new ArgumentNullException("未选择还贷方式！");
            if (comboBox1.Text == comboBox1.Items[0].ToString()) //等额本金
                debt = new MEqualCaptial() { DebtType = DebtType.EqualCaptial};
            else
                debt = new MEqualInterest() { DebtType = DebtType.EqualInterest };           
             debt.TimeType = GetTimeType();
             debt.SumDebt = Double.Parse(sumDebtTxt.Text);
             debt.TimeLength = Double.Parse(TimeLengthTxt.Text);
             debt.YearRate = Double.Parse(yearRateTxt.Text)/100;
        }

        private void FillControls()
        {
            try
            {
                 base.FillControlsBase("DebtSetting.xml",debt);
                 if (xmlAttributeDict["DebtType"].ToString() == "EqualCaptial")
                     comboBox1.SelectedText = "等额本金";
                 else if (xmlAttributeDict["DebtType"].ToString() == "EqualInterest")
                     comboBox1.SelectedText = "等额本息";
                 sumDebtTxt.Text = xmlAttributeDict["SumDebt"].ToString();
                 TimeLengthTxt.Text = xmlAttributeDict["TimeLength"].ToString();
                 yearRateTxt.Text = xmlAttributeDict["YearRate"].ToString();
            }
           catch(Exception ex)
            {
                IMessageBox.ShowError(ex.Message);
            }
        }

        /// <summary>
        /// Load事件响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DebtSettingDlg_Load(object sender, EventArgs e)
        {
            this.FillControls();
        }
    }
}
