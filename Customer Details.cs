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
    public partial class Customer_Details : Form
    {
        public Customer_Details()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Equipment_Type_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pollyPipeDataSet.Customer_Details' table. You can move, or remove it, as needed.
            this.customer_DetailsTableAdapter.Fill(this.pollyPipeDataSet.Customer_Details);

        }

        private void Add_New_B_Click(object sender, EventArgs e)
        {
            customerDetailsBindingSource.AddNew();
        }

        private void Cu_Name_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            customerDetailsBindingSource.EndEdit();
            customer_DetailsTableAdapter.Update(pollyPipeDataSet.Customer_Details);
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            customerDetailsBindingSource.RemoveCurrent();
        }

        private void Last_B_Click(object sender, EventArgs e)
        {

        }

        private void Close_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
