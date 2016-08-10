using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depositer.Lib
{
    public class DataGridViewDesign
    {
        /// <summary>
        /// 设置表格的奇偶行背景颜色
        /// </summary>
        /// <param name="debtDgview"></param>
        public static void SetDebtDataGirdViewFormat(DataGridView dgv)
        {
            if (dgv == null) return;
            //奇偶行的背景颜色设置
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (dgv.Rows.IndexOf(row) % 2 == 1)
                    row.DefaultCellStyle.BackColor = Color.White;
                else
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }         
        }

    }
}
