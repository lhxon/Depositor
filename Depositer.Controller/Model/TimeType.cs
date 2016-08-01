using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    public enum TimeType
    {
        /// <summary>
        /// 按年计算
        /// </summary>
        Year=1,
        /// <summary>
        /// 按月计算
        /// </summary>
        Month=12,
        /// <summary>
        /// 按天计算
        /// </summary>
        Day=365
    }
}
