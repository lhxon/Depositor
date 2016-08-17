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
    }
}
