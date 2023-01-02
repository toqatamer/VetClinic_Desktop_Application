namespace WireFrames
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.eMRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinary_clinicDataSet9 = new WireFrames.veterinary_clinicDataSet9();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.drsoapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinary_clinicDataSet7 = new WireFrames.veterinary_clinicDataSet7();
            this.drsoapBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.veterinary_clinicDataSet10 = new WireFrames.veterinary_clinicDataSet10();
            this.nurseAddCreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinary_clinicDataSet11 = new WireFrames.veterinary_clinicDataSet11();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.dr_soapTableAdapter = new WireFrames.veterinary_clinicDataSet7TableAdapters.Dr_soapTableAdapter();
            this.veterinary_clinicDataSet8 = new WireFrames.veterinary_clinicDataSet8();
            this.drsoapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dr_soapTableAdapter1 = new WireFrames.veterinary_clinicDataSet8TableAdapters.Dr_soapTableAdapter();
            this.eMRTableAdapter = new WireFrames.veterinary_clinicDataSet9TableAdapters.EMRTableAdapter();
            this.dr_soapTableAdapter2 = new WireFrames.veterinary_clinicDataSet10TableAdapters.Dr_soapTableAdapter();
            this.nurseAddCreditTableAdapter = new WireFrames.veterinary_clinicDataSet11TableAdapters.NurseAddCreditTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drsoapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsoapBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseAddCreditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet11)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsoapBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(-4, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 23);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.eMRBindingSource;
            this.comboBox2.DisplayMember = "PetID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(497, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // eMRBindingSource
            // 
            this.eMRBindingSource.DataMember = "EMR";
            this.eMRBindingSource.DataSource = this.veterinary_clinicDataSet9;
            // 
            // veterinary_clinicDataSet9
            // 
            this.veterinary_clinicDataSet9.DataSetName = "veterinary_clinicDataSet9";
            this.veterinary_clinicDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(319, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "ID";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(451, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 408);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 28);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(317, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Choose time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(436, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "X-Ray";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 443);
            this.tabControl1.TabIndex = 7;
            // 
            // drsoapBindingSource
            // 
            this.drsoapBindingSource.DataMember = "Dr_soap";
            this.drsoapBindingSource.DataSource = this.veterinary_clinicDataSet7;
            // 
            // veterinary_clinicDataSet7
            // 
            this.veterinary_clinicDataSet7.DataSetName = "veterinary_clinicDataSet7";
            this.veterinary_clinicDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drsoapBindingSource2
            // 
            this.drsoapBindingSource2.DataMember = "Dr_soap";
            this.drsoapBindingSource2.DataSource = this.veterinary_clinicDataSet10;
            // 
            // veterinary_clinicDataSet10
            // 
            this.veterinary_clinicDataSet10.DataSetName = "veterinary_clinicDataSet10";
            this.veterinary_clinicDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nurseAddCreditBindingSource
            // 
            this.nurseAddCreditBindingSource.DataMember = "NurseAddCredit";
            this.nurseAddCreditBindingSource.DataSource = this.veterinary_clinicDataSet11;
            // 
            // veterinary_clinicDataSet11
            // 
            this.veterinary_clinicDataSet11.DataSetName = "veterinary_clinicDataSet11";
            this.veterinary_clinicDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Linen;
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(795, 414);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Help";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(0, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(161, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "We are here for your help!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(183, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "You have problem with appointment?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Contact us";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // dr_soapTableAdapter
            // 
            this.dr_soapTableAdapter.ClearBeforeFill = true;
            // 
            // veterinary_clinicDataSet8
            // 
            this.veterinary_clinicDataSet8.DataSetName = "veterinary_clinicDataSet8";
            this.veterinary_clinicDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drsoapBindingSource1
            // 
            this.drsoapBindingSource1.DataMember = "Dr_soap";
            this.drsoapBindingSource1.DataSource = this.veterinary_clinicDataSet8;
            // 
            // dr_soapTableAdapter1
            // 
            this.dr_soapTableAdapter1.ClearBeforeFill = true;
            // 
            // eMRTableAdapter
            // 
            this.eMRTableAdapter.ClearBeforeFill = true;
            // 
            // dr_soapTableAdapter2
            // 
            this.dr_soapTableAdapter2.ClearBeforeFill = true;
            // 
            // nurseAddCreditTableAdapter
            // 
            this.nurseAddCreditTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(642, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(689, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 20;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drsoapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsoapBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseAddCreditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet11)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsoapBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private veterinary_clinicDataSet7 veterinary_clinicDataSet7;
        private System.Windows.Forms.BindingSource drsoapBindingSource;
        private veterinary_clinicDataSet7TableAdapters.Dr_soapTableAdapter dr_soapTableAdapter;
        private veterinary_clinicDataSet8 veterinary_clinicDataSet8;
        private System.Windows.Forms.BindingSource drsoapBindingSource1;
        private veterinary_clinicDataSet8TableAdapters.Dr_soapTableAdapter dr_soapTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private veterinary_clinicDataSet9 veterinary_clinicDataSet9;
        private System.Windows.Forms.BindingSource eMRBindingSource;
        private veterinary_clinicDataSet9TableAdapters.EMRTableAdapter eMRTableAdapter;
        private veterinary_clinicDataSet10 veterinary_clinicDataSet10;
        private System.Windows.Forms.BindingSource drsoapBindingSource2;
        private veterinary_clinicDataSet10TableAdapters.Dr_soapTableAdapter dr_soapTableAdapter2;
        private veterinary_clinicDataSet11 veterinary_clinicDataSet11;
        private System.Windows.Forms.BindingSource nurseAddCreditBindingSource;
        private veterinary_clinicDataSet11TableAdapters.NurseAddCreditTableAdapter nurseAddCreditTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
    }
}