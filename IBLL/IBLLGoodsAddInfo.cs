using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace IBLL
{
   public interface IBLLGoodsAddInfo
    {
        /// <summary>
        /// 查询所有收藏
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        List<GoodsAddInfoAndUserInfoAndGoodsInfo> GetGoodsAddInfos(int UserId);
        /// <summary>
        /// 删除收藏
        /// </summary>
        /// <param name="ClectId"></param>
        /// <returns></returns>
        int UpdateGoodsClect(int ClectId);
    }
}
