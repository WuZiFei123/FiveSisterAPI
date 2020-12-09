using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 热卖表
    /// </summary>
    public class HotGoodsInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int HotGoodsInfoId { get; set; }
        /// <summary>
        /// 商品外键        /// </summary>
        public int GoodsIdOut { get; set; }
    }
}
