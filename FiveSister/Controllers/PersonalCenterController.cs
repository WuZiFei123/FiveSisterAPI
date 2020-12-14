using BLL;
using IBLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveSister.Controllers
{
    [ApiController]
    public class PersonalCenterController : ControllerBase
    {
        IBLLAddressInfo ibll;
        public PersonalCenterController(IBLLAddressInfo _ibll)
        {
            ibll = _ibll;
        }
        /// <summary>
        /// 查询收货地址
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/GetAddressInfos")]
        public List<AddressInfo> GetAddressInfos(int userInfoId=0)
        {
            return ibll.GetAddressInfos(userInfoId);
        }

        /// <summary>
        /// 添加收货地址
        /// </summary>
        /// <param name="addressInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [RouteAttribute("api/[controller]/AddressInfoAdd")]
        public int AddressInfoAdd(AddressInfo addressInfo)
        {
            return ibll.AddressInfoAdd(addressInfo);       
        }

        /// <summary>
        /// 修改收货地址
        /// </summary>
        /// <param name="addressInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [RouteAttribute("api/[controller]/AddressInfoModify")]
        public int AddressInfoModify(AddressInfo addressInfo)
        {
            return ibll.AddressInfoModify(addressInfo);
        }

        /// <summary>
        /// 全为不默认
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/ModifyStateAddressInfo")]
        public int ModifyStateAddressInfo(int userInfoId)
        {
            return ibll.ModifyStateAddressInfo(userInfoId);
        }

        /// <summary>
        /// 设置默认
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [RouteAttribute("api/[controller]/ModifyDefaultAddressInfo")]
        public int ModifyDefaultAddressInfo(int addressInfoId)
        {
            return ibll.ModifyDefaultAddressInfo(addressInfoId);
        }
        [HttpGet]
        [RouteAttribute("api/[controller]/DeleteAddressInfo")]
        public int DeleteAddressInfo(int addressInfoId)
        {
            return ibll.DeleteAddressInfo(addressInfoId);
        }
    }
}

