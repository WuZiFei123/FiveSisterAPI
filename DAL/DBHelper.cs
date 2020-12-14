using System;
using System.Collections.Generic;
using System.Data.SqlClient;//引用数据库客户端
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;
using Newtonsoft.Json;

namespace DAL
{
    public class DBHelper
    {
        //连接数据库
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=FiveSister;Integrated Security=True");
        /// <summary>
        /// 商品分页显示
        /// </summary>
        /// <param name="ProcName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static List<GoodsInfo> GetGoodsInfosPage(string ProcName,SqlParameter[] parameters=null)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(ProcName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            string str = JsonConvert.SerializeObject(dt);
            List<GoodsInfo> list = JsonConvert.DeserializeObject<List<GoodsInfo>>(str);   
            return list;
        }
    }
}
