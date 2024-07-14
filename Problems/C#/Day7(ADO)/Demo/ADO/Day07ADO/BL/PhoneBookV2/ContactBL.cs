using Day07ADO.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07ADO.BL.PhoneBookV2
{
    public static class ContactBL
    {
        //function => Static => convert to Sql command
        public static DataTable GetByID(int _id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Contacts WHERE Id = "+_id);
            return DALPhoneBook.Select(cmd);//On the Fly
            
        }

        public static DataTable GetAll()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Contacts");
            return DALPhoneBook.Select(cmd);//On the Fly
        }

        public static int AddContact(int _id, string _name, string _phone, string _address)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Contacts values (@id, @name, @phone, @address)");
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.Parameters.AddWithValue("@name", _name);
            cmd.Parameters.AddWithValue("@phone", _phone);
            cmd.Parameters.AddWithValue("@address", _address);
            return DALPhoneBook.DML(cmd);//On the Fly
        }
        
    }
}
