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
    public partial class Installation_Equipment_Details : Form
    {
        public Installation_Equipment_Details()
        {
            InitializeComponent();
        }

        private void Eq_Sp_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void In_Eq_De_L_Click(object sender, EventArgs e)
        {

        }

        private void Installation_Equipment_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pollyPipeDataSet.Installation_Equipment_Details' table. You can move, or remove it, as needed.
            this.installation_Equipment_DetailsTableAdapter.Fill(this.pollyPipeDataSet.Installation_Equipment_Details);

        }

        private void Add_New_B_Click(object sender, EventArgs e)
        {
            installationEquipmentDetailsBindingSource.AddNew();
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            installationEquipmentDetailsBindingSource.EndEdit();
            installation_Equipment_DetailsTableAdapter.Update(pollyPipeDataSet.Installation_Equipment_Details);
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            installationEquipmentDetailsBindingSource.RemoveCurrent();
        }

        private void Close_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
