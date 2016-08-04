﻿using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Controller.Model
{
    [XMLAttribute("SumDebt")]
    [XMLAttribute("DebtType")]  
    [XMLAttribute("OnDebtTime")]
    [XMLAttribute("BigTimes")]
    public abstract class MDebt:MBase
    {
        private double sumDebt = 0d;

        /// <summary>
        /// 总贷款数
        /// 异常 LessOrEquZeroException
        /// </summary>
        public double SumDebt
        {
            get { return sumDebt; }
            set
            {
                if (value <= 0)
                    throw new LessOrEquZeroException(value);
                sumDebt = value;
            }
        }

        /// <summary>
        /// 贷款月利率
        /// </summary>
        public double MonthDebtRate 
        {
            get { return YearRate / 12; }
        }

        /// <summary>
        /// 以月为单位的还款总月数
        /// </summary>
        public double TimeLengthMonth
        {
            get { return converttimeLengthToMonth(); }
        }

        protected double converttimeLengthToMonth()
        {
            if (TimeType == TimeType.Year)
                return timelength * 12;
            else if (TimeType == TimeType.Day)
                return timelength / 30;
            else if (TimeType == TimeType.Month)
                return timelength;
            else
                throw new ArgumentException("未设置时间类型！");
        }

        /// <summary>
        /// 贷款日期
        /// </summary>
        public DateTime OnDebtTime { get; set; }

        /// <summary>
        /// 大额还款次数
        /// </summary>
        public int BigTimes { get; set; }


        /// <summary>
        /// 贷款类型
        /// </summary>
        public DebtType DebtType { get; set; }

        /// <summary>
        /// 时间从还款日算起是第几个月
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        internal int GetMonthIndex(DateTime time)
        {
            if (time < OnDebtTime)
                throw new ArgumentException("月索引小于0");
            var time1 = new DateTime(time.Year, time.Month, 1);
            var tmptime = OnDebtTime;
            int i = 0;
            while (tmptime < time1)
            {
                tmptime = tmptime.AddMonths(1);
                ++i;
            }
            return i;
        }

        /// <summary>
        /// 获取某个月的还款金额
        /// </summary>
        /// <param name="monthIndex">还款月的编号，从1开始</param>
        /// <returns></returns>
        public abstract double PaymentAt(int monthIndex);
        public abstract double PaymentAt(DateTime time);

        /// <summary>
        /// 每月偿还的本金
        /// </summary>
        public abstract double PaymentCapitalMonth(int monthIndex);

        /// <summary>
        /// 在某个月偿还的利息
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public abstract double PaymentInterestAt(int monthIndex);

        /// <summary>
        /// 获取等额本金需要的总还款额
        /// </summary>
        /// <returns></returns>
        public abstract double GetSumPayment();

        /// <summary>
        /// 获取在某个月时已经还款的总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public abstract double FinishedPaymentAt(int monthIndex);

        /// <summary>
        /// 剩余还款总额度
        /// </summary>
        /// <param name="monthIndex"></param>
        /// <returns></returns>
        public abstract double LeftDebtAt(int monthIndex);       
    }
}
