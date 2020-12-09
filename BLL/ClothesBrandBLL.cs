using System;
using Model;
using IBLL;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class ClothesBrandBLL : IBLLClothesBrand
    {
        ClothesBrandDAL dal = new ClothesBrandDAL();
        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int AddClothesBrand(ClothesBrand c)
        {
            return dal.AddClothesBrand(c);
        }
        /// <summary>
        /// 获取所有品牌
        /// </summary>
        /// <returns></returns>
        public List<ClothesBrand> GetClothesBrands()
        {
            return dal.GetClothesBrands();
        }
    }
}
