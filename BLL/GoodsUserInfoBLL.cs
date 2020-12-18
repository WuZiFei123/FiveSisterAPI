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
        /// 根据Id获取用户
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoById(int Id)
        {
            return dal.GetUserInfoById(Id);
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
        /// <summary>
        /// 付款扣钱
        /// </summary>
        /// <param name="Money"></param>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public int PayMoneyUser(int Money, int UserId)
        {
            return dal.PayMoneyUser(Money,UserId);
        }
        /// <summary>
        /// 商家收钱
        /// </summary>
        /// <param name="Money"></param>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public int ReMoneyShopUser(int Money, int UserId)
        {
            return dal.ReMoneyShopUser(Money, UserId);
        }
        /// <summary>
        /// 获取买家的余额
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public int GetUserMoney(int UserId)
        {
            return dal.GetUserMoney(UserId);
        }
        /// <summary>
        /// 支付事务
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="ShopUserId"></param>
        /// <param name="Price"></param>
        /// <returns></returns>
        public int ExecTran_Pay(int UserId, int ShopUserId, int Price)
        {
            return dal.ExecTran_Pay(UserId,ShopUserId,Price);
        }
    }
}
