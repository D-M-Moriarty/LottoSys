using System;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using LottoSYS.Prize;
using System.Linq;

namespace LottoSYS.Sales
{
    class Panels
    {
        public int panelid { get; set; }
        public int ticketid { get; set; }
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int number3 { get; set; }
        public int number4 { get; set; }
        public int number5 { get; set; }
        public int number6 { get; set; }

        public const float PANEL_PRICE = 2.2f;

        public static DataSet getPanel(int custId)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT DISTINCT P.*, T.PRICE, PR.PRIZEAMOUNT, T.PRIZEFLAG, T.PURCHASEDATE " + 
                            "From Panel P Join Ticket T ON P.TICKETID = T.TICKETID " + 
                            "JOIN Customer C ON '" + custId + "' = T.CUSTOMERID " +
                            "LEFT JOIN Prizes PR ON PR.TICKETID = T.TICKETID " +
                            "ORDER BY PR.PRIZEAMOUNT";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);



            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

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

        public static DataTable getPanels()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataTable DT = new DataTable();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Panel P JOIN Ticket T on T.TicketId = P.TicketId WHERE T.PrizeFlag = 'NO'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            var dr = cmd.ExecuteReader();

            DT.Load(dr);

            //close database
            conn.Close();

            return DT;
        }

        public static DataTable getCheckPanels()
        {

            var draw = Draw.getDraws();

            var draws = draw.DataTableToList<Draw>();

            DateTime drawDate = draws.Last().getDate();

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataTable DT = new DataTable();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Panel P JOIN Ticket T on T.TicketId = P.TicketId WHERE T.PURCHASEDATE >= '" + 
                String.Format("{0:dd-MMM-yy}", drawDate.AddDays(-6)) + "' "+
                " AND T.PURCHASEDATE <= '" + String.Format("{0:dd-MMM-yy}", drawDate) + "'" +
                " AND T.PrizeFlag = 'NO'";

            Console.Write("The date is " + drawDate.AddDays(-6));

            /*SELECT*
             FROM PANEL P
             JOIN TICKET T ON T.TICKETID = P.TICKETID
             WHERE T.PURCHASEDATE >= LASTDRAWDATE
             AND <= NEXT DRAWDATE
             */

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            var dr = cmd.ExecuteReader();

            DT.Load(dr);

            //close database
            conn.Close();

            return DT;
        }

        public static DataSet getPanel(int ticketId, int panelId)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Panel WHERE TicketId = " + ticketId + " AND PanelId = " + panelId;

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
            panelid = panelId;
        }

        public void setTicketId(int ticketId)
        {
            ticketid = ticketId;
        }

        public void setNum1(int num1)
        {
            number1 = num1;
        }

        public void setNum2(int num2)
        {
            number2 = num2;
        }

        public void setNum3(int num3)
        {
            number3 = num3;
        }

        public void setNum4(int num4)
        {
            number4 = num4;
        }

        public void setNum5(int num5)
        {
            number5 = num5;
        }

        public void setNum6(int num6)
        {
            number6 = num6;
        }

        public int getPanelId()
        {
            return panelid;
        }

        public int getTicketId()
        {
            return ticketid;
        }

        public int getNum1()
        {
            return number1;
        }

        public int getNum2()
        {
            return number2;
        }

        public int getNum3()
        {
            return number3;
        }

        public int getNum4()
        {
            return number4;
        }

        public int getNum5()
        {
            return number5;
        }

        public int getNum6()
        {
            return number6;
        }

    }
}
