using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet11.NurseAddCredit' table. You can move, or remove it, as needed.
            this.nurseAddCreditTableAdapter.Fill(this.veterinary_clinicDataSet11.NurseAddCredit);
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet10.Dr_soap' table. You can move, or remove it, as needed.
            this.dr_soapTableAdapter2.Fill(this.veterinary_clinicDataSet10.Dr_soap);
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet9.EMR' table. You can move, or remove it, as needed.
            this.eMRTableAdapter.Fill(this.veterinary_clinicDataSet9.EMR);
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet8.Dr_soap' table. You can move, or remove it, as needed.
            this.dr_soapTableAdapter1.Fill(this.veterinary_clinicDataSet8.Dr_soap);
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet7.Dr_soap' table. You can move, or remove it, as needed.
            this.dr_soapTableAdapter.Fill(this.veterinary_clinicDataSet7.Dr_soap);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            PatientXRay patientXRay = new PatientXRay();
            patientXRay.PetID = comboBox2.Text;
            patientXRay.ChooseTime = dateTimePicker1.Text;

            ValidationContext validationContext = new ValidationContext(patientXRay);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(patientXRay, validationContext, errors, true))
            {
                foreach (var item in errors)
                {
                    switch (item.MemberNames.First())
                    {
                        case "PetID":
                            {
                                label7.Text = item.ErrorMessage;
                                break;
                            }
                        case "ChooseTime":
                            {
                                label10.Text = item.ErrorMessage;
                                break;
                            }
                        case "xray":
                            label11.Text = item.ErrorMessage;
                            break;
                        default:
                            MessageBox.Show(item.ErrorMessage);
                            break;

                    }
                }
            }

            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO NurseLab (PetID,ChooseTime)" + "VALUES(@PetID,@ChooseTime)", sqlcon);
                    command.Parameters.Add("@PetID", SqlDbType.VarChar).Value = patientXRay.PetID.ToString();
                    command.Parameters.Add("@ChooseTime", SqlDbType.VarChar).Value = patientXRay.ChooseTime.ToString();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.InsertCommand = command;
                    adp.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}


