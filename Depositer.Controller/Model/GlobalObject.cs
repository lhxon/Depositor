using Depositer.Lib;
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
        public static MDebt Debt
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
        public static MInvestment Investment
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

        /// <summary>
        /// 获取配置的贷款实例
        /// </summary>
        public static void GetGlobalDebtInstance()
        {
            var xmlTools = new XMLTools();
            //加载贷款设置数据
            xmlTools.ReadFromXML("DebtSetting.xml", typeof(MDebt));
            var debtDict = xmlTools.XmlAttributeDict;
            var mobject = MRoot.ConvertDictToMObject(xmlTools.XmlAttributeDict, debtDict["DebtType"].ToString());
            debt = mobject as MDebt;
        }

        /// <summary>
        /// 获取配置的投资实例
        /// </summary>
        public static void GetGlobalInvestInstance()
        {
            var xmlTools = new XMLTools();
            //加载投资设置数据
            xmlTools.ReadFromXML("InvestmentSetting.xml", typeof(MDebt));
            var investDict = xmlTools.XmlAttributeDict;
            var invobject = MRoot.ConvertDictToMObject(xmlTools.XmlAttributeDict, "MInvestment");
            investment = invobject as MInvestment;
        }
    }
}      
