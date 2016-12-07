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
            frmCustomerProfile frmNext = new frmCustomerProfile(this);
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
            Finance.frmSalesAnalysis frmNext = new Finance.frmSalesAnalysis(this);
            this.Hide();
            frmNext.Show();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuPayPrize_Click(object sender, EventArgs e)
        {
            Prizes.frmCheckTicket frmNext = new Prizes.frmCheckTicket(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuRunDraw_Click(object sender, EventArgs e)
        {
            frmRunDraw frmNext = new frmRunDraw(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuNumberAnalysis_Click(object sender, EventArgs e)
        {
            frmNumberAnalysis frmNext = new frmNumberAnalysis(this);
            this.Hide();
            frmNext.Show();
        }

        private void listWinningTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckTicket frmNext = new frmCheckTicket(this);
            this.Hide();
            frmNext.Show();
        }

       
        

        private void salesAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesAnalysis frmNext = new frmSalesAnalysis(this);
            this.Hide();
            frmNext.Show();
        }

        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers.frmListCustomers frmNext = new Customers.frmListCustomers(this);
            this.Hide();
            frmNext.Show();
        }
    }
}
