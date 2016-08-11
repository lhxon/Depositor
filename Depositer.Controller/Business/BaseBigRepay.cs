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
    public class BaseBigRepay
    {
        protected DebtAnalysis debtAna = new DebtAnalysis();
        protected DataTable dataTableAfterNow;
        protected double sumDebtAfterBigRepay;
        protected double leftsum;
        protected double sumCapital;
        protected double sumInterest;

        /// <summary>
        /// 提前还贷处理前，都从配置信息重新构建贷款设置
        /// </summary>
        public BaseBigRepay()
        {
            XMLTools xmlTools = new XMLTools();
            //加载贷款设置数据
            xmlTools.ReadFromXML("DebtSetting.xml", typeof(MDebt));
            var debtDict = xmlTools.XmlAttributeDict;
            var mobject = MRoot.ConvertDictToMObject(xmlTools.XmlAttributeDict, debtDict["DebtType"].ToString());
            GlobalObject.Debt = mobject as MDebt;
        }

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
