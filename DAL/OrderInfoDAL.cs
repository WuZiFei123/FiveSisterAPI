using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
   public class OrderInfoDAL
    {
        /// <summary>
        /// 查询所有订单
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<OrderInfo> GetOrderInfos(int UserId,int State)
        {
            string sql = $"select e.*,b.GoodsLookId,c.GoodsInfoId,b.GoodsImg,c.GoodsInfoDesc,b.GoodsColor,b.GoodsSize,a.OrderInfoSumPrice,a.OrderInfoState,a.OrderInfoId from OrderInfo a join GoodsLook b on a.GoodsLookIdOut = b.GoodsLookId join GoodsInfo c on b.GoodsIdOut = c.GoodsInfoId join UserInfo e on a.UserInfoIdOut = e.UserInfoId where e.UserInfoId ={UserId} and a.OrderInfoState = {State} ";
            return DapperHelper.GetList<OrderInfo>(sql);
        }
        /// <summary>
        /// 修改订单状态
        /// </summary>
        /// <param name="OrderId"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public int UpdateOrderInfoBuy(int OrderId,int State)
        {
            State++;
            string sql = $"update OrderInfo set OrderInfoState ={State} where OrderInfoId = {OrderId}";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public int AddOrderInfo(OrderInfo order)
        {
            string sql = $"insert into OrderInfo values({order.GoodsLookIdOut},{order.UserInfoIdOut},'{order.OrderInfoSumPrice}',{order.OrderInfoNumber},1);select @@identity as NewId";
            var list = DapperHelper.GetList<OrderInfo>(sql);
            return list[0].NewId;
        }
    }
}
