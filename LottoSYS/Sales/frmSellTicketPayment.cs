using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS.Sales
{
    public partial class frmSellTicketPayment : Form
    {
       
        private frmSellTickets parent;

        public frmSellTicketPayment()
        {
            InitializeComponent();
        }

        public frmSellTicketPayment(frmSellTickets Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void SellTicketPaymentForm_Load(object sender, EventArgs e)
        {
            grpBankDetails.Visible = false;
            grpCardDetails.Visible = false;

            txtValue.Text = "€" + string.Format("{0:0.00}", 2.2f * parent.numOfLines);
            txtNoOfLines.Text = "" + parent.numOfLines;

         
            
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void rdoLodged_CheckedChanged(object sender, EventArgs e)
        {
            grpBankDetails.Visible = true;
        }

        private void rdoForwardAdd_CheckedChanged(object sender, EventArgs e)
        {
            grpBankDetails.Visible = false;
        }

        private void rdoDebitCard_CheckedChanged(object sender, EventArgs e)
        {
            grpCardDetails.Visible = true;
        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            grpCardDetails.Visible = false;
        }

        private void rdoCheque_CheckedChanged(object sender, EventArgs e)
        {
            grpCardDetails.Visible = false;
        }
    }
}
