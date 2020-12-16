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
        IBLLClothesType bLLClothesType;
        public FiveSister(IBLLClothesBrand _bll,IBLLClothesType _bLLClothesType) 
        {
            bll = _bll;
            bLLClothesType = _bLLClothesType;
        }

        /// <summary>
        /// 获取所有类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetClothesTypes")]    
        public List<ClothesType> GetClothesTypes(int TypeId=0)
        {
            var s =  bLLClothesType.GetClothesTypes();
            if(TypeId!=0)
            {
                s = s.Where(s=>s.ClothesTypeId==TypeId).ToList();
                return s;
            }
            return s;
        }
        /// <summary>
        /// 获取所有品牌
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetClothesBrands")]
        public List<ClothesBrand> GetClothesBrands(int Id)
        {
            return bll.GetClothesBrands(Id);
        }
        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/AddClothesBrand")]
        public int AddClothesBrand()
        {
            ClothesBrand c = new ClothesBrand() { ClothesBrandName="特步" };
            return bll.AddClothesBrand(c);
        }
    }
}
