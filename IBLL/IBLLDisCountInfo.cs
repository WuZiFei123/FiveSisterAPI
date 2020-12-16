using System;
using System.Collections.Generic;
using System.Text;
using Model;


namespace IBLL
{
   public interface IBLLDisCountInfo
    {
        /// <summary>
        /// 获取所有优惠券
        /// </summary>
        /// <returns></returns>
        List<DisCountInfo> GetDisCountInfos();
    }
}
