using LottoSYS.Prize;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string strSQL = "SELECT MATCH" + num + " FROM PRIZESTRUCTURE WHERE DRAWDATE < '" + Draw.getMaxDrawDate() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            // Execute the query
            OracleDataReader dr = cmd.ExecuteReader();

            // read the first (only) value returned by query
            // If the first stockno, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                PrizeAmount = 1;
            }
            else
            {
                PrizeAmount = Convert.ToInt16(dr.GetValue(0)) + 1;
            }

            // Close DB connection
            myConn.Close();

            // Return next StockNo
            return PrizeAmount;
        }

    }
}
