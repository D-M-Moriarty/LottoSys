﻿using LottoSYS.Prizes;
using LottoSYS.Sales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LottoSYS.Prize
{
    public partial class frmCheckTicket : Form
    {
        FrmMainMenu parent;

        PrizeModel prize;

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
            var ticket = Ticket.getTicket();

            var panel = Panels.getPanels();

            var draw = Draw.getDraws();

            //Populate panels
            var panels = panel.DataTableToList<Panels>();
            var draws = draw.DataTableToList<Draw>();

            //Get Draw numbers
            int[] drawNums = new int[6];
            int[] panelNums = new int[6];

            //Check each panel against the draw numbers for winners
            foreach (var pan in panels)
            {
                checkNumbers(pan, draws.First());
                //method()
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

        private void checkNumbers(Panels pan, Draw draw)
        {
            //Check Numbers for winners
            int count = 0;
            int prizeAmount = 0;

            int[] drawNums = new int[6];
            int[] panelNums = new int[6];

            int[] n1 = new int[] { 2, 4, 6, 8 , 7, 1 };
            int[] n2 = new int[] { 2, 4, 6, 8 , 7, 9 };

            drawNums[0] = draw.getNumber1();
            drawNums[1] = draw.getNumber2();
            drawNums[2] = draw.getNumber3();
            drawNums[3] = draw.getNumber4();
            drawNums[4] = draw.getNumber5();
            drawNums[5] = draw.getNumber6();

            panelNums[0] = pan.getNum1();
            panelNums[1] = pan.getNum2();
            panelNums[2] = pan.getNum3();
            panelNums[3] = pan.getNum4();
            panelNums[4] = pan.getNum5();
            panelNums[5] = pan.getNum6();
            

            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if (n1[i] == n2[j])
                        count++;
                }
            }

            if(count > 2)
            {
                if (count == 3)
                {
                    prizeAmount = 50000;

                    MessageBox.Show("you won " + prizeAmount.ToString());
                }
                else if (count == 4)
                {
                    prizeAmount = 100000;

                    MessageBox.Show("you won " + prizeAmount.ToString());
                }
                else if (count == 5)
                {
                    prizeAmount = 500000;

                    MessageBox.Show("you won " + prizeAmount.ToString());
                }
                else if (count == 6)
                {
                    prizeAmount = 1000000;

                    MessageBox.Show("you won " + prizeAmount.ToString());
                }

                prize = new PrizeModel(DateTime.Now.ToString(),
                                           pan.getTicketId(),
                                           pan.getPanelId(),
                                           prizeAmount
                                       );

                prize.regPrize();

            }
            else
            {
                MessageBox.Show("There are no winners this week");
            }

            

        }
    }
}
