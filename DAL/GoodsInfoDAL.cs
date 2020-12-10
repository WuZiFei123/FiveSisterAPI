using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL
{
   public class GoodsInfoDAL
    {
        /// <summary>
        /// 商品存储过程分页显示
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="Name"></param>
        /// <param name="Brand"></param>
        /// <param name="Types"></param>
        /// <returns></returns>
        public GoodsInfo_PageList GetGoodsInfosPage(int PageIndex, int PageSize, string Name, string Brand, string Types)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter(){ ParameterName="@Name", DbType=DbType.String,Value=Name},
                new SqlParameter() { ParameterName = "@Brand", DbType=DbType.String,Value=Brand},
                new SqlParameter() { ParameterName = "@Types", DbType = DbType.String, Value = Types },
                new SqlParameter() { ParameterName = "@PageIndex", DbType = DbType.Int32, Value = PageIndex },
                new SqlParameter() { ParameterName = "@PageSize", DbType = DbType.Int32, Value = PageSize },
                new SqlParameter() { ParameterName = "@PageCount", DbType = DbType.Int32,Direction=ParameterDirection.Output}
            };
            GoodsInfo_PageList list = new GoodsInfo_PageList()
            {
                GoodsInfos = DBHelper.GetGoodsInfosPage("GoodsInfo_Page", parameters),
                Count = Convert.ToInt32(parameters[5].Value)
            };
            return list;
        }
        /// <summary>
        /// 查询销售量最高的商品
        /// </summary>
        /// <returns></returns>
        public List<GoodsInfo> GetGoodsInfoTop()
        {
            string sql = $"select top 4 * from GoodsInfo order by  GoodsInfoCount desc";
            return DapperHelper.GetList<GoodsInfo>(sql);
        }
    }
}
