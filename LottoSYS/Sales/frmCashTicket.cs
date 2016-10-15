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

        }
    }
}
