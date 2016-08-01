using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Forms
{
    public partial class InvestSettingDlg : BaseDlg
    {
        private MEarnings earnings = new MEarnings();
        public InvestSettingDlg()
        {
            InitializeComponent();
        }

        protected override void SaveButtonCall()
        {
            try
            {
                BuildInvestModelInstance();
                UpdateXML("EarningsSetting.xml", earnings);
                IsSavedOK = true;
            }
            catch (Exception ex)
            {
                IMessageBox.ShowWarning(ex.Message);
            }
            base.SaveButtonCall();
        }

        /// <summary>
        /// 构建贷款对象的实例
        /// 异常包括 ： LessOrEquZeroException FormatException
        /// </summary>
        private void BuildInvestModelInstance()
        {
            earnings = new MEarnings()
            {
                TimeType = GetTimeType(), 
                InvestmentAmount = Double.Parse(investAmountTxt.Text),
                TimeLength = Double.Parse(TimeLengthTxt.Text) ,
                YearRate = Double.Parse(investYearRateTxt.Text)
            };         
        }

        private void FillControls()
        {
            try
            {
                base.FillControlsBase("EarningsSetting.xml",earnings);
                double investAmount = Double.Parse(xmlAttributeDict["InvestmentAmount"].ToString()) / 10000;
                TimeLengthTxt.Text = xmlAttributeDict["TimeLength"].ToString();
                investAmountTxt.Text = investAmount.ToString();
                investYearRateTxt.Text = xmlAttributeDict["YearRate"].ToString();
            }
            catch (Exception ex)
            {
                IMessageBox.ShowError(ex.Message);
            }
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
        
    }
}
