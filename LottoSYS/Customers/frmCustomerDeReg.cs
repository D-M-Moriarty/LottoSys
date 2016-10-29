﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS
{
    public partial class frmCustomerDeReg : Form
    {
        private FrmMainMenu parent;

        public frmCustomerDeReg(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCustomerDeReg_Load(object sender, EventArgs e)
        {
            grpDeReg.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpDeReg.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(chkWithdrawn.Checked && chkDeceased.Checked)
            {
                MessageBox.Show("Only one check box may selected!!!");
            }
            else if(chkDeceased.Checked)
            {
                MessageBox.Show("Please enter dated deceased");
            }
            else if (chkWithdrawn.Checked)
            {
                MessageBox.Show("Please enter dated withdrawn");
            }
            else
            {
                MessageBox.Show("Please select a checkbox!!");
            }
        }
    }
}
