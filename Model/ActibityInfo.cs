using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 活动表
    /// </summary>
   public class ActibityInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ActibityInfoId { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        public int GoodsInfoIdOut { get; set; }
        /// <summary>
        /// 活动图片
        /// </summary>
        public string ActibityInfoImg { get; set; }
        /// <summary>
        /// 是否开启活动
        /// </summary>
        public int ActibityInfoState { get; set; }
    }
}
