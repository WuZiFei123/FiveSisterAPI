using System;
using System.Collections.Generic;
using System.Text;
using IBLL;
using DAL;
using Model;

namespace BLL
{
    public class PosstionInfoBLL : IBLLPosstionInfo
    {
        PosstionInfoDAL PosstionInfoDAL = new PosstionInfoDAL();
        /// <summary>
        /// 地址三级联动
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<PosstionInfo> GetPosstionInfos(int pid)
        {
            return PosstionInfoDAL.GetPosstionInfos(pid);
        }
        /// <summary>
        /// 获取地址name
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<PosstionInfo> GetPosstionInfosName(int pid)
        {
            return PosstionInfoDAL.GetPosstionInfosName(pid);
        }
    }
}
