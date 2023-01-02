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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet4.EMR' table. You can move, or remove it, as needed.
            this.eMRTableAdapter.Fill(this.veterinary_clinicDataSet4.EMR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NurseAddCredit nurseAddCredit = new NurseAddCredit();
            nurseAddCredit.PetID = comboBox1.Text;
            nurseAddCredit.Credit = textBox1.Text;


            ValidationContext validationContext = new ValidationContext(nurseAddCredit);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(nurseAddCredit, validationContext, errors, true))
            {
                foreach (var item in errors)
                {
                    switch (item.MemberNames.First())
                    {
                        case "PetID":
                            label3.Text = item.ErrorMessage;
                            break;
                        case "Credit":
                            label4.Text = item.ErrorMessage;
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
                        SqlCommand command = new SqlCommand("INSERT INTO NurseAddCredit (PetID,Credit)" + "VALUES(@PetID,@Credit)", sqlcon);
                        command.Parameters.Add("@PetID", SqlDbType.VarChar).Value = nurseAddCredit.PetID.ToString();
                        command.Parameters.Add("@Credit", SqlDbType.VarChar).Value = nurseAddCredit.Credit.ToString();
                        SqlDataAdapter adp = new SqlDataAdapter();
                        adp.InsertCommand = command;
                        adp.InsertCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }
    }

       
    
}
