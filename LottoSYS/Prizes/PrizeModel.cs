using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace LottoSYS.Prizes
{
    class PrizeModel
    {
        private string drawDate { get; set; }
        private int ticketId { get; set; }
        private int panelId { get; set; }
        private int prizeAmount { get; set; }

        /*
         * 
         * private string drawDate;
           private int ticketId;
           private int panelId;
           private int prizeAmount;

        */

        public PrizeModel(string drawDate, int ticketId, int panelId, int prizeAmount)
        {
            setDrawDate(drawDate);
            setTicketId(ticketId);
            setPanelId(panelId);
            setPrizeAmount(prizeAmount);
        }

        public void regPrize()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to INSERT stock record
            String strSQl = "INSERT INTO Prizes VALUES('" + DateTime.Now.ToString("dd-MMM-yy") + "', " +
                getTicketId() + ", " + getPanelId() + ", " +
                getPrizeAmount() + ")";


            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

        public static DataSet getPrize()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM PRIZES";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public void setDrawDate(string drawDate)
        {
            this.drawDate = drawDate;
        }

        public void setTicketId(int ticketId)
        {
            this.ticketId = ticketId;
        }

        public void setPanelId(int panelId)
        {
            this.panelId = panelId;
        }

        public void setPrizeAmount(int prizeAmount)
        {
            this.prizeAmount = prizeAmount;
        }

        public string getDrawDate()
        {
            return drawDate;
        }

        public int getTicketId()
        {
            return ticketId;
        }

        public int getPanelId()
        {
            return panelId;
        }

        public int getPrizeAmount()
        {
            return prizeAmount;
        }
    }
}



