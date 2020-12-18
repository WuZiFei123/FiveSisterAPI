using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;
using Model;
using IBLL;
namespace FiveSister.Controllers
{

    [ApiController]
    public class GoodsUserInfo : ControllerBase
    {
        IBLLUserInfo _goodsUserInfobll;
        public GoodsUserInfo(IBLLUserInfo bllUserInfo)
        {
            _goodsUserInfobll = bllUserInfo;
        } 
        [HttpGet]
        [RouteAttribute("api/[controller]/GetUserInfos")]
        public UserInfo GetUserInfos(string name, string pass)
        
        {
            var s =  _goodsUserInfobll.GetUserInfos(name,pass);
            return s[0];           
        }
        [HttpGet]
        [RouteAttribute("api/[controller]/GetUserInfos")]
        public List<UserInfo> GetUserInfos(UserInfo userInfo)
        {
            return _goodsUserInfobll.GetUserInfos(userInfo);
        }
        [HttpPost]
        [RouteAttribute("api/[controller]/GetZhu")]
        public int GetZhu([FromForm]UserInfo user)
        { 
            return _goodsUserInfobll.GetZhu(user);
        }
        [RouteAttribute("api/[controller]/Update")]
        public int Update([FromForm] string UserInfoPass,string UserInfoId)
        {
            return _goodsUserInfobll.Update(UserInfoPass,UserInfoId);
        }
        /// <summary>
        /// 根据Id获取用户
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetUserInfoById")]
        public UserInfo GetUserInfoById(int Id)
        {
            var s =  _goodsUserInfobll.GetUserInfoById(Id);
            return s;
        }
        /// <summary>
        /// 扣钱付款
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/PayMoneyUser")]
        public int PayMoneyUser(int Price,int UserId)
        {
            var s =  _goodsUserInfobll.PayMoneyUser(Price, UserId);
            return s;
        }
        /// <summary>
        /// 商家收钱
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/ReMoneyShopUser")]
        public int ReMoneyShopUser(int Price, int UserId)
        {
            var s =  _goodsUserInfobll.ReMoneyShopUser(Price, UserId);
            return s;
        }
        /// <summary>
        /// 获取买家的余额
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetUserMoney")]
        public int ReMoneyShopUser(int UserId)
        {
            var s = _goodsUserInfobll.GetUserMoney(UserId);
            return s;
        }
        /// <summary>
        /// 支付事务
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/ExecTran_Pay")]
        public int ExecTran_Pay(int UserId,int ShopUserId,int Price)
        {
            var s = _goodsUserInfobll.ExecTran_Pay(UserId,ShopUserId,Price);
            return s;
        }
    }
}
