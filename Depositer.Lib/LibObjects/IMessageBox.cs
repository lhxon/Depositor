using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Depositer.Lib
{
    public class IMessageBox
    {
        public static void ShowInformationOK(string str)
        {
            MessageBox.Show(str, "还投决策器提示", MessageBoxButtons.OK, 
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, false);
        }
        public static void ShowWarning(string str)
        {
            MessageBox.Show(str, "还投决策器提示", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0, false);
        }
        public static void ShowError(string str)
        {
            MessageBox.Show(str, "还投决策器提示", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, 0, false);
        }
        public static DialogResult ShowYesNo(string str)
        {
            return MessageBox.Show(str, "还投决策器提示", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, false);
        }
    }
}
