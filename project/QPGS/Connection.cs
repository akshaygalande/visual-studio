using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
namespace QPGS
{
    public class Connection
    {
        static string constr = ConfigurationManager.ConnectionStrings["DQPGS"].ConnectionString; 
        public SqlConnection con = new SqlConnection(constr);
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        public SqlDataAdapter adapter = new SqlDataAdapter();

        public void Open()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Close()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
