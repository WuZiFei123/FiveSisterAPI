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
    }
}
