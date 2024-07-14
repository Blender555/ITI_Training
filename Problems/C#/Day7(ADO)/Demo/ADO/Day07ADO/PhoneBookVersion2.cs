using Day07ADO.BL.PhoneBookV2;
using Day07ADO.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Day07ADO
{
    public partial class PhoneBookVersion2 : Form
    {
        public PhoneBookVersion2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = ContactBL.GetByID(Convert.ToInt32(textBoxID.Text));
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show(text: "No Data Found For This ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                textBoxName.Text = dt.Rows[0]["Name"].ToString();
                textBoxPhone.Text = dt.Rows[0]["Phone"].ToString();
                textBoxAddress.Text = dt.Rows[0]["Address"].ToString();
            }
        }

        private void Clear()
        {
            textBoxID.Text = textBoxName.Text = textBoxAddress.Text = textBoxPhone.Text = string.Empty;
            textBoxID.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DataTable dt = ContactBL.GetAll();
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show(text: "No Data Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                dataGridViewContacts.DataSource = dt;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ContactBL.AddContact(int.Parse(textBoxID.Text), textBoxName.Text, textBoxPhone.Text, textBoxAddress.Text)<=0)
            {
                MessageBox.Show(text: "Insertion Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                MessageBox.Show(text: "Insertion Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewContacts.DataSource = ContactBL.GetAll();
            }
            Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
