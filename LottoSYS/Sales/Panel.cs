using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoSYS.Sales
{
    class Panel
    {

        private int panelId;
        private int ticketId;
        private int num1;
        private int num2;
        private int num3;
        private int num4;
        private int num5;
        private int num6;

        public static DataSet getPanel()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Panel";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getPanel(string surname)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Panel WHERE Surname LIKE '%" + surname + "%' AND CUSTOMER_STATUS = 'Active'";

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

        public void regPanel()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to INSERT stock record
            String strSQl = "INSERT INTO Panel VALUES(" + getPanelId() + ", " + getTicketId() +
                ", " + getNum1() + ", " + getNum2() + ", " + getNum3() +
                ", " + getNum4() + ", " + getNum5() + ", " + getNum6() + ")";


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

        public void setPanelId(int panelId)
        {
            this.panelId = panelId;
        }

        public void setTicketId(int ticketId)
        {
            this.ticketId = ticketId;
        }

        public void setNum1(int num1)
        {
            this.num1 = num1;
        }

        public void setNum2(int num2)
        {
            this.num2 = num2;
        }

        public void setNum3(int num3)
        {
            this.num3 = num3;
        }

        public void setNum4(int num4)
        {
            this.num4 = num4;
        }

        public void setNum5(int num5)
        {
            this.num5 = num5;
        }

        public void setNum6(int num6)
        {
            this.num6 = num6;
        }

        public int getPanelId()
        {
            return panelId;
        }

        public int getTicketId()
        {
            return ticketId;
        }

        public int getNum1()
        {
            return num1;
        }

        public int getNum2()
        {
            return num2;
        }

        public int getNum3()
        {
            return num3;
        }

        public int getNum4()
        {
            return num4;
        }

        public int getNum5()
        {
            return num5;
        }

        public int getNum6()
        {
            return num6;
        }

    }
}
