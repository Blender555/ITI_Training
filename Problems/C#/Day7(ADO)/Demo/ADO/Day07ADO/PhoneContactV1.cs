using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day07ADO
{
    public partial class PhoneContactV1 : Form
    {
        public PhoneContactV1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          dataGridViewContacts.DataSource = GetAll();
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1KVIP8;Initial Catalog=DB_ADO;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("Select * From Contacts");
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        private void PhoneContactV1_Load(object sender, EventArgs e)
        {
            dataGridViewContacts.DataSource = GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1KVIP8;Initial Catalog=DB_ADO;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("Select * From Contacts where ID = @ID");
            cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                textBoxName.Text = dt.Rows[0]["Name"].ToString();
                textBoxPhone.Text = dt.Rows[0]["Phone"].ToString();
                textBoxAddress.Text = dt.Rows[0]["Address"].ToString();
            }
            else
            {
                MessageBox.Show(text: "No Data Found For This ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }

        }

        private void Clear()
        {
            textBoxID.Text = textBoxName.Text = textBoxAddress.Text = textBoxPhone.Text = string.Empty;
            textBoxID.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1KVIP8;Initial Catalog=DB_ADO;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("Insert Into Contacts values(@ID,@Name,@Phone,@Address) ");
            cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
            cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
            cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
            cmd.Connection = con;
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                dataGridViewContacts.DataSource = GetAll();
                MessageBox.Show( "Insertion Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Insertion Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Clear();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1KVIP8;Initial Catalog=DB_ADO;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("Update Contacts set Name=@Name,Phone=@Phone,Address=@Address where ID=@ID ");
            cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
            cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
            cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
            cmd.Connection = con;
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                dataGridViewContacts.DataSource = GetAll();
                MessageBox.Show("Update Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Update Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Clear();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1KVIP8;Initial Catalog=DB_ADO;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("Delete From Contacts where ID=@ID ");
            cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
            cmd.Connection = con;
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                dataGridViewContacts.DataSource = GetAll();
                MessageBox.Show("Delete Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Delete Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Clear();
            con.Close();
        }

        private void dataGridViewContacts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           textBoxID.Text = dataGridViewContacts.Rows[e.RowIndex].Cells[0].Value.ToString();
           textBoxName.Text = dataGridViewContacts.Rows[e.RowIndex].Cells[1].Value.ToString();
           textBoxPhone.Text = dataGridViewContacts.Rows[e.RowIndex].Cells[2].Value.ToString();
           textBoxAddress.Text = dataGridViewContacts.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e) // Like "%a%"
        {
            // mobile 12412412 , name  "Hamdy"  , address = "Banha"
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1KVIP8;Initial Catalog=DB_ADO;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("Select * From Contacts where ID like '%"+textBoxSearch.Text + "%'or Name Like'%"+textBoxSearch.Text + "%'or Phone Like'%" + textBoxSearch.Text + "%'or Address Like'%" + textBoxSearch.Text+"%'");
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridViewContacts.DataSource = dt;
        }
    }
}
