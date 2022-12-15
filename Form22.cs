using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WireFrames
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet19.NurseAddCredit' table. You can move, or remove it, as needed.
            this.nurseAddCreditTableAdapter.Fill(this.veterinary_clinicDataSet19.NurseAddCredit);
            // TODO: This line of code loads data into the 'veterinary_clinicDataSet18.Dr_soap' table. You can move, or remove it, as needed.
            this.dr_soapTableAdapter.Fill(this.veterinary_clinicDataSet18.Dr_soap);

        }
    }
}
