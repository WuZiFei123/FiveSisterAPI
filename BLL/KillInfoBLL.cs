using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DAL;
using IBLL;

namespace BLL
{
    public class KillInfoBLL : IBLLKillInfo
    {
        KillInfoDAL dal = new KillInfoDAL();
        /// <summary>
        /// 获取所有秒杀
        /// </summary>
        /// <returns></returns>
        public List<KillInfo> GetKillInfos()
        {
            return dal.GetKillInfos();
        }
    }
}
