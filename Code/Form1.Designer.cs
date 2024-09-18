
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
            this.Enter_B = new System.Windows.Forms.Button();
            this.Equipment_Type = new System.Windows.Forms.Label();
            this.Equipment_Specification = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Eq_Type_TB = new System.Windows.Forms.TextBox();
            this.Eq_Specification_TB = new System.Windows.Forms.TextBox();
            this.Reset_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enter_B
            // 
            this.Enter_B.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_B.Location = new System.Drawing.Point(638, 350);
            this.Enter_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Enter_B.Name = "Enter_B";
            this.Enter_B.Size = new System.Drawing.Size(112, 40);
            this.Enter_B.TabIndex = 0;
            this.Enter_B.Text = "Enter";
            this.Enter_B.UseVisualStyleBackColor = true;
            this.Enter_B.Click += new System.EventHandler(this.button1_Click);
            // 
            // Equipment_Type
            // 
            this.Equipment_Type.AutoSize = true;
            this.Equipment_Type.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipment_Type.ForeColor = System.Drawing.Color.Black;
            this.Equipment_Type.Location = new System.Drawing.Point(203, 187);
            this.Equipment_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Equipment_Type.Name = "Equipment_Type";
            this.Equipment_Type.Size = new System.Drawing.Size(149, 24);
            this.Equipment_Type.TabIndex = 2;
            this.Equipment_Type.Text = "Equipment Type";
            this.Equipment_Type.Click += new System.EventHandler(this.label2_Click);
            // 
            // Equipment_Specification
            // 
            this.Equipment_Specification.AutoSize = true;
            this.Equipment_Specification.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipment_Specification.Location = new System.Drawing.Point(203, 259);
            this.Equipment_Specification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Equipment_Specification.Name = "Equipment_Specification";
            this.Equipment_Specification.Size = new System.Drawing.Size(218, 24);
            this.Equipment_Specification.TabIndex = 3;
            this.Equipment_Specification.Text = "Equipment Specification";
            this.Equipment_Specification.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(345, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Equipment Types";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Eq_Type_TB
            // 
            this.Eq_Type_TB.Location = new System.Drawing.Point(515, 181);
            this.Eq_Type_TB.Name = "Eq_Type_TB";
            this.Eq_Type_TB.Size = new System.Drawing.Size(235, 36);
            this.Eq_Type_TB.TabIndex = 5;
            // 
            // Eq_Specification_TB
            // 
            this.Eq_Specification_TB.Location = new System.Drawing.Point(515, 253);
            this.Eq_Specification_TB.Name = "Eq_Specification_TB";
            this.Eq_Specification_TB.Size = new System.Drawing.Size(235, 36);
            this.Eq_Specification_TB.TabIndex = 6;
            // 
            // Reset_B
            // 
            this.Reset_B.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_B.Location = new System.Drawing.Point(515, 350);
            this.Reset_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Reset_B.Name = "Reset_B";
            this.Reset_B.Size = new System.Drawing.Size(112, 40);
            this.Reset_B.TabIndex = 7;
            this.Reset_B.Text = "Reset";
            this.Reset_B.UseVisualStyleBackColor = true;
            this.Reset_B.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 560);
            this.Controls.Add(this.Reset_B);
            this.Controls.Add(this.Eq_Specification_TB);
            this.Controls.Add(this.Eq_Type_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Equipment_Specification);
            this.Controls.Add(this.Equipment_Type);
            this.Controls.Add(this.Enter_B);
            this.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_B;
        private System.Windows.Forms.Label Equipment_Type;
        private System.Windows.Forms.Label Equipment_Specification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Eq_Type_TB;
        private System.Windows.Forms.TextBox Eq_Specification_TB;
        private System.Windows.Forms.Button Reset_B;
    }
}

