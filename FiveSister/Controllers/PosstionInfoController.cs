using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBLL;
using BLL;
using Model;

namespace FiveSister.Controllers
{
    [ApiController]
    public class PosstionInfoController : ControllerBase
    {
        IBLLPosstionInfo BLLPosstionInfo;
        public PosstionInfoController(IBLLPosstionInfo _bLLPosstionInfo)
        {
            BLLPosstionInfo = _bLLPosstionInfo;
        }
        /// <summary>
        /// 地址三级联动
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetPosstionInfos")]
        public List<PosstionInfo> GetPosstionInfos(int pid)
        {
            return BLLPosstionInfo.GetPosstionInfos(pid);
        }
        /// <summary>
        /// 获取地址name
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetPosstionInfosName")]
        public List<PosstionInfo> GetPosstionInfosName(int pid)
        {
            return BLLPosstionInfo.GetPosstionInfosName(pid);
        }
    }
}
