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
    }
}
    
