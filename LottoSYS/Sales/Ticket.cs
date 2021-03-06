﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LottoSYS.Prize
{
    class Ticket
    {

        private int ticketId;
        private int customerId;
        private DateTime purchaseDate;
        private string time;
        private double price;
        private string prizeFlag;


        public Ticket()
        {

        }

        public Ticket(int ticketId, int customerId, DateTime purchaseDate, string time, double price, string prizeFlag)
        {
            this.ticketId = ticketId;
            this.customerId = customerId;
            this.purchaseDate = purchaseDate;
            this.time = time;
            this.price = price;
            this.prizeFlag = prizeFlag;
        }



        public static int getCustomerId(int ticketId)
        {

            // variable to hold value to be returned
            int customerId;

            // connect to the Db
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            //define sql query
            string strSQL = "SELECT CustomerId FROM Ticket WHERE TicketId = " + ticketId;
            
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            // Execute the query
            OracleDataReader dr = cmd.ExecuteReader();

            // read the first (only) value returned by query
            // If the first stockno, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                customerId = 1;
            }
            else
            {
                customerId = Convert.ToInt16(dr.GetValue(0));
            }

            // Close DB connection
            myConn.Close();

            // Return next StockNo
            return customerId;
        }

        public static DataTable getTickets()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataTable DT = new DataTable();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Ticket WHERE PrizeFlag = 'NO'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            var dr = cmd.ExecuteReader();

            DT.Load(dr);

            //close database
            conn.Close();

            return DT;
        }


        public static void setPrizeFlag(int TicketId, string ch)
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to UPDATE Customer details
            String strSQl = "UPDATE Ticket SET PrizeFlag = '" + ch + "' WHERE TicketId = " + TicketId;

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }

      

        public static int nextTicketId()
        {
            // variable to hold value to be returned
            int intNextTicketId;

            // connect to the Db
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to get MAX Stock_No used
            String strSQl = "SELECT MAX(TicketId) FROM Ticket";

            OracleCommand cmd = new OracleCommand(strSQl, myConn);

            // Execute the query
            OracleDataReader dr = cmd.ExecuteReader();

            // read the first (only) value returned by query
            // If the first stockno, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                intNextTicketId = 1;
            }
            else
            {
                intNextTicketId = Convert.ToInt16(dr.GetValue(0)) + 1;
            }

            // Close DB connection
            myConn.Close();

            // Return next StockNo
            return intNextTicketId;



        }

        public void regTicket()
        {
            // Connect to database
            OracleConnection myConn = new OracleConnection(ConnectDB.oradb);
            myConn.Open();

            // Define SQL query to INSERT stock record
            String strSQl = "INSERT INTO Ticket VALUES(" + getTicketId() + ", " + getCustomerId() +
                ", '" + String.Format("{0:dd-MMM-yy}", getPurchaseDate()) + "', '" + getTime() + "', " + getPrice() +
                ", '" + getPrizeFlag() + "')";


            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }



        

        public static int[,] generateNumbers(int loop)
        {
            int Min = 1;
            int Max = 47;
            Random randNum = new Random();

            int[] nums = new int[6];
            int[,] numsCopy = new int[loop, 6];
            bool[] alreadyPicked = new bool[47];
            int num;

            for (int i = 0; i < loop; i++)
            {

                for (int j = 0; j < 6; j++)
                {
                    num = randNum.Next(Min, Max);

                    while (alreadyPicked[num])
                        num = randNum.Next(Min, Max);

                    alreadyPicked[num] = true;

                    numsCopy[i, j] = num;

                    // selection sort
                    if (j == 5)
                    {
                        int min;
                        int temp;
                        for (int b = 0; b < 6; b++)
                        {
                            // Assume first element is min
                            min = b;
                            for (int a = (b + 1); a < 6; a++)
                            {
                                if (numsCopy[i, a] < numsCopy[i, min])
                                {
                                    min = a;

                                }
                            }
                            if (min != b)
                            {   //switching with the temperary viriables
                                temp = numsCopy[i, b];
                                numsCopy[i, b] = numsCopy[i, min];
                                numsCopy[i, min] = temp;
                            }
                        }

                    }

                }


            }

            return numsCopy;


        }

        public static int[] generateNumbers()
        {

            string str = "";
            int Min = 1;
            int Max = 47;
            string zero = "0";
            Random randNum = new Random();

            int[] nums = new int[6];
            int[] serialNum = new int[21];
            int[] numsCopy = new int[6];
            bool[] alreadyPicked = new bool[47];
            int num;

            for (int i = 0; i < nums.Length; i++)
            {
                num = randNum.Next(Min, Max);

                while (alreadyPicked[num])
                    num = randNum.Next(Min, Max);

                alreadyPicked[num] = true;
                nums[i] = num;
                numsCopy[i] = num;


                //insertion sort
                if (i == nums.Length - 1)
                {
                    int min;
                    int temp;
                    for (int b = 0; b < numsCopy.Length; b++)
                    {
                        // Assume first element is min
                        min = b;
                        for (int a = (b + 1); a < numsCopy.Length; a++)
                        {
                            if (numsCopy[a] < numsCopy[min])
                            {
                                min = a;

                            }
                        }
                        if (min != b)
                        {   //switching with the temperary viriables
                            temp = numsCopy[b];
                            numsCopy[b] = numsCopy[min];
                            numsCopy[min] = temp;
                        }
                    }

                }
            }

            return numsCopy;


        }
        

        public void setTicketId(int ticketId)
        {
            this.ticketId = ticketId;
        }

        public void setCustomerId(int customerId)
        {
            this.customerId = customerId;
        }

        public void setPurchaseDate(DateTime purchaseDate)
        {
            this.purchaseDate = purchaseDate;
        }

        public void setTime(string time)
        {
            this.time = time;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public void setPrizeFlag(string prizeFlag)
        {
            this.prizeFlag = prizeFlag;
        }
        public int getTicketId()
        {
            return ticketId;
        }

        public int getCustomerId()
        {
            return customerId;
        }

        public DateTime getPurchaseDate()
        {
            return purchaseDate;
        }

        public string getTime()
        {
            return time;
        }

        public double getPrice()
        {
            return price;
        }

        public string getPrizeFlag()
        {
            return prizeFlag;
        }
    }
}
