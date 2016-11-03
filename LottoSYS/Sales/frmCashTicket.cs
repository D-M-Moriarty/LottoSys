using System;
using System.Windows.Forms;

namespace LottoSYS.Sales
{
    public partial class frmCashTicket : Form
    {
        FrmMainMenu parent;

        public frmCashTicket()
        {
            InitializeComponent();
        }

        public frmCashTicket(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmCashTicket_Load(object sender, EventArgs e)
        {
            lblSerialNumber.Visible = false;
            txtSerialNumber.Visible = false;
            btnValidate.Visible = false;
            grpPayment.Visible = false;
            txtAmount.Text = "€75";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblSerialNumber.Visible = true;
            txtSerialNumber.Visible = true;
            btnValidate.Visible = true;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            grpPayment.Visible = true;
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Youre payment has been processed\n\nReceipt here");
        }
    }
}
