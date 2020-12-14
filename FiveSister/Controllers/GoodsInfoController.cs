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
        public GoodsInfo_PageList GetGoodsInfosPage(int PageIndex=1, int PageSize=10, string Name="", string Brand="", string Types="",int Orderby =0,int Price =0)
        {
            var s = bLLGoodsInfo.GetGoodsInfosPage(PageIndex,PageSize,Name,Brand,Types);
            if(Orderby==1)
            {
                s.GoodsInfos = s.GoodsInfos.OrderBy(g => g.GoodsInfoCount).ToList();
            }
            if (Orderby == 2)
            {
                s.GoodsInfos = s.GoodsInfos.OrderByDescending(g => g.GoodsInfoCount).ToList();
            }
            if (Price == 1)
            {
                s.GoodsInfos = s.GoodsInfos.OrderBy(g => g.GoodsInfoPrice).ToList();
            }
            if (Price == 2)
            {
                s.GoodsInfos = s.GoodsInfos.OrderByDescending(g => g.GoodsInfoPrice).ToList();
            }
            s.Con = s.GoodsInfos.Count;
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
    }
}
