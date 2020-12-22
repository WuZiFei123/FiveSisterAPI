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
            string sql = $"select e.*,b.GoodsLookId,c.GoodsInfoId,b.GoodsImg,b.GoodsLookId,c.GoodsInfoDesc,b.GoodsColor,b.GoodsSize,a.OrderInfoSumPrice,a.OrderInfoState,a.OrderInfoId from OrderInfo a join GoodsLook b on a.GoodsLookIdOut = b.GoodsLookId join GoodsInfo c on b.GoodsIdOut = c.GoodsInfoId join UserInfo e on a.UserInfoIdOut = e.UserInfoId where e.UserInfoId ={UserId} and a.OrderInfoState = {State} ";
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
        /// 添加订单返回订单主键
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public int AddOrderInfo(OrderInfo order)
        {
            string sql = $"insert into OrderInfo values({order.GoodsLookIdOut},{order.UserInfoIdOut},'{order.OrderInfoSumPrice}',{order.OrderInfoNumber},1);select @@identity as NewId";
            var list = DapperHelper.GetList<OrderInfo>(sql);
            return list[0].NewId;
        }
        /// <summary>
        /// 根据Id查询出订单支付
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public List<OrderInfo> GetPayMoneyOrderInfo(int OrderId)
        {
            string sql = $"select c.*,f.AddressInfoName,a.OrderInfoId,b.GoodsImg,d.GoodsInfoDesc,b.GoodsColor,b.GoodsSize,d.GoodsInfoPrice,a.OrderInfoNumber,a.OrderInfoSumPrice,e.UserInfoIdOut as shangjia,a.UserInfoIdOut from OrderInfo a join GoodsLook b on a.GoodsLookIdOut = b.GoodsLookId join UserInfo c on a.UserInfoIdOut = c.UserInfoId join GoodsInfo d on b.GoodsIdOut = d.GoodsInfoId join ShopInfo e on d.ShopIdOut = e.ShopInfoId  join AddressInfo f on c.UserInfoId = f.UserInfoIdOut where a.OrderInfoId = {OrderId}";
            return DapperHelper.GetList<OrderInfo>(sql);
        }
        /// <summary>
        /// 添加订单详情
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int AddOrderDesc(OrderDesc o)
        {
            o.OrderDescStartTime = DateTime.Now.ToString();
            string sql = $"insert into OrderDesc values('{o.OrderDescName}','{o.OrderDescPhone}','{o.OrderDescPosstion}','{o.OrderDescStartTime}',{o.OrderDescMoney},{o.OrderInfoIdOut},'{o.OrderDescRemark}')";
            return DapperHelper.Cud(sql);
        }
        /// <summary>
        /// 获取物流信息
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public List<CompanyInfo> GetCompanyInfos(int OrderId)
        {
            string sql = $"select * from CompanyInfo where OrderInfoIdOut = {OrderId}";
            return DapperHelper.GetList<CompanyInfo>(sql);
        }
    }
}
