
namespace Polly_Pipe
{
    partial class Customer_Details
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
            this.Customer_Details_L = new System.Windows.Forms.Label();
            this.Cu_In_Ad_TB = new System.Windows.Forms.TextBox();
            this.Cu_Name_TB = new System.Windows.Forms.TextBox();
            this.Customer_Installation_Address_L = new System.Windows.Forms.Label();
            this.Customer_Name_L = new System.Windows.Forms.Label();
            this.Add_New_B = new System.Windows.Forms.Button();
            this.Close_B = new System.Windows.Forms.Button();
            this.Cu_De_GB = new System.Windows.Forms.GroupBox();
            this.Save_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pollyPipeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pollyPipeDataSet = new Polly_Pipe.PollyPipeDataSet();
            this.customer_DetailsTableAdapter = new Polly_Pipe.PollyPipeDataSetTableAdapters.Customer_DetailsTableAdapter();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cu_De_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_Details_L
            // 
            this.Customer_Details_L.AutoSize = true;
            this.Customer_Details_L.BackColor = System.Drawing.Color.Transparent;
            this.Customer_Details_L.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Details_L.ForeColor = System.Drawing.Color.Red;
            this.Customer_Details_L.Location = new System.Drawing.Point(580, 26);
            this.Customer_Details_L.Name = "Customer_Details_L";
            this.Customer_Details_L.Size = new System.Drawing.Size(264, 41);
            this.Customer_Details_L.TabIndex = 1;
            this.Customer_Details_L.Text = "Customer Details";
            this.Customer_Details_L.Click += new System.EventHandler(this.label2_Click);
            // 
            // Cu_In_Ad_TB
            // 
            this.Cu_In_Ad_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsBindingSource, "C_Address", true));
            this.Cu_In_Ad_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cu_In_Ad_TB.Location = new System.Drawing.Point(392, 183);
            this.Cu_In_Ad_TB.Name = "Cu_In_Ad_TB";
            this.Cu_In_Ad_TB.Size = new System.Drawing.Size(277, 36);
            this.Cu_In_Ad_TB.TabIndex = 10;
            // 
            // Cu_Name_TB
            // 
            this.Cu_Name_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsBindingSource, "C_Name", true));
            this.Cu_Name_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cu_Name_TB.Location = new System.Drawing.Point(392, 97);
            this.Cu_Name_TB.Name = "Cu_Name_TB";
            this.Cu_Name_TB.Size = new System.Drawing.Size(277, 36);
            this.Cu_Name_TB.TabIndex = 9;
            this.Cu_Name_TB.TextChanged += new System.EventHandler(this.Cu_Name_TB_TextChanged);
            // 
            // Customer_Installation_Address_L
            // 
            this.Customer_Installation_Address_L.AutoSize = true;
            this.Customer_Installation_Address_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Installation_Address_L.Location = new System.Drawing.Point(42, 186);
            this.Customer_Installation_Address_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Customer_Installation_Address_L.Name = "Customer_Installation_Address_L";
            this.Customer_Installation_Address_L.Size = new System.Drawing.Size(320, 29);
            this.Customer_Installation_Address_L.TabIndex = 8;
            this.Customer_Installation_Address_L.Text = "Customer Installation Address";
            // 
            // Customer_Name_L
            // 
            this.Customer_Name_L.AutoSize = true;
            this.Customer_Name_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Name_L.ForeColor = System.Drawing.Color.Black;
            this.Customer_Name_L.Location = new System.Drawing.Point(42, 100);
            this.Customer_Name_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Customer_Name_L.Name = "Customer_Name_L";
            this.Customer_Name_L.Size = new System.Drawing.Size(177, 29);
            this.Customer_Name_L.TabIndex = 7;
            this.Customer_Name_L.Text = "Customer Name";
            this.Customer_Name_L.Click += new System.EventHandler(this.Equipment_Type_Click);
            // 
            // Add_New_B
            // 
            this.Add_New_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_B.Location = new System.Drawing.Point(62, 288);
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
            this.Close_B.Location = new System.Drawing.Point(512, 288);
            this.Close_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Close_B.Name = "Close_B";
            this.Close_B.Size = new System.Drawing.Size(133, 40);
            this.Close_B.TabIndex = 11;
            this.Close_B.Text = "Close";
            this.Close_B.UseVisualStyleBackColor = true;
            this.Close_B.Click += new System.EventHandler(this.Close_B_Click);
            // 
            // Cu_De_GB
            // 
            this.Cu_De_GB.Controls.Add(this.Save_B);
            this.Cu_De_GB.Controls.Add(this.Delete_B);
            this.Cu_De_GB.Controls.Add(this.Add_New_B);
            this.Cu_De_GB.Controls.Add(this.Customer_Name_L);
            this.Cu_De_GB.Controls.Add(this.Close_B);
            this.Cu_De_GB.Controls.Add(this.Customer_Installation_Address_L);
            this.Cu_De_GB.Controls.Add(this.Cu_In_Ad_TB);
            this.Cu_De_GB.Controls.Add(this.Cu_Name_TB);
            this.Cu_De_GB.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cu_De_GB.Location = new System.Drawing.Point(33, 89);
            this.Cu_De_GB.Name = "Cu_De_GB";
            this.Cu_De_GB.Size = new System.Drawing.Size(707, 413);
            this.Cu_De_GB.TabIndex = 13;
            this.Cu_De_GB.TabStop = false;
            this.Cu_De_GB.Text = "Customers";
            // 
            // Save_B
            // 
            this.Save_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_B.Location = new System.Drawing.Point(212, 288);
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
            this.Delete_B.Location = new System.Drawing.Point(362, 288);
            this.Delete_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(133, 40);
            this.Delete_B.TabIndex = 13;
            this.Delete_B.Text = "Delete";
            this.Delete_B.UseVisualStyleBackColor = true;
            this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(765, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 394);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "Customer_Details";
            this.customerDetailsBindingSource.DataSource = this.pollyPipeDataSetBindingSource;
            // 
            // pollyPipeDataSetBindingSource
            // 
            this.pollyPipeDataSetBindingSource.DataSource = this.pollyPipeDataSet;
            this.pollyPipeDataSetBindingSource.Position = 0;
            // 
            // pollyPipeDataSet
            // 
            this.pollyPipeDataSet.DataSetName = "PollyPipeDataSet";
            this.pollyPipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_DetailsTableAdapter
            // 
            this.customer_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.FillWeight = 9.625671F;
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.custIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.FillWeight = 9.625671F;
            this.cNameDataGridViewTextBoxColumn.HeaderText = "C_Name";
            this.cNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cAddressDataGridViewTextBoxColumn
            // 
            this.cAddressDataGridViewTextBoxColumn.DataPropertyName = "C_Address";
            this.cAddressDataGridViewTextBoxColumn.FillWeight = 280.7487F;
            this.cAddressDataGridViewTextBoxColumn.HeaderText = "C_Address";
            this.cAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cAddressDataGridViewTextBoxColumn.Name = "cAddressDataGridViewTextBoxColumn";
            this.cAddressDataGridViewTextBoxColumn.Width = 350;
            // 
            // Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1434, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Customer_Details_L);
            this.Controls.Add(this.Cu_De_GB);
            this.Name = "Customer_Details";
            this.Text = "Customer_Details";
            this.Load += new System.EventHandler(this.Customer_Details_Load);
            this.Cu_De_GB.ResumeLayout(false);
            this.Cu_De_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Customer_Details_L;
        private System.Windows.Forms.TextBox Cu_In_Ad_TB;
        private System.Windows.Forms.TextBox Cu_Name_TB;
        private System.Windows.Forms.Label Customer_Installation_Address_L;
        private System.Windows.Forms.Label Customer_Name_L;
        private System.Windows.Forms.Button Add_New_B;
        private System.Windows.Forms.Button Close_B;
        private System.Windows.Forms.GroupBox Cu_De_GB;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pollyPipeDataSetBindingSource;
        private PollyPipeDataSet pollyPipeDataSet;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private PollyPipeDataSetTableAdapters.Customer_DetailsTableAdapter customer_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddressDataGridViewTextBoxColumn;
    }
}