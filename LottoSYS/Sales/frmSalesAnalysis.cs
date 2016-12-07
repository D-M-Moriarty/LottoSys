using System;
using System.Windows.Forms;

namespace LottoSYS.Finance
{
    public partial class frmSalesAnalysis : Form
    {
        FrmMainMenu parent;

        public frmSalesAnalysis()
        {
            InitializeComponent();
        }

        public frmSalesAnalysis(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            txtPassword.PasswordChar = '*';
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            grpAnalysis.Visible = false;
            lstAnalysis.Items.Add("Total sales\t\t€67000");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == "12345" && txtUsername.Text == "Darren")
            {
                grpAnalysis.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grpAnalysis_Enter(object sender, EventArgs e)
        {

        }
    }
}
