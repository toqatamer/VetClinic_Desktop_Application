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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NurseSignIn nurseSignIn = new NurseSignIn();
            nurseSignIn.NationalID = textBox1.Text;
            nurseSignIn.Password = textBox2.Text;

            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO NurseSignIn (NationalID,Password)" + "VALUES(@NationalID,@Password)", sqlcon);
                    command.Parameters.Add("@NationalID", SqlDbType.VarChar).Value = nurseSignIn.NationalID.ToString();
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = nurseSignIn.Password.ToString();
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
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }
    }
}
