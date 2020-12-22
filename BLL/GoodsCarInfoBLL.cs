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
        /// 删除购物车数据
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int DeleteCars(string ids)
        {
            return dal.DeleteCars(ids);
        }
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
        public List<GoodsCarInfo> GetShopCarAndGoods(int UserId)
        {
            return dal.GetShopCarAndGoods(UserId);
        }
        /// <summary>
        /// 购物车添加商品
        /// </summary>
        /// <param name="goodsCar"></param>
        /// <returns></returns>
        public int AddGoodsCarInfos(GoodsCarInfo goodsCar)
        {
            return dal.AddGoodsCarInfos(goodsCar);
        }
        /// <summary>
        /// 实现数量减一
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateAndBack(int id)
        {
            return dal.UpdateAndBack(id);
        }
        /// <summary>
        /// 修改数量加一
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateAndGo(int id)
        {
            return dal.UpdateAndGo(id);
        }
        /// <summary>
        /// 获取选中的总价格
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public TempCar GetGoodsCarPrice(string ids, int UserId)
        {
            return dal.GetGoodsCarPrice(ids,UserId);
        }
    }
}
