using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depositer.Controller.Model
{
    public class MGlobal
    {
        /// <summary>
        /// 配置的贷款对象
        /// </summary>
        public static MDebt Debt { get; set; }

        /// <summary>
        /// 投资对象
        /// </summary>
        public static MInvestment Investment { get; set; }
    }
}
