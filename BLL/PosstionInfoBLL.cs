using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DAL;
using IBLL;

namespace BLL
{
    public class PosstionInfoBLL : IBLLPosstionInfo
    {
        PosstionInfoDAL PosstionInfoDAL = new PosstionInfoDAL();
        /// <summary>
        /// 查询省市区
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<PosstionInfo> GetPosstionInfos(int pid)
        {
            return PosstionInfoDAL.GetPosstionInfos(pid);
        }
    }
}
