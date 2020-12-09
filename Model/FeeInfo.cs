using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 快递表
    /// </summary>
   public class FeeInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int FeeInfoId { get; set; }
        /// <summary>
        /// 快递名称
        /// </summary>
        public string FeeInfoName { get; set; }
        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime FeeInfoStartTime { get; set; }
    }
}
