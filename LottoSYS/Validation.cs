using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS.Customers
{
    class Validation
    {




        public static Boolean validateCustomer(ComboBox cboCounty, ComboBox cboNationality,
            ComboBox cboTitle, ComboBox cboCountry, TextBox txtSurname, TextBox txtForename,
            TextBox txtAddress1, TextBox txtAddress2, TextBox txtPPSN, TextBox txtTown, DateTimePicker dtpDOB,
            Label lblSurname, Label lblForename, Label lblAddressLine1, Label lblAddressLine2,
            Label lblPPSN, Label lblTown, Label lblCounty, Label lblCountry, Label lblNationality,
            Label lblTitle, Label lblDOB, TextBox txtPhone, TextBox txtEmail, ComboBox cboGender, Label lblEmail)
        {
            if (txtSurname.Text != ""
            && txtForename.Text != ""
            && txtAddress1.Text != ""
            && txtAddress2.Text != ""
            && txtPPSN.Text != ""
            && txtTown.Text != ""
            && txtEmail.Text != ""
            && cboCounty.Text != ""
            && cboNationality.Text != ""
            && cboTitle.Text != ""
            && cboCountry.Text != "")
            {

                return true;
            }
            else
            {

                return false;
                

            }

        }

        // Checking fields
        public static void textFieldChecker(ComboBox cboCounty, ComboBox cboNationality,
            ComboBox cboTitle, ComboBox cboCountry, TextBox txtSurname, TextBox txtForename,
            TextBox txtAddress1, TextBox txtAddress2, TextBox txtPPSN, TextBox txtTown, DateTimePicker dtpDOB,
            Label lblSurname, Label lblForename, Label lblAddressLine1, Label lblAddressLine2,
            Label lblPPSN, Label lblTown, Label lblCounty, Label lblCountry, Label lblNationality,
            Label lblTitle, Label lblDOB, TextBox txtEmail, Label lblEmail)
        {
            if (txtSurname.Text == "" || !isValidName(txtSurname.ToString()))
            {
                lblSurname.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblSurname.ForeColor = System.Drawing.Color.Black;
            }

            if (txtForename.Text == "" || !isValidName(txtForename.ToString()))
            {
                lblForename.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblForename.ForeColor = System.Drawing.Color.Black;
            }

            if (txtAddress1.Text == "")
            {
                lblAddressLine1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblAddressLine1.ForeColor = System.Drawing.Color.Black;
            }

            if (txtAddress2.Text == "")
            {
                lblAddressLine2.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblAddressLine2.ForeColor = System.Drawing.Color.Black;
            }

            if (!isValidDOB(dtpDOB.Value))
            {
                lblDOB.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblDOB.ForeColor = System.Drawing.Color.Black;
            }

            if (txtPPSN.Text == "")
            {
                lblPPSN.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblPPSN.ForeColor = System.Drawing.Color.Black;
            }

            if (txtTown.Text == "")
            {
                lblTown.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblTown.ForeColor = System.Drawing.Color.Black;
            }

            if (txtEmail.Text == "" && !IsValidEmail(txtEmail.Text))
            {
                lblEmail.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblEmail.ForeColor = System.Drawing.Color.Black;
            }

            if (cboCounty.Text == "")
            {
                lblCounty.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblCounty.ForeColor = System.Drawing.Color.Black;
            }

            if (cboNationality.Text == "")
            {
                lblNationality.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblNationality.ForeColor = System.Drawing.Color.Black;
            }

            if (cboTitle.Text == "")
            {
                lblTitle.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblTitle.ForeColor = System.Drawing.Color.Black;
            }

            if (cboCountry.Text == "")
            {
                lblCountry.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblCountry.ForeColor = System.Drawing.Color.Black;
            }
        }


        // Name validation
        public static bool isValidName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsNumber(name[i]))
                    return false;
            }

            return true;
        }

        public static bool isValidDOB(DateTime DOB)
        {
            if (DateTime.Now.Year - DOB.Year >= 18)
                return true;
            else
                return false;
        }

        public static bool IsValidEmail(string emailaddress)
        {
            try
            {
                System.Net.Mail.MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
