namespace WireFrames
{
    partial class Form21
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veterinary_clinicDataSet6 = new WireFrames.veterinary_clinicDataSet6();
            this.drsoapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dr_soapTableAdapter = new WireFrames.veterinary_clinicDataSet6TableAdapters.Dr_soapTableAdapter();
            this.petIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsoapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.petIDDataGridViewTextBoxColumn,
            this.subjectiveDataGridViewTextBoxColumn,
            this.objectiveDataGridViewTextBoxColumn,
            this.assessmentDataGridViewTextBoxColumn,
            this.planDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.drsoapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // veterinary_clinicDataSet6
            // 
            this.veterinary_clinicDataSet6.DataSetName = "veterinary_clinicDataSet6";
            this.veterinary_clinicDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drsoapBindingSource
            // 
            this.drsoapBindingSource.DataMember = "Dr_soap";
            this.drsoapBindingSource.DataSource = this.veterinary_clinicDataSet6;
            // 
            // dr_soapTableAdapter
            // 
            this.dr_soapTableAdapter.ClearBeforeFill = true;
            // 
            // petIDDataGridViewTextBoxColumn
            // 
            this.petIDDataGridViewTextBoxColumn.DataPropertyName = "PetID";
            this.petIDDataGridViewTextBoxColumn.HeaderText = "PetID";
            this.petIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petIDDataGridViewTextBoxColumn.Name = "petIDDataGridViewTextBoxColumn";
            this.petIDDataGridViewTextBoxColumn.Width = 125;
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
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form21";
            this.Text = "Form21";
            this.Load += new System.EventHandler(this.Form21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinary_clinicDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsoapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private veterinary_clinicDataSet6 veterinary_clinicDataSet6;
        private System.Windows.Forms.BindingSource drsoapBindingSource;
        private veterinary_clinicDataSet6TableAdapters.Dr_soapTableAdapter dr_soapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn petIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}