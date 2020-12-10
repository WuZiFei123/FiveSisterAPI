using System;
using System.Collections.Generic;
using System.Text;
using Model;


namespace DAL
{
   public class GoodsCarInfoDAL
    {
        /// <summary>
        /// 查询所有购物车
        /// </summary>
        /// <returns></returns>
        public List<GoodsCarInfo> GetGoodsCarInfos()
        {
            string sql = $"select * from GoodsCarInfo";
            return DapperHelper.GetList<GoodsCarInfo>(sql);
        }
    }
}
