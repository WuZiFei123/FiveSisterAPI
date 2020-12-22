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
        public List<GoodsCarInfo> GetShopCarAndGoods(int UserId)
        {
             var s = bllGoodsCarInfo.GetShopCarAndGoods(UserId);
            return s;
        }
        /// <summary>
        /// 删除单个购物车
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpPost]
        [RouteAttribute("api/[controller]/DeleteCars")]
        public int DeleteCars(string ids)
        {
            return bllGoodsCarInfo.DeleteCars(ids);
        }
        /// <summary>
        /// 修改数量+
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [RouteAttribute("api/[controller]/UpdateAndGo")]
        public int UpdateAndGo(int id)
        {
            return bllGoodsCarInfo.UpdateAndGo(id);
        }
        /// <summary>
        /// 修改数量-
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [RouteAttribute("api/[controller]/UpdateAndBack")]
        public int UpdateAndBack(int id)
        {
            return bllGoodsCarInfo.UpdateAndBack(id);
        }
        /// <summary>
        /// 购物车添加商品
        /// </summary>
        /// <param name = "id" ></ param >
        /// < returns ></ returns >
        [HttpPost]
        [RouteAttribute("api/[controller]/AddGoodsCarInfos")]
        public int AddGoodsCarInfos([FromForm] GoodsCarInfo goodsCar)
        {
            return bllGoodsCarInfo.AddGoodsCarInfos(goodsCar);

        }
        /// <summary>
        /// 购物车全选价格
        /// </summary>
        /// <param name = "id" ></ param >
        /// < returns ></ returns >
        [HttpGet]
        [RouteAttribute("api/[controller]/GetGoodsCarPrice")]
        public TempCar GetGoodsCarPrice(string ids,int UserId)
        {
            return bllGoodsCarInfo.GetGoodsCarPrice(ids, UserId);
        }
    }
}
