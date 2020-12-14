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
        public List<UserInfo> GetUserInfos(string name, string pass)
        {
            return _goodsUserInfobll.GetUserInfos(name,pass);
            
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
    }
}
