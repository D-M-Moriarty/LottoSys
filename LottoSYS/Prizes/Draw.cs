using System;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LottoSYS.Prize
{
    class Draw
    {
        public DateTime drawDate { get; set; }
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int number3 { get; set; }
        public int number4 { get; set; }
        public int number5 { get; set; }
        public int number6 { get; set; }

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
            string strSQL = "SELECT * FROM Draw";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataTable getDraws()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataTable DT = new DataTable();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Draw";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            //execute the query
            var dr = cmd.ExecuteReader();

            DT.Load(dr);

            //close database
            conn.Close();

            return DT;
        }

        public void regDraw()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to INSERT stock record
            String strSQl = "INSERT INTO Draw VALUES('" + String.Format("{0:dd-MMM-yy}", DateTime.Now) + "', " +
                getNumber1() + ", " + getNumber2() + ", " +
                getNumber3() + ", " + getNumber4() + ", " +
                getNumber5() + ", " + getNumber6() + ")";


            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

        public static DateTime getMaxDrawDate()
        {

            // variable to hold value to be returned
            DateTime lastDraw;

            // connect to the Db
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to get MAX Stock_No used
            string strSQl = "SELECT MAX(DRAWDATE) FROM Draw";

            OracleCommand cmd = new OracleCommand(strSQl, myConn);

            // Execute the query
            OracleDataReader dr = cmd.ExecuteReader();

            // read the first (only) value returned by query
            // If the first stockno, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            
            lastDraw = Convert.ToDateTime(dr.GetValue(0));
            

            // Close DB connection
            myConn.Close();

            // Return next StockNo
            return lastDraw;
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

        public void setDate(DateTime drawDate)
        {
            this.drawDate = drawDate;
        }

        public DateTime getDate()
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
