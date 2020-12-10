using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using IBLL;
using Model;

namespace FiveSister.Controllers
{
    [ApiController]
    public class PosstionInfoControllers : ControllerBase
    {
        IBLLPosstionInfo bLLPosstionInfo;
        public PosstionInfoControllers(IBLLPosstionInfo _bLLPosstionInfo)
        {
            bLLPosstionInfo = _bLLPosstionInfo;
        }
        /// <summary>
        /// 查询所有省市区
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetPosstionInfos")]
        public List<PosstionInfo> GetPosstionInfos(int pid)
        {
            return bLLPosstionInfo.GetPosstionInfos(pid);
        }
    }
}
