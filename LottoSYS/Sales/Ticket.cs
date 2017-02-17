using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LottoSYS.Prizes
{
    class Ticket
    {

        private int ticketId;
        private int customerId;
        private string purchaseDate;
        private string time;
        private double price;
        private string prizeFlag;

        



        public Ticket()
        {

        }

        public Ticket(int ticketId, int customerId, string purchaseDate, string time, double price, string prizeFlag)
        {
            this.ticketId = ticketId;
            this.customerId = customerId;
            this.purchaseDate = purchaseDate;
            this.time = time;
            this.price = price;
            this.prizeFlag = prizeFlag;
        }

        public static DataSet getTicket()
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Ticket";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getTicket(int ticketId)
        {

            OracleConnection conn = new OracleConnection(ConnectDB.oradb);

            DataSet DS = new DataSet();

            //connect to the database
            conn.Open();

            //define sql query
            string strSQL = "SELECT * FROM Ticket WHERE TicketId = " + ticketId;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close database
            conn.Close();

            return DS;
        }

        public static DataSet getTicket(string surname, string order)
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

        public static DataSet getTicket(DataSet DS, string description)
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
                ", '" + getPurchaseDate() + "', '" + getTime() + "', " + getPrice() +
                ", '" + getPrizeFlag() + "')";


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
            String strSQl = "UPDATE Customer SET PrizeFlag = 'YES'";

            // Execute the command
            OracleCommand cmd = new OracleCommand(strSQl, myConn);
            cmd.ExecuteNonQuery();


            // Close DB connection
            myConn.Close();
        }


        public static void generateNumbers2(ComboBox cboTicketQTY)
        {
            //Placing the quantity into the number of tickets
            string numOfTicketsString = cboTicketQTY.Text;

            //Parsing to an integer
            int numOfTickets = Int32.Parse(numOfTicketsString);

            //MessageBox.Show(numOfTicketsString);

            //Currently converting the arrays to string
            //Ideally would like to change to 2d array or jagged array


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
            string numsoutput = "";


            //might make each ticket a line instead

            for (int j = 0; j < numOfTickets; j++)
            {

                str += "Line no. " + (j + 1) + ": ";

                for (int i = 0; i < nums.Length; i++)
                {

                    //if (i > 0)
                    //str += ",";

                    num = randNum.Next(Min, Max);

                    while (alreadyPicked[num])
                        num = randNum.Next(Min, Max);

                    alreadyPicked[num] = true;
                    nums[i] = num;
                    numsCopy[i] = num;

                    if (num < 10)
                    {
                        zero += nums[i];
                        //str += " " + zero;
                        zero = "0";
                        zero += numsCopy[i];
                        numsoutput += " " + zero;
                        zero = "0";
                    }
                    else
                    {
                        //str += " " + nums[i];
                        numsoutput += " " + numsCopy[i];
                    }

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

                        //formatting into a string for output
                        string txt = "";
                        foreach (int element in numsCopy)
                        {
                            if (element < 10)
                            {

                                zero = "0";
                                zero += element;
                                txt += zero + ", ";
                            }
                            else
                            {
                                txt += element + ", ";
                            }



                        }

                        str += txt;
                        MessageBox.Show(txt, "Ticket Details");

                    }


                }

                //return numsCopy;

                alreadyPicked = new bool[47];

                numsoutput += "\n\n";
                str += "\n\n";
            }


            //Generating the serial number
            str += "Serial Number: ";
            for (int j = 0; j < serialNum.Length; j++)
            {
                serialNum[j] = randNum.Next(0, 9);

                if (j == 4 || j == 16)
                {
                    str += " - " + serialNum[j];
                }
                else
                {
                    str += "" + serialNum[j];
                }

            }

            MessageBox.Show(str, "Ticket Details");
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

            for(int i = 0; i < loop; i++)
            {

                for (int j = 0; j < 6; j++)
                {
                    num = randNum.Next(Min, Max);

                    while (alreadyPicked[num])
                        num = randNum.Next(Min, Max);

                    alreadyPicked[num] = true;

                    numsCopy[i, j] = num;

                    //insertion sort
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
                                if (numsCopy[i,a] < numsCopy[i, min])
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


        public static void generateNumbers3(ComboBox cboTicketQTY)
        {
            //Placing the quantity into the number of tickets
            if (cboTicketQTY.Text != "")
            {
                string numOfTicketsString = cboTicketQTY.Text;

                //Parsing to an integer
                int numOfTickets = int.Parse(numOfTicketsString);

                if (numOfTickets < 6 && numOfTickets > 0)
                {
                    //MessageBox.Show(numOfTicketsString);

                    //Currently converting the arrays to string
                    //Ideally would like to change to 2d array or jagged array

                    float price = 2.2f;
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
                    string numsoutput = "";


                    //might make each ticket a line instead

                    for (int j = 0; j < numOfTickets; j++)
                    {

                        str += "Line no. " + (j + 1) + ": ";
                        numsoutput += "Line no. " + (j + 1) + ": ";

                        for (int i = 0; i < nums.Length; i++)
                        {

                            if (i > 0)
                                str += ",";

                            num = randNum.Next(Min, Max);

                            while (alreadyPicked[num])
                                num = randNum.Next(Min, Max);

                            alreadyPicked[num] = true;
                            nums[i] = num;
                            numsCopy[i] = num;

                            if (num < 10)
                            {
                                zero += nums[i];
                                str += " " + zero;
                                zero = "0";
                                zero += numsCopy[i];
                                numsoutput += " " + zero;
                                zero = "0";
                            }
                            else
                            {
                                str += " " + nums[i];
                                numsoutput += " " + numsCopy[i];
                            }

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

                                //formatting into a string for output
                                string txt = "";
                                foreach (int element in numsCopy)
                                {
                                    txt += element + ", ";
                                }
                                //MessageBox.Show(txt, "Ticket Details");

                            }


                        }

                        alreadyPicked = new bool[47];

                        numsoutput += "\n\n";
                        str += "\n\n";
                    }


                    //Generating the serial number
                    str += "Serial Number: ";
                    for (int j = 0; j < serialNum.Length; j++)
                    {
                        serialNum[j] = randNum.Next(0, 9);

                        if (j == 4 || j == 16)
                        {
                            str += " - " + serialNum[j];
                        }
                        else
                        {
                            str += "" + serialNum[j];
                        }

                    }

                    str += "\n\nTicket price €" + string.Format("{0:0.00}", price * numOfTickets);

                    MessageBox.Show(str, "Ticket Details");

                    cboTicketQTY.SelectedIndex = -1;
                    price = price;

                }
                else
                {
                    MessageBox.Show("Please pick between 1 and 5 lines, please re enter");
                }

            }
            else
            {
                MessageBox.Show("Please enter a Line quantity!");
            }


        }

        public void setTicketId(int ticketId)
        {
            this.ticketId = ticketId;
        }

        public void setCustomerId(int customerId)
        {
            this.customerId = customerId;
        }

        public void setPurchaseDate(string purchaseDate)
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

        public string getPurchaseDate()
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
