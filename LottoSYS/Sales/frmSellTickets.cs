using System;
using System.Windows.Forms;

namespace LottoSYS.Sales
{
    public partial class frmSellTickets : Form
    {
        private FrmMainMenu parent;
        public float price;
        public int numOfLines;
        private String surname;
        private String forename;
        private String town;
        private String phone;
        private String email;


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
            loadTicketQTY();
            txtEmail.Enabled = false;
            txtForename.Enabled = false;
            txtPhone.Enabled = false;
            txtSurname.Enabled = false;
            txtTown.Enabled = false;
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
            if(cboTicketQTY.Text != "")
            {
                string numOfTicketsString = cboTicketQTY.Text;

                //Parsing to an integer
                int numOfTickets = int.Parse(numOfTicketsString);

                if(numOfTickets < 6 && numOfTickets > 0)
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
                    this.price = price;
                    numOfLines = numOfTickets;
                    
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


            txtSurname.ResetText();
            txtForename.ResetText();
            txtTown.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
            cboTicketQTY.SelectedIndex = -1;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if non empty Resultset is there first
            lstList.Items.Add("Jim Miller, Examlpe street, Killorglin");
            lstList.Items.Add("Mary Shea, Examlpe street, Tralee");
            lstList.Items.Add("Tim Clifford, Examlpe street, Millstreet");
            lstList.Items.Add("Jim Miller, Examlpe street, Killorglin");
        }

        private void grpDetailBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
           
            frmSellTicketPayment frmNext = new frmSellTicketPayment(this);
            Hide();
            frmNext.Show();

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            String curItem = lstList.SelectedItem.ToString();



            // Find the string in ListBox2.
            int index = lstList.FindString(curItem);

            if (index == 0)
            {
                surname = "Miller";
                forename = "Jim";
                town = "Killorglin";
                phone = "89689679";
                email = "dkgfsuio|@sf.com";



            }
            else if (index == 1)
            {
                surname = "Mary";
                forename = "Shea";
                town = "Tralee";
                phone = "89689679";
                email = "dkgfsuio|@sf.com";
            }
            else
            {
                surname = "Tim";
                forename = "Clifford";
                town = "Millstreet";
                phone = "89689679";
                email = "dkgfsuio|@sf.com";
            }

            txtSurname.Text = surname;
            txtForename.Text = forename;
            txtTown.Text = town;
            txtEmail.Text = email;
            txtPhone.Text = phone;
            

        }

        private void loadTicketQTY()
        {
            for (int i = 1; i < 6; i++)
            {
                cboTicketQTY.Items.Add(i.ToString());
            }
            
            cboTicketQTY.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
