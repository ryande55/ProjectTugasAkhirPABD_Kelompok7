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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SGLQ4RNL\\RYANDA;database=DOA_DOA_HARIANN;User ID=sa;Password=agung223");
        private void Form4_Load(object sender, EventArgs e)
        {
           

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.DoaHarian'" + TextId.Text + "','" + textNama.Text + "','" +   "','" + textLatin + "','" + textTerjemahan + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.deleteDoa'" + TextId.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.UpdateDoa'" + TextId.Text + "','" + textNama.Text + "','" +   "','" + textLatin + "','" + textTerjemahan + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        void tampilkan()
        {
            SqlCommand com = new SqlCommand("exec dbo.tampilDoa", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
