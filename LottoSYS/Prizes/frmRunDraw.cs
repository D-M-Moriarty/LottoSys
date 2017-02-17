﻿using System;
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
        private int[] nums;

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

            Draw draw;

            int[] drawNums = Ticket.generateNumbers();

            
            draw = new Draw();

            draw.setDate(DateTime.Now.ToString());
            draw.setNumber1(drawNums[0]);
            draw.setNumber2(drawNums[1]);
            draw.setNumber3(drawNums[2]);
            draw.setNumber4(drawNums[3]);
            draw.setNumber5(drawNums[4]);
            draw.setNumber6(drawNums[5]);

            draw.regDraw();


            //Currently converting the arrays to string
            //Ideally would like to change to 2d array or jagged array


            string str = "";
            string zero = "0";
           
            //might make each ticket a line instead

            
            str += "Draw result: ";

            for (int i = 0; i < drawNums.Length; i++)
            {

                if (i > 0)
                    str += ",";

                if (drawNums[i] < 10)
                {
                    zero += drawNums[i];
                    str += " " + zero;
                    zero = "0";
                }
                else
                {
                    str += " " + drawNums[i];
                }

            }
            
            str += "\n\n";
            
            //MessageBox.Show(str,"Draw Results");
            listBox1.Items.Add(str);
            btnRunDraw.Enabled = false;
        }
    }
}
