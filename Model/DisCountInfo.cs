using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 优惠券
    /// </summary>
   public class DisCountInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int DisCountInfoId { get; set; }
        /// <summary>
        /// 优惠价格
        /// </summary>
        public int DisCountInfoPrice { get; set; }
        /// <summary>
        /// 优惠券级别
        /// </summary>
        public int DisCountInfoJb { get; set; }
        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 优惠券显示开始时间
        /// </summary>
        public string ShowStartTime { get; set; }
        /// <summary>
        /// 优惠券显示结束时间
        /// </summary>
        public string ShowEndTime { get; set; }
        public int DisCountAndUserId { get; set; }
    }
}
