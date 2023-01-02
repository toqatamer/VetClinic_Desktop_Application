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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DoctorSignIn doctorSignIn = new DoctorSignIn();
            doctorSignIn.ID = textBox1.Text;
            doctorSignIn.Password= textBox2.Text;
            

            ValidationContext validationContext = new ValidationContext(doctorSignIn);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(doctorSignIn, validationContext, errors, true))
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

                    if (textBox1.Text == "1" && textBox2.Text== "pass")
                    {

                        MessageBox.Show("Welcome doctor ....");
                        Form17 form17 = new Form17();
                        form17.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("can't open");
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
