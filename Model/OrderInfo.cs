using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 订单表
    /// </summary>
   public class OrderInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int OrderInfoId { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        public int GoodsLookIdOut { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public int UserInfoIdOut { get; set; }
        /// <summary>
        /// 总价格
        /// </summary>
        public string OrderInfoSumPrice { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public int OrderInfoNumber { get; set; }
        /// <summary>
        /// 订单状态1是待付款2是待发货3是待收货4是待评价
        /// </summary>
        public int OrderInfoState { get; set; }


        //关联数据
        /// <summary>
        /// 商品图片
        /// </summary>
        public string GoodsImg { get; set; }
        /// <summary>
        /// 商品简介
        /// </summary>
        public string GoodsInfoDesc { get; set; }
        /// <summary>
        /// 商品大小
        /// </summary>
        public string GoodsSize { get; set; }
        /// <summary>
        /// 商品颜色
        /// </summary>
        public string GoodsColor { get; set; }
        /// <summary>
        /// 商品主键
        /// </summary>
        public int GoodsLookId { get; set; }
        public int GoodsInfoId { get; set; }
        public int NewId { get; set; }

    }
}
