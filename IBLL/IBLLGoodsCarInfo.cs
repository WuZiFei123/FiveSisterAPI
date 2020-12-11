using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBLL
{
   public interface IBLLGoodsCarInfo
    {
        /// <summary>
        /// 查询所有购物车
        /// </summary>
        /// <returns></returns>
        List<GoodsCarInfo> GetGoodsCarInfos();
        /// <summary>
        /// 连接查询所有购物车
        /// </summary>
        /// <returns></returns>
        List<ShopCarAndGoods> GetShopCarAndGoods();
    }
}
