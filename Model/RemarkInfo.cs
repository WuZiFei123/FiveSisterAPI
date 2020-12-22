using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 评价表
    /// </summary>
    public class RemarkInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int RemarkInfoId { get; set; }
        /// <summary>
        /// 评价内容
        /// </summary>
        public string RemarkInfoDesc { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public int UserInfoIdOut { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        public int GoodsInfoIdOut { get; set; }
        /// <summary>
        /// 评价时间
        /// </summary>
        public string RemarkTime { get; set; }
        /// <summary>
        /// 评价图片
        /// </summary>
        public string RemarkImg { get; set; }
        /// <summary>
        /// 好评  中评  差评
        /// </summary>
        public int RemarkStare { get; set; }

    }
}
