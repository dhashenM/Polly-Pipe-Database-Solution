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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pollyPipeDataSet.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.pollyPipeDataSet.Equipment);

        }

        private void Eq_Type_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eq_Specification_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_New_B_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            equipmentBindingSource.AddNew();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            equipmentBindingSource.EndEdit();
            equipmentTableAdapter.Update(pollyPipeDataSet.Equipment);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            equipmentBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
