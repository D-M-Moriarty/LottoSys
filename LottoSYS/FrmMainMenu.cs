using LottoSYS.Sales;
using LottoSYS.Finance;
using System;
using System.Windows.Forms;

namespace LottoSYS
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            // Initalizes all Formitems and configurations set on the Form "frmxxx.Designer.cs"
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuCustomerReg_Click(object sender, EventArgs e)
        {
            frmCustomerReg frmNext = new frmCustomerReg(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuCustomerUpdate_Click(object sender, EventArgs e)
        {
            frmCustomerUpdate frmNext = new frmCustomerUpdate(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuCustomerDeReg_Click(object sender, EventArgs e)
        {
            frmCustomerDeReg frmNext = new frmCustomerDeReg(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuCustomerList_Click(object sender, EventArgs e)
        {
            frmListCustomers frmNext = new frmListCustomers(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuSellTickets_Click(object sender, EventArgs e)
        {
            frmSellTickets frmNext = new frmSellTickets(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuCashTicket_Click(object sender, EventArgs e)
        {
            frmCashTicket frmNext = new frmCashTicket(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuRevenueReport_Click(object sender, EventArgs e)
        {
            frmRevenueReport frmNext = new frmRevenueReport(this);
            this.Hide();
            frmNext.Show();
        }
    }
}
