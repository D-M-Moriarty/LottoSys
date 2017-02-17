using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LottoSYS.Prizes
{
    class Draw
    {

       private string drawDate;
       private int number1;
       private int number2;
       private int number3;
       private int number4;
       private int number5;
       private int number6;

        public static DataSet getDraw(String f)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Draw";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getDraw()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Draw WHERE DrawDate = '15/02/2017 23:08:17'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getPanel(string surname, string order)
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

        public static DataSet getPanel(DataSet DS, string description)
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

        public static int nextPanelId()
        {
            // variable to hold value to be returned
            int intNextCustomerId;

            // connect to the Db
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to get MAX Stock_No used
            String strSQl = "SELECT MAX(PanelId) FROM Panel";

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

        public void regDraw()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to INSERT stock record
            String strSQl = "INSERT INTO Draw VALUES('" + getDate() + "', " +
                getNumber1() + ", " + getNumber2() + ", " +
                getNumber3() + ", " + getNumber4() + ", " +
                getNumber5() + ", " + getNumber6() + ")";


            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

        public void updateTicket()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to UPDATE Customer details
            String strSQl = "UPDATE Panel SET PrizeFlag = 'YES'";

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

        public void setDate(string drawDate)
        {
            this.drawDate = drawDate;
        }

        public string getDate()
        {
            return drawDate;
        }

        public void setNumber1(int number1)
        {
            this.number1 = number1;
        }

        public void setNumber2(int number2)
        {
            this.number2 = number2;
        }

        public void setNumber3(int number3)
        {
            this.number3 = number3;
        }

        public void setNumber4(int number4)
        {
            this.number4 = number4;
        }

        public void setNumber5(int number5)
        {
            this.number5 = number5;
        }

        public void setNumber6(int number6)
        {
            this.number6 = number6;
        }

        public int getNumber1()
        {
            return number1;
        }

        public int getNumber2()
        {
            return number2;
        }

        public int getNumber3()
        {
            return number3;
        }

        public int getNumber4()
        {
            return number4;
        }

        public int getNumber5()
        {
            return number5;
        }

        public int getNumber6()
        {
            return number6;
        }

    }
}
