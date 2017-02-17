using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS.Prize
{
    public partial class frmNumberAnalysis : Form
    {
        FrmMainMenu parent;

        public frmNumberAnalysis()
        {
            InitializeComponent();
        }

        public frmNumberAnalysis(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmUnclaimedPrize_Load(object sender, EventArgs e)
        {
            lstMost.Items.Add("No 1: 32");
            lstMost.Items.Add("No 2: 11");
            lstMost.Items.Add("No 3: 21");
            lstMost.Items.Add("No 4: 41");
            lstMost.Items.Add("No 5: 09");
            lstMost.Items.Add("No 6: 01");
            lstMost.Items.Add("No 7: 46");
            lstMost.Items.Add("No 5: 09");
            lstMost.Items.Add("No 6: 01");
            lstMost.Items.Add("No 7: 46");

            lstLeast.Items.Add("No 1: 05");
            lstLeast.Items.Add("No 2: 02");
            lstLeast.Items.Add("No 3: 27");
            lstLeast.Items.Add("No 4: 10");
            lstLeast.Items.Add("No 5: 17");
            lstLeast.Items.Add("No 6: 47");
            lstLeast.Items.Add("No 7: 30");
            lstLeast.Items.Add("No 5: 17");
            lstLeast.Items.Add("No 6: 47");
            lstLeast.Items.Add("No 7: 30");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
