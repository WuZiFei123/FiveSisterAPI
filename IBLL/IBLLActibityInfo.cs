using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBLL
{
   public interface IBLLActibityInfo
    {
        List<ActibityInfo> GetActibityInfos();
        int UpdateActibityInfosByIds(string ids);
    }
}
