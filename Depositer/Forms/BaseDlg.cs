using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Depositer.Forms
{
    /// <summary>
    /// 设置基础对话框
    /// </summary>
    public partial class BaseDlg : Form
    {

        protected XMLTools xmlTools = new XMLTools();
        /// <summary>
        /// 保存成功与否标志
        /// </summary>
        protected bool IsSavedOK = false;

        public BaseDlg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveButtonCall();
        }

        /// <summary>
        /// 保存按钮下的事件响应
        /// </summary>
        protected virtual void SaveButtonCall()
        {
            if (IsSavedOK == true)
            {
                IMessageBox.ShowInformationOK("保存成功!");
                Close();
            }
            else
                IMessageBox.ShowWarning("保存失败");
        }

        /// <summary>
        /// 填充基础对话框内的控件值
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="obj"></param>
        protected void FillControlsBase(string filename, object obj)
        {
            xmlTools.ReadFromXML(filename, obj.GetType());
            string debtTimeType = xmlTools.XmlAttributeDict["TimeType"].ToString();
            if (debtTimeType == "Year")
                yearRadioBtn.Checked = true;
            else if (debtTimeType == "Month")
                monthRadioBtn.Checked = true;
            else if (debtTimeType == "Day")
                dayRadioBtn.Checked = true;
        }

        /// <summary>
        /// 取消按钮响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 获取贷款的时间类型
        /// 异常：ArgumentNullException
        /// </summary>       
        /// <param name="debt"></param>
        /// <returns></returns>
        protected TimeType GetTimeType()
        {
            if (yearRadioBtn.Checked == true) return TimeType.Year;
            else if (monthRadioBtn.Checked == true) return TimeType.Month;
            else if (dayRadioBtn.Checked == true) return TimeType.Day;
            else throw new ArgumentNullException("未选择时长的类型为年或月或日！");
        }

        /// <summary>
        /// 选择RadioButton更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yearRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (yearRadioBtn.Checked == true)
                monthRadioBtn.Checked = dayRadioBtn.Checked = false;
        }
        private void monthRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (monthRadioBtn.Checked == true)
                yearRadioBtn.Checked = dayRadioBtn.Checked = false;
        }
        private void dayRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dayRadioBtn.Checked == true)
                yearRadioBtn.Checked = monthRadioBtn.Checked = false;
        }

    }
}
