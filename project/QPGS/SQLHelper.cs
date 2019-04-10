using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QPGS
{
    class SQLHelper
    {
        public static SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["DQPGS"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            return con;
        }
        public static void ExecuteNonQuery(string strcmd)
        {
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand(strcmd, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetData(string strcmd)
        {
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand(strcmd, con);
                SqlDataAdapter dtadp = new SqlDataAdapter();
                dtadp.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dtadp.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int GetID(string strModule, string strPrefix)
        {
            try
            {
                string strcmd = "select LastRunning from AutoRunning where Prefix='" + strPrefix + "' and MModule='" + strModule + "'";
                DataTable dt = new DataTable();
                dt = GetData(strcmd);
                int n = 0;
                if (dt.Rows.Count > 0)
                {
                    n = Convert.ToInt32(dt.Rows[0]["LastRunning"].ToString());
                    n++;
                    strcmd = "update AutoRunning set LastRunning=" + n + " where Prefix='" + strPrefix + "' and MModule='" + strModule + "'";
                    ExecuteNonQuery(strcmd);
                }
                else
                {
                    n = 1;
                    strcmd = "insert into AutoRunning values('" + strModule + "','" + strPrefix + "'," + n + ")";
                    ExecuteNonQuery(strcmd);
                }
                return n;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
