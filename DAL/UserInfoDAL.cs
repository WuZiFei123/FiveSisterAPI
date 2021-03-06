﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
namespace DAL
{
    public class UserInfoDAL
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public  List<UserInfo> GetUserInfos(string name ,string pass)
        {
            string sql = $"select * from  UserInfo where UserInfoName = '{name}' and UserInfoPass='{pass}'";
            return DapperHelper.GetList<UserInfo>(sql);
        }
        public List<UserInfo> GetUserNameInfos(string name)
        {
            string sql = $"select * from UserInfo where UserInfoName = '{name}'";
            return DapperHelper.GetList<UserInfo>(sql);
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int GetZhu(UserInfo user)
        {
            string sql = $"insert into UserInfo values('{user.UserInfoName}','{user.UserInfoPass}','{user.UserInfoSex}','{user.UserInfoLetter}','{user.UserInfoTake}','{user.UserInfoPhone}','{user.UserInfoEmil}','{user.UserInfoHead}',{user.UserInfoMoney})";
            return DapperHelper.Cud(sql);
        }
        public int Update(string pass,int userid)
        {
            string sql = $"update  UserInfo set UserInfoPass='{pass}' where UserInfoId={userid}";
            return DapperHelper.Cud(sql); 
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="UserInfoPass"></param>
        /// <param name="UserInfoId"></param>
        /// <returns></returns>
        public int Update(string UserInfoPass,string UserInfoId)
        {
            string sql =$"update UserInfo set UserInfoPass='{UserInfoPass}' where  UserInfoId='{UserInfoId}'";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 根据Id获取用户
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoById(int Id)
        {
            string sql = $"select * from UserInfo where UserInfoId  = {Id}";
            var list = DapperHelper.GetList<UserInfo>(sql);
            return list[0];
        }
        /// <summary>
        /// 付款扣钱
        /// </summary>
        /// <param name="Money"></param>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public int PayMoneyUser(int Money,int UserId)
        {
            string sql = $"update UserInfo set UserInfoMoney =UserInfoMoney - {Money} where UserInfoId ={UserId}";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 商家收钱
        /// </summary>
        /// <param name="Money"></param>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public int ReMoneyShopUser(int Money, int UserId)
        {
            string sql = $"update UserInfo set UserInfoMoney =UserInfoMoney + {Money} where UserInfoId ={UserId}";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 获取买家的余额
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public int GetUserMoney(int UserId)
        {
            string sql = $"select * from UserInfo  where UserInfoId={UserId}";
            var list = DapperHelper.GetList<UserInfo>(sql);
            return list[0].UserInfoMoney;
        }
        /// <summary>
        /// 事务支付
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="ShopUserId"></param>
        /// <param name="Price"></param>
        /// <returns></returns>
        public int ExecTran_Pay(int UserId,int ShopUserId,int Price)
        {
            return DBHelper.ExecTran_Pay(UserId,ShopUserId,Price);
        }
    }
}
