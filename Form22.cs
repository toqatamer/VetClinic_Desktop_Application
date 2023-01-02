using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WireFrames
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet22.EMR' table. You can move, or remove it, as needed.
            this.eMRTableAdapter.Fill(this.veterinary_clinicDataSet22.EMR);
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet19.NurseAddCredit' table. You can move, or remove it, as needed.
            this.nurseAddCreditTableAdapter.Fill(this.veterinary_clinicDataSet19.NurseAddCredit);
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet18.Dr_soap' table. You can move, or remove it, as needed.
            this.dr_soapTableAdapter.Fill(this.veterinary_clinicDataSet18.Dr_soap);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form= new Form2();
            form.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultions consultions = new Consultions();
            consultions.PetID = comboBox2.Text;
            consultions.ChooseTime = dateTimePicker1.Text;

            ValidationContext validationContext = new ValidationContext(consultions);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(consultions, validationContext, errors, true))
            {
                foreach (var item in errors)
                {
                    switch (item.MemberNames.First())
                    {
                        case "PetID":
                            {
                                label6.Text = item.ErrorMessage;
                                break;
                            }
                        case "ChooseTime":
                            {
                                label9.Text = item.ErrorMessage;
                                break;
                            }
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
                    SqlCommand command = new SqlCommand("INSERT INTO Consultions (PetID,ChooseTime)" + "VALUES(@PetID,@ChooseTime)", sqlcon);
                    command.Parameters.Add("@PetID", SqlDbType.VarChar).Value = consultions.PetID.ToString();
                    command.Parameters.Add("@ChooseTime", SqlDbType.VarChar).Value = consultions.ChooseTime.ToString();
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
    }
}
