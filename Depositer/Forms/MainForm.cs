using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Depositer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 贷款设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void debtSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 投资设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void incomeSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

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


    }
}
