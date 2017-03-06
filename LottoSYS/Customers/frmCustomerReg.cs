using System;
using System.Windows.Forms;
using LottoSYS.Sales;
using LottoSYS.Customers;
using System.Data;

namespace LottoSYS
{
    public partial class frmCustomerReg : Form
    {

        FrmMainMenu parent;
        private frmSellTickets frmSellTickets;

        public frmCustomerReg()
        {
            InitializeComponent();
        }

        public frmCustomerReg(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmCustomerReg(frmSellTickets frmSellTickets)
        {
            this.frmSellTickets = frmSellTickets;
        }

        private void mnuExit(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddressLine1_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomerReg_Load(object sender, EventArgs e)
        {
            
            loadTitles();
            loadNationalities();
            loadCounties();
            loadCountries();
            loadGenders();

        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomerReg_Click(object sender, EventArgs e)
        {
            
        }

      //  OracleConnection conn = new OracleConnection(ConnectDB.oradb);

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            //validate data

            Validation.textFieldChecker(cboCounty, cboNationality,
                                cboTitle, cboCountry, txtSurname, txtForename,
                                txtAddress1, txtAddress2, txtPPSN, txtTown, dtpDOB,
                                lblSurname, lblForename, lblAddressLine1, lblAddressLine2,
                                lblPPSN, lblTown, lblCounty, lblCountry, lblNationality,
                                lblTitle, lblDOB, txtEmail, lblEmail);

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

                    MessageBox.Show("Data has been registered");

                    Customer customer = new Customer();

                    customer.setCustomerId(Convert.ToInt32(Customer.nextCustomerId().ToString("00000")));
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
                    customer.setStatus("ACTIVE");
                    customer.setRegDate(DateTime.Now);

                    customer.regCustomer();

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

                    if(!Validation.isValidEmail(txtEmail.ToString()))
                        error += "The customers email is invalid\n\n";


                    MessageBox.Show(error);
                }
                
            }
            else
            {
                MessageBox.Show("Please fill out all the required highlighted fields");
                
            }


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
    }
}