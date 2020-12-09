using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 店铺收藏表
    /// </summary>
   public class ShopAddInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ShopAddInfoId { get; set; }
        /// <summary>
        /// 店铺外键
        /// </summary>
        public int ShopInfoIdOut { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public int UserInfoIdOut { get; set; }
    }
}
