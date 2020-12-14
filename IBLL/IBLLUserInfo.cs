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
        List<UserInfo> GetUserInfos(UserInfo userInfo);
        /// <summary>
        /// 注册接口
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int GetZhu(UserInfo user);
        int Update(string UserInfoPass, string UserInfoId);
    }
}
