using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace IBLL
{
   public interface IBLLKillInfo
    {
        /// <summary>
        /// 获取所有秒杀
        /// </summary>
        /// <returns></returns>
        List<KillInfo> GetKillInfos();
    }
}
