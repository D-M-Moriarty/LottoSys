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
    public partial class frmListWinTick : Form
    {
        FrmMainMenu parent;

        public frmListWinTick()
        {
            InitializeComponent();
        }

        public frmListWinTick(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmListWinTick_Load(object sender, EventArgs e)
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
