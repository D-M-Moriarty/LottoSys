using Oracle.ManagedDataAccess.Client;
using System;

namespace LottoSYS
{
    class PrizeStructure
    {

        public static int getPrizeStructure(int num)
        {
      
            // variable to hold value to be returned
            int PrizeAmount;

            // connect to the Db
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            //define sql query
            string strSQL = "SELECT MATCH" + num +" FROM PRIZESTRUCTURE WHERE DRAWDATE = (SELECT MAX(DRAWDATE) FROM PRIZESTRUCTURE)";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            // Execute the query
            OracleDataReader dr = cmd.ExecuteReader();

            // read the first (only) value returned by query
            dr.Read();

            PrizeAmount = Convert.ToInt32(dr.GetValue(0));
            

            // Close DB connection
            myConn.Close();

            // Return next StockNo
            return PrizeAmount;
        }

    }
}
