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
        public List<GoodsCarInfo> GetShopCarAndGoods(int UserId)
        {
            string sql = $" select d.GoodsInfoId,a.GoodsCarInfoId,c.GoodsSize,c.GoodsColor,d.GoodsInfoName,c.GoodsImg,d.GoodsInfoDesc,d.GoodsInfoPrice,a.GoodsNumber,b.UserInfoId,b.UserInfoName,c.GoodsLookId from GoodsCarInfo a join UserInfo b on a.UserInfoIdOut = b.UserInfoId join GoodsLook c on a.GoodsLookIdOut = c.GoodsLookId join GoodsInfo d on c.GoodsIdOut = d.GoodsInfoId where b.UserInfoId = {UserId}";
            return DapperHelper.GetList<GoodsCarInfo>(sql);
        }
        /// <summary>
        /// 批量  单删购物车数据
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int DeleteCars(string ids)
        {
            string sql = $"delete from GoodsCarInfo where GoodsCarInfoId in ({ids})";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 修改数量加一
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateAndGo(int id)
        {
            string sql = $"update GoodsCarInfo set GoodsNumber=GoodsNumber+1 where GoodsCarInfo.GoodsCarInfoId={id}";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 修改数量减一
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateAndBack(int id)
        {
            string sql = $"update GoodsCarInfo set GoodsNumber=GoodsNumber-1 where GoodsCarInfo.GoodsCarInfoId={id}";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 商品添加购物车
        /// </summary>
        /// <returns></returns>
        public int AddGoodsCarInfos(GoodsCarInfo goodsCar)
        {
            string sql = $"insert into GoodsCarInfo values({goodsCar.GoodsLookIdOut},{goodsCar.UserInfoIdOut},{goodsCar.GoodsNumber})";
            return DapperHelper.Cud(sql);
        }
    }
}
