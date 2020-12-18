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
        /// 具体商品外键
        /// </summary>
        public int GoodsLookIdOut { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public int UserInfoIdOut { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int GoodsNumber { get; set; }

        //其他表
        /// <summary>
        /// 主键
        /// </summary>
        public int GoodsInfoId { get; set; }
        /// <summary>
        /// 商品简介
        /// </summary>
        public string GoodsInfoDesc { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        public int GoodsInfoPrice { get; set; }
        /// <summary>
        /// 主键
        /// </summary>
        public int UserInfoId { get; set; }
        /// <summary>
        /// 商品主键
        /// </summary>
        public int GoodsLookId { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string GoodsImg { get; set; }
        /// <summary>
        /// 商品颜色
        /// </summary>
        public string GoodsColor { get; set; }
        /// <summary>
        /// 商品大小
        /// </summary>
        public string GoodsSize { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsInfoName { get; set; }
        public int SumPrice { get; set; }
    }
}
