using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IBLL;
using Model;

namespace FiveSister.Controllers
{

    [ApiController]
    public class GoodsCarInfos : ControllerBase
    {
        IBLLGoodsCarInfo bllGoodsCarInfo;
        
        public GoodsCarInfos(IBLLGoodsCarInfo _bllGoodsCarInfo)
        {
            bllGoodsCarInfo = _bllGoodsCarInfo;  
        }
        /// <summary>
        /// 查询所有购物车
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetGoodsCarInfos")]
        public List<GoodsCarInfo> GetGoodsCarInfos()
        {
            return bllGoodsCarInfo.GetGoodsCarInfos();
        }
    }
}
