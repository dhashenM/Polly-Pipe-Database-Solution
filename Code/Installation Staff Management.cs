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
    public partial class Installation_Staff_Management : Form
    {
        public Installation_Staff_Management()
        {
            InitializeComponent();
        }

        private void In_St_De_L_Click(object sender, EventArgs e)
        {

        }

        private void Pe_Of_As_L_Click(object sender, EventArgs e)
        {

        }

        private void Ty_Of_St_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Qu_L_Click(object sender, EventArgs e)
        {

        }

        private void Reset_B_Click(object sender, EventArgs e)
        {

        }

        private void Enter_B_Click(object sender, EventArgs e)
        {

        }

        private void In_ID_St_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nu_Of_St_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ty_Of_St_L_Click(object sender, EventArgs e)
        {

        }

        private void In_ID_Staff_L_Click(object sender, EventArgs e)
        {

        }

        private void Pe_Of_As_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_New_B_Click(object sender, EventArgs e)
        {
            installationStaffDetailsBindingSource.AddNew();
        }

        private void Installation_Staff_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pollyPipeDataSet.Installation_Staff_Details' table. You can move, or remove it, as needed.
            this.installation_Staff_DetailsTableAdapter.Fill(this.pollyPipeDataSet.Installation_Staff_Details);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            installationStaffDetailsBindingSource.EndEdit();
            installation_Staff_DetailsTableAdapter.Update(pollyPipeDataSet.Installation_Staff_Details);
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            installationStaffDetailsBindingSource.RemoveCurrent();
        }

        private void Close_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
