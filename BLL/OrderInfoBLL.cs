using System;
using System.Collections.Generic;
using System.Text;
using Model;
using IBLL;
using DAL;

namespace BLL
{
    public class OrderInfoBLL : IBLLOrderInfo
    {
        OrderInfoDAL dal = new OrderInfoDAL();
        /// <summary>
        /// 查询所有订单
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<OrderInfo> GetOrderInfos(int UserId, int State)
        {
            return dal.GetOrderInfos(UserId,State);
        }
        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="OrderId"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public int UpdateOrderInfoBuy(int OrderId, int State)
        {
            return dal.UpdateOrderInfoBuy(OrderId,State);
        }
    }
}
