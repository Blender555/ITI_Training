using System.Data.SqlClient;
using System.Data;

namespace lab_7_ado.DAL
{
    internal class DALPhoneBook
    {
        private static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PhoneContacts;Integrated Security=True;TrustServerCertificate=True");
      
        public static DataTable Select(SqlCommand _cmd)
        {
            DataTable dt = new DataTable();
            _cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(_cmd);
            adapter.Fill(dt);
            return dt;
        }
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
