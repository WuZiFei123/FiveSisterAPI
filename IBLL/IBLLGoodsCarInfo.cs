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
        List<GoodsCarInfo> GetShopCarAndGoods(int UserId);
        /// <summary>
        /// 删除购物车数据
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        int DeleteCars(string ids);
        /// <summary>
        /// 修改数量加一
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int UpdateAndGo(int id);
        /// <summary>
        /// 修改数量减一
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int UpdateAndBack(int id);
    }
}
