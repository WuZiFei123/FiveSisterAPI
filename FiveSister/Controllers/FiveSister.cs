using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using BLL;
using IBLL;

namespace FiveSister.Controllers
{
    [ApiController]
    public class FiveSister : ControllerBase
    {
        IBLLClothesBrand bll;
        public FiveSister(IBLLClothesBrand _bll) 
        {
            bll = _bll;
        }
        /// <summary>
        /// 获取所有品牌
        /// </summary>
        /// <returns></returns>
        [RouteAttribute("api/[controller]/GetClothesBrands")]
        public List<ClothesBrand> GetClothesBrands()
        {
            return bll.GetClothesBrands();
        }
        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <returns></returns>
        [RouteAttribute("api/[controller]/AddClothesBrand")]
        public int AddClothesBrand()
        {
            ClothesBrand c = new ClothesBrand() { ClothesBrandName="特步" };
            return bll.AddClothesBrand(c);
        }
    }
}
