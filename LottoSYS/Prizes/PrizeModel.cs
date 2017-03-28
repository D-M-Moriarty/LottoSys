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
        private DateTime drawDate { get; set; }
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

        public PrizeModel(DateTime drawDate, int ticketId, int panelId, int prizeAmount)
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
            String strSQl = "INSERT INTO Prizes VALUES('" + String.Format("{0:dd-MMM-yy}", getDrawDate()) + "', " +
                getTicketId() + ", " + getPanelId() + ", " +
                getPrizeAmount() + ")";


            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }



            // Close DB connection
            myConn.Close();
        }

        public static DataSet getPrize(DateTime drawdate)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM PRIZES WHERE DRAWDATE = " + drawdate;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public void setDrawDate(DateTime drawDate)
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

        public DateTime getDrawDate()
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



