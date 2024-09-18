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
    public partial class Installation_Staff_Details : Form
    {
        public Installation_Staff_Details()
        {
            InitializeComponent();
        }

        private void Installation_Staff_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pollyPipeDataSet2.Installation_Staff_Requirements' table. You can move, or remove it, as needed.
            this.installation_Staff_RequirementsTableAdapter.Fill(this.pollyPipeDataSet2.Installation_Staff_Requirements);

        }

        private void Eq_Sp_L_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void In_St_De_L_Click(object sender, EventArgs e)
        {

        }

        private void Cu_De_GB_Enter(object sender, EventArgs e)
        {

        }

        private void In_ID_St_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_New_B_Click(object sender, EventArgs e)
        {
            installationStaffRequirementsBindingSource.AddNew();
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            installationStaffRequirementsBindingSource.EndEdit();
            installation_Staff_RequirementsTableAdapter.Update(pollyPipeDataSet2.Installation_Staff_Requirements);
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            installationStaffRequirementsBindingSource.RemoveCurrent();
        }

        private void Close_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
