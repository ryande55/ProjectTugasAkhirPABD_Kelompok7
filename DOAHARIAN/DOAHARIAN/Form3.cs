using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DOAHARIAN
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-SGLQ4RNL\\RYANDA; Initial Catalog = DOA_DOA_HARIANN; Persist Security Info = True;User ID = sa; Password=agung223");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "User" && txtPassword.Text == "user")
            {
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and password");
                txtUsername.Clear();
                txtPassword.Clear();
                this.Close();
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
