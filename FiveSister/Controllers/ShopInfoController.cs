using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using BLL;
using IBLL;


namespace FiveSister.Controllers
{
    [ApiController]
    public class ShopInfoController : ControllerBase
    {
        IBLLShopInfo bLLShopInfo;
        public ShopInfoController(IBLLShopInfo _bLLShopInfo)
        {
            bLLShopInfo = _bLLShopInfo;
        }
        /// <summary>
        /// 查询所有店铺
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetShopInfos")]
        public List<ShopInfo> GetShopInfos()
        {
            return bLLShopInfo.GetShopInfos();
        }
    }
}
