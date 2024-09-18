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
    public partial class Installation_Details : Form
    {
        public Installation_Details()
        {
            InitializeComponent();
        }

        private void St_Ma_Re_L_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Installation_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pollyPipeDataSet.Installation_Details' table. You can move, or remove it, as needed.
            this.installation_DetailsTableAdapter.Fill(this.pollyPipeDataSet.Installation_Details);

        }

        private void In_ID_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_New_B_Click(object sender, EventArgs e)
        {
            installationDetailsBindingSource.AddNew();
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            installationDetailsBindingSource.EndEdit();
            installation_DetailsTableAdapter.Update(pollyPipeDataSet.Installation_Details);
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            installationDetailsBindingSource.RemoveCurrent();
        }

        private void Close_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
