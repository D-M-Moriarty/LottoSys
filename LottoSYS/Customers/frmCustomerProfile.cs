using LottoSYS.Customers;
using LottoSYS.Sales;
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
    public partial class frmCustomerProfile : Form
    {

        FrmMainMenu parent;
        String profile;
        String curItem;
        private int custId;

        public frmCustomerProfile()
        {
            InitializeComponent();
        }

        public frmCustomerProfile(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }



        private void frmListCustomers_Load(object sender, EventArgs e)
        {
            grpDetails.Visible = false;
            
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if(profile != null)
            {
                MessageBox.Show(profile);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grdListing.DataSource = Customer.getCustomer(txtSearchBox.Text.ToUpper()).Tables["ss"];
        }

        private void grdListing_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.grdListing.Rows[e.RowIndex];

                this.custId = Convert.ToInt32(row.Cells[0].Value);

                lblName.Text = "Name: " + row.Cells[2].Value.ToString().TrimEnd() + " " + row.Cells[3].Value.ToString();

                lblAddress.Text = "Address: " + row.Cells[6].Value.ToString();

                lblTown.Text = "Town: " + row.Cells[8].Value.ToString();

                lblCounty.Text = "County: " + row.Cells[9].Value.ToString();

                lblRegDate.Text = "Registration Date: " + row.Cells[17].Value.ToString();

                lblBalance.Text = "Balance: €" + row.Cells[15].Value.ToString();

                grdCustomerTickets.DataSource = Panels.getPanel(custId).Tables["ss"];

                grpDetails.Visible = true;
            }
            catch
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grdCustomerTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
