using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polly_Pipe
{
    public partial class PollyPipeRecordSelection : Form
    {
        public PollyPipeRecordSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Installation_Details a = new Installation_Details();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Installation_Staff_Management a = new Installation_Staff_Management();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Installation_Equipment_Details a = new Installation_Equipment_Details();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer_Details a = new Customer_Details();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Installation_Staff_Details a = new Installation_Staff_Details();
            a.Show();
        }

        private void pplogin_Click(object sender, EventArgs e)
        {

        }
    }
}
