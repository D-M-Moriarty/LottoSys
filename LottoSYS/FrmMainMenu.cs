using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
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
    }
}
