using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WireFrames
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NurseAddPatient nurseAddPatient = new NurseAddPatient();
            nurseAddPatient.PetType = comboBox2.Text;
            nurseAddPatient.PetName = textBox2.Text;
            nurseAddPatient.PetGender = comboBox1.Text;
            nurseAddPatient.Allergies = textBox1.Text;
            nurseAddPatient.PrevDiseases = textBox6.Text;
            nurseAddPatient.Weight = textBox5.Text;
            nurseAddPatient.Height = textBox3.Text;
            nurseAddPatient.Age = textBox4.Text;
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();

                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO EMR(PetType,PetName,PetGender,Allergies,PrevDiseases,Weight,Height,Age)" + "VALUES(@PetType,@PetName,@PetGender,@Allergies,@PrevDiseases,@Weight,@Height,@Age)", sqlcon);
                    command.Parameters.Add("@PetType", SqlDbType.VarChar).Value = nurseAddPatient.PetType.ToString();
                    command.Parameters.Add("@PetName", SqlDbType.VarChar).Value = nurseAddPatient.PetName.ToString();
                    command.Parameters.Add("@PetGender", SqlDbType.VarChar).Value = nurseAddPatient.PetGender.ToString();
                    command.Parameters.Add("@Allergies", SqlDbType.VarChar).Value = nurseAddPatient.Allergies.ToString();
                    command.Parameters.Add("@PrevDiseases", SqlDbType.VarChar).Value = nurseAddPatient.PrevDiseases.ToString();
                    command.Parameters.Add("@Weight", SqlDbType.Float).Value = nurseAddPatient.Weight.ToString();
                    command.Parameters.Add("@Height", SqlDbType.Float).Value = nurseAddPatient.Height.ToString();
                    command.Parameters.Add("@Age", SqlDbType.Float).Value = nurseAddPatient.Age.ToString();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.InsertCommand = command;
                    adp.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("patient inserted");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

            }
    }
}
