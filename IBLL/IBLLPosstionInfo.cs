using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace IBLL
{
    public interface IBLLPosstionInfo
    {
        List<PosstionInfo> GetPosstionInfos(int pid);
    }
}
