using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WireFrames
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet17.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter1.Fill(this.veterinary_clinicDataSet17.Pharmacy);
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet16.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter.Fill(this.veterinary_clinicDataSet16.Pharmacy);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Pharmacy pharmacy = new Pharmacy();
            pharmacy.AvailableDrugs = comboBox1.Text;
            pharmacy.AddDrug = textBox1.Text;
            pharmacy.Vaccinces = comboBox2.Text;
            pharmacy.AddVaccines = textBox2.Text;

            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Pharmacy (AvailableDrugs,AddDrug,Vaccines,AddVaccines)" + "VALUES(@AvailableDrugs,@AddDrug,@Vaccines,@AddVaccines)", sqlcon);
                    command.Parameters.Add("@AvailableDrugs", SqlDbType.VarChar).Value = pharmacy.AvailableDrugs.ToString();
                    command.Parameters.Add("@AddDrug", SqlDbType.VarChar).Value = pharmacy.AddDrug.ToString();
                    command.Parameters.Add("@Vaccines", SqlDbType.VarChar).Value = pharmacy.Vaccinces.ToString();
                    command.Parameters.Add("@ADDVaccines", SqlDbType.VarChar).Value = pharmacy.AddVaccines.ToString();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.InsertCommand = command;
                    adp.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Placed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }
    }
    
}
