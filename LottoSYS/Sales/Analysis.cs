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
            string strSQL = "SELECT SUM(NumTickets) AS TotTickets, SUM(Price) AS TotSales, SUM(PrizeAmount) AS TotPrizes, SUM(Price) - SUM(PrizeAmount) AS PROFIT " +
                            "FROM(SELECT TicketID, 1 AS NumTickets, Price, 0 AS PrizeAmount " +
                                  "FROM Ticket " +
                                  "WHERE PurchaseDate BETWEEN '" + String.Format("{0:dd-MMM-yy}", startDate) + "' AND '" + String.Format("{0:dd-MMM-yy}", endDate) + "' " +
                                  "UNION ALL " +
                                  "SELECT TicketID, 0 AS NumTickets, 0 AS Price, PrizeAmount " +
                                  "FROM Prizes " +
                                  "WHERE TicketID IN(SELECT TicketID FROM Ticket WHERE PurchaseDate BETWEEN '" + String.Format("{0:dd-MMM-yy}", startDate) + "' AND '" + String.Format("{0:dd-MMM-yy}", endDate) + "'))";
                                  

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getNumberAnalysis(string order)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM NumberAnalysis ORDER BY NumberOccurences " + order + "";


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

            int num1 = draws.Last().getNumber1();
            int num2 = draws.Last().getNumber2();
            int num3 = draws.Last().getNumber3();
            int num4 = draws.Last().getNumber4();
            int num5 = draws.Last().getNumber5();
            int num6 = draws.Last().getNumber6();
            
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to UPDATE Customer details
            String strSQl = "UPDATE NumberAnalysis SET NumberOccurences = " +
                            "NumberOccurences + 1 WHERE NumPk = " + num1;
            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();
            // Define SQL query to UPDATE Customer details
            strSQl = "UPDATE NumberAnalysis SET NumberOccurences = " +
                            "NumberOccurences + 1 WHERE NumPk = " + num2;
            // Execute the command
            cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();
            // Define SQL query to UPDATE Customer details
            strSQl = "UPDATE NumberAnalysis SET NumberOccurences = " +
                            "NumberOccurences + 1 WHERE NumPk = " + num3;
            // Execute the command
            cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();
            // Define SQL query to UPDATE Customer details
            strSQl = "UPDATE NumberAnalysis SET NumberOccurences = " +
                            "NumberOccurences + 1 WHERE NumPk = " + num4;
            // Execute the command
            cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();
            // Define SQL query to UPDATE Customer details
            strSQl = "UPDATE NumberAnalysis SET NumberOccurences = " +
                            "NumberOccurences + 1 WHERE NumPk = " + num5;
            // Execute the command
            cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();
            // Define SQL query to UPDATE Customer details
            strSQl = "UPDATE NumberAnalysis SET NumberOccurences = " +
                            "NumberOccurences + 1 WHERE NumPk = " + num6;
            // Execute the command
            cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();



            // Close DB connection
            myConn.Close();
        }
        
    
    }
}
