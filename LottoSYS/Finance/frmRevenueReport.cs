using System;
using System.Windows.Forms;

namespace LottoSYS.Finance
{
    public partial class frmRevenueReport : Form
    {
        FrmMainMenu parent;

        public frmRevenueReport()
        {
            InitializeComponent();
        }

        public frmRevenueReport(FrmMainMenu Parent)
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
            if (txtPassword.Equals("hello"){
                grpRevenue.Visible = true;
            } else {
                Console.WriteLine("Invalid");
            }
        }
    }
}
