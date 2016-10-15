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
    }
}
