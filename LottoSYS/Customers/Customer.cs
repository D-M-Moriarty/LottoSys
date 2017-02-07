using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LottoSYS.Customers
{
    class Customer
    {

        private int customerId;
        private string title;
        private string surname;
        private string forename;
        private DateTime DOB;
        private string PPSN;
        private string addressLine1;
        private string addressLine2;
        private string town;
        private string county;
        private string country;
        private string countryResidence;
        private string nationality;
        private string gender;
        private string phone;
        private string email;




        public Customer()
        {

        }

       /* public static DataSet getCustomer(DataSet DS)
        {

            //OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Customer";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "res");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getCustomer(DataSet DS, string description)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT Stock_No, Description FROM STOCK WHERE Description LIKE '" + description + "%'";


            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            try
            {
                da.Fill(DS, "res");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //close database
            conn.Close();

            return DS;
        }

        public static int nextCustomerId()
        {
            // variable to hold value to be returned
            int intNextStockNo;

            // connect to the Db
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            // Define SQL query to get MAX Stock_No used
            String strSQl = "SELECT MAX(stock_No) FROM Stock";

            OracleCommand cmd = new OracleCommand(strSQl, myConn);

            // Execute the query
            OracleDataReader dr = cmd.ExecuteReader();

            // read the first (only) value returned by query
            // If the first stockno, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                intNextStockNo = 1;
            }
            else
            {
                intNextStockNo = Convert.ToInt16(dr.GetValue(0)) + 1;
            }

            // Close DB connection
            myConn.Close();

            // Return next StockNo
            return intNextStockNo;



        }

        public void regCustomer()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            // Define SQL query to INSERT stock record
            String strSQl = "INSERT INTO Stock VALUES(" + this.stock_no.ToString() +
                ",'" + this.description.ToUpper() + "'," + this.cost_price + "," +
                this.sale_price + "," + this.qty + ",'" + this.status + "')";

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

        public void updateCustomer()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            // Define SQL query to INSERT stock record
            String strSQl = "UPDATE STOCK SET DESCRIPTION = '" + this.description + "' WHERE STOCK_NO = " + this.stock_no;

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();





            // Close DB connection
            myConn.Close();
        }*/

        public static void validateCustomer(ComboBox cboCounty, ComboBox cboNationality,
            ComboBox cboTitle, ComboBox cboCountry, TextBox txtSurname, TextBox txtForename,
            TextBox txtAddress1, TextBox txtAddress2, TextBox txtPPSN, TextBox txtTown, DateTimePicker dtpDOB, 
            Label lblSurname, Label lblForename, Label lblAddressLine1, Label lblAddressLine2, 
            Label lblPPSN, Label lblTown, Label lblCounty, Label lblCountry, Label lblNationality,
            Label lblTitle)
        {
            if (txtSurname.Text != ""
            && txtForename.Text != ""
            && txtAddress1.Text != ""
            && txtAddress2.Text != ""
            && txtPPSN.Text != ""
            && txtTown.Text != ""
            && cboCounty.SelectedIndex != -1
            && cboNationality.SelectedIndex != -1
            && cboTitle.SelectedIndex != -1
            && cboCountry.SelectedIndex != -1)
            {

                if (isValidName(txtSurname.ToString()) && isValidName(txtForename.ToString()) &&
                    isValidDOB(dtpDOB.Value))
                {
                    MessageBox.Show("Data has been registered");
                }
                else
                {
                    string error = "";

                    if (!isValidName(txtSurname.ToString()))
                        error += "The surname is invalid\n\n";
                    else
                        lblSurname.ForeColor = System.Drawing.Color.Black;

                    if (!isValidName(txtForename.ToString()))
                        error += "The forename is invalid\n\n";
                    else
                        lblForename.ForeColor = System.Drawing.Color.Black;

                    if (!isValidDOB(dtpDOB.Value))
                        error += "The customer is under 18\n\n";


                    MessageBox.Show(error);
                }


            }
            else
            {
                MessageBox.Show("Please fill out all the required highlighted fields");

                if (txtSurname.Text == "")
                {
                    lblSurname.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblSurname.ForeColor = System.Drawing.Color.Black;
                }

                if (txtForename.Text == "")
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

        }


        // Name validation
        private bool isValidName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsNumber(name[i]))
                    return false;
            }

            return true;
        }

        private bool isValidDOB(DateTime DOB)
        {
            if (DateTime.Now.Year - DOB.Year >= 18)
                return true;
            else
                return false;
        }


        public void setCustomerId(int customerId)
        {
            this.customerId = customerId;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setForename(string forename)
        {
            this.forename = forename;
        }

        public void setDOB(DateTime DOB)
        {
            this.DOB = DOB;
        }

        public void setPPSN(string PPSN)
        {
            this.PPSN = PPSN;
        }

        public void setAddressLine1(string addressLine1)
        {
            this.addressLine1 = addressLine1;
        }

        public void setAddressLine2(string addressLine2)
        {
            this.addressLine2 = addressLine2;
        }

        public void setTown(string town)
        {
            this.town = town;
        }

        public void setCounty(string county)
        {
            this.county = county;
        }


        public void setCountry(string country)
        {
            this.country = country;
        }
        public void setCountryResidence(string countryResidence)
        {
            this.countryResidence = countryResidence;
        }

        public void setNationality(string nationality)
        {
            this.nationality = nationality;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

    }
}
