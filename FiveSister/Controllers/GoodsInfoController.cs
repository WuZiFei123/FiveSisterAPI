using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IBLL;
using BLL;
using Model;

namespace FiveSister.Controllers
{ 
    [ApiController]
    public class GoodsInfoController : ControllerBase
    {
        IBLLGoodsInfo bLLGoodsInfo;
        public GoodsInfoController(IBLLGoodsInfo _bLLGoodsInfo)
        {
            bLLGoodsInfo = _bLLGoodsInfo;
        }
        /// <summary>
        /// 分页获取获取所有商品
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetGoodsInfosPage")]
        public GoodsInfo_PageList GetGoodsInfosPage(int PageIndex=1, int PageSize=1, string Name="", string Brand="", string Types="")
        {
            var s = bLLGoodsInfo.GetGoodsInfosPage(PageIndex,PageSize,Name,Brand,Types);
            return s;
        }
        /// <summary>
        ///查询销售量最高的商品
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetGoodsInfoTop")]
        public List<GoodsInfo> GetGoodsInfoTop()
        {
            return bLLGoodsInfo.GetGoodsInfoTop();
        }
    }
}
