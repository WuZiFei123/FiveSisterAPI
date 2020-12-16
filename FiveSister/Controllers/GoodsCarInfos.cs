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
        
        /// <summary>
        /// 联查购物车数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetShopCarAndGoods")]
        public List<ShopCarAndGoods> GetShopCarAndGoods()
        {
             var s = bllGoodsCarInfo.GetShopCarAndGoods();
            return s;
        }
        [HttpPost]
        [RouteAttribute("api/[controller]/DeleteCars")]
        public int DeleteCars(string ids)
        {
            return bllGoodsCarInfo.DeleteCars(ids);
        }
        [HttpPost]
        [RouteAttribute("api/[controller]/UpdateAndGo")]
        public int UpdateAndGo(int id)
        {
            return bllGoodsCarInfo.UpdateAndGo(id);
        }
        [HttpPost]
        [RouteAttribute("api/[controller]/UpdateAndBack")]
        public int UpdateAndBack(int id)
        {
            return bllGoodsCarInfo.UpdateAndBack(id);
        }
    }
}
