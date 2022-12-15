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
