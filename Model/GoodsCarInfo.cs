using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 购物车表
    /// </summary>
   public class GoodsCarInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int GoodsCarInfoId { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        public int GoodsInfoIdOut { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public int UserInfoIdOut { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int GoodsNumber { get; set; }
    }
}
