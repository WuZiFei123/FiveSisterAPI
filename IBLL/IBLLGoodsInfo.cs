using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace IBLL
{
   public interface IBLLGoodsInfo
    {
        GoodsInfo_PageList GetGoodsInfosPage(int PageIndex,int PageSize,string Name,string Brand,string Types);
        List<GoodsInfo> GetGoodsInfoTop();
    }
}
