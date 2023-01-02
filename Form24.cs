using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Patagames.Ocr;
using System.Security.Cryptography;
using System.IO;

namespace WireFrames
{
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string PlainText = objOcr.GetTextFromImage(@textBox1.Text);
                richTextBox2.Text = PlainText;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "icon";
            ofd.Filter = "icon(*.png;*.jpeg;*.gif;)|*.png; *.jpeg; *.gif;";
            ofd.ShowDialog();
            pictureBox2.Image = new Bitmap(ofd.FileName);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            textBox1.Text = Path.GetFullPath(ofd.FileName);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
            this.Hide();
        }
    }
}
