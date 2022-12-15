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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WireFrames
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet2.EMR' table. You can move, or remove it, as needed.
            this.eMRTableAdapter.Fill(this.veterinary_clinicDataSet2.EMR);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NurseLab nurseLab = new NurseLab();
            nurseLab.PetID = comboBox1.Text;
            nurseLab.ChooseTime = dateTimePicker1.Text;

            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO NurseLab (PetID,ChooseTime)" + "VALUES(@PetID,@ChooseTime)", sqlcon);
                    command.Parameters.Add("@PetID", SqlDbType.VarChar).Value = nurseLab.PetID.ToString();
                    command.Parameters.Add("@ChooseTime", SqlDbType.VarChar).Value = nurseLab.ChooseTime.ToString();
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
