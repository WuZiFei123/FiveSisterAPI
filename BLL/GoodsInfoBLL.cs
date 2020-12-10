using System;
using System.Collections.Generic;
using System.Text;
using Model;
using IBLL;
using DAL;

namespace BLL
{
    public class GoodsInfoBLL : IBLLGoodsInfo
    {
        GoodsInfoDAL dal = new GoodsInfoDAL();
        /// <summary>
        /// 分页显示商品
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="Name"></param>
        /// <param name="Brand"></param>
        /// <param name="Types"></param>
        /// <returns></returns>
        public GoodsInfo_PageList GetGoodsInfosPage(int PageIndex, int PageSize, string Name, string Brand, string Types)
        {
            return dal.GetGoodsInfosPage(PageIndex, PageSize, Name, Brand, Types);
        }
        /// <summary>
        /// 查询销售量最高的商品
        /// </summary>
        /// <returns></returns>
        public List<GoodsInfo> GetGoodsInfoTop()
        {
            return dal.GetGoodsInfoTop();
        }

        public int GoodsAdd(GoodsInfo g)
        {
            return dal.GoodsAdd(g);
        }
    }
}
