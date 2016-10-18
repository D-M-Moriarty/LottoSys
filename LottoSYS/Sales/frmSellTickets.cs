using System;
using System.Windows.Forms;

namespace LottoSYS.Sales
{
    public partial class frmSellTickets : Form
    {
        private FrmMainMenu parent;

        public frmSellTickets()
        {
            InitializeComponent();
        }

        public frmSellTickets(FrmMainMenu Parent)
        {
            // Initalizes all Formitems and configurations set on the Form
            InitializeComponent();
            parent = Parent;
        }

        private void frmSellTickets_Load(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //Placing the quantity into the number of tickets
            string numOfTicketsString = txtQuantity.Text;

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
            bool[] alreadyPicked = new bool[47];
            int num;

            //might make each ticket a line instead

            for (int j = 0; j < numOfTickets; j++)
            {

                str += "Ticket no. " + (j+1) + ": ";

                for (int i = 0; i < nums.Length; i++)
                {

                    if (i > 0)
                        str += ",";

                    num = randNum.Next(Min, Max);

                    while (alreadyPicked[num])
                        num = randNum.Next(Min, Max);

                    alreadyPicked[num] = true;
                    nums[i] = num;

                    if (num < 10)
                    {
                        zero += nums[i];
                        str += " " + zero;
                        zero = "0";
                    }
                    else
                    {
                        str += " " + nums[i];
                    }
                    
                }

             
                alreadyPicked = new bool[47];

                str += "\n\n";
            }


            MessageBox.Show(str);
        }
    }
}
