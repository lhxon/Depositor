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
    public class MRoot:IMRoot
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
                if (TimeType == TimeType.Year)
                    return timelength * 12;
                else if (TimeType == TimeType.Day)
                    return timelength / 30;
                else if (TimeType == TimeType.Month)
                    return timelength;
                else
                    throw new ArgumentException("未设置时间类型");
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

    }
}
