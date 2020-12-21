using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 订单详情信息
    /// </summary>
   public class OrderDesc
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int OrderDescId { get; set; }
        /// <summary>
        /// 收件人
        /// </summary>
        public string OrderDescName { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string OrderDescPhone { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string OrderDescPosstion { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public string OrderDescStartTime { get; set; }
        /// <summary>
        /// 实付金额
        /// </summary>
        public int OrderDescMoney { get; set; }
        /// <summary>
        /// 关联订单
        /// </summary>
        public int OrderInfoIdOut { get; set; }
        /// <summary>
        /// 买家留言
        /// </summary>
        public string OrderDescRemark { get; set; }
    }
}
