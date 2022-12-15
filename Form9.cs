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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WireFrames
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet1.EMR' table. You can move, or remove it, as needed.
            this.eMRTableAdapter1.Fill(this.veterinary_clinicDataSet1.EMR);
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet.EMR' table. You can move, or remove it, as needed.
            this.eMRTableAdapter.Fill(this.veterinary_clinicDataSet.EMR);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SOAP soap = new SOAP();
            soap.PetID = comboBox1.Text;
            soap.Subjective = richTextBox1.Text;
            soap.Objective = richTextBox4.Text;
            soap.Assessment = richTextBox3.Text;
            soap.Plan__ = richTextBox2.Text;
            soap.Date = dateTimePicker1.Text;

            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Dr_soap (PetID,Subjective,Objective,Assessment,Plan__,Date)" + "VALUES(@PetID,@Subjective,@Objective,@Assessment,@Plan__,@Date)", sqlcon);
                    command.Parameters.Add("@PetID", SqlDbType.Int).Value = soap.PetID.ToString();
                    command.Parameters.Add("@Subjective", SqlDbType.VarChar).Value = soap.Subjective.ToString();
                    command.Parameters.Add("@Objective", SqlDbType.VarChar).Value = soap.Objective.ToString();
                    command.Parameters.Add("@Assessment", SqlDbType.VarChar).Value = soap.Assessment.ToString();
                    command.Parameters.Add("@Plan__", SqlDbType.VarChar).Value = soap.Plan__.ToString();
                    command.Parameters.Add("@Date", SqlDbType.VarChar).Value = soap.Date.ToString();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.InsertCommand = command;
                    adp.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("SOAP added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }



        }
    }
}
