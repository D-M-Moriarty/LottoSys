using System;
using System.Windows.Forms;

namespace LottoSYS.Finance
{
    public partial class frmPayPrize : Form
    {
        FrmMainMenu parent;

        public frmPayPrize()
        {
            InitializeComponent();
        }

        public frmPayPrize(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            txtPassword.PasswordChar = '*';
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            grpRevenue.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == "12345" && txtUsername.Text == "Darren")
            {
                grpRevenue.Visible = true;
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
    }
}
