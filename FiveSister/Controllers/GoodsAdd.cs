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
    public class GoodsAdd : ControllerBase
    {
        IBLLGoodsAddInfo bLLGoodsAddInfo;
        public GoodsAdd(IBLLGoodsAddInfo _bLLGoodsAddInfo)
        {
            bLLGoodsAddInfo = _bLLGoodsAddInfo;
        }
        /// <summary>
        /// 所有收藏
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetGoodsAddInfos")]
        public List<GoodsAddInfoAndUserInfoAndGoodsInfo> GetGoodsAddInfos(int UserId)
        {
            return bLLGoodsAddInfo.GetGoodsAddInfos(UserId);
        }
        /// <summary>
        /// 删除收藏
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/UpdateGoodsClect")]
        public int UpdateGoodsClect(int ClectId)
        {
            return bLLGoodsAddInfo.UpdateGoodsClect(ClectId);
        }
        /// <summary>
        /// 添加收藏
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpPost]
        [RouteAttribute("api/[controller]/AddGoodsClect")]
        public int AddGoodsClect([FromForm] GoodsAddInfo model)
        {
            return bLLGoodsAddInfo.AddGoodsClect(model);
        }
    }
}
