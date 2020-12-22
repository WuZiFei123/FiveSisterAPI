using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace IBLL
{
    public interface IBLLAddRemarkInfo
    {
        /// <summary>
        /// 添加评价
        /// </summary>
        /// <param name="RUG"></param>
        /// <returns></returns>
        int AddRemarkInfo(RemarkInfoAndUserInfoAndGoodsInfo RUG);
    }
}
