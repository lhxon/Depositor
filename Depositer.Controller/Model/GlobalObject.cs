using Depositer.Controller.Model.BusinessObject;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depositer.Controller.Model
{
    public class GlobalObject
    {
        /// <summary>
        /// 配置的贷款对象
        /// </summary>       
        private static IMDebt debt;
        public static IMDebt Debt
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
        /// 将xml字典转化为模型实例
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="objTypeName"></param>
        /// <returns></returns>
        public static object ConvertDictToMObject(Dictionary<object, object> dict, string objTypeName)
        {
            if (dict == null)
                throw new ArgumentNullException("模型字典");
            var assembly = Assembly.Load("Depositer.Controller");
            if (assembly == null) return null;
            var instance = assembly.CreateInstance("Depositer.Controller.Model." + objTypeName);
            if (instance == null) return null;
            foreach (var member in instance.GetType().GetProperties())
            {
                if (dict.ContainsKey(member.Name))
                {
                    if (member.PropertyType.Name == "Double")
                        member.SetValue(instance, Convert.ToDouble(dict[member.Name]));
                    else if (member.PropertyType.Name == "DebtType")
                    {
                        if (dict[member.Name].ToString() == DebtType.MEqualCaptial.ToString())
                            member.SetValue(instance, DebtType.MEqualCaptial);
                        else if (dict[member.Name].ToString() == DebtType.MEqualInterest.ToString())
                            member.SetValue(instance, DebtType.MEqualInterest);
                    }
                    else if (member.PropertyType.Name == "TimeType")
                    {
                        if (dict[member.Name].ToString() == TimeType.Year.ToString())
                            member.SetValue(instance, TimeType.Year);
                        else if (dict[member.Name].ToString() == TimeType.Month.ToString())
                            member.SetValue(instance, TimeType.Month);
                        else if (dict[member.Name].ToString() == TimeType.Day.ToString())
                            member.SetValue(instance, TimeType.Day);
                    }
                    else if (member.PropertyType.Name == "DateTime")
                        member.SetValue(instance, Convert.ToDateTime(dict[member.Name]));
                    else if (member.PropertyType.Name == "Int32")
                        member.SetValue(instance, Convert.ToInt32(dict[member.Name]));
                    else
                        member.SetValue(instance, dict[member.Name].ToString());
                }
            }
            return instance;
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
            var mobject = ConvertDictToMObject(xmlTools.XmlAttributeDict, debtDict["DebtType"].ToString());
            if (((MDebt)mobject).DebtType == DebtType.MEqualCaptial)
            {
                debt = (MEqualCaptial)mobject;
            }
            else debt = (MEqualInterest)mobject;
            
        }

        /// <summary>
        /// 主界面
        /// </summary>
        public  static Form MainForm { get; set; }

    }
}      
