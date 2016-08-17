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
    public partial class StartPageForm : BaseForm
    {
        public StartPageForm()
        {
            InitializeComponent();
            base.saveButton.Visible = false;
            base.closeBtn.Visible = false;
        }
    }
}
