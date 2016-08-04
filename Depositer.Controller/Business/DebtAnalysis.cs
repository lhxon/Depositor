using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depositer.Controller.Business
{
    /// <summary>
    /// 贷款分析界面及业务逻辑类
    /// </summary>
    public class DebtAnalysis
    {
        private DataColumn[] columns;
        private DateTime debtTime;
        private MDebt debt;
        private DataTable dateTableBeforeNow;
        private DataTable dateTableAfterNow;

        public DebtAnalysis()
        {
            debt = MGlobal.Debt;
            if (debt == null)
                throw new ArgumentException("请先进行贷款设置！");
            debtTime = debt.OnDebtTime;
        }

        /// <summary>
        /// 过去的还贷内存表
        /// </summary>
        public DataTable DataTableBeforeNow
        {
            get { return dateTableBeforeNow; }
        }

        /// <summary>
        /// 将来的还贷内存表
        /// </summary>
        public DataTable DataTableAfterNow
        {
            get { return dateTableAfterNow; }
        }

        /// <summary>
        /// 为贷款分析表填充数据
        /// </summary>
        public void FillDebtDatagridViewBeforeTimeNow(DataGridView debtDgview)
        {
            dateTableBeforeNow = new DataTable();
            setTableStructure();
            dateTableBeforeNow.Columns.AddRange(columns);
            for (int i = 1; i < debt.TimeLengthMonth + 1; i++)
            {
                var row = dateTableBeforeNow.NewRow();
                var time = debtTime.AddMonths(i);
                if (DateTimeExtension.ReturnYearMonth(DateTime.Now) < DateTimeExtension.ReturnYearMonth(time))
                    break;
                setRowData(row, i, time);
                dateTableBeforeNow.Rows.Add(row);
            }
            debtDgview.DataSource = dateTableBeforeNow;
        }

        /// <summary>
        /// 为贷款分析表填充数据
        /// </summary>
        public void FillDebtDatagridViewAfterTimeNow(DataGridView debtDgview)
        {
            dateTableAfterNow = new DataTable();
            setTableStructure();
            dateTableAfterNow.Columns.AddRange(columns);
            for (int i = 1; i < debt.TimeLengthMonth + 1; i++)
            {
                var row = dateTableAfterNow.NewRow();
                var time = debtTime.AddMonths(i);
                if (DateTimeExtension.ReturnYearMonth(time) <= DateTimeExtension.ReturnYearMonth(DateTime.Now))
                    continue;
                setRowData(row, i, time);
                dateTableAfterNow.Rows.Add(row);
            }
            debtDgview.DataSource = dateTableAfterNow;
        }

        /// <summary>
        /// 设置表的结构
        /// </summary>
        private void setTableStructure()
        {
            columns = new DataColumn[]{new DataColumn("时间",typeof(string)),
            new DataColumn("本息（元）",typeof(double)),new DataColumn("本金（元）",typeof(double)),
                new DataColumn("利息（元）",typeof(double)),new DataColumn("利息率",typeof(string))};
        }

        /// <summary>
        /// 设置行数据
        /// </summary>
        /// <param name="row"></param>
        /// <param name="i">从贷款日算起第几个月</param>
        /// <param name="time"></param>
        private void setRowData(DataRow row, int i, DateTime time)
        {
            row["时间"] = string.Format("{0}-{1}", time.Year.ToString(), time.Month.ToString());
            row["本息（元）"] = Math.Round(debt.PaymentAt(i) * 10000);
            row["本金（元）"] = Math.Round(debt.PaymentCapitalMonth(i) * 10000);
            row["利息（元）"] = Math.Round(debt.PaymentInterestAt(i) * 10000);
            row["利息率"] = (Math.Round((Double.Parse(row["利息（元）"].ToString()) /
                                  Double.Parse(row["本息（元）"].ToString())) * 100, 0)).ToString() + "%";
        }


        public double FinishedRepay()
        {
            var now = DateTimeExtension.ReturnYearMonth(DateTime.Now);
            var debttime = DateTimeExtension.ReturnYearMonth(debt.OnDebtTime);
            int i = 0;
            while (debttime <= now)
            {
                debttime = debttime.AddMonths(1);
                ++i;
            }
            return debt.FinishedPaymentAt(i) * 1e4;
        }

        /// <summary>
        /// 已还款比例
        /// </summary>
        /// <returns></returns>
        public double FinishedAmountScale()
        {
            return FinishedRepay() / (debt.GetSumPayment() * 1e4);
        }

        /// <summary>
        /// 未还数额
        /// </summary>
        /// <returns></returns>
        public double UnFinishedRepay()
        {
            return debt.GetSumPayment() * 1e4 - FinishedRepay();
        }

        /// <summary>
        /// 过滤表
        /// 异常：参数为空
        /// </summary>
        /// <param name="dt">数据源</param>
        /// <param name="start">yyyy-MM</param>
        /// <param name="end">yyyy-MM</param>
        /// <returns></returns>
        public DataTable FilterDebtItem(DataTable dt, DateTime start, DateTime end)
        {
            if (dt == null)
                throw new ArgumentNullException("内存表");
            //var rows = dt.Select(string.Format("{0}>='{1}' and {0}<'{2}'","时间",start,end));
            //if (rows == null)
            //    return new DataTable();
            var tmpdt = dt.Clone();
            foreach (DataRow row in dt.Rows)
            {
                var time = Convert.ToDateTime(row["时间"].ToString() + "-01");
                if (start <= time && time <= end)
                    tmpdt.Rows.Add(row.ItemArray);
            }
            return tmpdt;
        }

        /// <summary>
        /// 设置表格的显示格式
        /// </summary>
        /// <param name="debtDgview"></param>
        public void SetDebtDataGirdViewFormat(DataGridView debtDgview)
        {
            //奇偶行的背景颜色设置
            foreach (DataGridViewRow row in debtDgview.Rows)
            {
                if (debtDgview.Rows.IndexOf(row) % 2 == 1)
                    row.DefaultCellStyle.BackColor = Color.White;
                else
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                //if (Convert.ToDateTime(row.Cells[0].Value).Month == 1)
                //    row.DefaultCellStyle.BackColor = Color.Orange;
            }

            //设置当前时间月所在行颜色
            //debtDgview.Rows[dateNowInRowNo - 1].DefaultCellStyle.BackColor = SystemColors.WindowText;
        }
    }
}
