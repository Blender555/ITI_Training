using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07ADO.DAL
{
    public static class DALPhoneBook
    {
        //Select
        private static SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1KVIP8;Initial Catalog=DB_ADO;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"); 
        public static DataTable Select(SqlCommand _cmd)
        {
            DataTable dt = new DataTable();
            _cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(_cmd);
            adapter.Fill(dt);
            return dt;
        }
        //DML
        public static int DML(SqlCommand _cmd)
        {
            _cmd.Connection = con;
            con.Open();
            int result = _cmd.ExecuteNonQuery();
            con.Close();
            return result;
            
        }
    }
}
