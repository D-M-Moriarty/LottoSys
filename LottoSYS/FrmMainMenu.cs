using LottoSYS.Sales;
using LottoSYS.Finance;
using System;
using System.Windows.Forms;
using LottoSYS.Prizes;

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
            frmSellTicketPayment frmNext = new frmSellTicketPayment(this);
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
            Finance.frmPayPrize frmNext = new Finance.frmPayPrize(this);
            this.Hide();
            frmNext.Show();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuPayPrize_Click(object sender, EventArgs e)
        {
            Prizes.frmPayPrize frmNext = new Prizes.frmPayPrize(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuRunDraw_Click(object sender, EventArgs e)
        {
            frmRunDraw frmNext = new frmRunDraw(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuListUnclaimedPrizes_Click(object sender, EventArgs e)
        {
            frmUnclaimedPrize frmNext = new frmUnclaimedPrize(this);
            this.Hide();
            frmNext.Show();
        }

        private void listWinningTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListWinTick frmNext = new frmListWinTick(this);
            this.Hide();
            frmNext.Show();
        }

        private void customerProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerProfile frmNext = new frmCustomerProfile(this);
            this.Hide();
            frmNext.Show();
        }
    }
}
