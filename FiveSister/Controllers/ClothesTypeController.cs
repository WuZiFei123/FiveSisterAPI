using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBLL;
using Model;
using BLL;

namespace FiveSister.Controllers
{

    [ApiController]
    public class ClothesTypeController : ControllerBase
    {
        IBLLClothesType bLLClothesType;
        public ClothesTypeController(IBLLClothesType _bLLClothesType)
        {
            bLLClothesType = _bLLClothesType;
        }
        /// <summary>
        /// 查询所有类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetClothesTypes")]
        public List<ClothesType> GetClothesTypes()
        {
            return bLLClothesType.GetClothesTypes();
        }
    }
}
