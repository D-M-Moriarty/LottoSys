using LottoSYS.Prize;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoSYS.Sales
{
    class Analysis
    {

        public static DataSet getAnalysis(DateTime startDate, DateTime endDate)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT COUNT(T.TICKETID) / 5 AS Total_Tickets_Sold, " +
                "(COUNT(P.PANELID) * 2.2) AS Total_Income, SUM(PR.PRIZEAMOUNT) / 5 AS Payout, " +
                "(COUNT(P.PANELID) * 2.2) - SUM(PR.PRIZEAMOUNT) / 5 AS Profit " +
                "FROM PANEL P " +
                    "JOIN TICKET T ON P.TICKETID = T.TICKETID " +
                    "LEFT JOIN PRIZES PR ON T.TICKETID = PR.TICKETID " +
                "WHERE t.PURCHASEDATE BETWEEN '" + String.Format("{0:dd-MMM-yy}", startDate)
                + "' AND ' " + String.Format("{0:dd-MMM-yy}", endDate) + "'";


            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getNumberAnalysis()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM NumberAnalysis";


            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static void updateNumberAnalysis()
        {
            var draw = Draw.getDraws();
            var draws = draw.DataTableToList<Draw>();

            int num1 = draws.First().getNumber1();
            int num2 = draws.First().getNumber2();
            int num3 = draws.First().getNumber3();
            int num4 = draws.First().getNumber4();
            int num5 = draws.First().getNumber5();
            int num6 = draws.First().getNumber6();
            
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to UPDATE Customer details
            String strSQl = "UPDATE NumberAnalysis SET " + num1 + " = " + (num1 + 1) +
                                                   " SET " + num2 + " = " + (num2 + 1) +
                                                   " SET " + num3 + " = " + (num3 + 1) +
                                                   " SET " + num4 + " = " + (num4 + 1) +
                                                   " SET " + num5 + " = " + (num5 + 1) +
                                                   " SET " + num6 + " = " + (num6 + 1);

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }



    
    }
}
