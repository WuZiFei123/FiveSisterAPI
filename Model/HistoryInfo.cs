using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 浏览历史记录
    /// </summary>
   public class HistoryInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int HistoryInfoId { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        public int GoodsInfoIdOut { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public int UserInfoIdOut { get; set; }
    }
}
