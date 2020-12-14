using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
   public class ClothesBrandDAL
    {
        /// <summary>
        /// 获取所有品牌
        /// </summary>
        /// <returns></returns>
        public List<ClothesBrand> GetClothesBrands(int Id)
        {
            string sql = "select * from ClothesBrand where 1=1";
            if(Id!=0)
            {
                sql += $" and ClothesBrandId='{Id}'";
            }
            return DapperHelper.GetList<ClothesBrand>(sql);
        }
        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int AddClothesBrand(ClothesBrand c)
        {
            string sql = $"insert into ClothesBrand values('{c.ClothesBrandName}')";
            return DapperHelper.Cud(sql);
        }
    }
}
