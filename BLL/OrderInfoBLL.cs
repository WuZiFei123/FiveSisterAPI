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
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public int AddOrderInfo(OrderInfo order)
        {
            return dal.AddOrderInfo(order);
        }
        /// <summary>
        /// 根据Id查询出订单支付
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public List<OrderInfo> GetPayMoneyOrderInfo(int OrderId)
        {
            return dal.GetPayMoneyOrderInfo(OrderId);
        }
        /// <summary>
        /// 添加订单详情
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int AddOrderDesc(OrderDesc o)
        {
            return dal.AddOrderDesc(o);
        }
        /// <summary>
        /// 获取物流信息
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public List<CompanyInfo> GetCompanyInfos(int OrderId)
        {
            return dal.GetCompanyInfos(OrderId);
        }
    }
}
