using System;
using System.Collections.Generic;
using Model;

namespace IBLL
{
    public interface IBLLClothesBrand
    {
        /// <summary>
        /// 获取所有品牌
        /// </summary>
        /// <returns></returns>
        List<ClothesBrand> GetClothesBrands();
        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        int AddClothesBrand(ClothesBrand c);
    }
}
