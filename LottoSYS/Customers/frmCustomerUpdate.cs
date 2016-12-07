using System;
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
    public partial class frmCustomerUpdate : Form
    { 
        private FrmMainMenu parent;
        private String surname;
        private String forename;
        private String add1;
        private String add2;
        private String town;
        private String county;
        private String residence;
        private String phone;
        private String email;


        public frmCustomerUpdate(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

       

        private void frmCustomerUpdate_Load(object sender, EventArgs e)
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

      

        private void lblForename_Click(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if non empty Resultset is there first
            lstUpdate.Items.Add("Jim Miller, Examlpe street, Killorglin");
            lstUpdate.Items.Add("Mary Shea, Examlpe street, Tralee");
            lstUpdate.Items.Add("Tim Clifford, Examlpe street, Millstreet");
            lstUpdate.Items.Add("Jim Miller, Examlpe street, Killorglin");
        }

        private void mnuUpdateCustomer_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void cboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCounty_Click(object sender, EventArgs e)
        {

        }

        private void txtTown_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTown_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddressLine2_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddressLine1_Click(object sender, EventArgs e)
        {

        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lstUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            String curItem = lstUpdate.SelectedItem.ToString();



            // Find the string in ListBox2.
            int index = lstUpdate.FindString(curItem);

            if (index == 0)
            {
                surname = "Miller";
                forename = "Jim";
                add1 = "Example Street";
                add2 = "";
                town = "Killorglin";
                county = "Kerry";
                residence = "Ireland";
                phone = "89689679";
                email = "dkgfsuio|@sf.com";

                

            }
            else if (index == 1)
            {
                surname = "Mary";
                forename = "Shea";
                add1 = "Example Street";
                add2 = "";
                town = "Tralee";
                county = "Kerry";
                residence = "Ireland";
                phone = "89689679";
                email = "dkgfsuio|@sf.com";
            }
            else
            {
                surname = "Tim";
                forename = "Clifford";
                add1 = "Example Street";
                add2 = "";
                town = "Millstreet";
                county = "Cork";
                residence = "Ireland";
                phone = "89689679";
                email = "dkgfsuio|@sf.com";
            }

            txtSurname.Text = surname;
            txtForename.Text = forename;
            txtAddress2.Text = add2;
            txtTown.Text = town;
            txtPhone.Text = phone;
            txtEmail.Text = email;
            txtAddress1.Text = add1;
            cboCounty.Text = county;
            cboCountry.Text = residence;

            


            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            //if (index == -1)
            //MessageBox.Show("Item is not available in ListBox2");
            ///else
            // {
            // listBox1.SetSelected(index, true);
            //}
        }
    }
}
