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
        /// 用户获取优惠券
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int AddDidAndUser(DisCountAndUser d)
        {
            return dal.AddDidAndUser(d);
        }

        /// <summary>
        /// 获取所有优惠券
        /// </summary>
        /// <returns></returns>
        public DisCountInfo GetDisCountInfos(int ss)
        {
            return dal.GetDisCountInfos(ss);
        }

    }
}
