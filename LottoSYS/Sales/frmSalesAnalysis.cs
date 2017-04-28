using LottoSYS.Customers;
using LottoSYS.Sales;
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
            // stopping the password beinng displayed
            txtPassword.PasswordChar = '*';
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            // setting the end value to one day after the selected value of the first date
            dtpEndDate.Value = DateTime.Today.AddDays(1);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // checking if the username and password are correct
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
            dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grdSales.DataSource = Analysis.getAnalysis(dtpStartDate.Value, dtpEndDate.Value).Tables["ss"];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ClsPrint _ClsPrint = new ClsPrint(grdSales, "Number Analysis");
            _ClsPrint.printPreview();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
