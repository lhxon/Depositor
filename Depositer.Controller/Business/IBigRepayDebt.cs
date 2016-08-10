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
    /// 大额还款模型类
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

    ///// <summary>
    ///// 一次付清所有剩余贷款
    ///// </summary>
    //public class OnePayAllLeft:IBigRepayDebt
    //{
    //    public DataTable Recalculate(double bigRepayAmount)
    //    {
    //        return new DataTable();
    //    }
     
    //}




    ///// <summary>
    ///// 大额还款后，减少每月的本息
    ///// </summary>
    //public class ShortMonthCaptialInterest:IBigRepayDebt
    //{
    //    public DataTable Recalculate(double bigRepayAmount)
    //    {
    //        return new DataTable(); 
    //    }
    //}


}
