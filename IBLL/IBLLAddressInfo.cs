using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBLL
{
    public interface IBLLAddressInfo
    {
        /// <summary>
        /// 查询所有收货地址
        /// </summary>
        /// <returns></returns>
        List<AddressInfo> GetAddressInfos(int userInfoId);


        /// <summary>
        /// 修改地址
        /// </summary>
        /// <param name="addressInfo"></param>
        /// <returns></returns>
        int AddressInfoModify(AddressInfo addressInfo);

        /// <summary>
        /// 添加收货地址
        /// </summary>
        /// <param name="addressInfo"></param>
        /// <returns></returns>
        int AddressInfoAdd(AddressInfo addressInfo);
        /// <summary>
        /// 全为不默认
        /// </summary>
        /// <param name="userInfoId"></param>
        /// <returns></returns>
        int ModifyStateAddressInfo(int userInfoId);

        /// <summary>
        /// 设置默认
        /// </summary>
        /// <param name="addressInfoId"></param>
        /// <returns></returns>
        int ModifyDefaultAddressInfo(int addressInfoId);

        int DeleteAddressInfo(int addressInfoId);
    }
}
