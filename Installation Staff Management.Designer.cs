
namespace Polly_Pipe
{
    partial class Installation_Staff_Management
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
            this.Pe_Of_As_TB = new System.Windows.Forms.TextBox();
            this.installationStaffDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pollyPipeDataSet = new Polly_Pipe.PollyPipeDataSet();
            this.Pe_Of_As_L = new System.Windows.Forms.Label();
            this.In_ID_St_TB = new System.Windows.Forms.TextBox();
            this.Staff_No_L = new System.Windows.Forms.Label();
            this.In_ID_Staff_L = new System.Windows.Forms.Label();
            this.In_St_Ma_L = new System.Windows.Forms.Label();
            this.Staff_No = new System.Windows.Forms.TextBox();
            this.Save_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Add_New_B = new System.Windows.Forms.Button();
            this.Close_B = new System.Windows.Forms.Button();
            this.Cu_De_GB = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodOfAssignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installation_Staff_DetailsTableAdapter = new Polly_Pipe.PollyPipeDataSetTableAdapters.Installation_Staff_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.installationStaffDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).BeginInit();
            this.Cu_De_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pe_Of_As_TB
            // 
            this.Pe_Of_As_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationStaffDetailsBindingSource, "Period_Of_Assignment", true));
            this.Pe_Of_As_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pe_Of_As_TB.Location = new System.Drawing.Point(332, 245);
            this.Pe_Of_As_TB.Name = "Pe_Of_As_TB";
            this.Pe_Of_As_TB.Size = new System.Drawing.Size(277, 36);
            this.Pe_Of_As_TB.TabIndex = 59;
            this.Pe_Of_As_TB.TextChanged += new System.EventHandler(this.Pe_Of_As_TB_TextChanged);
            // 
            // installationStaffDetailsBindingSource
            // 
            this.installationStaffDetailsBindingSource.DataMember = "Installation_Staff_Details";
            this.installationStaffDetailsBindingSource.DataSource = this.pollyPipeDataSet;
            // 
            // pollyPipeDataSet
            // 
            this.pollyPipeDataSet.DataSetName = "PollyPipeDataSet";
            this.pollyPipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pe_Of_As_L
            // 
            this.Pe_Of_As_L.AutoSize = true;
            this.Pe_Of_As_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pe_Of_As_L.ForeColor = System.Drawing.Color.Black;
            this.Pe_Of_As_L.Location = new System.Drawing.Point(84, 248);
            this.Pe_Of_As_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pe_Of_As_L.Name = "Pe_Of_As_L";
            this.Pe_Of_As_L.Size = new System.Drawing.Size(232, 29);
            this.Pe_Of_As_L.TabIndex = 58;
            this.Pe_Of_As_L.Text = "Period of Assignment";
            this.Pe_Of_As_L.Click += new System.EventHandler(this.Pe_Of_As_L_Click);
            // 
            // In_ID_St_TB
            // 
            this.In_ID_St_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationStaffDetailsBindingSource, "In_ID", true));
            this.In_ID_St_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_ID_St_TB.Location = new System.Drawing.Point(304, 65);
            this.In_ID_St_TB.Name = "In_ID_St_TB";
            this.In_ID_St_TB.Size = new System.Drawing.Size(277, 36);
            this.In_ID_St_TB.TabIndex = 53;
            this.In_ID_St_TB.TextChanged += new System.EventHandler(this.In_ID_St_TB_TextChanged);
            // 
            // Staff_No_L
            // 
            this.Staff_No_L.AutoSize = true;
            this.Staff_No_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_No_L.Location = new System.Drawing.Point(204, 161);
            this.Staff_No_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Staff_No_L.Name = "Staff_No_L";
            this.Staff_No_L.Size = new System.Drawing.Size(151, 29);
            this.Staff_No_L.TabIndex = 51;
            this.Staff_No_L.Text = "Staff Number";
            this.Staff_No_L.Click += new System.EventHandler(this.Ty_Of_St_L_Click);
            // 
            // In_ID_Staff_L
            // 
            this.In_ID_Staff_L.AutoSize = true;
            this.In_ID_Staff_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_ID_Staff_L.ForeColor = System.Drawing.Color.Black;
            this.In_ID_Staff_L.Location = new System.Drawing.Point(130, 68);
            this.In_ID_Staff_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.In_ID_Staff_L.Name = "In_ID_Staff_L";
            this.In_ID_Staff_L.Size = new System.Drawing.Size(156, 29);
            this.In_ID_Staff_L.TabIndex = 50;
            this.In_ID_Staff_L.Text = "Installation ID";
            this.In_ID_Staff_L.Click += new System.EventHandler(this.In_ID_Staff_L_Click);
            // 
            // In_St_Ma_L
            // 
            this.In_St_Ma_L.AutoSize = true;
            this.In_St_Ma_L.BackColor = System.Drawing.Color.Transparent;
            this.In_St_Ma_L.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_St_Ma_L.ForeColor = System.Drawing.Color.Tomato;
            this.In_St_Ma_L.Location = new System.Drawing.Point(457, 57);
            this.In_St_Ma_L.Name = "In_St_Ma_L";
            this.In_St_Ma_L.Size = new System.Drawing.Size(354, 40);
            this.In_St_Ma_L.TabIndex = 49;
            this.In_St_Ma_L.Text = "Installation Staff Details";
            this.In_St_Ma_L.Click += new System.EventHandler(this.In_St_De_L_Click);
            // 
            // Staff_No
            // 
            this.Staff_No.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationStaffDetailsBindingSource, "Staff_No", true));
            this.Staff_No.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_No.Location = new System.Drawing.Point(362, 154);
            this.Staff_No.Name = "Staff_No";
            this.Staff_No.Size = new System.Drawing.Size(135, 36);
            this.Staff_No.TabIndex = 60;
            // 
            // Save_B
            // 
            this.Save_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_B.Location = new System.Drawing.Point(212, 366);
            this.Save_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(133, 40);
            this.Save_B.TabIndex = 64;
            this.Save_B.Text = "Save";
            this.Save_B.UseVisualStyleBackColor = true;
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Delete_B
            // 
            this.Delete_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_B.Location = new System.Drawing.Point(362, 366);
            this.Delete_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(133, 40);
            this.Delete_B.TabIndex = 63;
            this.Delete_B.Text = "Delete";
            this.Delete_B.UseVisualStyleBackColor = true;
            this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);
            // 
            // Add_New_B
            // 
            this.Add_New_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_B.Location = new System.Drawing.Point(62, 366);
            this.Add_New_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_New_B.Name = "Add_New_B";
            this.Add_New_B.Size = new System.Drawing.Size(133, 40);
            this.Add_New_B.TabIndex = 62;
            this.Add_New_B.Text = "Add New";
            this.Add_New_B.UseVisualStyleBackColor = true;
            this.Add_New_B.Click += new System.EventHandler(this.Add_New_B_Click);
            // 
            // Close_B
            // 
            this.Close_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_B.Location = new System.Drawing.Point(512, 366);
            this.Close_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Close_B.Name = "Close_B";
            this.Close_B.Size = new System.Drawing.Size(133, 40);
            this.Close_B.TabIndex = 61;
            this.Close_B.Text = "Close";
            this.Close_B.UseVisualStyleBackColor = true;
            this.Close_B.Click += new System.EventHandler(this.Close_B_Click);
            // 
            // Cu_De_GB
            // 
            this.Cu_De_GB.Controls.Add(this.In_ID_St_TB);
            this.Cu_De_GB.Controls.Add(this.Save_B);
            this.Cu_De_GB.Controls.Add(this.In_ID_Staff_L);
            this.Cu_De_GB.Controls.Add(this.Delete_B);
            this.Cu_De_GB.Controls.Add(this.Staff_No_L);
            this.Cu_De_GB.Controls.Add(this.Add_New_B);
            this.Cu_De_GB.Controls.Add(this.Pe_Of_As_L);
            this.Cu_De_GB.Controls.Add(this.Close_B);
            this.Cu_De_GB.Controls.Add(this.Pe_Of_As_TB);
            this.Cu_De_GB.Controls.Add(this.Staff_No);
            this.Cu_De_GB.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cu_De_GB.Location = new System.Drawing.Point(59, 133);
            this.Cu_De_GB.Name = "Cu_De_GB";
            this.Cu_De_GB.Size = new System.Drawing.Size(707, 443);
            this.Cu_De_GB.TabIndex = 65;
            this.Cu_De_GB.TabStop = false;
            this.Cu_De_GB.Text = "Installation Staff";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inIDDataGridViewTextBoxColumn,
            this.staffNoDataGridViewTextBoxColumn,
            this.periodOfAssignmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.installationStaffDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(817, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 443);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // inIDDataGridViewTextBoxColumn
            // 
            this.inIDDataGridViewTextBoxColumn.DataPropertyName = "In_ID";
            this.inIDDataGridViewTextBoxColumn.HeaderText = "In_ID";
            this.inIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inIDDataGridViewTextBoxColumn.Name = "inIDDataGridViewTextBoxColumn";
            this.inIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // staffNoDataGridViewTextBoxColumn
            // 
            this.staffNoDataGridViewTextBoxColumn.DataPropertyName = "Staff_No";
            this.staffNoDataGridViewTextBoxColumn.HeaderText = "Staff_No";
            this.staffNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffNoDataGridViewTextBoxColumn.Name = "staffNoDataGridViewTextBoxColumn";
            this.staffNoDataGridViewTextBoxColumn.Width = 80;
            // 
            // periodOfAssignmentDataGridViewTextBoxColumn
            // 
            this.periodOfAssignmentDataGridViewTextBoxColumn.DataPropertyName = "Period_Of_Assignment";
            this.periodOfAssignmentDataGridViewTextBoxColumn.HeaderText = "Period_Of_Assignment";
            this.periodOfAssignmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodOfAssignmentDataGridViewTextBoxColumn.Name = "periodOfAssignmentDataGridViewTextBoxColumn";
            this.periodOfAssignmentDataGridViewTextBoxColumn.Width = 200;
            // 
            // installation_Staff_DetailsTableAdapter
            // 
            this.installation_Staff_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Installation_Staff_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1289, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cu_De_GB);
            this.Controls.Add(this.In_St_Ma_L);
            this.Name = "Installation_Staff_Management";
            this.Text = "Installation_Staff_Management";
            this.Load += new System.EventHandler(this.Installation_Staff_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.installationStaffDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).EndInit();
            this.Cu_De_GB.ResumeLayout(false);
            this.Cu_De_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pe_Of_As_TB;
        private System.Windows.Forms.Label Pe_Of_As_L;
        private System.Windows.Forms.TextBox In_ID_St_TB;
        private System.Windows.Forms.Label Staff_No_L;
        private System.Windows.Forms.Label In_ID_Staff_L;
        private System.Windows.Forms.Label In_St_Ma_L;
        private System.Windows.Forms.TextBox Staff_No;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.Button Add_New_B;
        private System.Windows.Forms.Button Close_B;
        private System.Windows.Forms.GroupBox Cu_De_GB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PollyPipeDataSet pollyPipeDataSet;
        private System.Windows.Forms.BindingSource installationStaffDetailsBindingSource;
        private PollyPipeDataSetTableAdapters.Installation_Staff_DetailsTableAdapter installation_Staff_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodOfAssignmentDataGridViewTextBoxColumn;
    }
}