using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;
using IBLL;

namespace BLL
{
    public class ActibityInfoBLL : IBLLActibityInfo
    {
        ActibityInfoDAL dal = new ActibityInfoDAL();
        /// <summary>
        /// 查询所有活动
        /// </summary>
        /// <returns></returns>
        public List<ActibityInfo> GetActibityInfos()
        {
            return dal.GetActibityInfos();
        }
        /// <summary>
        /// 把已经推送的轮播修改为下架
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int UpdateActibityInfosByIds(string ids)
        {
            return dal.UpdateActibityInfosByIds(ids);
        }
    }
}
