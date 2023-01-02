using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows;

namespace WireFrames
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }


      



        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))


            {
                sqlcon.Open();
                try
                {

                    if (textBox8.Text == "12345678987654" && textBox7.Text == "pass22")
                    {

                        MessageBox.Show("Welcome....");
                        Form2 form2 = new Form2();
                        form2.Show();
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
    }
}
