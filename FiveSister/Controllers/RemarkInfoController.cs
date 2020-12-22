using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using IBLL;
using BLL;

namespace FiveSister.Controllers
{
    
    [ApiController]
    public class RemarkInfoController : ControllerBase
    {
        IBLLAddRemarkInfo bllAddRemarkInfo;
        public RemarkInfoController(IBLLAddRemarkInfo _bll)
        {
            bllAddRemarkInfo = _bll;
        }
        [HttpPost]
        [RouteAttribute("api/[controller]/AddRemarkInfo")]
        public int AddRemarkInfo([FromForm]RemarkInfoAndUserInfoAndGoodsInfo RUG)
        {
            return bllAddRemarkInfo.AddRemarkInfo(RUG);
        }
    }
}