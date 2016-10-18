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

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRunDraw_Click(object sender, EventArgs e)
        {
            string str = "";
            int Min = 1;
            int Max = 47;
            Random randNum = new Random();


            int[] nums = new int[6];
            bool[] alreadyPicked = new bool[47];
            int num;

            for (int j = 0; j < 4; j++)
            {

                for (int i = 0; i < nums.Length; i++)
                {
                    num = randNum.Next(Min, Max);

                    while (alreadyPicked[num])
                        num = randNum.Next(Min, Max);

                    alreadyPicked[num] = true;
                    nums[i] = num;
                    str += " " + nums[i];
                }

                alreadyPicked = new bool[47];

                str += "\n";
            }

            

            

            MessageBox.Show(str);
        }
    }
}
