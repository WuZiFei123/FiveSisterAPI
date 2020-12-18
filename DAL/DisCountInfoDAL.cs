﻿using System;
using System.Collections.Generic;
using System.Text;
using Model;


namespace DAL
{
    public class DisCountInfoDAL
    {
        /// <summary>
        /// 用户获取优惠券
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int AddDidAndUser(DisCountAndUser d)
        {
            string sql = $"insert into DisCountAndUser values({d.UserIdOut},{d.DisCountId})";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 获取随机优惠券
        /// </summary>
        /// <returns></returns>
        public DisCountInfo GetDisCountInfos(int ss)
        {
            string sql = $"select * from DisCountInfo";
            var list =  DapperHelper.GetList<DisCountInfo>(sql);
            Random random = new Random();
            if(ss==1)
            {
                var s = random.Next(1, 5);
                return list[s];
            }
            if (ss == 2)
            {
                var s = random.Next(6, 10);
                return list[s];
            }
            if (ss == 3)
            {
                var s = random.Next(10, 15);
                return list[s];
            }
            if(ss==9999)
            {
                return list[15];
            }
            return list[0];
        }
    }
}
