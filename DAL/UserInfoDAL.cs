using Model;
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
        public  List<UserInfo> GetUserInfos(string name, string pass)
        {  
            string sql = "select * from UserInfo Where 1=1";
            if (name!= "")
            {
                sql += $" and UserInfoName='{name}'";
            }
            if (pass!= "")
            {
                sql += $" and UserInfoPass='{pass}'";
            }
            return DapperHelper.GetList<UserInfo>(sql);
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int GetZhu(UserInfo user)
        {
            string sql = $"insert into UserInfo values('{user.UserInfoName}','{user.UserInfoPass}','{user.UserInfoSex}','{user.UserInfoLetter}','{user.UserInfoTake}','{user.UserInfoPhone}','{user.UserInfoEmil}','{user.UserInfoHead}')";
            return DapperHelper.Cud(sql);
        }
        public int Update(UserInfo u)
        {
            string sql = $"update  UserInfo set UserInfoPass='{u.UserInfoPass}'";
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
    }
}
