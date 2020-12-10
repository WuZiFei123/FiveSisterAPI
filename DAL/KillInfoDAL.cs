using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
  public class KillInfoDAL
    {
        /// <summary>
        /// 获取所有秒杀
        /// </summary>
        /// <returns></returns>
        public List<KillInfo> GetKillInfos()
        {
            string sql = "select * from KillInfo k join GoodsInfo g on k.GoodsInfoIdOut = g.GoodsInfoId";
            return DapperHelper.GetList<KillInfo>(sql);
        }
    }
}
