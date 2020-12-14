using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public class PosstionInfoDAL
    {
        /// <summary>
        /// 地址三级联动
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<PosstionInfo> GetPosstionInfos(int pid)
        {
            string sql = $"select * from PosstionInfo where Pid={pid}";
            return DapperHelper.GetList<PosstionInfo>(sql);
        }
        /// <summary>
        /// 获取地址name
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<PosstionInfo> GetPosstionInfosName(int pid)
        {
            string sql = $"select * from PosstionInfoId where Pid={pid}";
            return DapperHelper.GetList<PosstionInfo>(sql);
        }
    }
}
