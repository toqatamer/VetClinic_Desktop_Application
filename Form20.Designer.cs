namespace WireFrames
{
    partial class Form20
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form20));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinary_clinicDataSet5 = new WireFrames.veterinary_clinicDataSet5();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.eMRTableAdapter = new WireFrames.veterinary_clinicDataSet5TableAdapters.EMRTableAdapter();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eMRBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veterinary_clinicDataSet24 = new WireFrames.veterinary_clinicDataSet24();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.petIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drsoapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinary_clinicDataSet23 = new WireFrames.veterinary_clinicDataSet23();
            this.dr_soapTableAdapter = new WireFrames.veterinary_clinicDataSet23TableAdapters.Dr_soapTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.eMRTableAdapter1 = new WireFrames.veterinary_clinicDataSet24TableAdapters.EMRTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.petIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevDiseasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsoapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet23)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.petIDDataGridViewTextBoxColumn,
            this.petTypeDataGridViewTextBoxColumn,
            this.petNameDataGridViewTextBoxColumn,
            this.petGenderDataGridViewTextBoxColumn,
            this.allergiesDataGridViewTextBoxColumn,
            this.prevDiseasesDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eMRBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(815, 95);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eMRBindingSource
            // 
            this.eMRBindingSource.DataMember = "EMR";
            this.eMRBindingSource.DataSource = this.veterinary_clinicDataSet5;
            // 
            // veterinary_clinicDataSet5
            // 
            this.veterinary_clinicDataSet5.DataSetName = "veterinary_clinicDataSet5";
            this.veterinary_clinicDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // eMRTableAdapter
            // 
            this.eMRTableAdapter.ClearBeforeFill = true;
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(3, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(472, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 164);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // eMRBindingSource1
            // 
            this.eMRBindingSource1.DataMember = "EMR";
            this.eMRBindingSource1.DataSource = this.veterinary_clinicDataSet24;
            // 
            // veterinary_clinicDataSet24
            // 
            this.veterinary_clinicDataSet24.DataSetName = "veterinary_clinicDataSet24";
            this.veterinary_clinicDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.petIDDataGridViewTextBoxColumn1,
            this.subjectiveDataGridViewTextBoxColumn,
            this.objectiveDataGridViewTextBoxColumn,
            this.assessmentDataGridViewTextBoxColumn,
            this.planDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.drsoapBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 172);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(793, 102);
            this.dataGridView2.TabIndex = 21;
            // 
            // petIDDataGridViewTextBoxColumn1
            // 
            this.petIDDataGridViewTextBoxColumn1.DataPropertyName = "PetID";
            this.petIDDataGridViewTextBoxColumn1.HeaderText = "PetID";
            this.petIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.petIDDataGridViewTextBoxColumn1.Name = "petIDDataGridViewTextBoxColumn1";
            this.petIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // subjectiveDataGridViewTextBoxColumn
            // 
            this.subjectiveDataGridViewTextBoxColumn.DataPropertyName = "Subjective";
            this.subjectiveDataGridViewTextBoxColumn.HeaderText = "Subjective";
            this.subjectiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectiveDataGridViewTextBoxColumn.Name = "subjectiveDataGridViewTextBoxColumn";
            this.subjectiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // objectiveDataGridViewTextBoxColumn
            // 
            this.objectiveDataGridViewTextBoxColumn.DataPropertyName = "Objective";
            this.objectiveDataGridViewTextBoxColumn.HeaderText = "Objective";
            this.objectiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.objectiveDataGridViewTextBoxColumn.Name = "objectiveDataGridViewTextBoxColumn";
            this.objectiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // assessmentDataGridViewTextBoxColumn
            // 
            this.assessmentDataGridViewTextBoxColumn.DataPropertyName = "Assessment";
            this.assessmentDataGridViewTextBoxColumn.HeaderText = "Assessment";
            this.assessmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assessmentDataGridViewTextBoxColumn.Name = "assessmentDataGridViewTextBoxColumn";
            this.assessmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // planDataGridViewTextBoxColumn
            // 
            this.planDataGridViewTextBoxColumn.DataPropertyName = "Plan__";
            this.planDataGridViewTextBoxColumn.HeaderText = "Plan__";
            this.planDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planDataGridViewTextBoxColumn.Name = "planDataGridViewTextBoxColumn";
            this.planDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // drsoapBindingSource
            // 
            this.drsoapBindingSource.DataMember = "Dr_soap";
            this.drsoapBindingSource.DataSource = this.veterinary_clinicDataSet23;
            // 
            // veterinary_clinicDataSet23
            // 
            this.veterinary_clinicDataSet23.DataSetName = "veterinary_clinicDataSet23";
            this.veterinary_clinicDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dr_soapTableAdapter
            // 
            this.dr_soapTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(245, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "PetID";
            // 
            // eMRTableAdapter1
            // 
            this.eMRTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // petIDDataGridViewTextBoxColumn
            // 
            this.petIDDataGridViewTextBoxColumn.DataPropertyName = "PetID";
            this.petIDDataGridViewTextBoxColumn.HeaderText = "PetID";
            this.petIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petIDDataGridViewTextBoxColumn.Name = "petIDDataGridViewTextBoxColumn";
            this.petIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.petIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // petTypeDataGridViewTextBoxColumn
            // 
            this.petTypeDataGridViewTextBoxColumn.DataPropertyName = "PetType";
            this.petTypeDataGridViewTextBoxColumn.HeaderText = "PetType";
            this.petTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petTypeDataGridViewTextBoxColumn.Name = "petTypeDataGridViewTextBoxColumn";
            this.petTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // petNameDataGridViewTextBoxColumn
            // 
            this.petNameDataGridViewTextBoxColumn.DataPropertyName = "PetName";
            this.petNameDataGridViewTextBoxColumn.HeaderText = "PetName";
            this.petNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petNameDataGridViewTextBoxColumn.Name = "petNameDataGridViewTextBoxColumn";
            this.petNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // petGenderDataGridViewTextBoxColumn
            // 
            this.petGenderDataGridViewTextBoxColumn.DataPropertyName = "PetGender";
            this.petGenderDataGridViewTextBoxColumn.HeaderText = "PetGender";
            this.petGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petGenderDataGridViewTextBoxColumn.Name = "petGenderDataGridViewTextBoxColumn";
            this.petGenderDataGridViewTextBoxColumn.Width = 125;
            // 
            // allergiesDataGridViewTextBoxColumn
            // 
            this.allergiesDataGridViewTextBoxColumn.DataPropertyName = "Allergies";
            this.allergiesDataGridViewTextBoxColumn.HeaderText = "Allergies";
            this.allergiesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.allergiesDataGridViewTextBoxColumn.Name = "allergiesDataGridViewTextBoxColumn";
            this.allergiesDataGridViewTextBoxColumn.Width = 125;
            // 
            // prevDiseasesDataGridViewTextBoxColumn
            // 
            this.prevDiseasesDataGridViewTextBoxColumn.DataPropertyName = "PrevDiseases";
            this.prevDiseasesDataGridViewTextBoxColumn.HeaderText = "PrevDiseases";
            this.prevDiseasesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prevDiseasesDataGridViewTextBoxColumn.Name = "prevDiseasesDataGridViewTextBoxColumn";
            this.prevDiseasesDataGridViewTextBoxColumn.Width = 125;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 125;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form20";
            this.Text = "Form20";
            this.Load += new System.EventHandler(this.Form20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsoapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet23)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private veterinary_clinicDataSet5 veterinary_clinicDataSet5;
        private System.Windows.Forms.BindingSource eMRBindingSource;
        private veterinary_clinicDataSet5TableAdapters.EMRTableAdapter eMRTableAdapter;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private veterinary_clinicDataSet23 veterinary_clinicDataSet23;
        private System.Windows.Forms.BindingSource drsoapBindingSource;
        private veterinary_clinicDataSet23TableAdapters.Dr_soapTableAdapter dr_soapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn petIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private veterinary_clinicDataSet24 veterinary_clinicDataSet24;
        private System.Windows.Forms.BindingSource eMRBindingSource1;
        private veterinary_clinicDataSet24TableAdapters.EMRTableAdapter eMRTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn petIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevDiseasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}