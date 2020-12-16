using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace IBLL
{
   public interface IBLLOrderInfo
    {
        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        List<OrderInfo> GetOrderInfos(int UserId,int State);
        /// <summary>
        /// 修改为已付款
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        int UpdateOrderInfoBuy(int OrderId, int State);
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        int AddOrderInfo(OrderInfo order);
    }
}
