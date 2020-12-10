using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public class ShopInfoDAL
    {
        /// <summary>
        /// 查询所有店铺
        /// </summary>
        /// <returns></returns>
        public List<ShopInfo> GetShopInfos()
        {
            string sql = $"select * from ShopInfo";
            return DapperHelper.GetList<ShopInfo>(sql);
        }
    }
}
