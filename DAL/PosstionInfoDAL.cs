using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public class PosstionInfoDAL
    {
        /// <summary>
        /// 查询省市区
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<PosstionInfo> GetPosstionInfos(int pid)
        {
            string sql = $"select * from PosstionInfo where PosstionInfoId={pid}";
            return DapperHelper.GetList<PosstionInfo>(sql);
        }
    }
}
