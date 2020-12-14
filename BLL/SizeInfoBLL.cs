using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DAL;
using IBLL;

namespace BLL
{
    public class SizeInfoBLL : IBLLSizeInfo
    {
        SizeInfoDAL SizeInfoDAL = new SizeInfoDAL();
        /// <summary>
        /// 获取全部尺码
        /// </summary>
        /// <returns></returns>
        public List<SizeInfo> GetSizeInfos()
        {
            return SizeInfoDAL.GetSizeInfos();
        }
    }
}
