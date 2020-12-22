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
using System.Diagnostics;

namespace DAL
{
    public class DBHelper
    {
        static string StrConn = "Data Source=.;Initial Catalog=FiveSister;Integrated Security=True";
        //连接数据库
        static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-337N7SE\\MSSQLSERVERS;Initial Catalog=FiveSister;Integrated Security=True");
        /// <summary>
        /// 商品分页显示
        /// </summary>
        /// <param name="ProcName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static List<GoodsInfo> GetGoodsInfosPage(string ProcName,SqlParameter[] parameters=null)
        {
            using (SqlConnection conn = new SqlConnection(StrConn))
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
        //调用存储过程
        public static int ExecTran_Pay(int UserId,int ShopUserId,int Price)
        {
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                SqlTransaction tran;//定义事务
                conn.Open();
                tran = conn.BeginTransaction();//事务开始
                var red = DapperHelper.GetList<UserInfo>($"select * from UserInfo  where UserInfoId={UserId}");
                var UserMoney = red[0].UserInfoMoney;
                    SqlCommand comm2 = new SqlCommand($"update UserInfo set UserInfoMoney = UserInfoMoney-{Price} where UserInfoId ={UserId}");
                    comm2.Connection = conn;
                    comm2.Transaction = tran;
                    comm2.ExecuteNonQuery();
                    SqlCommand comm = new SqlCommand($"update UserInfo set UserInfoMoney = UserInfoMoney+{Price} where UserInfoId ={ShopUserId}");
                    comm.Connection = conn;
                    comm.Transaction = tran;
                    comm.ExecuteNonQuery();
                    tran.Commit();//事务提交
                    return 1;
            }
        }
    }
}
