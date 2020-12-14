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
            string sql = $"select * from GoodsInfo";
            return DapperHelper.GetList<GoodsCarInfo>(sql);
        }
        /// <summary>
        /// 联查所有购物车
        /// </summary>
        /// <returns></returns>
        public List<ShopCarAndGoods> GetShopCarAndGoods()
        {
            string sql = $"select * from GoodsInfo join GoodsCarInfo on GoodsInfo.GoodsInfoId=GoodsCarInfo.GoodsCarInfoId join UserInfo on GoodsCarInfo.UserInfoIdOut=UserInfo.UserInfoId";
            return DapperHelper.GetList<ShopCarAndGoods>(sql);
        }
    }
}
