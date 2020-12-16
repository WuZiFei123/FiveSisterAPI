using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using BLL;
using IBLL;

namespace FiveSister.Controllers
{
    [ApiController]
    public class MyOrderInfo : ControllerBase
    {
        IBLLOrderInfo BLLOrderInfo;
        public MyOrderInfo (IBLLOrderInfo _BLLOrderInfo)
        {
            BLLOrderInfo = _BLLOrderInfo;
        }
        /// <summary>
        /// 获取所有订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetOrderInfos")]
        public List<OrderInfo> GetOrderInfos(int UserId=2,int State=0)
        {
            return BLLOrderInfo.GetOrderInfos(UserId,State);
        }
        /// <summary>
        /// 修改订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/UpdateOrderInfoBuy")]
        public int UpdateOrderInfoBuy(int OrderId, int State)
        {
            return BLLOrderInfo.UpdateOrderInfoBuy(OrderId, State);
        }
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        [RouteAttribute("api/[controller]/AddOrderInfo")]
        public  int AddOrderInfo([FromForm] OrderInfo order)
        {
            return BLLOrderInfo.AddOrderInfo(order);
        }
    }
}
