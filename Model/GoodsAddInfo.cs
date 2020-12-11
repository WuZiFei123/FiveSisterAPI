using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 商品收藏表
    /// </summary>
   public class GoodsAddInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int GoodsAddInfoId { get; set; }
        /// <summary>
        /// 商品外键
        public int GoodsInfoIdOut { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public int UserInfoIdOut { get; set; }
    }
}
