namespace LottoSYS
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuCustomerProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerDeReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmRevenueReport = new System.Windows.Forms.ToolStripMenuItem();
            this.transToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listWinningTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payPrizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listUnclaimedPrizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomerProfile,
            this.salesToolStripMenuItem,
            this.financeToolStripMenuItem,
            this.prizesToolStripMenuItem,
            this.mnuExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(575, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuCustomerProfile
            // 
            this.mnuCustomerProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomerReg,
            this.mnuCustomerUpdate,
            this.mnuCustomerDeReg,
            this.mnuCustomerList});
            this.mnuCustomerProfile.Name = "mnuCustomerProfile";
            this.mnuCustomerProfile.Size = new System.Drawing.Size(76, 20);
            this.mnuCustomerProfile.Text = "Customers";
            // 
            // mnuCustomerReg
            // 
            this.mnuCustomerReg.Name = "mnuCustomerReg";
            this.mnuCustomerReg.Size = new System.Drawing.Size(190, 22);
            this.mnuCustomerReg.Text = "Register Customer";
            this.mnuCustomerReg.Click += new System.EventHandler(this.mnuCustomerReg_Click);
            // 
            // mnuCustomerUpdate
            // 
            this.mnuCustomerUpdate.Name = "mnuCustomerUpdate";
            this.mnuCustomerUpdate.Size = new System.Drawing.Size(190, 22);
            this.mnuCustomerUpdate.Text = "Update Customer";
            this.mnuCustomerUpdate.Click += new System.EventHandler(this.mnuCustomerUpdate_Click);
            // 
            // mnuCustomerDeReg
            // 
            this.mnuCustomerDeReg.Name = "mnuCustomerDeReg";
            this.mnuCustomerDeReg.Size = new System.Drawing.Size(190, 22);
            this.mnuCustomerDeReg.Text = "De-Register Customer";
            this.mnuCustomerDeReg.Click += new System.EventHandler(this.mnuCustomerDeReg_Click);
            // 
            // mnuCustomerList
            // 
            this.mnuCustomerList.Name = "mnuCustomerList";
            this.mnuCustomerList.Size = new System.Drawing.Size(190, 22);
            this.mnuCustomerList.Text = "List Customers";
            this.mnuCustomerList.Click += new System.EventHandler(this.mnuCustomerList_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellTicketsToolStripMenuItem,
            this.cashTicketToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // sellTicketsToolStripMenuItem
            // 
            this.sellTicketsToolStripMenuItem.Name = "sellTicketsToolStripMenuItem";
            this.sellTicketsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sellTicketsToolStripMenuItem.Text = "Sell Tickets";
            this.sellTicketsToolStripMenuItem.Click += new System.EventHandler(this.mnuSellTickets_Click);
            // 
            // cashTicketToolStripMenuItem
            // 
            this.cashTicketToolStripMenuItem.Name = "cashTicketToolStripMenuItem";
            this.cashTicketToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cashTicketToolStripMenuItem.Text = "Cash Ticket";
            this.cashTicketToolStripMenuItem.Click += new System.EventHandler(this.mnuCashTicket_Click);
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmRevenueReport,
            this.transToolStripMenuItem});
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.financeToolStripMenuItem.Text = "Finance";
            // 
            // frmRevenueReport
            // 
            this.frmRevenueReport.Name = "frmRevenueReport";
            this.frmRevenueReport.Size = new System.Drawing.Size(157, 22);
            this.frmRevenueReport.Text = "Revenue Report";
            this.frmRevenueReport.Click += new System.EventHandler(this.mnuRevenueReport_Click);
            // 
            // transToolStripMenuItem
            // 
            this.transToolStripMenuItem.Name = "transToolStripMenuItem";
            this.transToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.transToolStripMenuItem.Text = "Trans";
            // 
            // prizesToolStripMenuItem
            // 
            this.prizesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runDrawToolStripMenuItem,
            this.listWinningTicketsToolStripMenuItem,
            this.payPrizeToolStripMenuItem,
            this.listUnclaimedPrizesToolStripMenuItem});
            this.prizesToolStripMenuItem.Name = "prizesToolStripMenuItem";
            this.prizesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.prizesToolStripMenuItem.Text = "Prizes";
            // 
            // runDrawToolStripMenuItem
            // 
            this.runDrawToolStripMenuItem.Name = "runDrawToolStripMenuItem";
            this.runDrawToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.runDrawToolStripMenuItem.Text = "Run Draw";
            // 
            // listWinningTicketsToolStripMenuItem
            // 
            this.listWinningTicketsToolStripMenuItem.Name = "listWinningTicketsToolStripMenuItem";
            this.listWinningTicketsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listWinningTicketsToolStripMenuItem.Text = "List Winning Tickets";
            // 
            // payPrizeToolStripMenuItem
            // 
            this.payPrizeToolStripMenuItem.Name = "payPrizeToolStripMenuItem";
            this.payPrizeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.payPrizeToolStripMenuItem.Text = "Pay Prize";
            // 
            // listUnclaimedPrizesToolStripMenuItem
            // 
            this.listUnclaimedPrizesToolStripMenuItem.Name = "listUnclaimedPrizesToolStripMenuItem";
            this.listUnclaimedPrizesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listUnclaimedPrizesToolStripMenuItem.Text = "List Unclaimed Prizes";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(162, 169);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(222, 29);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Lotto System Home";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 373);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "FrmMainMenu";
            this.Text = "LottoSYS - Main Menu";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerProfile;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerReg;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerDeReg;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerList;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStripMenuItem sellTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmRevenueReport;
        private System.Windows.Forms.ToolStripMenuItem transToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listWinningTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payPrizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listUnclaimedPrizesToolStripMenuItem;
    }
}

