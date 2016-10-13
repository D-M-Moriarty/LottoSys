using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS
{
    public partial class frmCustomerUpdate : Form
    {
        private FrmMainMenu parent;

        public frmCustomerUpdate()
        {
            InitializeComponent();
        }

        public frmCustomerUpdate(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmCustomerUpdate_Load(object sender, EventArgs e)
        {
            grpUpdateBox.Visible = false;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void lblForename_Click(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if non empty Resultset is there first
            grpUpdateBox.Visible = true;
        }

        private void mnuUpdateCustomer_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void cboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCounty_Click(object sender, EventArgs e)
        {

        }

        private void txtTown_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTown_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddressLine2_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddressLine1_Click(object sender, EventArgs e)
        {

        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
