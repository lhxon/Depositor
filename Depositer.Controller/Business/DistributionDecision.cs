using Depositer.Controller.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depositer.Controller.Business
{
    /// <summary>
    /// 综合考虑投资收益，及贷款利息等因素找到一个最大收益数
    /// </summary>
    public class DistributionDecision
    {

        /// <summary>
        /// 用于月供和大额还款的钱
        /// </summary>
        private double rmbInDebt;

        /// <summary>
        /// 用于投资的钱
        /// </summary>
        private double rmbInveset;

        /// <summary>
        /// 最大收益
        /// </summary>
        private double maxEarning;

        /// <summary>
        /// 钱分布决策
        /// 假定一年内只有一次大额还款机会；假定投资时长1个月;假定投资时此刻所在的月份
        /// </summary>
        public void DecideDistribution()
        {
            //double invest = MGlobal.Investment.GetIncomeAmount();
            //double debtAmount = MGlobal.Debt.PaymentAt(DateTime.Now);
            //if(invest<debtAmount) //选择还贷
            //{

            //}
        }

    }
}
