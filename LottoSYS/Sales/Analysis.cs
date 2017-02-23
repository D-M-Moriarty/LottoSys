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
    }
}
