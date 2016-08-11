using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depositer.Controller.Business
{
    public class BigRepayDebtBase
    {
        protected DebtAnalysis debtAna = new DebtAnalysis();
        protected DataTable dataTableAfterNow;
        protected double sumDebt;
        protected double leftsum;
        protected double sumCapital;
        protected double sumInterest;
        /// <summary>
        /// 本息
        /// </summary>
        public double LeftSumCapitalInterest
        {
            get { return Math.Round(leftsum / 1e4, 2); }
        }
        /// <summary>
        /// 本金
        /// </summary>
        public double LeftSumCapital
        {
            get { return Math.Round(sumCapital / 1e4, 2); }
        }
        /// <summary>
        /// 利息
        /// </summary>
        public double LeftSumInterest
        {
            get { return Math.Round(sumInterest / 1e4, 2); }
        }
    }
}
