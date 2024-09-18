
namespace Polly_Pipe
{
    partial class Installation_Staff_Details
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
            this.Ty_Of_St_CB = new System.Windows.Forms.ComboBox();
            this.Qu_L = new System.Windows.Forms.Label();
            this.In_ID_St_TB = new System.Windows.Forms.TextBox();
            this.Nu_Of_St_TB = new System.Windows.Forms.TextBox();
            this.Ty_Of_St_L = new System.Windows.Forms.Label();
            this.In_ID_Staff_L = new System.Windows.Forms.Label();
            this.In_St_De_L = new System.Windows.Forms.Label();
            this.Pe_Of_As_TB = new System.Windows.Forms.TextBox();
            this.Pe_Of_As_L = new System.Windows.Forms.Label();
            this.Staff_Req_dataGridView = new System.Windows.Forms.DataGridView();
            this.pollyPipeDataSet = new Polly_Pipe.PollyPipeDataSet();
            this.pollyPipeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pollyPipeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pollyPipeDataSet2 = new Polly_Pipe.PollyPipeDataSet2();
            this.installationStaffRequirementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installation_Staff_RequirementsTableAdapter = new Polly_Pipe.PollyPipeDataSet2TableAdapters.Installation_Staff_RequirementsTableAdapter();
            this.Sta_Re_GB = new System.Windows.Forms.GroupBox();
            this.Save_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Add_New_B = new System.Windows.Forms.Button();
            this.Close_B = new System.Windows.Forms.Button();
            this.inIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodOfAssignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Req_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationStaffRequirementsBindingSource)).BeginInit();
            this.Sta_Re_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ty_Of_St_CB
            // 
            this.Ty_Of_St_CB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationStaffRequirementsBindingSource, "Type_Of_Staff", true));
            this.Ty_Of_St_CB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ty_Of_St_CB.FormattingEnabled = true;
            this.Ty_Of_St_CB.Items.AddRange(new object[] {
            "20-gallon Tanks ",
            "50-gallon Tanks ",
            "100-gallon Tanks ",
            "200-gallon Tanks ",
            "400-gallon Tanks",
            "Standard\tThermostats ",
            "Super Thermostats",
            "Standard Air pumps ",
            "Super Air pumps ",
            "Air driven Filters ",
            "Under gravel Filters ",
            "Large Gravel Bag",
            "Small Gravel Bag",
            "Standard\tWood Panels"});
            this.Ty_Of_St_CB.Location = new System.Drawing.Point(208, 163);
            this.Ty_Of_St_CB.Name = "Ty_Of_St_CB";
            this.Ty_Of_St_CB.Size = new System.Drawing.Size(277, 36);
            this.Ty_Of_St_CB.TabIndex = 46;
            // 
            // Qu_L
            // 
            this.Qu_L.AutoSize = true;
            this.Qu_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qu_L.Location = new System.Drawing.Point(498, 166);
            this.Qu_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Qu_L.Name = "Qu_L";
            this.Qu_L.Size = new System.Drawing.Size(178, 29);
            this.Qu_L.TabIndex = 45;
            this.Qu_L.Text = "Number of Staff";
            // 
            // In_ID_St_TB
            // 
            this.In_ID_St_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationStaffRequirementsBindingSource, "In_ID", true));
            this.In_ID_St_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_ID_St_TB.Location = new System.Drawing.Point(340, 75);
            this.In_ID_St_TB.Name = "In_ID_St_TB";
            this.In_ID_St_TB.Size = new System.Drawing.Size(277, 36);
            this.In_ID_St_TB.TabIndex = 42;
            this.In_ID_St_TB.TextChanged += new System.EventHandler(this.In_ID_St_TB_TextChanged);
            // 
            // Nu_Of_St_TB
            // 
            this.Nu_Of_St_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationStaffRequirementsBindingSource, "No_Of_Staff", true));
            this.Nu_Of_St_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nu_Of_St_TB.Location = new System.Drawing.Point(692, 163);
            this.Nu_Of_St_TB.Name = "Nu_Of_St_TB";
            this.Nu_Of_St_TB.Size = new System.Drawing.Size(54, 36);
            this.Nu_Of_St_TB.TabIndex = 41;
            // 
            // Ty_Of_St_L
            // 
            this.Ty_Of_St_L.AutoSize = true;
            this.Ty_Of_St_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ty_Of_St_L.Location = new System.Drawing.Point(57, 166);
            this.Ty_Of_St_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ty_Of_St_L.Name = "Ty_Of_St_L";
            this.Ty_Of_St_L.Size = new System.Drawing.Size(144, 29);
            this.Ty_Of_St_L.TabIndex = 40;
            this.Ty_Of_St_L.Text = "Type of Staff";
            this.Ty_Of_St_L.Click += new System.EventHandler(this.Eq_Sp_L_Click);
            // 
            // In_ID_Staff_L
            // 
            this.In_ID_Staff_L.AutoSize = true;
            this.In_ID_Staff_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_ID_Staff_L.ForeColor = System.Drawing.Color.Black;
            this.In_ID_Staff_L.Location = new System.Drawing.Point(166, 78);
            this.In_ID_Staff_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.In_ID_Staff_L.Name = "In_ID_Staff_L";
            this.In_ID_Staff_L.Size = new System.Drawing.Size(156, 29);
            this.In_ID_Staff_L.TabIndex = 39;
            this.In_ID_Staff_L.Text = "Installation ID";
            // 
            // In_St_De_L
            // 
            this.In_St_De_L.AutoSize = true;
            this.In_St_De_L.BackColor = System.Drawing.Color.Transparent;
            this.In_St_De_L.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_St_De_L.ForeColor = System.Drawing.Color.Olive;
            this.In_St_De_L.Location = new System.Drawing.Point(550, 35);
            this.In_St_De_L.Name = "In_St_De_L";
            this.In_St_De_L.Size = new System.Drawing.Size(421, 37);
            this.In_St_De_L.TabIndex = 38;
            this.In_St_De_L.Text = "Installation Staff Requirements";
            this.In_St_De_L.Click += new System.EventHandler(this.In_St_De_L_Click);
            // 
            // Pe_Of_As_TB
            // 
            this.Pe_Of_As_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationStaffRequirementsBindingSource, "Period_Of_Assignment", true));
            this.Pe_Of_As_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pe_Of_As_TB.Location = new System.Drawing.Point(399, 251);
            this.Pe_Of_As_TB.Name = "Pe_Of_As_TB";
            this.Pe_Of_As_TB.Size = new System.Drawing.Size(277, 36);
            this.Pe_Of_As_TB.TabIndex = 48;
            this.Pe_Of_As_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pe_Of_As_L
            // 
            this.Pe_Of_As_L.AutoSize = true;
            this.Pe_Of_As_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pe_Of_As_L.ForeColor = System.Drawing.Color.Black;
            this.Pe_Of_As_L.Location = new System.Drawing.Point(145, 258);
            this.Pe_Of_As_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pe_Of_As_L.Name = "Pe_Of_As_L";
            this.Pe_Of_As_L.Size = new System.Drawing.Size(232, 29);
            this.Pe_Of_As_L.TabIndex = 47;
            this.Pe_Of_As_L.Text = "Period of Assignment";
            this.Pe_Of_As_L.Click += new System.EventHandler(this.label1_Click);
            // 
            // Staff_Req_dataGridView
            // 
            this.Staff_Req_dataGridView.AllowUserToAddRows = false;
            this.Staff_Req_dataGridView.AutoGenerateColumns = false;
            this.Staff_Req_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Staff_Req_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inIDDataGridViewTextBoxColumn,
            this.typeOfStaffDataGridViewTextBoxColumn,
            this.periodOfAssignmentDataGridViewTextBoxColumn,
            this.noOfStaffDataGridViewTextBoxColumn});
            this.Staff_Req_dataGridView.DataSource = this.installationStaffRequirementsBindingSource;
            this.Staff_Req_dataGridView.Location = new System.Drawing.Point(884, 125);
            this.Staff_Req_dataGridView.Name = "Staff_Req_dataGridView";
            this.Staff_Req_dataGridView.RowHeadersWidth = 51;
            this.Staff_Req_dataGridView.RowTemplate.Height = 24;
            this.Staff_Req_dataGridView.Size = new System.Drawing.Size(633, 424);
            this.Staff_Req_dataGridView.TabIndex = 49;
            // 
            // pollyPipeDataSet
            // 
            this.pollyPipeDataSet.DataSetName = "PollyPipeDataSet";
            this.pollyPipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pollyPipeDataSetBindingSource
            // 
            this.pollyPipeDataSetBindingSource.DataSource = this.pollyPipeDataSet;
            this.pollyPipeDataSetBindingSource.Position = 0;
            // 
            // pollyPipeDataSetBindingSource1
            // 
            this.pollyPipeDataSetBindingSource1.DataSource = this.pollyPipeDataSet;
            this.pollyPipeDataSetBindingSource1.Position = 0;
            // 
            // pollyPipeDataSet2
            // 
            this.pollyPipeDataSet2.DataSetName = "PollyPipeDataSet2";
            this.pollyPipeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // installationStaffRequirementsBindingSource
            // 
            this.installationStaffRequirementsBindingSource.DataMember = "Installation_Staff_Requirements";
            this.installationStaffRequirementsBindingSource.DataSource = this.pollyPipeDataSet2;
            // 
            // installation_Staff_RequirementsTableAdapter
            // 
            this.installation_Staff_RequirementsTableAdapter.ClearBeforeFill = true;
            // 
            // Sta_Re_GB
            // 
            this.Sta_Re_GB.Controls.Add(this.Save_B);
            this.Sta_Re_GB.Controls.Add(this.Delete_B);
            this.Sta_Re_GB.Controls.Add(this.Pe_Of_As_TB);
            this.Sta_Re_GB.Controls.Add(this.Add_New_B);
            this.Sta_Re_GB.Controls.Add(this.Pe_Of_As_L);
            this.Sta_Re_GB.Controls.Add(this.Close_B);
            this.Sta_Re_GB.Controls.Add(this.Ty_Of_St_CB);
            this.Sta_Re_GB.Controls.Add(this.In_ID_St_TB);
            this.Sta_Re_GB.Controls.Add(this.Qu_L);
            this.Sta_Re_GB.Controls.Add(this.In_ID_Staff_L);
            this.Sta_Re_GB.Controls.Add(this.Ty_Of_St_L);
            this.Sta_Re_GB.Controls.Add(this.Nu_Of_St_TB);
            this.Sta_Re_GB.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sta_Re_GB.Location = new System.Drawing.Point(40, 125);
            this.Sta_Re_GB.Name = "Sta_Re_GB";
            this.Sta_Re_GB.Size = new System.Drawing.Size(799, 424);
            this.Sta_Re_GB.TabIndex = 50;
            this.Sta_Re_GB.TabStop = false;
            this.Sta_Re_GB.Text = "Staff Requirements";
            this.Sta_Re_GB.Enter += new System.EventHandler(this.Cu_De_GB_Enter);
            // 
            // Save_B
            // 
            this.Save_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_B.Location = new System.Drawing.Point(261, 336);
            this.Save_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(133, 40);
            this.Save_B.TabIndex = 14;
            this.Save_B.Text = "Save";
            this.Save_B.UseVisualStyleBackColor = true;
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Delete_B
            // 
            this.Delete_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_B.Location = new System.Drawing.Point(411, 336);
            this.Delete_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(133, 40);
            this.Delete_B.TabIndex = 13;
            this.Delete_B.Text = "Delete";
            this.Delete_B.UseVisualStyleBackColor = true;
            this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);
            // 
            // Add_New_B
            // 
            this.Add_New_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_B.Location = new System.Drawing.Point(111, 336);
            this.Add_New_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_New_B.Name = "Add_New_B";
            this.Add_New_B.Size = new System.Drawing.Size(133, 40);
            this.Add_New_B.TabIndex = 12;
            this.Add_New_B.Text = "Add New";
            this.Add_New_B.UseVisualStyleBackColor = true;
            this.Add_New_B.Click += new System.EventHandler(this.Add_New_B_Click);
            // 
            // Close_B
            // 
            this.Close_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_B.Location = new System.Drawing.Point(561, 336);
            this.Close_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Close_B.Name = "Close_B";
            this.Close_B.Size = new System.Drawing.Size(133, 40);
            this.Close_B.TabIndex = 11;
            this.Close_B.Text = "Close";
            this.Close_B.UseVisualStyleBackColor = true;
            this.Close_B.Click += new System.EventHandler(this.Close_B_Click);
            // 
            // inIDDataGridViewTextBoxColumn
            // 
            this.inIDDataGridViewTextBoxColumn.DataPropertyName = "In_ID";
            this.inIDDataGridViewTextBoxColumn.HeaderText = "In_ID";
            this.inIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inIDDataGridViewTextBoxColumn.Name = "inIDDataGridViewTextBoxColumn";
            this.inIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // typeOfStaffDataGridViewTextBoxColumn
            // 
            this.typeOfStaffDataGridViewTextBoxColumn.DataPropertyName = "Type_Of_Staff";
            this.typeOfStaffDataGridViewTextBoxColumn.HeaderText = "Type_Of_Staff";
            this.typeOfStaffDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeOfStaffDataGridViewTextBoxColumn.Name = "typeOfStaffDataGridViewTextBoxColumn";
            this.typeOfStaffDataGridViewTextBoxColumn.Width = 170;
            // 
            // periodOfAssignmentDataGridViewTextBoxColumn
            // 
            this.periodOfAssignmentDataGridViewTextBoxColumn.DataPropertyName = "Period_Of_Assignment";
            this.periodOfAssignmentDataGridViewTextBoxColumn.HeaderText = "Period_Of_Assignment";
            this.periodOfAssignmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodOfAssignmentDataGridViewTextBoxColumn.Name = "periodOfAssignmentDataGridViewTextBoxColumn";
            this.periodOfAssignmentDataGridViewTextBoxColumn.Width = 230;
            // 
            // noOfStaffDataGridViewTextBoxColumn
            // 
            this.noOfStaffDataGridViewTextBoxColumn.DataPropertyName = "No_Of_Staff";
            this.noOfStaffDataGridViewTextBoxColumn.HeaderText = "No_Of_Staff";
            this.noOfStaffDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOfStaffDataGridViewTextBoxColumn.Name = "noOfStaffDataGridViewTextBoxColumn";
            // 
            // Installation_Staff_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1568, 583);
            this.Controls.Add(this.Sta_Re_GB);
            this.Controls.Add(this.Staff_Req_dataGridView);
            this.Controls.Add(this.In_St_De_L);
            this.Name = "Installation_Staff_Details";
            this.Text = "Installation_Staff_Details";
            this.Load += new System.EventHandler(this.Installation_Staff_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Req_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationStaffRequirementsBindingSource)).EndInit();
            this.Sta_Re_GB.ResumeLayout(false);
            this.Sta_Re_GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Ty_Of_St_CB;
        private System.Windows.Forms.Label Qu_L;
        private System.Windows.Forms.TextBox In_ID_St_TB;
        private System.Windows.Forms.TextBox Nu_Of_St_TB;
        private System.Windows.Forms.Label Ty_Of_St_L;
        private System.Windows.Forms.Label In_ID_Staff_L;
        private System.Windows.Forms.Label In_St_De_L;
        private System.Windows.Forms.TextBox Pe_Of_As_TB;
        private System.Windows.Forms.Label Pe_Of_As_L;
        private System.Windows.Forms.DataGridView Staff_Req_dataGridView;
        private System.Windows.Forms.BindingSource pollyPipeDataSetBindingSource1;
        private PollyPipeDataSet pollyPipeDataSet;
        private System.Windows.Forms.BindingSource pollyPipeDataSetBindingSource;
        private PollyPipeDataSet2 pollyPipeDataSet2;
        private System.Windows.Forms.BindingSource installationStaffRequirementsBindingSource;
        private PollyPipeDataSet2TableAdapters.Installation_Staff_RequirementsTableAdapter installation_Staff_RequirementsTableAdapter;
        private System.Windows.Forms.GroupBox Sta_Re_GB;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.Button Add_New_B;
        private System.Windows.Forms.Button Close_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn inIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfStaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodOfAssignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfStaffDataGridViewTextBoxColumn;
    }
}