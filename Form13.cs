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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WireFrames
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NurseHospitalization nurseHospitalization = new NurseHospitalization();  
            nurseHospitalization.PetID = comboBox1.Text;
            nurseHospitalization.from__ = dateTimePicker3.Text;
            nurseHospitalization.to__ = dateTimePicker1.Text;

            ValidationContext validationContext = new ValidationContext(nurseHospitalization);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(nurseHospitalization, validationContext, errors, true))
            {
                foreach (var item in errors)
                {
                    switch (item.MemberNames.First())
                    {
                        case "PetID":
                            label2.Text = item.ErrorMessage;
                            break;
                        case "from__":
                            label3.Text = item.ErrorMessage;
                            break;
                        case "to__":
                            label7.Text = item.ErrorMessage;
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
                    SqlCommand command = new SqlCommand("INSERT INTO NurseHospital (PetID,from__,to__)" + "VALUES(@PetID,@from__,@to__)", sqlcon);
                    command.Parameters.Add("@PetID", SqlDbType.VarChar).Value = nurseHospitalization.PetID.ToString();
                    command.Parameters.Add("@from__", SqlDbType.VarChar).Value = nurseHospitalization.from__.ToString();
                    command.Parameters.Add("@to__", SqlDbType.VarChar).Value = nurseHospitalization.to__.ToString();
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

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet3.EMR' table. You can move, or remove it, as needed.
            this.eMRTableAdapter.Fill(this.veterinary_clinicDataSet3.EMR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }
    }
}
