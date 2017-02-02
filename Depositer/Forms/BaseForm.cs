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
    public partial class BaseForm : Form
    {
        protected bool IsSavedOK = false;

        public BaseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存按钮下的事件响应
        /// </summary>
        protected virtual void SaveButtonCall()
        {
            if (IsSavedOK == true)
            {
                IMessageBox.ShowInformationOK("保存成功!");              
            }
            else
                IMessageBox.ShowWarning("保存失败");
        }

        protected virtual void CloseButtionCall()
        {
            this.Close();
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
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            CloseButtionCall();
        }

        internal void closeOpenedForm(Type formtype, Form parentForm)
        {
            if (parentForm == null) return;

            foreach (Control childForm in parentForm.MdiChildren)
            {
                if (childForm.GetType() == formtype)
                    ((Form)childForm).Close();
            }
        }

    }
}
