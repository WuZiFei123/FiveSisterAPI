using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DAL;
using IBLL;

namespace BLL
{
   public class GoodsAddInfoBLL:IBLLGoodsAddInfo
    {
        GoodsAddInfoDAL dal = new GoodsAddInfoDAL();
        /// <summary>
        /// 所有收藏
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<GoodsAddInfoAndUserInfoAndGoodsInfo> GetGoodsAddInfos(int UserId)
        {
            return dal.GetGoodsAddInfos(UserId);
        }
        /// <summary>
        /// 删除收藏
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public int UpdateGoodsClect(int ClectId)
        {
            return dal.UpdateGoodsClect(ClectId);
        }
    }
}
