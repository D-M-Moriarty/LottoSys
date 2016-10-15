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
    public partial class frmRunDraw : Form
    {
        FrmMainMenu parent;

        public frmRunDraw()
        {
            InitializeComponent();
        }

        public frmRunDraw(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmRunDraw_Load(object sender, EventArgs e)
        {

        }
    }
}
