﻿using System;
using System.Collections.Generic;
using System.Text;
using Model;
using IBLL;
using DAL;

namespace BLL
{
    public class ShopInfoBLL : IBLLShopInfo
    {
        ShopInfoDAL ShopInfoDAL = new ShopInfoDAL();
        /// <summary>
        /// 查询所有店铺
        /// </summary>
        /// <returns></returns>
        public List<ShopInfo> GetShopInfos()
        {
            return ShopInfoDAL.GetShopInfos();
        }
        /// <summary>
        /// 根据具体商品查询商家Id
        /// </summary>
        /// <returns></returns>
        public int GetShopUserId(int ShopUserId)
        {
            return ShopInfoDAL.GetShopUserId(ShopUserId);
        }
    }
}
