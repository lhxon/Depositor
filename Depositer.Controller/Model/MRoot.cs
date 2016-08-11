using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Depositer.Controller.Model
{
    /// <summary>
    /// 系统模型基类（模型超类）
    /// </summary>
    [XMLAttribute("XMLYearRate")]
    [XMLAttribute("TimeType")]
    [XMLAttribute("TimeLength")]
    public class MRoot
    {

        private double timelength;
        /// <summary>
        /// 时长
        /// 异常 LessOrEquZeroException
        /// </summary>
        public double TimeLength
        {
            get 
            {
                return timelength; //converttimeLengthToMonth(); 
            }
            set
            {
                if (value <= 0)
                    throw new LessOrEquZeroException(value);
                timelength = value;               
            }
        }

        /// <summary>
        /// 以月为单位的时间长度
        /// </summary>
        public double TimeLengthMonth
        {
            get
            {
                return converttimeLengthToMonth();
            }
        }
        /// <summary>
        /// 时间类型
        /// </summary>
        public TimeType TimeType { get; set; }

        private double yearRate;
        /// <summary>
        /// 贷款年利率
        /// 异常 LessOrEquZeroException
        /// </summary>
        public double YearRate
        {
            get { return yearRate; }
            set
            {
                if (value < 0)
                    throw new LessOrEquZeroException(value);
                yearRate = value;
                yearRate /= 100;
            }
        }

        /// <summary>
        /// 仅用作界面显示用的（转换成百分比后的）
        /// </summary>
        public double XMLYearRate
        {
            get { return yearRate * 100; }
            set { yearRate = value / 100; }
        }

        /// <summary>
        /// 统一转化时间单位为月
        /// </summary>
        /// <returns></returns>
        protected double converttimeLengthToMonth()
        {
            if (TimeType == TimeType.Year)
                return timelength * 12;
            else if (TimeType == TimeType.Day)
                return timelength / 30;
            else if (TimeType == TimeType.Month)
                return timelength;
            else
                throw new ArgumentException("未设置时间类型");
        }

        /// <summary>
        /// 将xml字典转化为模型实例
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="objTypeName"></param>
        /// <returns></returns>
        public static object ConvertDictToMObject(Dictionary<object,object> dict, string objTypeName)
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

    }
}
