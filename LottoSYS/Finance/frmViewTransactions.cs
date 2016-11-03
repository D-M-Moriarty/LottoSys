using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS.Finance
{
    public partial class frmViewTransactions : Form
    {
        FrmMainMenu parent;

        public frmViewTransactions()
        {
            InitializeComponent();
        }

        public frmViewTransactions(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
