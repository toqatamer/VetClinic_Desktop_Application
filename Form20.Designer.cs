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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.veterinary_clinicDataSet5 = new WireFrames.veterinary_clinicDataSet5();
            this.eMRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMRTableAdapter = new WireFrames.veterinary_clinicDataSet5TableAdapters.EMRTableAdapter();
            this.petIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevDiseasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(-6, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(811, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // veterinary_clinicDataSet5
            // 
            this.veterinary_clinicDataSet5.DataSetName = "veterinary_clinicDataSet5";
            this.veterinary_clinicDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMRBindingSource
            // 
            this.eMRBindingSource.DataMember = "EMR";
            this.eMRBindingSource.DataSource = this.veterinary_clinicDataSet5;
            // 
            // eMRTableAdapter
            // 
            this.eMRTableAdapter.ClearBeforeFill = true;
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
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form20";
            this.Text = "Form20";
            this.Load += new System.EventHandler(this.Form20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private veterinary_clinicDataSet5 veterinary_clinicDataSet5;
        private System.Windows.Forms.BindingSource eMRBindingSource;
        private veterinary_clinicDataSet5TableAdapters.EMRTableAdapter eMRTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn petIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevDiseasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
    }
}