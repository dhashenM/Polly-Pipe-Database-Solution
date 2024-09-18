
namespace Polly_Pipe
{
    partial class Installation_Details
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
            this.St_Ty_TB = new System.Windows.Forms.TextBox();
            this.St_Na_TB = new System.Windows.Forms.TextBox();
            this.St_Ty_L = new System.Windows.Forms.Label();
            this.In_Ty_L = new System.Windows.Forms.Label();
            this.In_De_L = new System.Windows.Forms.Label();
            this.Cu_ID_L = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.In_ID_TB = new System.Windows.Forms.TextBox();
            this.In_ID_L = new System.Windows.Forms.Label();
            this.Cu_De_GB = new System.Windows.Forms.GroupBox();
            this.Save_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Add_New_B = new System.Windows.Forms.Button();
            this.Close_B = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pollyPipeDataSet = new Polly_Pipe.PollyPipeDataSet();
            this.installationDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installation_DetailsTableAdapter = new Polly_Pipe.PollyPipeDataSetTableAdapters.Installation_DetailsTableAdapter();
            this.inIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cu_De_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // St_Ty_TB
            // 
            this.St_Ty_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationDetailsBindingSource, "In_Name", true));
            this.St_Ty_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_Ty_TB.Location = new System.Drawing.Point(345, 219);
            this.St_Ty_TB.Name = "St_Ty_TB";
            this.St_Ty_TB.Size = new System.Drawing.Size(277, 36);
            this.St_Ty_TB.TabIndex = 24;
            // 
            // St_Na_TB
            // 
            this.St_Na_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationDetailsBindingSource, "Cust_ID", true));
            this.St_Na_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_Na_TB.Location = new System.Drawing.Point(345, 294);
            this.St_Na_TB.Name = "St_Na_TB";
            this.St_Na_TB.Size = new System.Drawing.Size(277, 36);
            this.St_Na_TB.TabIndex = 23;
            // 
            // St_Ty_L
            // 
            this.St_Ty_L.AutoSize = true;
            this.St_Ty_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_Ty_L.Location = new System.Drawing.Point(77, 222);
            this.St_Ty_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.St_Ty_L.Name = "St_Ty_L";
            this.St_Ty_L.Size = new System.Drawing.Size(194, 29);
            this.St_Ty_L.TabIndex = 22;
            this.St_Ty_L.Text = "Installation Name";
            // 
            // In_Ty_L
            // 
            this.In_Ty_L.AutoSize = true;
            this.In_Ty_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_Ty_L.ForeColor = System.Drawing.Color.Black;
            this.In_Ty_L.Location = new System.Drawing.Point(77, 149);
            this.In_Ty_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.In_Ty_L.Name = "In_Ty_L";
            this.In_Ty_L.Size = new System.Drawing.Size(183, 29);
            this.In_Ty_L.TabIndex = 21;
            this.In_Ty_L.Text = "Installation Type";
            // 
            // In_De_L
            // 
            this.In_De_L.AutoSize = true;
            this.In_De_L.BackColor = System.Drawing.Color.Transparent;
            this.In_De_L.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_De_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.In_De_L.Location = new System.Drawing.Point(562, 33);
            this.In_De_L.Name = "In_De_L";
            this.In_De_L.Size = new System.Drawing.Size(288, 41);
            this.In_De_L.TabIndex = 20;
            this.In_De_L.Text = "Installation Details";
            this.In_De_L.Click += new System.EventHandler(this.St_Ma_Re_L_Click);
            // 
            // Cu_ID_L
            // 
            this.Cu_ID_L.AutoSize = true;
            this.Cu_ID_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cu_ID_L.Location = new System.Drawing.Point(77, 297);
            this.Cu_ID_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cu_ID_L.Name = "Cu_ID_L";
            this.Cu_ID_L.Size = new System.Drawing.Size(139, 29);
            this.Cu_ID_L.TabIndex = 27;
            this.Cu_ID_L.Text = "Customer ID";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationDetailsBindingSource, "In_Type", true));
            this.comboBox1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Freshwater Tropical",
            "Freshwater Cold",
            "Marine"});
            this.comboBox1.Location = new System.Drawing.Point(345, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 36);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // In_ID_TB
            // 
            this.In_ID_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.installationDetailsBindingSource, "In_ID", true));
            this.In_ID_TB.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_ID_TB.Location = new System.Drawing.Point(345, 70);
            this.In_ID_TB.Name = "In_ID_TB";
            this.In_ID_TB.Size = new System.Drawing.Size(277, 36);
            this.In_ID_TB.TabIndex = 30;
            this.In_ID_TB.TextChanged += new System.EventHandler(this.In_ID_TB_TextChanged);
            // 
            // In_ID_L
            // 
            this.In_ID_L.AutoSize = true;
            this.In_ID_L.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In_ID_L.Location = new System.Drawing.Point(77, 73);
            this.In_ID_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.In_ID_L.Name = "In_ID_L";
            this.In_ID_L.Size = new System.Drawing.Size(156, 29);
            this.In_ID_L.TabIndex = 29;
            this.In_ID_L.Text = "Installation ID";
            // 
            // Cu_De_GB
            // 
            this.Cu_De_GB.Controls.Add(this.Save_B);
            this.Cu_De_GB.Controls.Add(this.In_ID_TB);
            this.Cu_De_GB.Controls.Add(this.Delete_B);
            this.Cu_De_GB.Controls.Add(this.In_ID_L);
            this.Cu_De_GB.Controls.Add(this.comboBox1);
            this.Cu_De_GB.Controls.Add(this.Add_New_B);
            this.Cu_De_GB.Controls.Add(this.Cu_ID_L);
            this.Cu_De_GB.Controls.Add(this.Close_B);
            this.Cu_De_GB.Controls.Add(this.In_Ty_L);
            this.Cu_De_GB.Controls.Add(this.St_Ty_L);
            this.Cu_De_GB.Controls.Add(this.St_Ty_TB);
            this.Cu_De_GB.Controls.Add(this.St_Na_TB);
            this.Cu_De_GB.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cu_De_GB.Location = new System.Drawing.Point(68, 103);
            this.Cu_De_GB.Name = "Cu_De_GB";
            this.Cu_De_GB.Size = new System.Drawing.Size(710, 459);
            this.Cu_De_GB.TabIndex = 31;
            this.Cu_De_GB.TabStop = false;
            this.Cu_De_GB.Text = "Installation";
            // 
            // Save_B
            // 
            this.Save_B.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_B.Location = new System.Drawing.Point(206, 379);
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
            this.Delete_B.Location = new System.Drawing.Point(356, 379);
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
            this.Add_New_B.Location = new System.Drawing.Point(56, 379);
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
            this.Close_B.Location = new System.Drawing.Point(506, 379);
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
            this.inTypeDataGridViewTextBoxColumn,
            this.inNameDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.installationDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(825, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 459);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pollyPipeDataSet
            // 
            this.pollyPipeDataSet.DataSetName = "PollyPipeDataSet";
            this.pollyPipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // installationDetailsBindingSource
            // 
            this.installationDetailsBindingSource.DataMember = "Installation_Details";
            this.installationDetailsBindingSource.DataSource = this.pollyPipeDataSet;
            // 
            // installation_DetailsTableAdapter
            // 
            this.installation_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // inIDDataGridViewTextBoxColumn
            // 
            this.inIDDataGridViewTextBoxColumn.DataPropertyName = "In_ID";
            this.inIDDataGridViewTextBoxColumn.HeaderText = "In_ID";
            this.inIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inIDDataGridViewTextBoxColumn.Name = "inIDDataGridViewTextBoxColumn";
            this.inIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // inTypeDataGridViewTextBoxColumn
            // 
            this.inTypeDataGridViewTextBoxColumn.DataPropertyName = "In_Type";
            this.inTypeDataGridViewTextBoxColumn.HeaderText = "In_Type";
            this.inTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inTypeDataGridViewTextBoxColumn.Name = "inTypeDataGridViewTextBoxColumn";
            this.inTypeDataGridViewTextBoxColumn.Width = 170;
            // 
            // inNameDataGridViewTextBoxColumn
            // 
            this.inNameDataGridViewTextBoxColumn.DataPropertyName = "In_Name";
            this.inNameDataGridViewTextBoxColumn.HeaderText = "In_Name";
            this.inNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inNameDataGridViewTextBoxColumn.Name = "inNameDataGridViewTextBoxColumn";
            this.inNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // Installation_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1436, 616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cu_De_GB);
            this.Controls.Add(this.In_De_L);
            this.Name = "Installation_Details";
            this.Text = "Installation_Details";
            this.Load += new System.EventHandler(this.Installation_Details_Load);
            this.Cu_De_GB.ResumeLayout(false);
            this.Cu_De_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox St_Ty_TB;
        private System.Windows.Forms.TextBox St_Na_TB;
        private System.Windows.Forms.Label St_Ty_L;
        private System.Windows.Forms.Label In_Ty_L;
        private System.Windows.Forms.Label In_De_L;
        private System.Windows.Forms.Label Cu_ID_L;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox In_ID_TB;
        private System.Windows.Forms.Label In_ID_L;
        private System.Windows.Forms.GroupBox Cu_De_GB;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.Button Add_New_B;
        private System.Windows.Forms.Button Close_B;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PollyPipeDataSet pollyPipeDataSet;
        private System.Windows.Forms.BindingSource installationDetailsBindingSource;
        private PollyPipeDataSetTableAdapters.Installation_DetailsTableAdapter installation_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
    }
}