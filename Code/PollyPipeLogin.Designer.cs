
namespace Polly_Pipe
{
    partial class PollyPipeLogin
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
            this.pplogin = new System.Windows.Forms.Label();
            this.groupBoxlogin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pplogin_b = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ppexit_b = new System.Windows.Forms.Button();
            this.groupBoxlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pplogin
            // 
            this.pplogin.AutoSize = true;
            this.pplogin.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pplogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pplogin.Location = new System.Drawing.Point(200, 47);
            this.pplogin.Name = "pplogin";
            this.pplogin.Size = new System.Drawing.Size(352, 37);
            this.pplogin.TabIndex = 0;
            this.pplogin.Text = "Polly Pipe Database Login";
            this.pplogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxlogin
            // 
            this.groupBoxlogin.Controls.Add(this.ppexit_b);
            this.groupBoxlogin.Controls.Add(this.textBox2);
            this.groupBoxlogin.Controls.Add(this.textBox1);
            this.groupBoxlogin.Controls.Add(this.pplogin_b);
            this.groupBoxlogin.Controls.Add(this.label2);
            this.groupBoxlogin.Controls.Add(this.label1);
            this.groupBoxlogin.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxlogin.Location = new System.Drawing.Point(60, 118);
            this.groupBoxlogin.Name = "groupBoxlogin";
            this.groupBoxlogin.Size = new System.Drawing.Size(627, 351);
            this.groupBoxlogin.TabIndex = 3;
            this.groupBoxlogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(102, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // pplogin_b
            // 
            this.pplogin_b.Location = new System.Drawing.Point(180, 238);
            this.pplogin_b.Name = "pplogin_b";
            this.pplogin_b.Size = new System.Drawing.Size(91, 45);
            this.pplogin_b.TabIndex = 6;
            this.pplogin_b.Text = "Login";
            this.pplogin_b.UseVisualStyleBackColor = true;
            this.pplogin_b.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 32);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 32);
            this.textBox2.TabIndex = 9;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // ppexit_b
            // 
            this.ppexit_b.Location = new System.Drawing.Point(355, 238);
            this.ppexit_b.Name = "ppexit_b";
            this.ppexit_b.Size = new System.Drawing.Size(91, 45);
            this.ppexit_b.TabIndex = 10;
            this.ppexit_b.Text = "Exit";
            this.ppexit_b.UseVisualStyleBackColor = true;
            this.ppexit_b.Click += new System.EventHandler(this.ppexit_b_Click);
            // 
            // PollyPipeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(744, 518);
            this.Controls.Add(this.groupBoxlogin);
            this.Controls.Add(this.pplogin);
            this.Name = "PollyPipeLogin";
            this.Text = "PollyPipeLogin";
            this.groupBoxlogin.ResumeLayout(false);
            this.groupBoxlogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pplogin;
        private System.Windows.Forms.GroupBox groupBoxlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ppexit_b;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button pplogin_b;
    }
}