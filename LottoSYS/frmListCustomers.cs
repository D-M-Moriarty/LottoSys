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
    public partial class frmListCustomers : Form
    {

        FrmMainMenu parent;

        public frmListCustomers()
        {
            InitializeComponent();
        }

        public frmListCustomers(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }



        private void frmListCustomers_Load(object sender, EventArgs e)
        {

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

    }
}
