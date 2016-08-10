using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Forms
{
    /// <summary>
    /// 贷款设置对话框
    /// </summary>
    public partial class DebtSettingDlg : BaseDlg
    {
        private static MDebt debt = new MEqualCaptial();


        public DebtSettingDlg()
        {
            InitializeComponent();
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

        private void FillControls()
        {
            try
            {
                base.FillControlsBase("DebtSetting.xml", debt);
                if (xmlTools.XmlAttributeDict["DebtType"].ToString() == "MEqualCaptial")
                    comboBox1.SelectedText = "等额本金";
                else if (xmlTools.XmlAttributeDict["DebtType"].ToString() == "MEqualInterest")
                    comboBox1.SelectedText = "等额本息";
                sumDebtTxt.Text = xmlTools.XmlAttributeDict["SumDebt"].ToString();
                TimeLengthTxt.Text = xmlTools.XmlAttributeDict["TimeLength"].ToString();
                yearRateTxt.Text = xmlTools.XmlAttributeDict["XMLYearRate"].ToString();
                dateTimePicker1.Text = xmlTools.XmlAttributeDict["OnDebtTime"].ToString();
                bigTimesTxt.Text = xmlTools.XmlAttributeDict["BigTimes"].ToString();
            }
            catch (Exception ex)
            {
                IMessageBox.ShowError(ex.Message);
            }
        }

        protected override void SaveButtonCall()
        {
            try
            {
                BuildDebtModelInstance();
                xmlTools.UpdateXML("DebtSetting.xml",debt);
                IsSavedOK = true;
            }
            catch(Exception ex)
            {
                IsSavedOK = false;
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
                debt = new MEqualCaptial() { DebtType = DebtType.MEqualCaptial};
            else
                debt = new MEqualInterest() { DebtType = DebtType.MEqualInterest };           
             debt.TimeType = GetTimeType();
             debt.SumDebt = Double.Parse(sumDebtTxt.Text);
             debt.TimeLength = Double.Parse(TimeLengthTxt.Text);
             debt.YearRate = Double.Parse(yearRateTxt.Text);
             debt.OnDebtTime = Convert.ToDateTime(dateTimePicker1.Text);
             debt.BigTimes = Int32.Parse(bigTimesTxt.Text);
             GlobalObject.Debt = debt;
        }     
    }
}
