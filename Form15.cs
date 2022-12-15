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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorSignIn doctorSignIn = new DoctorSignIn();
            doctorSignIn.NationalID = textBox1.Text;
            doctorSignIn.Password= textBox2.Text;

            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO DoctorSignIn (NationalID,Password)" + "VALUES(@NationalID,@Password)", sqlcon);
                    command.Parameters.Add("@NationalID", SqlDbType.VarChar).Value = doctorSignIn.NationalID.ToString();
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = doctorSignIn.Password.ToString();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.InsertCommand = command;
                    adp.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Log in done");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            Form17 form17 = new Form17();
            form17.Show();
            this.Hide();
        }
    }
}
