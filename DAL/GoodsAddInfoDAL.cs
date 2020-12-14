using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
   public class GoodsAddInfoDAL
    {
        /// <summary>
        /// 获取所有收藏
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<GoodsAddInfoAndUserInfoAndGoodsInfo> GetGoodsAddInfos(int UserId)
        {
            string sql = $"select * from GoodsAddInfo a join UserInfo b on a.UserInfoIdOut = b.UserInfoId join GoodsInfo c on a.GoodsInfoIdOut = c.GoodsInfoId where b.UserInfoId ={UserId}";
            return DapperHelper.GetList<GoodsAddInfoAndUserInfoAndGoodsInfo>(sql);
        }
        /// <summary>
        /// 删除收藏
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public int UpdateGoodsClect(int ClectId)
        {
            string sql = $"delete from GoodsAddInfo where GoodsAddInfoId ={ClectId}";
            return DapperHelper.Cud(sql);
        }
    }
}
