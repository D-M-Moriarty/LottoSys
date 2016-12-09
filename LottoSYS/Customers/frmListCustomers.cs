using System;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void lblSearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if non empty Resultset is there first
            lstList.Items.Add("Jim Miller, Examlpe street, Killorglin");
            lstList.Items.Add("Mary Shea, Examlpe street, Tralee");
            lstList.Items.Add("Tim Clifford, Examlpe street, Millstreet");
            lstList.Items.Add("Jim Miller, Examlpe street, Killorglin");

            btnSearch.Enabled = false;
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

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            curItem = lstList.SelectedItem.ToString();



            // Find the string in ListBox2.
            index = lstList.FindString(curItem);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
