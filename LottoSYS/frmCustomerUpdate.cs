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
    public partial class frmCustomerUpdate : Form
    {
        private FrmMainMenu parent;

        public frmCustomerUpdate()
        {
            InitializeComponent();
        }

        public frmCustomerUpdate(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmCustomerUpdate_Load(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
