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
        private string DOB;
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
        private string status;
        private DateTime regDate;
        private double balance;




        public Customer()
        {

        }

        public static DataSet getCustomer()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Customer";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getWinningCustomer()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT DISTINCT CUSTOMER.* " +
                                "FROM CUSTOMER, TICKET " +
                            "WHERE CUSTOMER.CUSTOMERID = TICKET.CUSTOMERID " +
                            "AND TICKET.PRIZEFLAG = 'YES'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getCustomerProfile(string surname)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT C.Forename, C.Surname, T.purchaseDate, P.* " + 
                "From Customer C Join Ticket T ON C.CustomerId = T.CUSTOMERID " +
                "Join Panel P ON P.TICKETID = T.TICKETID " +
                "WHERE C.Surname LIKE '%" + surname.ToUpper() + "%' AND CUSTOMER_STATUS = 'ACTIVE'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }



        public static DataSet getCustomer(string surname)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Customer WHERE Surname LIKE '%" + surname + "%' AND CUSTOMER_STATUS = 'ACTIVE'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getCustomer(string surname, string order)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Customer WHERE Surname LIKE '%" + surname +
                "%' AND CUSTOMER_STATUS = 'Active' ORDER BY " + order;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getCustomer(DataSet DS, string description)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

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
            int intNextCustomerId;

            // connect to the Db
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to get MAX Stock_No used
            String strSQl = "SELECT MAX(CustomerId) FROM Customer";

            OracleCommand cmd = new OracleCommand(strSQl, myConn);

            // Execute the query
            OracleDataReader dr = cmd.ExecuteReader();

            // read the first (only) value returned by query
            // If the first stockno, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                intNextCustomerId = 1;
            }
            else
            {
                intNextCustomerId = Convert.ToInt16(dr.GetValue(0)) + 1;
            }

            // Close DB connection
            myConn.Close();

            // Return next StockNo
            return intNextCustomerId;



        }

        public void regCustomer()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to INSERT stock record
            String strSQl = "INSERT INTO Customer VALUES(" + getCustomerId() + ", '" + getTitle().TrimEnd().ToUpper() + "', '" + getSurname().ToUpper() + "', '" + getForename().ToUpper() +
                "', '" + String.Format("{0:dd-MMM-yy}", getDOB()) + "', '" + getPPSN().ToUpper() + "', '" + getAddressLine1().ToUpper() + "', '" +
                getAddressLine2().ToUpper() + "', '" + getTown().ToUpper() + "', '" + getCounty().TrimEnd().ToUpper() + "', '" + getCountry().TrimEnd().ToUpper() + "', '" +
                getNationality().TrimEnd().ToUpper() + "', '" + getGender().TrimEnd().ToUpper() + "', '" + getPhone().ToUpper() + "', '" + getEmail().ToUpper() + "', '" +
                getBalance() + "', '" + getStatus().ToUpper() + "', '" + String.Format("{0:dd-MMM-yy}", getRegDate()) + "')";


            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

        public void de_regCustomer(int customerId)
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to INSERT stock record
            String strSQl = "INSERT INTO De_Reg VALUES(" + customerId + 
                ",'" + String.Format("{0:dd-MMM-yy}", DateTime.Now) + "')";


            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

        public void updateCustomer()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to UPDATE Customer details
            String strSQl = "UPDATE Customer SET Title = '" + getTitle() + "', Surname = '" + getSurname() +
                "', Forename = '" + getForename() + "', DOB = '" + String.Format("{0:dd-MMM-yy}", getDOB()) + "', PPSN = '" +
                getPPSN() + "', AddressLine1 = '" + getAddressLine1() + "', AddressLine2 = '" +
                getAddressLine2() + "', Town = '" + getTown() + "', County = '" + getCounty() +
                "', Country = '" + getCountry() + "', Nationality = '" + getNationality() +
                "', Gender = '" + getGender() + "', Phone = '" + getPhone() +
                "', Email = '" + getEmail() + "' WHERE CustomerId = " + getCustomerId();

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

        public void updateCustomer(string status)
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to UPDATE Customer details
            String strSQl = "UPDATE Customer SET CUSTOMER_STATUS = '" + status + "' WHERE CustomerId = " + getCustomerId();

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

        public static void updateCustomerBalance(int winnings, int custId)
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to UPDATE Customer details
            String strSQl = "UPDATE Customer SET BALANCE = BALANCE + '" + winnings + "' WHERE CustomerId = " + custId;

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

        public static DataSet getTitles()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM TITLE";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getNationalities()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Nationality";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getCounties()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM County";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getCountries()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Country";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getGenders()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Gender";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
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

        public void setDOB(string DOB)
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

        public void setStatus(string status)
        {
            this.status = status;
        }

        public void setRegDate(DateTime regDate)
        {
            this.regDate = regDate;
        }

        public void setBalance(int balance)
        {
            this.balance = balance;
        }

        public int getCustomerId()
        {
            return customerId;
        }

        public string getTitle()
        {
            return title;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getForename()
        {
            return forename;
        }

        public string getDOB()
        {
            return DOB;
        }

        public string getPPSN()
        {
            return PPSN;
        }

        public string getAddressLine1()
        {
            return addressLine1;
        }

        public string getAddressLine2()
        {
            return addressLine2;
        }

        public string getTown()
        {
            return town;
        }

        public string getCounty()
        {
            return county;
        }

        public string getCountry()
        {
            return country;
        }

        public string getCountryResidence()
        {
            return countryResidence;
        }

        public string getNationality()
        {
            return nationality;
        }

        public string getGender()
        {
            return gender;
        }

        public string getPhone()
        {
            return phone;
        }

        public string getEmail()
        {
            return email;
        }

        public string getStatus()
        {
            return status;
        }

        public DateTime getRegDate()
        {
            return regDate;
        }

        public double getBalance()
        {
            return this.balance;
        }


    }
}
