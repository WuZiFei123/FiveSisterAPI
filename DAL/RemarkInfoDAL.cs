using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public class RemarkInfoDAL
    {
        /// <summary>
        /// 添加评价表
        /// </summary>
        /// <param name="RUG"></param>
        /// <returns></returns>
        public int AddRemarkInfo(RemarkInfoAndUserInfoAndGoodsInfo RUG)
        {
            
            string sql = $"insert into RemarkInfo values('{RUG.RemarkInfoDesc}','{RUG.UserInfoIdOut}','{RUG.GoodsLookIdOut}','{DateTime.Now}','{RUG.RemarkImg}','{RUG.RemarkStare}')";
            return DapperHelper.Cud(sql);
        }
    }
}
