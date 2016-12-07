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
    public partial class frmCheckTicket : Form
    {
        FrmMainMenu parent;

        public frmCheckTicket()
        {
            InitializeComponent();
        }

        public frmCheckTicket(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmPayPrize_Load(object sender, EventArgs e)
        {
            lstWinning.Items.Add("Name,             TicketId    Value\n");
            lstWinning.Items.Add("Tom O shea,    5432,       €4000\n");
            lstWinning.Items.Add("Tom O shea,    5432,       €4000\n");
            lstWinning.Items.Add("Tom O shea,    5432,       €4000\n");
            lstWinning.Items.Add("Tom O shea,    5432,       €4000\n");
            lstWinning.Items.Add("Tom O shea,    5432,       €4000\n");
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
