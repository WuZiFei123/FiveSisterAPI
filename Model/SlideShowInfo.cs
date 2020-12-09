using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 轮播表
    /// </summary>
    public class SlideShowInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int SlideShowInfoId { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        public int GoodsIdOut { get; set; }
    }
}
