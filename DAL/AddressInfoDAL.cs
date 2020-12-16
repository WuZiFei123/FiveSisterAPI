using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class AddressInfoDAL
    {
        /// <summary>
        /// 获取收货地址
        /// </summary>
        /// <returns></returns>
        public List<AddressInfo> GetAddressInfos(int userInfoId)
        {
            string sql = $"select * from AddressInfo where UserInfoIdOut = {userInfoId}";
            return DapperHelper.GetList<AddressInfo>(sql);
        }
        /// <summary>
        /// 添加收货地址
        /// </summary>
        /// <param name="addressInfo"></param>
        /// <returns></returns>
        public int AddAddressInfo(AddressInfo addressInfo)
        {
            string sql = $"insert into AddressInfo values('{addressInfo.AddressInfoPeople}','{addressInfo.AddressInfoPhone}',{addressInfo.UserInfoIdOut},{addressInfo.PosstionInfoIdOut}，'{addressInfo.AddressInfoName}',{addressInfo.AddressInfoState})";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 修改收货地址
        /// </summary>
        /// <param name="addressInfo"></param>
        /// <returns></returns>
        public int ModifyAddressInfo(AddressInfo addressInfo)
        {
            string sql = $"update AddressInfo set AddressInfoPeople='{addressInfo.AddressInfoPeople}',AddressInfoPhone='{addressInfo.AddressInfoPhone}',UserInfoIdOut={addressInfo.UserInfoIdOut},PosstionInfoIdOut={addressInfo.PosstionInfoIdOut},AddressInfoName='{addressInfo.AddressInfoName}',AddressInfoState={addressInfo.AddressInfoState} where AddressInfoId = {addressInfo.AddressInfoId}";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 全为不默认
        /// </summary>
        /// <param name="stateid"></param>
        /// <returns></returns>
        public int ModifyStateAddressInfo(int userInfoId)
        {
            string sql = $"update AddressInfo set AddressInfoState=0 where UserInfoIdOut = {userInfoId}";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 设置默认
        /// </summary>
        /// <param name="addressInfoId"></param>
        /// <returns></returns>
        public int ModifyDefaultAddressInfo(int addressInfoId)
        {
            string sql = $"update AddressInfo set AddressInfoState=1 where AddressInfoId = {addressInfoId}";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 删除收货地址
        /// </summary>
        /// <param name="addressInfoId"></param>
        /// <returns></returns>
        public int DeleteAddressInfo(int addressInfoId)
        {
            string sql = $"delete from AddressInfo where AddressInfoId={addressInfoId}";
            return DapperHelper.Cud(sql);
        }
    }
}
