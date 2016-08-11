using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depositer.Controller.Model
{
    public class GlobalObject
    {
        /// <summary>
        /// 配置的贷款对象
        /// </summary>       
        private static MDebt debt; 
        public static  MDebt Debt 
        { 
            get
            {
                return debt;
            }
            set
            {
                debt = value;
            }
        }

        /// <summary>
        /// 投资对象
        /// </summary>
        private static MInvestment investment;
        public static  MInvestment Investment 
        {
            get
            {
                return investment;
            }
            set
            {
                investment = value;
            }
        }
    }
}
