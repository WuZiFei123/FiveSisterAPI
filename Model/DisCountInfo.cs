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
    }
}
