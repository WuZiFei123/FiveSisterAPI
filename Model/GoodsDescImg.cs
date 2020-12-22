using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 商品详情图片表
    /// </summary>
   public class GoodsDescImg
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int GoodsDescImgId { get; set; }
        /// <summary>
        /// 详情图片
        /// </summary>
        public string GoodsDescImgUrl { get; set; }
        /// <summary>
        /// 关联商品
        /// </summary>
        public int GoodsIdOut { get; set; }
    }
}
