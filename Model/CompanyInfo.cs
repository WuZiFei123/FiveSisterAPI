using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 物流表
    /// </summary>
   public class CompanyInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int CompanyInfoId { get; set; }
        /// <summary>
        /// 物流经过地址
        /// </summary>
        public string CompanyInfoContext { get; set; }
        /// <summary>
        /// 订单外键
        /// </summary>
        public int OrderInfoIdOut { get; set; }
        /// <summary>
        /// 物流时间
        /// </summary>
        public DateTime CompanyInfoTime { get; set; }
    }
}
