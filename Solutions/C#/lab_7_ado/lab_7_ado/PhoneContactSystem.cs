using System.Data;
using System.Data.SqlClient;
using lab_7_ado.BL;

namespace lab_7_ado
{
    public partial class PhoneContactSystem : Form
    {
        public PhoneContactSystem()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            id_txt.Text = name_txt.Text = address_txt.Text = phone_txt.Text = string.Empty;
            id_txt.Focus();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (ContactBL.AddContact(name_txt.Text, phone_txt.Text, address_txt.Text) <= 0)
            {
                MessageBox.Show(text: "insertion failed", "failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(text: "insertion done", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView.DataSource = ContactBL.GetAll();
            }
            Clear();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_txt.Text))
            {
                MessageBox.Show("Please Enter Value in ID Field");
            }
            else
            {
                if (ContactBL.UpdateContact(int.Parse(id_txt.Text), name_txt.Text, phone_txt.Text, address_txt.Text) > 0)
                {
                    dataGridView.DataSource = ContactBL.GetAll();
                    MessageBox.Show("Update Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Clear();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_txt.Text))
            {
                MessageBox.Show("Please Enter Value in ID Field");
            }
            else
            {
                if (ContactBL.DeleteContact(int.Parse(id_txt.Text)) > 0)
                {
                    dataGridView.DataSource = ContactBL.GetAll();
                    MessageBox.Show("Delete Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Clear();
        }

        private void by_id_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_txt.Text))
            {
                MessageBox.Show("Please Enter Value in ID Field");
            }
            else
            {
                DataTable dt = ContactBL.GetByID(Convert.ToInt32(id_txt.Text));
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show(text: "No Data Found For This ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    name_txt.Text = dt.Rows[0]["name"].ToString();
                    phone_txt.Text = dt.Rows[0]["phone"].ToString();
                    address_txt.Text = dt.Rows[0]["address"].ToString();
                }
            }
        }

        private void all_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = ContactBL.GetAll();
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show(text: "No Data Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                dataGridView.DataSource = dt;
            }
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_txt.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            name_txt.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            phone_txt.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            address_txt.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PhoneContacts;Integrated Security=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("Select * From Information where id like '%" + search_txt.Text + "%'or name Like'%" + search_txt.Text + "%'or phone Like'%" + search_txt.Text + "%'or address Like'%" + search_txt.Text + "%'");
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
