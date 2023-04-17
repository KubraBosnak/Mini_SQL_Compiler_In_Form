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

namespace Mini_SQL_Compiler_In_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=KUBRA-BOSNAK;Initial Catalog=DbNotKayit;Integrated Security=True");


        private void btnHelper_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.w3schools.com/sql/"); 
        }

        private void btnNewQuery_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
    
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string sorgu;
            sorgu = richTextBox1.Text;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu kontrol ediniz!");
                richMessage.Text = "Sorgunuzu kontrol ediniz!";
            }
           
        }
        private void btnCRUD_Click(object sender, EventArgs e)
        {
                string sorgu = richTextBox1.Text;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu,baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLDERS", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Sorgunuzu kontrol ediniz!");
                richMessage.Text = "Sorgunuzu kontrol ediniz!";
            }
        }
    }
}
