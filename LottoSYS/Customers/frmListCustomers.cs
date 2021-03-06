﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS.Customers
{
    public partial class frmListCustomers : Form
    {
        private FrmMainMenu parent;
        // Get the currently selected item in the ListBox.
        String curItem;


        // Find the string in ListBox2.
        int index;

        public frmListCustomers()
        {
            InitializeComponent();
        }

        public frmListCustomers(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void lblSearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grdListing.DataSource = Customer.getCustomerList(txtSearchBox.Text.ToUpper()).Tables["ss"];

            //btnSearch.Enabled = false;
        }


        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void frmListCustomers_Load(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdoSurname_CheckedChanged(object sender, EventArgs e)
        {
            grdListing.DataSource = Customer.getCustomerList(txtSearchBox.Text).Tables["ss"];
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdoWinners_CheckedChanged(object sender, EventArgs e)
        {
            grdListing.DataSource = Customer.getWinningCustomerList(txtSearchBox.Text).Tables["ss"];
        }

        private void rdoWithdrawn_CheckedChanged(object sender, EventArgs e)
        {
            grdListing.DataSource = Customer.getWithdrawnCustomerList(txtSearchBox.Text).Tables["ss"];
        }

        private void grpSort_Click(object sender, EventArgs e)
        {
            ClsPrint _ClsPrint = new ClsPrint(grdListing, "Customer Listing");
            _ClsPrint.printPreview();
        }

        private void grdListing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        
}
