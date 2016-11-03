using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS.Prizes
{
    public partial class frmPayPrize : Form
    {
        FrmMainMenu parent;

        public frmPayPrize()
        {
            InitializeComponent();
        }

        public frmPayPrize(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmPayPrize_Load(object sender, EventArgs e)
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
