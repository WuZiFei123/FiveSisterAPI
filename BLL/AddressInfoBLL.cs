using DAL;
using IBLL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class AddressInfoBLL : IBLLAddressInfo
    {
        AddressInfoDAL dal = new AddressInfoDAL();
        /// <summary>
        /// 添加收货地址
        /// </summary>
        /// <param name="addressInfo"></param>
        /// <returns></returns>
        public int AddressInfoAdd(AddressInfo addressInfo)
        {
            return dal.AddAddressInfo(addressInfo);
        }
        /// <summary>
        /// 根据主键查询地址
        /// </summary>
        /// <param name="AddressId"></param>
        /// <returns></returns>
        public List<AddressInfo> GetAddressInfosByAddressId(int AddressId)
        {
            return dal.GetAddressInfosByAddressId(AddressId);
        }
        /// <summary>
        /// 修改收货地址
        /// </summary>
        /// <param name="addressInfo"></param>
        /// <returns></returns>
        public int AddressInfoModify(AddressInfo addressInfo)
        {
            return dal.ModifyAddressInfo(addressInfo);
        }
        /// <summary>
        /// 查询收货地址
        /// </summary>
        /// <returns></returns>
        public List<AddressInfo> GetAddressInfos(int userInfoId)
        {
            return dal.GetAddressInfos(userInfoId);
        }
        /// <summary>
        /// 设置默认
        /// </summary>
        /// <param name="addressInfoId"></param>
        /// <returns></returns>
        public int ModifyDefaultAddressInfo(int addressInfoId)
        {
            return dal.ModifyDefaultAddressInfo(addressInfoId);
        }
        /// <summary>
        /// 全为不默认
        /// </summary>
        /// <param name="userInfoId"></param>
        /// <returns></returns>
        public int ModifyStateAddressInfo(int userInfoId)
        {
            return dal.ModifyStateAddressInfo(userInfoId);
        }
        /// <summary>
        /// 删除收货地址
        /// </summary>
        /// <param name="addressInfoId"></param>
        /// <returns></returns>
        public int DeleteAddressInfo(int addressInfoId)
        {
            return dal.DeleteAddressInfo(addressInfoId);
        }
    }
}
