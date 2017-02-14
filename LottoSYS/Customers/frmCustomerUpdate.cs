﻿using LottoSYS.Customers;
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
        private String title;
        private String PPSN;
        private String nationality;
        private String gender;

        private int custId;

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
            grdUpdate.DataSource = Customer.getCustomer(txtSearchBox.Text).Tables["ss"];
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

        private void tbnSubmit_Click(object sender, EventArgs e)
        {
            //validate data
            if (Validation.validateCustomer(cboCounty, cboNationality,
             cboTitle, cboCountry, txtSurname, txtForename,
             txtAddress1, txtAddress2, txtPPSN, txtTown, dtpDOB,
             lblSurname, lblForename, lblAddressLine1, lblAddressLine2,
             lblPPSN, lblTown, lblCounty, lblCountry, lblNationality,
             lblTitle, lblDOB, txtPhone, txtEmail, cboGender, lblEmail))
            {
                if (Validation.isValidName(txtSurname.ToString()) && Validation.isValidName(txtForename.ToString()) &&
                    Validation.isValidDOB(dtpDOB.Value))
                {
                    MessageBox.Show("Data has been updated");

                    Customer customer = new Customer();

                    customer.setCustomerId(custId);
                    customer.setTitle(cboTitle.Text);
                    customer.setSurname(txtSurname.Text);
                    customer.setForename(txtForename.Text);
                    customer.setDOB(dtpDOB.Text);
                    customer.setPPSN(txtPPSN.Text);
                    customer.setAddressLine1(txtAddress1.Text);
                    customer.setAddressLine2(txtAddress2.Text);
                    customer.setTown(txtTown.Text);
                    customer.setCounty(cboCounty.Text);
                    customer.setCountry(cboCountry.Text);
                    customer.setNationality(cboNationality.Text);
                    customer.setGender(cboGender.Text);
                    customer.setPhone(txtPhone.Text);
                    customer.setEmail(txtEmail.Text);

                    customer.updateCustomer();

                    txtSurname.Text = "";
                    txtForename.Text = "";
                    txtAddress2.Text = "";
                    txtTown.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    txtAddress1.Text = "";
                    cboCounty.Text = "";
                    cboCountry.Text = "";
                    txtPPSN.Text = "";
                    cboCountry.SelectedIndex = -1;
                    cboCounty.SelectedIndex = -1;
                    cboGender.SelectedIndex = -1;
                    cboNationality.SelectedIndex = -1;
                    cboTitle.SelectedIndex = -1;

                }
                else
                {
                    string error = "";

                    if (!Validation.isValidName(txtSurname.ToString()))
                        error += "The surname is invalid\n\n";
                    else
                        lblSurname.ForeColor = System.Drawing.Color.Black;

                    if (!Validation.isValidName(txtForename.ToString()))
                        error += "The forename is invalid\n\n";
                    else
                        lblForename.ForeColor = System.Drawing.Color.Black;

                    if (!Validation.isValidDOB(dtpDOB.Value))
                        error += "The customer is under 18\n\n";

                    Validation.textFieldChecker(cboCounty, cboNationality,
                                cboTitle, cboCountry, txtSurname, txtForename,
                                txtAddress1, txtAddress2, txtPPSN, txtTown, dtpDOB,
                                lblSurname, lblForename, lblAddressLine1, lblAddressLine2,
                                lblPPSN, lblTown, lblCounty, lblCountry, lblNationality,
                                lblTitle, lblDOB, txtEmail, lblEmail);


                    MessageBox.Show(error);
                }

            }
            else
            {
                MessageBox.Show("Please fill out all the required highlighted fields");

                Validation.textFieldChecker(cboCounty, cboNationality,
                                cboTitle, cboCountry, txtSurname, txtForename,
                                txtAddress1, txtAddress2, txtPPSN, txtTown, dtpDOB,
                                lblSurname, lblForename, lblAddressLine1, lblAddressLine2,
                                lblPPSN, lblTown, lblCounty, lblCountry, lblNationality,
                                lblTitle, lblDOB, txtEmail, lblEmail);
            }

        }

        private void grpUpdateBox_Enter(object sender, EventArgs e)
        {

        }

        private void grdUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdUpdate.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = this.grdUpdate.Rows[e.RowIndex];

                custId = Convert.ToInt32(row.Cells[0].Value);

                cboTitle.Text = row.Cells[1].Value.ToString();

                txtSurname.Text = row.Cells[2].Value.ToString();

                txtForename.Text = row.Cells[3].Value.ToString();

                dtpDOB.Text = row.Cells[4].Value.ToString();

                txtPPSN.Text = row.Cells[5].Value.ToString();

                txtAddress1.Text = row.Cells[6].Value.ToString();
                
                txtAddress2.Text = row.Cells[7].Value.ToString();

                txtTown.Text = row.Cells[8].Value.ToString();

                cboCounty.Text = row.Cells[9].Value.ToString();

                cboCountry.Text = row.Cells[10].Value.ToString();

                cboNationality.Text = row.Cells[11].Value.ToString();

                cboGender.Text = row.Cells[12].Value.ToString();

                txtPhone.Text = row.Cells[13].Value.ToString();

                txtEmail.Text = row.Cells[14].Value.ToString();


            }
        }
    }
}
