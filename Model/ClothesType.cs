using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 类型表
    /// </summary>
   public class ClothesType
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ClothesTypeId { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string ClothesTypeName { get; set; }
        /// <summary>
        /// 类型父Id
        /// </summary>
        public int ClothesTypePid { get; set; }
    }
}
