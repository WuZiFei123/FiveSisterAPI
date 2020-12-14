using System;
using System.Collections.Generic;
using System.Text;
using IBLL;
using DAL;
using Model;
namespace BLL
{
   public class GoodsUserInfoBLL:IBLLUserInfo
    {
        UserInfoDAL dal = new UserInfoDAL();


        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>
        /// <returns></returns>

        public List<UserInfo> GetUserInfos(UserInfo userInfo)
        {
            return dal.GetUserInfos(userInfo);
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int GetZhu(UserInfo user)
        {
            return dal.GetZhu(user);
        }

        public int Update(string UserInfoPass, string UserInfoId)
        {
            return dal.Update(UserInfoPass, UserInfoId);
        }


    }
}
