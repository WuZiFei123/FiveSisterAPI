using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public class SizeInfoDAL
    {
        /// <summary>
        /// 获取所有尺码
        /// </summary>
        /// <returns></returns>
        public List<SizeInfo> GetSizeInfos()
        {
            string sql = $"select * from SizeInfo";
            return DapperHelper.GetList<SizeInfo>(sql);

        }
    }
}
