
namespace Polly_Pipe
{
    partial class Form2
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
            this.St_Na_TB = new System.Windows.Forms.TextBox();
            this.St_Ty_L = new System.Windows.Forms.Label();
            this.Staff_Name_L = new System.Windows.Forms.Label();
            this.St_Ma_Re_L = new System.Windows.Forms.Label();
            this.Staff_No_TB = new System.Windows.Forms.TextBox();
            this.Staff_No_L = new System.Windows.Forms.Label();
            this.Cu_De_GB = new System.Windows.Forms.GroupBox();
            this.Save_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Add_New_B = new System.Windows.Forms.Button();
            this.Close_B = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pollyPipeDataSet = new Polly_Pipe.PollyPipeDataSet();
            this.staffDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staff_DetailsTableAdapter = new Polly_Pipe.PollyPipeDataSetTableAdapters.Staff_DetailsTableAdapter();
            this.staffNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Type_CB = new System.Windows.Forms.ComboBox();
            this.Cu_De_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // St_Na_TB
            // 
            this.St_Na_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDetailsBindingSource, "S_Name", true));
            this.St_Na_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_Na_TB.Location = new System.Drawing.Point(365, 154);
            this.St_Na_TB.Name = "St_Na_TB";
            this.St_Na_TB.Size = new System.Drawing.Size(277, 36);
            this.St_Na_TB.TabIndex = 16;
            // 
            // St_Ty_L
            // 
            this.St_Ty_L.AutoSize = true;
            this.St_Ty_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_Ty_L.Location = new System.Drawing.Point(86, 232);
            this.St_Ty_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.St_Ty_L.Name = "St_Ty_L";
            this.St_Ty_L.Size = new System.Drawing.Size(117, 29);
            this.St_Ty_L.TabIndex = 15;
            this.St_Ty_L.Text = "Staff Type";
            // 
            // Staff_Name_L
            // 
            this.Staff_Name_L.AutoSize = true;
            this.Staff_Name_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Name_L.ForeColor = System.Drawing.Color.Black;
            this.Staff_Name_L.Location = new System.Drawing.Point(86, 157);
            this.Staff_Name_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Staff_Name_L.Name = "Staff_Name_L";
            this.Staff_Name_L.Size = new System.Drawing.Size(128, 29);
            this.Staff_Name_L.TabIndex = 14;
            this.Staff_Name_L.Text = "Staff Name";
            // 
            // St_Ma_Re_L
            // 
            this.St_Ma_Re_L.AutoSize = true;
            this.St_Ma_Re_L.BackColor = System.Drawing.Color.Transparent;
            this.St_Ma_Re_L.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_Ma_Re_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.St_Ma_Re_L.Location = new System.Drawing.Point(490, 47);
            this.St_Ma_Re_L.Name = "St_Ma_Re_L";
            this.St_Ma_Re_L.Size = new System.Drawing.Size(398, 41);
            this.St_Ma_Re_L.TabIndex = 13;
            this.St_Ma_Re_L.Text = "Staff Management Record";
            this.St_Ma_Re_L.Click += new System.EventHandler(this.Customer_Details_L_Click);
            // 
            // Staff_No_TB
            // 
            this.Staff_No_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDetailsBindingSource, "Staff_No", true));
            this.Staff_No_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_No_TB.Location = new System.Drawing.Point(365, 80);
            this.Staff_No_TB.Name = "Staff_No_TB";
            this.Staff_No_TB.Size = new System.Drawing.Size(277, 36);
            this.Staff_No_TB.TabIndex = 21;
            this.Staff_No_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Staff_No_L
            // 
            this.Staff_No_L.AutoSize = true;
            this.Staff_No_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_No_L.ForeColor = System.Drawing.Color.Black;
            this.Staff_No_L.Location = new System.Drawing.Point(86, 83);
            this.Staff_No_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Staff_No_L.Name = "Staff_No_L";
            this.Staff_No_L.Size = new System.Drawing.Size(151, 29);
            this.Staff_No_L.TabIndex = 20;
            this.Staff_No_L.Text = "Staff Number";
            this.Staff_No_L.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cu_De_GB
            // 
            this.Cu_De_GB.Controls.Add(this.Staff_Type_CB);
            this.Cu_De_GB.Controls.Add(this.Save_B);
            this.Cu_De_GB.Controls.Add(this.Staff_No_TB);
            this.Cu_De_GB.Controls.Add(this.Delete_B);
            this.Cu_De_GB.Controls.Add(this.Staff_No_L);
            this.Cu_De_GB.Controls.Add(this.Add_New_B);
            this.Cu_De_GB.Controls.Add(this.Close_B);
            this.Cu_De_GB.Controls.Add(this.Staff_Name_L);
            this.Cu_De_GB.Controls.Add(this.St_Na_TB);
            this.Cu_De_GB.Controls.Add(this.St_Ty_L);
            this.Cu_De_GB.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cu_De_GB.Location = new System.Drawing.Point(54, 134);
            this.Cu_De_GB.Name = "Cu_De_GB";
            this.Cu_De_GB.Size = new System.Drawing.Size(707, 413);
            this.Cu_De_GB.TabIndex = 66;
            this.Cu_De_GB.TabStop = false;
            this.Cu_De_GB.Text = "Staff";
            // 
            // Save_B
            // 
            this.Save_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_B.Location = new System.Drawing.Point(224, 321);
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
            this.Delete_B.Location = new System.Drawing.Point(374, 321);
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
            this.Add_New_B.Location = new System.Drawing.Point(74, 321);
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
            this.Close_B.Location = new System.Drawing.Point(524, 321);
            this.Close_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Close_B.Name = "Close_B";
            this.Close_B.Size = new System.Drawing.Size(133, 40);
            this.Close_B.TabIndex = 61;
            this.Close_B.Text = "Close";
            this.Close_B.UseVisualStyleBackColor = true;
            this.Close_B.Click += new System.EventHandler(this.Close_B_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffNoDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.staffTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(804, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(493, 401);
            this.dataGridView1.TabIndex = 67;
            // 
            // pollyPipeDataSet
            // 
            this.pollyPipeDataSet.DataSetName = "PollyPipeDataSet";
            this.pollyPipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffDetailsBindingSource
            // 
            this.staffDetailsBindingSource.DataMember = "Staff_Details";
            this.staffDetailsBindingSource.DataSource = this.pollyPipeDataSet;
            // 
            // staff_DetailsTableAdapter
            // 
            this.staff_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // staffNoDataGridViewTextBoxColumn
            // 
            this.staffNoDataGridViewTextBoxColumn.DataPropertyName = "Staff_No";
            this.staffNoDataGridViewTextBoxColumn.HeaderText = "Staff_No";
            this.staffNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffNoDataGridViewTextBoxColumn.Name = "staffNoDataGridViewTextBoxColumn";
            this.staffNoDataGridViewTextBoxColumn.Width = 80;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "S_Name";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "S_Name";
            this.sNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.Width = 160;
            // 
            // staffTypeDataGridViewTextBoxColumn
            // 
            this.staffTypeDataGridViewTextBoxColumn.DataPropertyName = "Staff_Type";
            this.staffTypeDataGridViewTextBoxColumn.HeaderText = "Staff_Type";
            this.staffTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffTypeDataGridViewTextBoxColumn.Name = "staffTypeDataGridViewTextBoxColumn";
            this.staffTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // Staff_Type_CB
            // 
            this.Staff_Type_CB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDetailsBindingSource, "Staff_Type", true));
            this.Staff_Type_CB.FormattingEnabled = true;
            this.Staff_Type_CB.Items.AddRange(new object[] {
            "Plumber",
            "Installation Manager",
            "Aquatics Installer",
            "Brick Layer"});
            this.Staff_Type_CB.Location = new System.Drawing.Point(365, 232);
            this.Staff_Type_CB.Name = "Staff_Type_CB";
            this.Staff_Type_CB.Size = new System.Drawing.Size(277, 41);
            this.Staff_Type_CB.TabIndex = 65;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1353, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cu_De_GB);
            this.Controls.Add(this.St_Ma_Re_L);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Cu_De_GB.ResumeLayout(false);
            this.Cu_De_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox St_Na_TB;
        private System.Windows.Forms.Label St_Ty_L;
        private System.Windows.Forms.Label Staff_Name_L;
        private System.Windows.Forms.Label St_Ma_Re_L;
        private System.Windows.Forms.TextBox Staff_No_TB;
        private System.Windows.Forms.Label Staff_No_L;
        private System.Windows.Forms.GroupBox Cu_De_GB;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.Button Add_New_B;
        private System.Windows.Forms.Button Close_B;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PollyPipeDataSet pollyPipeDataSet;
        private System.Windows.Forms.BindingSource staffDetailsBindingSource;
        private PollyPipeDataSetTableAdapters.Staff_DetailsTableAdapter staff_DetailsTableAdapter;
        private System.Windows.Forms.ComboBox Staff_Type_CB;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffTypeDataGridViewTextBoxColumn;
    }
}