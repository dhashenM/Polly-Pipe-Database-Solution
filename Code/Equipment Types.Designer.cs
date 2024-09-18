
namespace Polly_Pipe
{
    partial class Form1
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
            this.Equipment_Type = new System.Windows.Forms.Label();
            this.Equipment_Specification = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Eq_Type_TB = new System.Windows.Forms.TextBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pollyPipeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pollyPipeDataSet = new Polly_Pipe.PollyPipeDataSet();
            this.Eq_Specification_TB = new System.Windows.Forms.TextBox();
            this.Cu_De_GB = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eqNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eqSpecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eqTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollyPipeDataSet1 = new Polly_Pipe.PollyPipeDataSet1();
            this.pollyPipeDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pollyPipeDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTableAdapter = new Polly_Pipe.PollyPipeDataSetTableAdapters.EquipmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).BeginInit();
            this.Cu_De_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Equipment_Type
            // 
            this.Equipment_Type.AutoSize = true;
            this.Equipment_Type.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipment_Type.ForeColor = System.Drawing.Color.Black;
            this.Equipment_Type.Location = new System.Drawing.Point(99, 109);
            this.Equipment_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Equipment_Type.Name = "Equipment_Type";
            this.Equipment_Type.Size = new System.Drawing.Size(179, 29);
            this.Equipment_Type.TabIndex = 2;
            this.Equipment_Type.Text = "Equipment Type";
            this.Equipment_Type.Click += new System.EventHandler(this.label2_Click);
            // 
            // Equipment_Specification
            // 
            this.Equipment_Specification.AutoSize = true;
            this.Equipment_Specification.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipment_Specification.Location = new System.Drawing.Point(99, 181);
            this.Equipment_Specification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Equipment_Specification.Name = "Equipment_Specification";
            this.Equipment_Specification.Size = new System.Drawing.Size(263, 29);
            this.Equipment_Specification.TabIndex = 3;
            this.Equipment_Specification.Text = "Equipment Specification";
            this.Equipment_Specification.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(569, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Equipment Types";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Eq_Type_TB
            // 
            this.Eq_Type_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Eq_Type", true));
            this.Eq_Type_TB.Location = new System.Drawing.Point(421, 106);
            this.Eq_Type_TB.Name = "Eq_Type_TB";
            this.Eq_Type_TB.Size = new System.Drawing.Size(252, 40);
            this.Eq_Type_TB.TabIndex = 5;
            this.Eq_Type_TB.TextChanged += new System.EventHandler(this.Eq_Type_TB_TextChanged);
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.pollyPipeDataSetBindingSource;
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
            // Eq_Specification_TB
            // 
            this.Eq_Specification_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Eq_Spec", true));
            this.Eq_Specification_TB.Location = new System.Drawing.Point(421, 178);
            this.Eq_Specification_TB.Name = "Eq_Specification_TB";
            this.Eq_Specification_TB.Size = new System.Drawing.Size(252, 40);
            this.Eq_Specification_TB.TabIndex = 6;
            this.Eq_Specification_TB.TextChanged += new System.EventHandler(this.Eq_Specification_TB_TextChanged);
            // 
            // Cu_De_GB
            // 
            this.Cu_De_GB.Controls.Add(this.button1);
            this.Cu_De_GB.Controls.Add(this.button2);
            this.Cu_De_GB.Controls.Add(this.button3);
            this.Cu_De_GB.Controls.Add(this.button4);
            this.Cu_De_GB.Controls.Add(this.Equipment_Type);
            this.Cu_De_GB.Controls.Add(this.Eq_Specification_TB);
            this.Cu_De_GB.Controls.Add(this.Equipment_Specification);
            this.Cu_De_GB.Controls.Add(this.Eq_Type_TB);
            this.Cu_De_GB.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cu_De_GB.Location = new System.Drawing.Point(36, 96);
            this.Cu_De_GB.Name = "Cu_De_GB";
            this.Cu_De_GB.Size = new System.Drawing.Size(776, 374);
            this.Cu_De_GB.TabIndex = 19;
            this.Cu_De_GB.TabStop = false;
            this.Cu_De_GB.Text = "Equipment";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(240, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(390, 271);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(90, 271);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(540, 271);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eqNoDataGridViewTextBoxColumn,
            this.eqSpecDataGridViewTextBoxColumn,
            this.eqTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.equipmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(843, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(484, 363);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eqNoDataGridViewTextBoxColumn
            // 
            this.eqNoDataGridViewTextBoxColumn.DataPropertyName = "Eq_No";
            this.eqNoDataGridViewTextBoxColumn.FillWeight = 128.3422F;
            this.eqNoDataGridViewTextBoxColumn.HeaderText = "Eq_No";
            this.eqNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eqNoDataGridViewTextBoxColumn.Name = "eqNoDataGridViewTextBoxColumn";
            this.eqNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.eqNoDataGridViewTextBoxColumn.Width = 80;
            // 
            // eqSpecDataGridViewTextBoxColumn
            // 
            this.eqSpecDataGridViewTextBoxColumn.DataPropertyName = "Eq_Spec";
            this.eqSpecDataGridViewTextBoxColumn.FillWeight = 85.82888F;
            this.eqSpecDataGridViewTextBoxColumn.HeaderText = "Eq_Spec";
            this.eqSpecDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eqSpecDataGridViewTextBoxColumn.Name = "eqSpecDataGridViewTextBoxColumn";
            this.eqSpecDataGridViewTextBoxColumn.Width = 200;
            // 
            // eqTypeDataGridViewTextBoxColumn
            // 
            this.eqTypeDataGridViewTextBoxColumn.DataPropertyName = "Eq_Type";
            this.eqTypeDataGridViewTextBoxColumn.FillWeight = 85.82888F;
            this.eqTypeDataGridViewTextBoxColumn.HeaderText = "Eq_Type";
            this.eqTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eqTypeDataGridViewTextBoxColumn.Name = "eqTypeDataGridViewTextBoxColumn";
            this.eqTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // pollyPipeDataSet1
            // 
            this.pollyPipeDataSet1.DataSetName = "PollyPipeDataSet1";
            this.pollyPipeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pollyPipeDataSet1BindingSource
            // 
            this.pollyPipeDataSet1BindingSource.DataSource = this.pollyPipeDataSet1;
            this.pollyPipeDataSet1BindingSource.Position = 0;
            // 
            // pollyPipeDataSet1BindingSource1
            // 
            this.pollyPipeDataSet1BindingSource1.DataSource = this.pollyPipeDataSet1;
            this.pollyPipeDataSet1BindingSource1.Position = 0;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cu_De_GB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet)).EndInit();
            this.Cu_De_GB.ResumeLayout(false);
            this.Cu_De_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollyPipeDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Equipment_Type;
        private System.Windows.Forms.Label Equipment_Specification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Eq_Type_TB;
        private System.Windows.Forms.TextBox Eq_Specification_TB;
        private System.Windows.Forms.GroupBox Cu_De_GB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pollyPipeDataSetBindingSource;
        private PollyPipeDataSet pollyPipeDataSet;
        private PollyPipeDataSet1 pollyPipeDataSet1;
        private System.Windows.Forms.BindingSource pollyPipeDataSet1BindingSource;
        private System.Windows.Forms.BindingSource pollyPipeDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private PollyPipeDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqSpecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqTypeDataGridViewTextBoxColumn;
    }
}

