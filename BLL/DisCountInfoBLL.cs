using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DAL;
using IBLL;
namespace BLL
{
   public class DisCountInfoBLL:IBLLDisCountInfo
    {
        DisCountInfoDAL dal = new DisCountInfoDAL();

        /// <summary>
        /// 用户获取优惠券
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int AddDidAndUser(DisCountAndUser d)
        {
            return dal.AddDidAndUser(d);
        }
        /// <summary>
        /// 获取该用户的失效的优惠券
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<DisCountInfo> GetEndDisCountInfosById(int UserId)
        {
            return dal.GetEndDisCountInfosById(UserId);
        }
        /// <summary>
        /// 删除过期优惠券
        /// </summary>
        /// <param name="DisAndUserId"></param>
        /// <returns></returns>
        public int DeleteDisCount(int DisAndUserId)
        {
            return dal.DeleteDisCount(DisAndUserId);
        }
        /// <summary>
        /// 获取该用户的所有优惠券
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<DisCountInfo> GetDisCountInfosById(int UserId)
        {
            return dal.GetDisCountInfosById(UserId);
        }
        /// <summary>
        /// 获取所有优惠券
        /// </summary>
        /// <returns></returns>
        public DisCountInfo GetDisCountInfos(int ss)
        {
            return dal.GetDisCountInfos(ss);
        }

        public List<DisCountInfo> GetDisCountInfos()
        {
            throw new NotImplementedException();
        }
    }
}
