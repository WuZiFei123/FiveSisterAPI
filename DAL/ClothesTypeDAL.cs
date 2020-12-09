using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
   public class ClothesTypeDAL
    {
        /// <summary>
        /// 查询所有类型
        /// </summary>
        /// <returns></returns>
        public List<ClothesType> GetClothesTypes()
        {
            string sql = $"select * from ClothesType";
            return DapperHelper.GetList<ClothesType>(sql);
        }
    }
}
