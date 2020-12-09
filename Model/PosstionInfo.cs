using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 地址表
    /// </summary>
    public class PosstionInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int PosstionInfoId { get; set; }
        /// <summary>
        /// 地址名称
        /// </summary>
        public string PosstionName { get; set; }
        /// <summary>
        /// 父级Id
        /// </summary>
        public int Pid { get; set; }
    }
}
