using System;
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
            d.StartTime = DateTime.Now;
            d.EndTime = d.StartTime.AddDays(3);
            string sql = $"insert into DisCountAndUser values({d.UserIdOut},{d.DisCountId},'{d.StartTime}','{d.EndTime}')";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 获取该用户的所有优惠券
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<DisCountInfo> GetDisCountInfosById(int UserId)
        {
            string sql = $"select c.DisCountInfoPrice,a.StartTime,a.EndTime from DisCountAndUser a join UserInfo b on a.UserIdOut = b.UserInfoId  join DisCountInfo c on a.DisCountId = c.DisCountInfoId where b.UserInfoId ={UserId}";
            return DapperHelper.GetList<DisCountInfo>(sql);
        }
        /// <summary>
        /// 获取该用户的失效的优惠券
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<DisCountInfo> GetEndDisCountInfosById(int UserId)
        {
            string sql = $"select c.DisCountInfoPrice,a.StartTime,a.EndTime,a.DisCountAndUserId from DisCountAndUser a  join UserInfo b on a.UserIdOut = b.UserInfoId  join DisCountInfo c on a.DisCountId = c.DisCountInfoId where b.UserInfoId = 2 and a.EndTime <= '{DateTime.Now}'";
            return DapperHelper.GetList<DisCountInfo>(sql);
        }
        /// <summary>
        /// 删除过期优惠券
        /// </summary>
        /// <param name="DisAndUserId"></param>
        /// <returns></returns>
        public int DeleteDisCount(int DisAndUserId) 
        {
            string sql = $"delete from DisCountAndUser where DisCountAndUserId = {DisAndUserId}";
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
