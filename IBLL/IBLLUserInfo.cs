using System;
using System.Collections.Generic;
using System.Text;
using Model;


namespace IBLL
{
   public interface IBLLUserInfo
    {
        /// <summary>
        /// 登录接口
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        List<UserInfo> GetUserInfos(string name, string pass);
        /// <summary>
        /// 注册接口
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int GetZhu(UserInfo user);
        int Update(string UserInfoPass, int UserInfoId);
        UserInfo GetUserInfoById(int Id);
        /// <summary>
        /// 付款扣钱
        /// </summary>
        /// <param name="Money"></param>
        /// <param name="UserId"></param>
        /// <returns></returns>
        int PayMoneyUser(int Money, int UserId);
        int ReMoneyShopUser(int Money, int UserId);
        int GetUserMoney(int UserId);
        int ExecTran_Pay(int UserId, int ShopUserId, int Price);
        List<UserInfo> GetUserNameInfos(string name);
    }
}
