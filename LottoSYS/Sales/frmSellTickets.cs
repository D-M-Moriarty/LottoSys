using LottoSYS.Customers;
using LottoSYS.Prize;
using System;
using System.Windows.Forms;

namespace LottoSYS.Sales
{
    public partial class frmSellTickets : Form
    {
        private FrmMainMenu parent;
        public int numOfLines;

        private const int numbers6 = 6;

        private int[,] panelNums;
        private int[] generated = new int[6];

        private int custId;

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
            TimeSpan end = new TimeSpan(11, 0, 0); 
            TimeSpan now = DateTime.Now.TimeOfDay;
            DateTime today = DateTime.Today;

            // Checking if its a Tuesday and its before 5 o clock or else its not a tuesday
            // This is to stop selling tickets after 5 o clock on tuesdays before the draw is run
            if (today.DayOfWeek == DayOfWeek.Tuesday && now < end || today.DayOfWeek != DayOfWeek.Tuesday)
            {
                Console.Write(DateTime.Today.DayOfWeek);

                loadTicketQTY();
                txtEmail.Enabled = false;
                txtForename.Enabled = false;
                txtPhone.Enabled = false;
                txtSurname.Enabled = false;
                txtTown.Enabled = false;
                btnProcess.Enabled = false;
            }
            else
            {
                MessageBox.Show("Cannot buy tickets anymore today", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                parent.Show();
            }

            
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

            //Parsing to an integer
            int numOfLines = Int32.Parse(cboTicketQTY.Text);
            
            for(int p = 0; p < 1000; p++)
            {
                Ticket ticket = new Ticket();
                Panels panel;

                int ticketId = Ticket.nextTicketId();

                ticket.setTicketId(Convert.ToInt32(Ticket.nextTicketId().ToString("00000")));
                ticket.setCustomerId(custId);
                ticket.setPurchaseDate(DateTime.Now);
                ticket.setTime(DateTime.Now.ToString());
                ticket.setPrice(Panels.PANEL_PRICE * numOfLines);
                ticket.setPrizeFlag("NO");

                ticket.regTicket();
                

                panelNums = new int[numOfLines, numbers6];

                panelNums = Ticket.generateNumbers(numOfLines);


                for (int i = 0; i < numOfLines; i++)
                {
                    panel = new Panels();

                    panel.setPanelId(i + 1);

                    panel.setTicketId(ticketId);

                    panel.setNum1(panelNums[i, 0]);
                    panel.setNum2(panelNums[i, 1]);
                    panel.setNum3(panelNums[i, 2]);
                    panel.setNum4(panelNums[i, 3]);
                    panel.setNum5(panelNums[i, 4]);
                    panel.setNum6(panelNums[i, 5]);

                    panel.regPanel();

                }



                string outpo = "";

                for (int i = 0; i < numOfLines; i++)
                {
                    outpo += "Line no. " + (i + 1) + ": ";

                    for (int j = 0; j < numbers6; j++)
                    {
                        if (panelNums[i, j] < 10)
                        {
                            string zero = "0";
                            zero += panelNums[i, j];
                            outpo += " " + zero;
                        }
                        else
                        {
                            outpo += " " + panelNums[i, j];
                        }

                        Console.Write(panelNums[i, j]);
                    }

                    outpo += "\n\n";

                    Console.WriteLine(" ");
                }
            }
                

                //MessageBox.Show(outpo);


            

            txtSurname.ResetText();
            txtForename.ResetText();
            txtTown.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
            cboTicketQTY.SelectedIndex = -1;

            btnProcess.Enabled = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grdListing.DataSource = Customer.getCustomer(txtSearchBox.Text).Tables["ss"];
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

        private void loadTicketQTY()
        {
            for (int i = 1; i < 6; i++)
            {
                cboTicketQTY.Items.Add(i.ToString());
            }

            cboTicketQTY.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void grdListing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.grdListing.Rows[e.RowIndex];

                custId = Convert.ToInt32(row.Cells[0].Value);

                txtSurname.Text = row.Cells[2].Value.ToString();

                txtForename.Text = row.Cells[3].Value.ToString();

                txtTown.Text = row.Cells[8].Value.ToString();

                txtPhone.Text = row.Cells[13].Value.ToString();

                txtEmail.Text = row.Cells[14].Value.ToString();

                btnProcess.Enabled = true;
            }
            catch
            {

            }
        }
    }
}
