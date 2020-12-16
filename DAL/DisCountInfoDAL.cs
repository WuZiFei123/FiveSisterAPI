using System;
using System.Collections.Generic;
using System.Text;
using Model;


namespace DAL
{
  public  class DisCountInfoDAL
    {
        /// <summary>
        /// 获取所有优惠券
        /// </summary>
        /// <returns></returns>
        public List<DisCountInfo> GetDisCountInfos()
        {
            string sql = "select * from DisCountInfo";
            return DapperHelper.GetList<DisCountInfo>(sql);
        }
    }
}
