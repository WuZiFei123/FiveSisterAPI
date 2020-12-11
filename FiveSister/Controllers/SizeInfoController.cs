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
    public class SizeInfoController : ControllerBase
    {
        IBLLSizeInfo BLLSizeInfo;
        public SizeInfoController(IBLLSizeInfo _BLLSizeInfo)
        {
            BLLSizeInfo = _BLLSizeInfo;
        }
        /// <summary>
        /// 获取全部尺码
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetSizeInfos")]
        public List<SizeInfo> GetSizeInfos()
        {
            return BLLSizeInfo.GetSizeInfos();
        }
    }
}
