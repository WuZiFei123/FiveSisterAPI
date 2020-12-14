using System;
using System.Collections.Generic;
using System.Text;
using IBLL;
using DAL;
using Model;

namespace BLL
{
    public class GoodsCarInfoBLL : IBLLGoodsCarInfo
    {
        GoodsCarInfoDAL dal = new GoodsCarInfoDAL();
        /// <summary>
        /// 查询所有购物车
        /// </summary>
        /// <returns></returns>
        public List<GoodsCarInfo> GetGoodsCarInfos()
        {
            return dal.GetGoodsCarInfos();
        }
        /// <summary>
        /// 联查所有购物车
        /// </summary>
        /// <returns></returns>
        public List<ShopCarAndGoods> GetShopCarAndGoods()
        {
            return dal.GetShopCarAndGoods();
        }
    }
}
