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
    public partial class frmUnclaimedPrize : Form
    {
        FrmMainMenu parent;

        public frmUnclaimedPrize()
        {
            InitializeComponent();
        }

        public frmUnclaimedPrize(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmUnclaimedPrize_Load(object sender, EventArgs e)
        {

        }
    }
}
