using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 秒杀表
    /// </summary>
    public  class KillInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int KillInfoId { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        public int GoodsInfoIdOut { get; set; }
        /// <summary>
        /// 秒杀宣传图片
        /// </summary>
        public string KillInfoImg { get; set; }
        /// <summary>
        /// 是否上架
        /// </summary>
        public int KillInfoState { get; set; }


        /// <summary>
        /// 商品简介
        /// </summary>
        public string GoodsInfoDesc { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        public string GoodsInfoPrice { get; set; }
    }
}
