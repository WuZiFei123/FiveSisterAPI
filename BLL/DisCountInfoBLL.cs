using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DAL;
using IBLL;
namespace BLL
{
   public class DisCountInfoBLL:IBLLDisCountInfo
    {
        DisCountInfoDAL dal = new DisCountInfoDAL();
        /// <summary>
        /// 获取所有优惠券
        /// </summary>
        /// <returns></returns>
        public List<DisCountInfo> GetDisCountInfos()
        {
            return dal.GetDisCountInfos();
        }

    }
}
