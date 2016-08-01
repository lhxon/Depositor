using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depositer.Controller.Model
{
    /// <summary>
    /// 模型基类
    /// </summary>
    [XMLAttribute("XMLYearRate")]
    [XMLAttribute("TimeType")]
    [XMLAttribute("TimeLength")]
    public class MBase
    {

        protected double timelength;
        /// <summary>
        /// 时长
        /// 异常 LessOrEquZeroException
        /// </summary>
        public double TimeLength
        {
            get { return timelength; }
            set
            {
                if (value <= 0)
                    throw new LessOrEquZeroException(value);
                timelength = value;
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
        }

    }
}
