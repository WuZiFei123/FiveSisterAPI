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
        /// <summary>
        /// 联动复选框查询类型
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<ClothesType> GetClothesType(int pid)
        {
            string sql = $"select * from ClothesType where ClothesTypePid={pid}";
            return DapperHelper.GetList<ClothesType>(sql);
        }
    }
}
