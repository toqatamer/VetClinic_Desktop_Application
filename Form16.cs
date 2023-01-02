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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NurseSignIn nurseSignIn = new NurseSignIn();
            nurseSignIn.ID = textBox1.Text;
            nurseSignIn.Password= textBox2.Text;

            ValidationContext validationContext = new ValidationContext(nurseSignIn);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(nurseSignIn, validationContext, errors, true))
            {
                foreach (var item in errors)
                {
                    switch (item.MemberNames.First())
                    {
                        case "ID":
                            {
                                label5.Text = item.ErrorMessage;
                                break;
                            }
                        case "Password":
                            {
                                label6.Text = item.ErrorMessage;
                                break;
                            }
                        case "Email":
                            label7.Text = item.ErrorMessage; break;


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

                    if (textBox1.Text == "2" && textBox2.Text == "pass")
                    {

                        MessageBox.Show("Welcome nurse ....");
                        Form10 form10 = new Form10();
                        form10.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();  
            form8.Show();
            this.Hide();
        }
    }
}
