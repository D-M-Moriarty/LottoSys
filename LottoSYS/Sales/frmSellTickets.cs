using LottoSYS.Customers;
using LottoSYS.Prizes;
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
            string ticketOut = "";

            Ticket.generateNumbers2(cboTicketQTY);

            //Parsing to an integer
            int numOfLines = Int32.Parse(cboTicketQTY.Text);

            panelNums = new int[numOfLines, numbers6];

            for (int i = 0; i < numOfLines; i++)
            {
                generated = Ticket.generateNumbers();


                for (int j = 0; j < numbers6; j++)
                {
                    panelNums[i, j] = generated[j];
                }

            }

            string outpo = "";

            for (int i = 0; i < numOfLines; i++)
            {
                for (int j = 0; j < 6; j++) Console.Write(panelNums[i, j]);

                Console.WriteLine(" ");
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
            if (grdListing.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = this.grdListing.Rows[e.RowIndex];

                custId = Convert.ToInt32(row.Cells[0].Value);

                txtSurname.Text = row.Cells[2].Value.ToString();

                txtForename.Text = row.Cells[3].Value.ToString();

                txtTown.Text = row.Cells[8].Value.ToString();

                txtPhone.Text = row.Cells[13].Value.ToString();

                txtEmail.Text = row.Cells[14].Value.ToString();


            }
        }
    }
}
