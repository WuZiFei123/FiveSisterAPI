using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 具体商品表
    /// </summary>
   public class GoodsLook
    {
        /// <summary>
        /// 商品主键
        /// </summary>
        public int GoodsLookId { get; set; }
        /// <summary>
        /// 商品颜色
        /// </summary>
        public string GoodsColor { get; set; }
        /// <summary>
        /// 商品大小
        /// </summary>
        public string GoodsSize { get; set; }
        /// <summary>
        /// 商品库存
        /// </summary>
        public int GoodsKc { get; set; }
        /// <summary>
        /// 关联商品
        /// </summary>
        public int GoodsIdOut { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string GoodsImg { get; set; }
    }
}
