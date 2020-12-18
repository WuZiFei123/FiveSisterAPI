using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 用户优惠券表
    /// </summary>
   public class DisCountAndUser
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int DisCountAndUserId { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public int UserIdOut { get; set; }
        /// <summary>
        /// 优惠券外键
        /// </summary>
        public int DisCountId { get; set; }
        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

    }
}
