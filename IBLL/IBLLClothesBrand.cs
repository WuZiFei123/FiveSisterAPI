using System;
using System.Collections.Generic;
using Model;

namespace IBLL
{
    public interface IBLLClothesBrand
    {
        /// <summary>
        /// 根据Id获取品牌
        /// </summary>
        /// <returns></returns>
        List<ClothesBrand> GetClothesBrands(int Id);
        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        int AddClothesBrand(ClothesBrand c);
    }
}
