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
    public class DisCount : ControllerBase
    {
        IBLLDisCountInfo BLLDisCount;
        public DisCount(IBLLDisCountInfo _BLLDisCount) 
        {
            BLLDisCount = _BLLDisCount;
        }
        /// <summary>
        /// 获取单个优惠券  
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetClothesTypes")]
        public DisCountInfo GetClothesTypes(int ss)
        {
            return BLLDisCount.GetDisCountInfos(ss);
        }
        /// <summary>
        /// 添加用户优惠券  
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [RouteAttribute("api/[controller]/AddDidAndUser")]
        public int AddDidAndUser([FromForm] DisCountAndUser d)
        {
            return BLLDisCount.AddDidAndUser(d);
        }
        /// <summary>
        /// 删除用户优惠券  
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/DeleteDisCount")]
        public int DeleteDisCount(int DisAndUserId)
        {
            return BLLDisCount.DeleteDisCount(DisAndUserId);
        }
        /// <summary>
        /// 获取该用户的所有优惠券
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetDisCountInfosById")]
        public List<DisCountInfo> GetDisCountInfosById(int UserId)
        {
            var list = BLLDisCount.GetDisCountInfosById(UserId);
            foreach (var item in list)
            {
                item.ShowStartTime = item.StartTime.ToString("yyyy-MM-dd");
                item.ShowEndTime = item.EndTime.ToString("yyyy-MM-dd");
            }
            return list;
        }
        /// <summary>
        /// 获取该用户的所有过期优惠券
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetEndDisCountInfosById")]
        public List<DisCountInfo> GetEndDisCountInfosById(int UserId)
        {
            var list = BLLDisCount.GetEndDisCountInfosById(UserId);
            foreach (var item in list)
            {
                item.ShowStartTime = item.StartTime.ToString("yyyy-MM-dd");
                item.ShowEndTime = item.EndTime.ToString("yyyy-MM-dd");
            }
            return list;
        }
    }
}
