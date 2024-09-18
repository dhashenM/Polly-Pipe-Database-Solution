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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Customer_Details_L_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pollyPipeDataSet.Staff_Details' table. You can move, or remove it, as needed.
            this.staff_DetailsTableAdapter.Fill(this.pollyPipeDataSet.Staff_Details);

        }

        private void Add_New_B_Click(object sender, EventArgs e)
        {
            staffDetailsBindingSource.AddNew();
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            staffDetailsBindingSource.EndEdit();
            staff_DetailsTableAdapter.Update(pollyPipeDataSet.Staff_Details);
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            staffDetailsBindingSource.RemoveCurrent();
        }

        private void Close_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
