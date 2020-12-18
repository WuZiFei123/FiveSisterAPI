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
        /// <summary>
        /// 根据具体商品获取商家
        /// </summary>
        /// <returns></returns>
        public int GetShopUserId(int ShopUserId)
        {
            string sql = $"select d.UserInfoId from GoodsLook a join GoodsInfo b on a.GoodsIdOut = b.GoodsInfoId  join ShopInfo c on c.ShopInfoId = b.ShopIdOut join UserInfo d on c.UserInfoIdOut = d.UserInfoId where a.GoodsLookId = {ShopUserId}";
            var l = DapperHelper.GetList<UserInfo>(sql);
            return l[0].UserInfoId;
        }
    }
}
