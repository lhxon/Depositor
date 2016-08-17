using Depositer.Controller.Business;
using Depositer.Controller.Model;
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
    public partial class DetailDebtDlg : BaseDlg
    {
        private bool paidFlag = true;
        private DebtAnalysis debtAnal = new DebtAnalysis();
        private DataTable fullTable = new DataTable();
        private DataTable showTable = new DataTable();
        private DataTable newTable;
        private int beforeCursor;
        private int afterCursor;

        private DetailDebtDlg()
        {
            InitializeComponent();
        }

        public DetailDebtDlg(bool paidFlag):this()
        {
            this.paidFlag = paidFlag;
        }

        public DetailDebtDlg(DataTable table):this()
        {
            this.newTable = table;
        }

        private void selectDataRow(int begRowNo, int endRowNo)
        {
            if (begRowNo < 0 || endRowNo < 0)
                return;
            showTable = fullTable.Clone();
            foreach (DataRow row in fullTable.Rows)
            {
                if (fullTable.Rows.IndexOf(row) < begRowNo) continue;
                if (fullTable.Rows.IndexOf(row) > endRowNo) continue;
                showTable.ImportRow(row);
            }
        }

        //Load事件
        private void PaidDetailDebtDlg_Load(object sender, EventArgs e)
        {
            if(newTable==null)
            {
                if (paidFlag == true)
                    debtAnal.FillDebtDatagridViewBeforeTimeNow(this.debtDgv1);
                else
                    debtAnal.FillDebtDatagridViewAfterTimeNow(this.debtDgv1);
                fullTable = this.debtDgv1.DataSource as DataTable;
            }
            else
            {
                fullTable = newTable;
            }
            selectDataRow(0, 11);
            beforeCursor = 0;
            afterCursor = 11;
            this.debtDgv1.DataSource = showTable;
            DataGridViewDesign.SetDebtDataGirdViewFormat(this.debtDgv1);
        }

        //往前12个月
        private void before12MonthBtn_Click(object sender, EventArgs e)
        {
            if(fullTable.Rows.Count==0) return;
            //if (showTable.Rows.Count == 0) return;
            if (beforeCursor == 0) return;
            beforeCursor -= 12;
            afterCursor -= 12; 
            selectDataRow(beforeCursor, afterCursor);
            this.debtDgv1.DataSource = showTable;
            DataGridViewDesign.SetDebtDataGirdViewFormat(this.debtDgv1);
        }

        //往后12个月
        private void after12MonthBtn_Click(object sender, EventArgs e)
        {
            if (fullTable.Rows.Count == 0) return;
            //if (showTable.Rows.Count == 0) return;
            if (afterCursor == fullTable.Rows.Count-1) return;
            beforeCursor += 12;
            afterCursor += 12;  
            selectDataRow(beforeCursor, afterCursor);      
            this.debtDgv1.DataSource = showTable;
            DataGridViewDesign.SetDebtDataGirdViewFormat(this.debtDgv1);
        }
    }
}
