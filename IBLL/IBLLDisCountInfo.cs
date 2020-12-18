using System;
using System.Collections.Generic;
using System.Text;
using Model;


namespace IBLL
{
   public interface IBLLDisCountInfo
    {
        /// <summary>
        /// 获取优惠券 
        /// </summary>
        /// <returns></returns>
        DisCountInfo GetDisCountInfos(int ss);
        int AddDidAndUser(DisCountAndUser d);
        List<DisCountInfo> GetDisCountInfosById(int UserId);
        List<DisCountInfo> GetEndDisCountInfosById(int UserId);
        int DeleteDisCount(int DisAndUserId);
        /// <summary>
        //// 获取所有优惠券
        /// </summary>
        /// <returns></returns>
        List<DisCountInfo> GetDisCountInfos();
    }
}
