using System.Data;
using System.Data.SqlClient;
using lab_7_ado.DAL;

namespace lab_7_ado.BL
{
    public static class ContactBL
    {
        public static DataTable GetByID(int _id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Information WHERE id = " + _id);
            return DALPhoneBook.Select(cmd);

        }
        public static DataTable GetAll()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Information");
            return DALPhoneBook.Select(cmd);
        }

        public static int AddContact(string _name, string _phone, string _address)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Information values (@name, @phone, @address)");
            cmd.Parameters.AddWithValue("@name", _name);
            cmd.Parameters.AddWithValue("@phone", _phone);
            cmd.Parameters.AddWithValue("@address", _address);
            return DALPhoneBook.DML(cmd);
        }
        public static int UpdateContact(int _id, string _name, string _phone, string _address)
        {
            SqlCommand cmd = new SqlCommand("Update Information set name=@Name,phone=@Phone,address=@Address where id=@ID ");
            cmd.Parameters.AddWithValue("@ID", _id);
            cmd.Parameters.AddWithValue("@Name", _name);
            cmd.Parameters.AddWithValue("@Phone", _phone);
            cmd.Parameters.AddWithValue("@Address", _address);
            return DALPhoneBook.DML(cmd);
        }
        public static int DeleteContact(int _id)
        {
            SqlCommand cmd = new SqlCommand("Delete From Information where id=@ID");
            cmd.Parameters.AddWithValue("@ID", _id);
            return DALPhoneBook.DML(cmd);
        }
        
    }
}
