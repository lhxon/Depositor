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
    /// <summary>
    /// 大额还款接口类
    /// </summary>
    public interface IBigRepayDebt
    {
        /// <summary>
        /// 一次大额后，重新计算每月还的本金
        /// </summary>
        /// <param name="bigRepayAmount">大额还款金额</param>
        DataTable Recalculate(double bigRepayAmount);

        double LeftSumCapitalInterest { get; }

        double LeftSumCapital { get; }

        double LeftSumInterest { get; }

    }
}
