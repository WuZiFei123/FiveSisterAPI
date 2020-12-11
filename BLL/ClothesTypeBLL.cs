using System;
using System.Collections.Generic;
using System.Text;
using Model;
using IBLL;
using DAL;

namespace BLL
{
    public class ClothesTypeBLL : IBLLClothesType
    {
        ClothesTypeDAL dal = new ClothesTypeDAL();

        /// <summary>
        /// 获取所有类型
        /// </summary>
        /// <returns></returns>
        public List<ClothesType> GetClothesTypes()
        {
            return dal.GetClothesTypes();
        }
        /// <summary>
        /// 联动复选框查询
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<ClothesType> GetClothesType(int pid)
        {
            return dal.GetClothesType(pid);
        }
    }
}
