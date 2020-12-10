using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
   public class ActibityInfoDAL
    { 
        /// <summary>
        /// 查询所有活动
        /// </summary>
        /// <returns></returns>
        public List<ActibityInfo> GetActibityInfos()
        {
            string sql = $"select * from ActibityInfo where ActibityInfoState=1";
            return DapperHelper.GetList<ActibityInfo>(sql);
        }
        /// <summary>
        /// 把已经推送的轮播修改为下架
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int UpdateActibityInfosByIds(string ids)
        {
            string sql = $"update ActibityInfo set ActibityInfoState=0 where ActibityInfoId in({ids})";
            return DapperHelper.Cud(sql);
        }
    }
}
