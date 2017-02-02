using Depositer.Controller.Model;
using Depositer.Controller.Model.BusinessObject;
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
    /// 贷款分析界面的业务逻辑类
    /// </summary>
    public class DebtAnalysis
    {
        private DataColumn[] columns;
        private DateTime debtTime;
        private IMDebt idebt;
        private DataTable dateTableBeforeNow;
        private DataTable dateTableAfterNow;

        public DebtAnalysis()
        {
            if (GlobalObject.Debt.DebtType == DebtType.MEqualCaptial)
                idebt = new MEqualCaptial();
            else idebt = new MEqualInterest();

            idebt = GlobalObject.Debt;
            if (idebt == null)
                throw new ArgumentException("请先进行贷款设置！");
            debtTime = idebt.OnDebtTime;
        }

        ///// <summary>
        ///// 更新debt，比如在大额还款后
        ///// </summary>
        ///// <param name="debt"></param>
        //public void UpdateDebt(MDebt debt)
        //{
        //    this.debt = debt;
        //}
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
            idebt = GlobalObject.Debt;
            setTableStructure();
            dateTableBeforeNow.Columns.AddRange(columns);
            for (int i = 1; i < idebt.TimeLengthMonth + 1; i++)
            {
                var row = dateTableBeforeNow.NewRow();
                var time = debtTime.AddMonths(i);
                if (DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")) < DateTime.Parse(time.ToString("yyyy-MM-01")))
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
            for (int i = 1; i < idebt.TimeLengthMonth + 1; i++)
            {
                var row = dateTableAfterNow.NewRow();
                var time = debtTime.AddMonths(i);
                if (DateTime.Parse(time.ToString("yyyy-MM-01")) <= DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")))
                    continue;
                setRowData(row, i, time);
                dateTableAfterNow.Rows.Add(row);
            }
            debtDgview.DataSource = dateTableAfterNow;
        }

        /// <summary>
        /// 生成的表结构
        /// </summary>
        internal DataColumn[] dataColumns
        {
            get { return columns; }
        }
        
        /// <summary>
        /// 设置表的结构
        /// </summary>
        internal void setTableStructure()
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
        internal void setRowData(DataRow row, int i, DateTime time)
        {
            row["时间"] = string.Format("{0}-{1}", time.Year.ToString(), time.Month.ToString());
            row["本息（元）"] = Math.Round(idebt.PaymentAt(idebt.OnDebtTime.AddMonths(i)) * 10000);
            row["本金（元）"] = Math.Round(idebt.PaymentCapitalMonth(idebt.OnDebtTime.AddMonths(i)) * 10000);
            row["利息（元）"] = Math.Round(idebt.PaymentInterestAt(idebt.OnDebtTime.AddMonths(i)) * 10000);
            row["利息率"] = (Math.Round((Double.Parse(row["利息（元）"].ToString()) /
                                  Double.Parse(row["本息（元）"].ToString())) * 100, 0)).ToString() + "%";
        }

        /// <summary>
        /// 设置行数据
        /// </summary>
        /// <param name="row"></param>
        /// <param name="i">从贷款日算起第几个月</param>
        /// <param name="time"></param>
        internal void setRowData(DataRow row, DateTime time)
        {
            row["时间"] = string.Format("{0}-{1}", time.Year.ToString(), time.Month.ToString());
            row["本息（元）"] = Math.Round(idebt.PaymentAt(time) * 10000);
            row["本金（元）"] = Math.Round(idebt.PaymentCapitalMonth(time) * 10000);
            row["利息（元）"] = Math.Round(idebt.PaymentInterestAt(time) * 10000);
            row["利息率"] = (Math.Round((Double.Parse(row["利息（元）"].ToString()) /
                                  Double.Parse(row["本息（元）"].ToString())) * 100, 0)).ToString() + "%";
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
    }
}
