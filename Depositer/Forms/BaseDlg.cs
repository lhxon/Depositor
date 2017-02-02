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
    public partial class BaseDlg : BaseForm
    {
        public BaseDlg()
        {
            InitializeComponent();
            base.closeBtn.Visible = true;
            base.saveButton.Location = new Point(this.Width / 4, this.Height-50);
            base.closeBtn.Location = new Point(this.Width / 3 * 2, this.Height - 50);
        }

        /// <summary>
        /// 控制子界面相对父界面的显示位置
        /// </summary>
        /// <param name="parentFrm"></param>
        /// <param name="childFrm"></param>
        protected void childFormShowPosition(Form parentFrm, Form childFrm)
        {
            var pointOnScreen = PointToScreen(parentFrm.Location);
            childFrm.Location = new Point(pointOnScreen.X + parentFrm.Width,pointOnScreen.Y);
            childFrm.StartPosition = FormStartPosition.Manual;
        }
    }
}
