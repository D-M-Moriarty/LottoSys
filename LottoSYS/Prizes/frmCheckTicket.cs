using LottoSYS.Customers;
using LottoSYS.Prizes;
using LottoSYS.Sales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace LottoSYS.Prize
{
    public partial class frmCheckTicket : Form
    {
        FrmMainMenu parent;

        PrizeModel prize;

        public frmCheckTicket()
        {
            InitializeComponent();
        }

        public frmCheckTicket(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmPayPrize_Load(object sender, EventArgs e)
        {
            // disabling the print button
            btnPrint.Enabled = false;
            // TODO send an email
            // TODO check all tab indices

        }


        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // method for checking numbers
        private void checkNumbers(Panels pan, Draw draw)
        {
            //Check Numbers for winners
            int count = 0;
            int prizeAmount = 0;

            // initialising 2 blank arrays
            int[] drawNums = new int[6];
            int[] panelNums = new int[6];

            // test arrays
            int[] n1 = new int[] { 2, 4, 6, 8, 7, 1 };
            int[] n2 = new int[] { 2, 4, 6, 8, 7, 9 };

            // Populating the draw number array 
            drawNums[0] = draw.getNumber1();
            drawNums[1] = draw.getNumber2();
            drawNums[2] = draw.getNumber3();
            drawNums[3] = draw.getNumber4();
            drawNums[4] = draw.getNumber5();
            drawNums[5] = draw.getNumber6();

            // Populating the panel array
            panelNums[0] = pan.getNum1();
            panelNums[1] = pan.getNum2();
            panelNums[2] = pan.getNum3();
            panelNums[3] = pan.getNum4();
            panelNums[4] = pan.getNum5();
            panelNums[5] = pan.getNum6();

            // Comparing all the panel numbers with each draw number
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    // if there are two matching numbers count them
                    if (drawNums[i] == panelNums[j])
                        count++;
                }
            }

            // Checking the amount of matching numbers
            if (count > 2)
            {
                // retrieving the correct prizeamount from the prizestructure table
                if (count == 3)
                {
                    //prizeAmount = 100;
                    prizeAmount = PrizeStructure.getPrizeStructure(3);

                    //MessageBox.Show("you won " + prizeAmount.ToString());
                }
                else if (count == 4)
                {
                    //prizeAmount = 1000;
                    prizeAmount = PrizeStructure.getPrizeStructure(4);

                    //MessageBox.Show("you won " + prizeAmount.ToString());
                }
                else if (count == 5)
                {
                    //prizeAmount = 50000;
                    prizeAmount = PrizeStructure.getPrizeStructure(5);

                    //MessageBox.Show("you won " + prizeAmount.ToString());
                }
                else if (count == 6)
                {
                    //prizeAmount = 100000;
                    prizeAmount = PrizeStructure.getPrizeStructure(6);


                    //MessageBox.Show("you won " + prizeAmount.ToString());
                }

                // creating the new prize for the winning panel
                prize = new PrizeModel(DateTime.Now,
                                           pan.getTicketId(),
                                           pan.getPanelId(),
                                           prizeAmount
                                       );

                // Set Prize Flag to Yes    
                Ticket.setPrizeFlag(pan.getTicketId(), "YES");

                // Register the winning ticket and panel
                prize.regPrize();

                // updating the customers balance
                Customer.updateCustomerBalance(prizeAmount, Ticket.getCustomerId(pan.getTicketId()));

                // send email to notify customer they have won a prize
                sendEmail(Ticket.getCustomerId(pan.getTicketId()));


            }
            else
            {
                // setting the prizeFlag to checked so it cannot be checked again
                Ticket.setPrizeFlag(pan.getTicketId(), "CH");
                Console.WriteLine("There are no winners this week");
            }



        }

        public static void sendEmail(int customerId)
        {
            string email = Customer.getCustomerEmail(customerId);

            var fromAddress = new MailAddress("dmamprop@gmail.com", "Lotto Prize");
            var toAddress = new MailAddress(email, "Customer");
            const string fromPassword = "x11-453762";
            const string subject = "LottoSys";
            string body = "You have recently won a prize and your balance has een updated";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        private void btnCheckTickets_Click(object sender, EventArgs e)
        {
            // enabling the print button
            btnPrint.Enabled = true;

            try
            {
                //var ticket = Ticket.getTickets();
                
                var panel = Panels.getCheckPanels();

                try
                {

                    var draw = Draw.getDraws();

                    //Populate panels
                    var panels = panel.DataTableToList<Panels>();
                    var draws = draw.DataTableToList<Draw>();
                    //var tickets = ticket.DataTableToList<Ticket>();

                    //Get Draw numbers
                    int[] drawNums = new int[6];
                    int[] panelNums = new int[6];

                    //Check each panel against the draw numbers for winners
                    foreach (var pan in panels)
                    {
                        checkNumbers(pan, draws.Last());
                    }

                    // the number of run draws
                    int drawCount = draws.Count;

                    // if draws have been run
                    if (drawCount > 0)
                    {
                        //MessageBox.Show(Draw.getMaxDrawDate().ToString());
                       
                        // display th ewinning tickets on the datagridview
                        grdWinningTickets.DataSource = PrizeModel.getPrize(Draw.getMaxDrawDate()).Tables["ss"];

                        DataGridViewRow row = this.grdWinningTickets.Rows[0];
                        
                        if (row.Cells[0].Value == null)
                            MessageBox.Show("There are no winning tickets", "OOps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No draw has been run yet");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("There are no winners");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("tickets cannot be checked");
            }


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ClsPrint _ClsPrint = new ClsPrint(grdWinningTickets, "Winning tickes");
            _ClsPrint.printPreview();
        }
    }
}
