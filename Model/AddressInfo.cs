using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class AddressInfo
    {
        /// <summary>
        /// 收货地址主键
        /// </summary>
        public int AddressInfoId { get; set; }

        /// <summary>
        /// 用户外键
        /// </summary>
        public int UserInfoIdOut { get; set; }

        /// <summary>
        /// 收货人
        /// </summary>
        public string AddressInfoPeople { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        public string AddressInfoPhone { get; set; }
        

        /// <summary>
        /// 地址表外键
        /// </summary>
        public int PosstionInfoIdOut { get; set; }
        /// <summary>
        /// 收货地址详细地址
        /// </summary>
        public string AddressInfoName { get; set; }

        /// <summary>
        /// 收货地址状态(是否默认地址 1默认，0非默认)
        /// </summary>
        public int AddressInfoState { get; set; }
    }
}
