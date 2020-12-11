using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class GoodsAddInfoAndUserInfoAndGoodsInfo
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

        /// <summary>
        /// 主键
        /// </summary>
        public int UserInfoId { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        public int GoodsInfoId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsInfoName { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string GoodsInfoImage { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        public string GoodsInfoPrice { get; set; }
        /// <summary>
        /// 商品售出数量
        /// </summary>
        public int GoodsInfoCount { get; set; }
        /// <summary>
        /// 商品是否上架
        /// </summary>
        public int GoodsInfoState { get; set; }
        /// <summary>
        /// 商品出产地
        /// </summary>
        public string GoodsInfoPlace { get; set; }
        /// <summary>
        /// 商品颜色
        /// </summary>
        public string GoodsInfoColor { get; set; }
        /// <summary>
        /// 商品规格
        /// </summary>
        public string GoodsInfoSize { get; set; }
        /// <summary>
        /// 所属店铺
        /// </summary>
        public int ShopIdOut { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public string GoodsTypes { get; set; }
        /// <summary>
        /// 商品简介
        /// </summary>
        public string GoodsInfoDesc { get; set; }
    }
}
