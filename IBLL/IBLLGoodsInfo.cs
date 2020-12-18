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
        int GoodsAdd(GoodsInfo g);
        List<GoodsInfo> GetGoodsInfos(int id);
        List<GoodsLook> GetGoodsLooksColor(int id);
        List<GoodsLook> GetGoodsLooksSize(int id);
        List<GoodsLook> GetGoodsLooksKC(int id, string color, string size);
    }
}
