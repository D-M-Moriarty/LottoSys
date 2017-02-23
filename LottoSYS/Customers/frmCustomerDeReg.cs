using LottoSYS.Customers;
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

        private int custId;

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
            btnSubmit.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grdListing.DataSource = Customer.getCustomer(txtSearchBox.Text).Tables["ss"];

            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.setCustomerId(custId);


            if (rdoDeceased.Checked)
            {
                MessageBox.Show("Please enter dated deceased");

                customer.updateCustomer("Deceased");

                customer.de_regCustomer(custId);

                txtSurname.Text = "";
                txtForename.Text = "";
                txtAddress1.Text = "";
                txtAddress2.Text = "";
                txtTown.Text = "";

            }
            else if (rdoWithdrawn.Checked)
            {
                MessageBox.Show("Please enter dated withdrawn");

                customer.updateCustomer("Withdrawn");

                customer.de_regCustomer(custId);

                txtSurname.Text = "";
                txtForename.Text = "";
                txtAddress1.Text = "";
                txtAddress2.Text = "";
                txtTown.Text = "";
            }
            else
            {
                MessageBox.Show("Please select a radio button!!");
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

        private void grpDeReg_Enter(object sender, EventArgs e)
        {

        }

        private void grdListing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdListing.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = this.grdListing.Rows[e.RowIndex];

                custId = Convert.ToInt32(row.Cells[0].Value);

                txtSurname.Text = row.Cells[3].Value.ToString();

                txtForename.Text = row.Cells[2].Value.ToString();

                txtAddress1.Text = row.Cells[6].Value.ToString();

                txtAddress2.Text = row.Cells[7].Value.ToString();

                txtTown.Text = row.Cells[8].Value.ToString();


            }
        }
    }
}
