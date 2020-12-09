using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 店铺表
    /// </summary>
   public class ShopInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ShopInfoId { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopInfoName { get; set; }
        /// <summary>
        /// 店铺总销售量
        /// </summary>
        public int ShopInfoCount { get; set; }
        /// <summary>
        /// 店铺负责人
        /// </summary>
        public int UserInfoIdOut { get; set; }
        /// <summary>
        /// 店铺创建时间
        /// </summary>
        public DateTime ShopInfoStartTime { get; set; }
        /// <summary>
        /// 店铺浏览量
        /// </summary>
        public int ShopInfoLook { get; set; }
        /// <summary>
        /// 店铺是否运营中
        /// </summary>
        public int ShopInfoState { get; set; }
    }
}
