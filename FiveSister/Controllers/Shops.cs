using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using IBLL;
using BLL;

namespace FiveSister.Controllers
{
    [ApiController]
    public class Shops : ControllerBase
    {
        IBLLShopInfo BLLShopInfo;
        public Shops(IBLLShopInfo _BLLShopInfo)
        {
            BLLShopInfo = _BLLShopInfo;
        }
        /// <summary>
        /// 根据具体商品Id获取商家Id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetShopUserId")]
        public int GetShopUserId(int GoodsLookId)
        {
            return BLLShopInfo.GetShopUserId(GoodsLookId);
        }
    }
}
