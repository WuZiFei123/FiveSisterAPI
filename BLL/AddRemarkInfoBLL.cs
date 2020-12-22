using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;
using IBLL;

namespace BLL
{
    public class AddRemarkInfoBLL : IBLLAddRemarkInfo
    {
        RemarkInfoDAL dal = new RemarkInfoDAL();
        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="RUG"></param>
        /// <returns></returns>
        public int AddRemarkInfo(RemarkInfoAndUserInfoAndGoodsInfo RUG)
        {
            return dal.AddRemarkInfo(RUG);
        } 
    }
}
