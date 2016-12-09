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
    public partial class frmCustomerDeReg : Form
    {
        private FrmMainMenu parent;
        private String surname;
        private String forename;
        private String add1;
        private String add2;
        private String town;

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
            txtAddress1.ReadOnly = true;
            txtAddress1.BackColor = Color.White;
            txtAddress2.ReadOnly = true;
            txtAddress2.BackColor = Color.White;
            txtForename.ReadOnly = true;
            txtForename.BackColor = Color.White;
            txtSurname.ReadOnly = true;
            txtSurname.BackColor = Color.White;
            txtTown.ReadOnly = true;
            txtTown.BackColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if non empty Resultset is there first
            lstdereg.Items.Add("Jim Miller, Examlpe street, Killorglin");
            lstdereg.Items.Add("Mary Shea, Examlpe street, Tralee");
            lstdereg.Items.Add("Tim Clifford, Examlpe street, Millstreet");
            lstdereg.Items.Add("Jim Miller, Examlpe street, Killorglin");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtForename.Text != "")
            {
                if (rdoWithdrawn.Checked && rdoDeceased.Checked)
                {
                    MessageBox.Show("Only one check box may selected!!!");
                }
                else if (rdoDeceased.Checked)
                {
                    MessageBox.Show("Please enter dated deceased");

                }
                else if (rdoWithdrawn.Checked)
                {
                    MessageBox.Show("Please enter dated withdrawn");
                }
                else
                {
                    MessageBox.Show("Please select a radio button!!");
                }

                txtSurname.Text = "";
                txtForename.Text = "";
                txtAddress1.Text = "";
                txtAddress2.Text = "";
                txtTown.Text = "";

            }


        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void lblDeReg_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstdereg_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            String curItem = lstdereg.SelectedItem.ToString();



            // Find the string in ListBox2.
            int index = lstdereg.FindString(curItem);

            if (index == 0)
            {
                surname = "Miller";
                forename = "Jim";
                add1 = "Example Street";
                add2 = "";
                town = "Killorglin";



            }
            else if (index == 1)
            {
                surname = "Mary";
                forename = "Shea";
                add1 = "Example Street";
                add2 = "";
                town = "Tralee";
            }
            else
            {
                surname = "Tim";
                forename = "Clifford";
                add1 = "Example Street";
                add2 = "";
                town = "Millstreet";
            }

            txtSurname.Text = surname;
            txtForename.Text = forename;
            txtAddress2.Text = add2;
            txtTown.Text = town;
            txtAddress1.Text = add1;
        }

        private void grpDeReg_Enter(object sender, EventArgs e)
        {

        }
    }
}
