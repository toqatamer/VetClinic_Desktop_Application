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

namespace WireFrames
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NurseAdd nurseAdd = new NurseAdd();
            nurseAdd.Name = textBox2.Text;
            nurseAdd.NationalID = textBox3.Text;
            nurseAdd.Password = textBox4.Text;
            nurseAdd.PhoneNumber = textBox1.Text;
            nurseAdd.RegistrationDate = dateTimePicker1.Text;

            ValidationContext validationContext = new ValidationContext(nurseAdd);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(nurseAdd, validationContext , errors ,true))
            {
                foreach (var item in errors)
                {
                    switch(item.MemberNames.First())
                    {
                        case "Name":
                            label7.Text = item.ErrorMessage;
                            break;
                        case "NationalID":
                            label8.Text = item.ErrorMessage;
                            break;
                        case "Password":
                            label9.Text = item.ErrorMessage;
                            break;
                        case "PhoneNumber":
                            label10.Text = item.ErrorMessage;
                            break;
                        case "RegistrationDate":
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
                    SqlCommand command = new SqlCommand("INSERT INTO NurseAdd(Name,NationalID,Password,PhoneNumber,RegistrationDate)" + "VALUES(@Name,@NationalID,@Password,@PhoneNumber,@RegistrationDate)", sqlcon);
                    command.Parameters.Add("@Name", SqlDbType.VarChar).Value = nurseAdd.Name.ToString();
                    command.Parameters.Add("@NationalID", SqlDbType.VarChar).Value = nurseAdd.NationalID.ToString();
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = nurseAdd.Password.ToString();
                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = nurseAdd.PhoneNumber.ToString();
                    command.Parameters.Add("@RegistrationDate", SqlDbType.VarChar).Value = nurseAdd.RegistrationDate.ToString();
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

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }
    }
}
    
