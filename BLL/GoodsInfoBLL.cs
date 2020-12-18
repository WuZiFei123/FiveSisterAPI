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
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public int GoodsAdd(GoodsInfo g)
        {
            return dal.GoodsAdd(g);
        }
        /// <summary>
        /// 查询商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<GoodsInfo> GetGoodsInfos(int id)
        {
            return dal.GetGoodsInfos(id);
        }
        /// <summary>
        /// 查询商品参数颜色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<GoodsLook> GetGoodsLooksColor(int id)
        {
            return dal.GetGoodsLooksColor(id);
        }
        /// <summary>
        /// 查询商品参数尺码
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<GoodsLook> GetGoodsLooksSize(int id)
        {
            return dal.GetGoodsLooksSize(id);
        }
        /// <summary>
        /// 查询商品库存
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<GoodsLook> GetGoodsLooksKC(int id, string color, string size)
        {
            return dal.GetGoodsLooksKC(id,color,size);
        }
        
    }
}
