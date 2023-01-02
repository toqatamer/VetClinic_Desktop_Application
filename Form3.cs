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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet20.EMR' table. You can move, or remove it, as needed.
            this.eMRTableAdapter.Fill(this.veterinary_clinicDataSet20.EMR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            prescription.PetID = comboBox1.Text;
            prescription.PetName = textBox3.Text;
            prescription.Date_ = dateTimePicker2.Text;
            prescription.Drug_ = textBox1.Text;
            prescription.Dose_ = textBox2.Text;
            prescription.Duration = comboBox2.Text;
            prescription.NextCon = dateTimePicker2.Text;
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();

                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Prescription(PetID,PetName,Date_,Drug_,Dose_,Duration,NextCon)" + "VALUES(@PetID,@PetName,@Date_,@Drug_,@Dose_,@Duration,@NextCon)", sqlcon);
                    command.Parameters.Add("@PetID", SqlDbType.VarChar).Value = prescription.PetID.ToString();
                    command.Parameters.Add("@PetName", SqlDbType.VarChar).Value = prescription.PetName.ToString();
                    command.Parameters.Add("@Date_", SqlDbType.VarChar).Value = prescription.Date_.ToString();
                    command.Parameters.Add("@Drug_", SqlDbType.VarChar).Value = prescription.Drug_.ToString();
                    command.Parameters.Add("@Dose_", SqlDbType.VarChar).Value = prescription.Dose_.ToString();
                    command.Parameters.Add("@Duration", SqlDbType.VarChar).Value = prescription.Duration.ToString();
                    command.Parameters.Add("@NextCon", SqlDbType.VarChar).Value = prescription.NextCon.ToString();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.InsertCommand = command;
                    adp.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Done");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
            this.Hide();
        }
    }
    }

