﻿using LottoSYS.Sales;
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

            Analysis.updateNumberAnalysis();

            grdNumAnalysis.DataSource = Analysis.getNumberAnalysis().Tables["ss"];

            
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
