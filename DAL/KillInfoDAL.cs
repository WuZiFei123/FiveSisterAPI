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
            string sql = "select * from KillInfo k join GoodsLook g on k.GoodsInfoIdOut = g.GoodsLookId  join GoodsInfo c on g.GoodsIdOut = c.GoodsInfoId";
            return DapperHelper.GetList<KillInfo>(sql);
        }
    }
}
