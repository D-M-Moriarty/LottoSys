using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS
{
    public partial class frmCustomerProfile : Form
    {

        FrmMainMenu parent;
        String profile;
        String curItem;

        public frmCustomerProfile()
        {
            InitializeComponent();
        }

        public frmCustomerProfile(FrmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }



        private void frmListCustomers_Load(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            curItem = listBox1.SelectedItem.ToString();

            

            // Find the string in ListBox2.
            int index = listBox1.FindString(curItem);

            if (index == 0)
            {
                profile = "Mary Doe,\n Killorglin,\n Co Kerry\n" +
                    "\nAccount opened on: 21/11/2016\n\n" +
                    "TicketId\tPurch Date      N1  N2  N3  N4  N5  N6   Prize Amnt" +
                    "\n1827\t12/04/2013      23   11   03   34   11   15    €0" +
                    "\n5421\t09/10/2014      03   05   19   47   38   21    €600" +
                    "\n9290\t02/08/2016      12   23   34   43   21   45    €101" + 
                    "\n\nBalance: €701";

            }
            else if (index == 1)
            {
                profile = "John Doe,\n Killarney,\n Co Kerry\n" +
                    "\nAccount opened on: 21/11/2016\n\n" +
                    "TicketId\tPurch Date      N1  N2  N3  N4  N5  N6   Prize Amnt" +
                    "\n1827\t12/04/2013      23   11   03   34   11   15    €0" +
                    "\n5421\t09/10/2014      03   05   19   47   38   21    €600" +
                    "\n9290\t02/08/2016      12   23   34   43   21   45    €101" +
                    "\n\nBalance: €701";
            }
            else
            {
                profile = "Daveid Doe,\n Glenbeigh,\n Co Kerry\n" +
                    "\nAccount opened on: 21/11/2016\n\n" +
                    "TicketId\tPurch Date      N1  N2  N3  N4  N5  N6   Prize Amnt" +
                    "\n1827\t12/04/2013      23   11   03   34   11   15    €0" +
                    "\n5421\t09/10/2014      03   05   19   47   38   21    €600" +
                    "\n9290\t02/08/2016      12   23   34   43   21   45    €101" +
                    "\n\nBalance: €701";
            }

            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            //if (index == -1)
                //MessageBox.Show("Item is not available in ListBox2");
            ///else
           // {
               // listBox1.SetSelected(index, true);
            //}
                
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if(profile != null)
            {
                MessageBox.Show(profile);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mary Doe, Killorglin, Co Kerry");
            listBox1.Items.Add("John Doe, Killarney, Co Kerry");
            listBox1.Items.Add("Daveid Doe, Glenbeigh, Co Kerry");
        }
    }
}
