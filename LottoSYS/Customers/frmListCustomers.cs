using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS.Customers
{
    public partial class frmListCustomers : Form
    {
        private FrmMainMenu parent;

        public frmListCustomers()
        {
            InitializeComponent();
        }

        public frmListCustomers(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblSearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void frmListCustomers_Load(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
