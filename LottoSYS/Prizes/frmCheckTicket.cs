using LottoSYS.Sales;
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
            DataSet ticket = Ticket.getTicket(9);

            DataSet panel = Panels.getPanel(9, 1);

            DataSet draw = Draw.getDraw();

            int[] drawNums = new int[6];
            int[] panelNums = new int[6];

            DataRow dr = draw.Tables[0].Rows[0];

            DataRow pa = panel.Tables[0].Rows[0];

            string pNums = "";
            string dNums = "";

            for (int i = 0; i < panel.Tables[0].Rows.Count - 2; i++)
            {
                panelNums[i] = Convert.ToInt32(panel.Tables[i].Rows[i]["Number" + (i + 1)]);
                pNums += panelNums[i + 2];
            }
                

            for (int i = 0; i < draw.Tables[0].Rows.Count - 1; i++)
            {
                drawNums[i] = Convert.ToInt32(draw.Tables[i].Rows[i]["Number" + (i + 1)]);
                dNums += panelNums[i + 1];
            }

            for (int i = 0; i < 6; i++)
            {
                MessageBox.Show(dNums[i].ToString());
            }
                






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
