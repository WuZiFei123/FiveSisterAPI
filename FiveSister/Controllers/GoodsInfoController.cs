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
        IBLLActibityInfo bLLActibityInfo;
        IBLLKillInfo bLLKillInfo;
        public GoodsInfoController(IBLLGoodsInfo _bLLGoodsInfo, IBLLActibityInfo _bLLActibityInfo,IBLLKillInfo _bLLKillInfo)
        {
            bLLGoodsInfo = _bLLGoodsInfo;
            bLLActibityInfo = _bLLActibityInfo;
            bLLKillInfo = _bLLKillInfo;
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
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        [HttpPost]
        [RouteAttribute("api/[controller]/GoodsAdd")]
        public int GoodsAdd([FromForm] GoodsInfo g)
        {
            return bLLGoodsInfo.GoodsAdd(g);
        }
        /// <summary>
        /// 查询所有活动
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetActibityInfos")]
        public List<ActibityInfo> GetActibityInfos()
        {
            return bLLActibityInfo.GetActibityInfos();
        }
        /// <summary>
        /// 把已经推送的轮播修改为下架
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/UpdateActibityInfosByIds")]
        public int UpdateActibityInfosByIds(string ids)
        {
            return bLLActibityInfo.UpdateActibityInfosByIds(ids);
        }
        /// <summary>
        /// 查询所有秒杀
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetKillInfos")]
        public List<KillInfo> GetKillInfos()
        {
            return bLLKillInfo.GetKillInfos();
        }
        /// <summary>
        /// 查询商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetGoodsInfos")]
        public List<GoodsInfo> GetGoodsInfos(int id=0)
        {
            return bLLGoodsInfo.GetGoodsInfos(id);
        }
        /// <summary>
        /// 查询商品详情颜色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetGoodsLooksColor")]
        public List<GoodsLook> GetGoodsLooksColor(int id)
        {
            return bLLGoodsInfo.GetGoodsLooksColor(id);
        }
        /// <summary>
        /// 查询商品详情尺码
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetGoodsLooksSize")]
        public List<GoodsLook> GetGoodsLooksSize(int id)
        {
            return bLLGoodsInfo.GetGoodsLooksSize(id);
        }
        /// <summary>
        /// 查询商品库存详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetGoodsLooksKC")]
        public List<GoodsLook> GetGoodsLooksKC(int id, string color, string size)
        {
            return bLLGoodsInfo.GetGoodsLooksKC(id,color,size);
        }
        


    }
}
