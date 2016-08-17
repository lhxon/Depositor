using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Forms
{
    /// <summary>
    /// 投资设置对话框
    /// </summary>
    public partial class InvestSettingDlg : BaseSettingDlg
    {
        private MInvestment earnings = new MInvestment();
        public InvestSettingDlg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvestSettingDlg_Load(object sender, EventArgs e)
        {
            this.FillControls();
        }

        private void FillControls()
        {
            try
            {
                base.FillControlsBase("InvestmentSetting.xml", earnings);
                double investAmount = Double.Parse(xmlTools.XmlAttributeDict["InvestmentAmount"].ToString()) / 10000;
                TimeLengthTxt.Text = xmlTools.XmlAttributeDict["TimeLength"].ToString();
                investAmountTxt.Text = investAmount.ToString();
                investYearRateTxt.Text = xmlTools.XmlAttributeDict["XMLYearRate"].ToString();
                makingRMBMonthTxt.Text = xmlTools.XmlAttributeDict["MakingMoneyMonth"].ToString();
                savingTxt.Text = xmlTools.XmlAttributeDict["Saving"].ToString();
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
                BuildInvestModelInstance();
                xmlTools.UpdateXML("InvestmentSetting.xml", earnings);
                GlobalObject.Investment = earnings;
                IsSavedOK = true;
            }
            catch (Exception ex)
            {
                IsSavedOK = false;
                IMessageBox.ShowWarning(ex.Message);
            }
            base.SaveButtonCall();
        }

        protected override void CloseButtionCall()
        {
            this.Close();
        }

        /// <summary>
        /// 构建贷款对象的实例
        /// 异常包括 ： LessOrEquZeroException FormatException
        /// </summary>
        private void BuildInvestModelInstance()
        {
            earnings = new MInvestment()
            {
                TimeType = GetTimeType(), 
                InvestmentAmount = Double.Parse(investAmountTxt.Text),
                TimeLength = Double.Parse(TimeLengthTxt.Text) ,
                YearRate = Double.Parse(investYearRateTxt.Text),
                MakingMoneyMonth = Double.Parse(makingRMBMonthTxt.Text),
                Saving = Double.Parse(savingTxt.Text)
            };  
        }
    }
}
