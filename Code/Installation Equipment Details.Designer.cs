
namespace Polly_Pipe
{
    partial class Installation_Equipment_Details
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
            this.Qu_L = new System.Windows.Forms.Label();
            this.In_ID_TB = new System.Windows.Forms.TextBox();
            this.Eq_Sp_L = new System.Windows.Forms.Label();
            this.In_ID_Equipment_L = new System.Windows.Forms.Label();
            this.In_Eq_De_L = new System.Windows.Forms.Label();
            this.Qu_TB = new System.Windows.Forms.TextBox();
            this.Cu_De_GB = new System.Windows.Forms.GroupBox();
            this.Save_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Add_New_B = new System.Windows.Forms.Button();
            this.Close_B = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pollyPipeDataSet = new Polly_Pipe.PollyPipeDataSet();
            this.installationEquipmentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installation_Equipment_DetailsTableAdapter = new Polly_Pipe.PollyPipeDataSetTableAdapters.Installation_Equipment_DetailsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eqNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityNeededDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cu_De_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationEquipmentDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Qu_L
            // 
            this.Qu_L.AutoSize = true;
            this.Qu_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qu_L.Location = new System.Drawing.Point(438, 172);
            this.Qu_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Qu_L.Name = "Qu_L";
            this.Qu_L.Size = new System.Drawing.Size(104, 29);
            this.Qu_L.TabIndex = 36;
            this.Qu_L.Text = "Quantity";
            // 
            // In_ID_TB
            // 
            this.In_ID_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationEquipmentDetailsBindingSource, "In_ID", true));
            this.In_ID_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_ID_TB.Location = new System.Drawing.Point(388, 85);
            this.In_ID_TB.Name = "In_ID_TB";
            this.In_ID_TB.Size = new System.Drawing.Size(99, 36);
            this.In_ID_TB.TabIndex = 33;
            // 
            // Eq_Sp_L
            // 
            this.Eq_Sp_L.AutoSize = true;
            this.Eq_Sp_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eq_Sp_L.Location = new System.Drawing.Point(103, 172);
            this.Eq_Sp_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Eq_Sp_L.Name = "Eq_Sp_L";
            this.Eq_Sp_L.Size = new System.Drawing.Size(213, 29);
            this.Eq_Sp_L.TabIndex = 31;
            this.Eq_Sp_L.Text = "Equipment Number";
            // 
            // In_ID_Equipment_L
            // 
            this.In_ID_Equipment_L.AutoSize = true;
            this.In_ID_Equipment_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_ID_Equipment_L.ForeColor = System.Drawing.Color.Black;
            this.In_ID_Equipment_L.Location = new System.Drawing.Point(225, 88);
            this.In_ID_Equipment_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.In_ID_Equipment_L.Name = "In_ID_Equipment_L";
            this.In_ID_Equipment_L.Size = new System.Drawing.Size(156, 29);
            this.In_ID_Equipment_L.TabIndex = 30;
            this.In_ID_Equipment_L.Text = "Installation ID";
            // 
            // In_Eq_De_L
            // 
            this.In_Eq_De_L.AutoSize = true;
            this.In_Eq_De_L.BackColor = System.Drawing.Color.Transparent;
            this.In_Eq_De_L.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_Eq_De_L.ForeColor = System.Drawing.Color.Green;
            this.In_Eq_De_L.Location = new System.Drawing.Point(453, 60);
            this.In_Eq_De_L.Name = "In_Eq_De_L";
            this.In_Eq_De_L.Size = new System.Drawing.Size(453, 41);
            this.In_Eq_De_L.TabIndex = 29;
            this.In_Eq_De_L.Text = "Installation Equipment Details";
            this.In_Eq_De_L.Click += new System.EventHandler(this.In_Eq_De_L_Click);
            // 
            // Qu_TB
            // 
            this.Qu_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationEquipmentDetailsBindingSource, "Quantity_Needed", true));
            this.Qu_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qu_TB.Location = new System.Drawing.Point(549, 169);
            this.Qu_TB.Name = "Qu_TB";
            this.Qu_TB.Size = new System.Drawing.Size(54, 36);
            this.Qu_TB.TabIndex = 32;
            // 
            // Cu_De_GB
            // 
            this.Cu_De_GB.Controls.Add(this.textBox1);
            this.Cu_De_GB.Controls.Add(this.Save_B);
            this.Cu_De_GB.Controls.Add(this.Delete_B);
            this.Cu_De_GB.Controls.Add(this.Qu_L);
            this.Cu_De_GB.Controls.Add(this.Add_New_B);
            this.Cu_De_GB.Controls.Add(this.Close_B);
            this.Cu_De_GB.Controls.Add(this.In_ID_Equipment_L);
            this.Cu_De_GB.Controls.Add(this.In_ID_TB);
            this.Cu_De_GB.Controls.Add(this.Eq_Sp_L);
            this.Cu_De_GB.Controls.Add(this.Qu_TB);
            this.Cu_De_GB.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cu_De_GB.Location = new System.Drawing.Point(72, 162);
            this.Cu_De_GB.Name = "Cu_De_GB";
            this.Cu_De_GB.Size = new System.Drawing.Size(690, 363);
            this.Cu_De_GB.TabIndex = 38;
            this.Cu_De_GB.TabStop = false;
            this.Cu_De_GB.Text = "Installation Equipment";
            // 
            // Save_B
            // 
            this.Save_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_B.Location = new System.Drawing.Point(208, 253);
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
            this.Delete_B.Location = new System.Drawing.Point(358, 253);
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
            this.Add_New_B.Location = new System.Drawing.Point(58, 253);
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
            this.Close_B.Location = new System.Drawing.Point(508, 253);
            this.Close_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Close_B.Name = "Close_B";
            this.Close_B.Size = new System.Drawing.Size(133, 40);
            this.Close_B.TabIndex = 11;
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
            this.inIDDataGridViewTextBoxColumn,
            this.eqNoDataGridViewTextBoxColumn,
            this.quantityNeededDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.installationEquipmentDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(818, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(354, 363);
            this.dataGridView1.TabIndex = 39;
            // 
            // pollyPipeDataSet
            // 
            this.pollyPipeDataSet.DataSetName = "PollyPipeDataSet";
            this.pollyPipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // installationEquipmentDetailsBindingSource
            // 
            this.installationEquipmentDetailsBindingSource.DataMember = "Installation_Equipment_Details";
            this.installationEquipmentDetailsBindingSource.DataSource = this.pollyPipeDataSet;
            // 
            // installation_Equipment_DetailsTableAdapter
            // 
            this.installation_Equipment_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationEquipmentDetailsBindingSource, "Eq_No", true));
            this.textBox1.Location = new System.Drawing.Point(323, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 40);
            this.textBox1.TabIndex = 37;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inIDDataGridViewTextBoxColumn
            // 
            this.inIDDataGridViewTextBoxColumn.DataPropertyName = "In_ID";
            this.inIDDataGridViewTextBoxColumn.HeaderText = "In_ID";
            this.inIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inIDDataGridViewTextBoxColumn.Name = "inIDDataGridViewTextBoxColumn";
            this.inIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // eqNoDataGridViewTextBoxColumn
            // 
            this.eqNoDataGridViewTextBoxColumn.DataPropertyName = "Eq_No";
            this.eqNoDataGridViewTextBoxColumn.HeaderText = "Eq_No";
            this.eqNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eqNoDataGridViewTextBoxColumn.Name = "eqNoDataGridViewTextBoxColumn";
            this.eqNoDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantityNeededDataGridViewTextBoxColumn
            // 
            this.quantityNeededDataGridViewTextBoxColumn.DataPropertyName = "Quantity_Needed";
            this.quantityNeededDataGridViewTextBoxColumn.HeaderText = "Quantity_Needed";
            this.quantityNeededDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityNeededDataGridViewTextBoxColumn.Name = "quantityNeededDataGridViewTextBoxColumn";
            this.quantityNeededDataGridViewTextBoxColumn.Width = 140;
            // 
            // Installation_Equipment_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1257, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cu_De_GB);
            this.Controls.Add(this.In_Eq_De_L);
            this.Name = "Installation_Equipment_Details";
            this.Text = "Installation_Equipment_Details";
            this.Load += new System.EventHandler(this.Installation_Equipment_Details_Load);
            this.Cu_De_GB.ResumeLayout(false);
            this.Cu_De_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationEquipmentDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Qu_L;
        private System.Windows.Forms.TextBox In_ID_TB;
        private System.Windows.Forms.Label Eq_Sp_L;
        private System.Windows.Forms.Label In_ID_Equipment_L;
        private System.Windows.Forms.Label In_Eq_De_L;
        private System.Windows.Forms.TextBox Qu_TB;
        private System.Windows.Forms.GroupBox Cu_De_GB;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.Button Add_New_B;
        private System.Windows.Forms.Button Close_B;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PollyPipeDataSet pollyPipeDataSet;
        private System.Windows.Forms.BindingSource installationEquipmentDetailsBindingSource;
        private PollyPipeDataSetTableAdapters.Installation_Equipment_DetailsTableAdapter installation_Equipment_DetailsTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityNeededDataGridViewTextBoxColumn;
    }
}