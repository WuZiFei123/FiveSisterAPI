using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Newtonsoft.Json;
using System.Linq;

namespace DAL
{
    public class DapperHelper
    {
        static IDbConnection conn = new SqlConnection("Data Source=DESKTOP-337N7SE\\MSSQLSERVERS;Initial Catalog=FiveSister;Integrated Security=True");

        /// <summary>
        /// 查询集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static List<T> GetList<T>(string sql)
        {
             return conn.Query<T>(sql).ToList();
        }
        /// <summary>
        /// 查询单个
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static T Get<T>(string sql)
        {
            var Lists = conn.Query(sql).AsList();
            if(Lists.Count>0)
            {
                return Lists[0];
            }
            else
            {
                return default(T);
            }
        }
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Cud(string sql)
        {
            return conn.Execute(sql);
        }
    }
}
