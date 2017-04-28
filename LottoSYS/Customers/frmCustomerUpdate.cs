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
    public partial class frmCustomerUpdate : Form
    {
        private FrmMainMenu parent;
        private string surname;
        private string forename;
        private string add1;
        private string add2;
        private string town;
        private string county;
        private string residence;
        private string phone;
        private string email;
        private string title;
        private string PPSN;
        private string nationality;
        private string gender;

        private int custId;

        public frmCustomerUpdate(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }



        private void frmCustomerUpdate_Load(object sender, EventArgs e)
        {
            // loading the dropdowns
            loadTitles();
            loadNationalities();
            loadCounties();
            loadCountries();
            loadGenders();

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // displaying the customers on the datagrid
            grdUpdate.DataSource = Customer.getCustomer(txtSearchBox.Text.ToUpper()).Tables["ss"];
        }

        private void tbnSubmit_Click(object sender, EventArgs e)
        {

            lblEmail.ForeColor = System.Drawing.Color.Black;
            lblPPSN.ForeColor = System.Drawing.Color.Black;

            Validation.textFieldChecker(cboCounty, cboNationality,
                                cboTitle, cboCountry, txtSurname, txtForename,
                                txtAddress1, txtAddress2, txtPPSN, txtTown, dtpDOB,
                                lblSurname, lblForename, lblAddressLine1, lblAddressLine2,
                                lblPPSN, lblTown, lblCounty, lblCountry, lblNationality,
                                lblTitle, lblDOB, txtEmail, lblEmail);
            //validate data
            if (Validation.validateCustomer(cboCounty, cboNationality,
             cboTitle, cboCountry, txtSurname, txtForename,
             txtAddress1, txtAddress2, txtPPSN, txtTown, dtpDOB,
             lblSurname, lblForename, lblAddressLine1, lblAddressLine2,
             lblPPSN, lblTown, lblCounty, lblCountry, lblNationality,
             lblTitle, lblDOB, txtPhone, txtEmail, cboGender, lblEmail))
            {

                lblEmail.ForeColor = System.Drawing.Color.Black;
                lblPPSN.ForeColor = System.Drawing.Color.Black;

                if (Validation.isValidName(txtSurname.ToString()) && Validation.isValidName(txtForename.ToString()) &&
                    Validation.isValidDOB(dtpDOB.Value))
                {
                    // if both fields are unchanged
                    if (PPSN == txtPPSN.Text && email == txtEmail.Text)
                    {
                        updateDetails();
                    }
                    // if both have been changed
                    else if (PPSN != txtPPSN.Text && email != txtEmail.Text)
                    {
                        if (Validation.IsValidEmail(txtEmail.Text) && Validation.isValidPPSN(txtPPSN.Text))
                        {
                            updateDetails();
                        }
                        else
                        {
                            string error = "";

                            lblEmail.ForeColor = System.Drawing.Color.Red;
                            lblPPSN.ForeColor = System.Drawing.Color.Red;

                            if (!Validation.IsValidEmail(txtEmail.Text))
                                error += "The customers email is invalid\n\n";

                            if (!Validation.isValidPPSN(txtPPSN.Text))
                                error += "The customers PPSN is invalidn\n";


                            MessageBox.Show(error);
                        }
                    }
                    // if pps has been changed
                    else if (PPSN != txtPPSN.Text)
                    {
                        if (Validation.isValidPPSN(txtPPSN.Text))
                        {
                            updateDetails();
                        }
                        else
                        {
                            string error = "";

                            if (!Validation.isValidPPSN(txtPPSN.Text))
                                error += "The customers PPSN is invalidn\n";

                            lblPPSN.ForeColor = System.Drawing.Color.Red;


                            MessageBox.Show(error);
                        }
                    }
                    // if email has been changed
                    else if (email != txtEmail.Text)
                    {
                        if (Validation.IsValidEmail(txtEmail.Text))
                        {
                            updateDetails();
                        }
                        else
                        {
                            string error = "";

                            if (!Validation.IsValidEmail(txtEmail.Text))
                                error += "The customers email is invalid\n\n";

                            lblEmail.ForeColor = System.Drawing.Color.Red;




                            MessageBox.Show(error);
                        }


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

                        MessageBox.Show(error);
                    }

                }
                else
                {
                    MessageBox.Show("Please fill out all the required highlighted fields");


                }

            }
        }

        private void grpUpdateBox_Enter(object sender, EventArgs e)
        {

        }

        private void grdUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.grdUpdate.Rows[e.RowIndex];

                custId = Convert.ToInt32(row.Cells[0].Value);

                cboTitle.SelectedValue = row.Cells[1].Value.ToString().TrimEnd();

                txtSurname.Text = row.Cells[2].Value.ToString().TrimEnd();

                txtForename.Text = row.Cells[3].Value.ToString().TrimEnd();

                dtpDOB.Text = row.Cells[4].Value.ToString().TrimEnd();

                txtPPSN.Text = row.Cells[5].Value.ToString().TrimEnd();

                PPSN = txtPPSN.Text;

                txtAddress1.Text = row.Cells[6].Value.ToString().TrimEnd();

                txtAddress2.Text = row.Cells[7].Value.ToString().TrimEnd();

                txtTown.Text = row.Cells[8].Value.ToString().TrimEnd();

                cboCounty.SelectedValue = row.Cells[9].Value.ToString().TrimEnd();

                cboCountry.SelectedValue = row.Cells[10].Value.ToString().TrimEnd();

                cboNationality.SelectedValue = row.Cells[11].Value.ToString().TrimEnd();

                cboGender.SelectedValue = row.Cells[12].Value.ToString().TrimEnd();

                txtPhone.Text = row.Cells[13].Value.ToString().TrimEnd();

                txtEmail.Text = row.Cells[14].Value.ToString().TrimEnd();

                email = txtEmail.Text;
            }
            catch
            {

            }
        }

        // method to update the customers details
        public void updateDetails()
        {
            MessageBox.Show("Data has been updated");

            Customer customer = new Customer();

            customer.setCustomerId(custId);
            customer.setTitle(cboTitle.Text.ToUpper());
            customer.setSurname(txtSurname.Text.ToUpper());
            customer.setForename(txtForename.Text.ToUpper());
            customer.setDOB(dtpDOB.Text.ToUpper());
            customer.setPPSN(txtPPSN.Text.ToUpper());
            customer.setAddressLine1(txtAddress1.Text.ToUpper());
            customer.setAddressLine2(txtAddress2.Text.ToUpper());
            customer.setTown(txtTown.Text.ToUpper());
            customer.setCounty(cboCounty.Text.ToUpper());
            customer.setCountry(cboCountry.Text.ToUpper());
            customer.setNationality(cboNationality.Text.ToUpper());
            customer.setGender(cboGender.Text.ToUpper());
            customer.setPhone(txtPhone.Text.ToUpper());
            customer.setEmail(txtEmail.Text.ToUpper());


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
            dtpDOB.Value = DateTime.Now;

            lblEmail.ForeColor = System.Drawing.Color.Black;
            lblPPSN.ForeColor = System.Drawing.Color.Black;

            grdUpdate.DataSource = Customer.getCustomer(txtSearchBox.Text.ToUpper()).Tables["ss"];
        }

        private void loadTitles()
        {
            cboTitle.ValueMember = "TITLES";
            cboTitle.DataSource = Customer.getTitles().Tables["ss"];
            cboTitle.SelectedIndex = -1;
            cboTitle.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void loadNationalities()
        {

            cboNationality.ValueMember = "Nationalities";
            cboNationality.DataSource = Customer.getNationalities().Tables["ss"];
            cboNationality.SelectedIndex = -1;
            cboNationality.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void loadCounties()
        {
            cboCounty.ValueMember = "Counties";
            cboCounty.DataSource = Customer.getCounties().Tables["ss"];
            cboCounty.SelectedIndex = -1;
            cboCounty.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void loadCountries()
        {
            cboCountry.ValueMember = "Countries";
            cboCountry.DataSource = Customer.getCountries().Tables["ss"];
            cboCountry.SelectedIndex = -1;
            cboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void loadGenders()
        {
            cboGender.ValueMember = "Genders";
            cboGender.DataSource = Customer.getGenders().Tables["ss"];
            cboGender.SelectedIndex = -1;
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void grdUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
