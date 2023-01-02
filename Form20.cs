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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WireFrames
{
    public partial class Form20 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EKQALCO\\SQLEXPRESS02;Initial Catalog=veterinary_clinic;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        
        DataTable dt;
     
        public Form20()
        {
            InitializeComponent();
            DisplayValue();
            Display();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet24.EMR' table. You can move, or remove it, as needed.
            this.eMRTableAdapter1.Fill(this.veterinary_clinicDataSet24.EMR);
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet23.Dr_soap' table. You can move, or remove it, as needed.
            this.dr_soapTableAdapter.Fill(this.veterinary_clinicDataSet23.Dr_soap);







            // TODO: This line of code loads data into the 'veterinary_clinicDataSet5.EMR' table. You can move, or remove it, as needed.
            this.eMRTableAdapter.Fill(this.veterinary_clinicDataSet5.EMR);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
            this.Hide();
        }

       
        public void SearchData(String search)
        {
            con.Open();
            string query = " Select * from EMR where PetID like '%"+search+"%'";
            adapt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void Search(String search)
        {
            con.Open();
            string query = " Select * from Dr_soap where PetID like '%"+ search +"%'";
            adapt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        public void DisplayValue()
        {
            con.Open();
            adapt = new SqlDataAdapter(" Select * from EMR", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void Display()
        {
            con.Open();
            adapt = new SqlDataAdapter(" Select * from Dr_soap", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBox1.Text);
            Search(textBox1.Text);
        }
    }
}
