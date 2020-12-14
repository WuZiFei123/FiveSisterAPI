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
        public int GoodsInfoIdOut { get; set; }
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
        /// 订单状态
        /// </summary>
        public int OrderInfoState { get; set; }
        /// <summary>
        /// 商品颜色
        /// </summary>
        public string GoodsColor { get; set; }
        /// <summary>
        /// 商品尺码
        /// </summary>
        public string GoodsSize { get; set; }
    }
}
