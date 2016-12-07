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
            this.prizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payPrizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumberAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.salesAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomerProfile,
            this.salesToolStripMenuItem,
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
            this.listCustomersToolStripMenuItem,
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
            this.mnuCustomerList.Text = "Customer Profile";
            this.mnuCustomerList.Click += new System.EventHandler(this.mnuCustomerList_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellTicketsToolStripMenuItem,
            this.salesAnalysisToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // sellTicketsToolStripMenuItem
            // 
            this.sellTicketsToolStripMenuItem.Name = "sellTicketsToolStripMenuItem";
            this.sellTicketsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sellTicketsToolStripMenuItem.Text = "Sell Tickets";
            this.sellTicketsToolStripMenuItem.Click += new System.EventHandler(this.mnuSellTickets_Click);
            // 
            // prizesToolStripMenuItem
            // 
            this.prizesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runDrawToolStripMenuItem,
            this.payPrizeToolStripMenuItem,
            this.NumberAnalysisToolStripMenuItem});
            this.prizesToolStripMenuItem.Name = "prizesToolStripMenuItem";
            this.prizesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.prizesToolStripMenuItem.Text = "Prizes";
            // 
            // runDrawToolStripMenuItem
            // 
            this.runDrawToolStripMenuItem.Name = "runDrawToolStripMenuItem";
            this.runDrawToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.runDrawToolStripMenuItem.Text = "Run Draw";
            this.runDrawToolStripMenuItem.Click += new System.EventHandler(this.mnuRunDraw_Click);
            // 
            // payPrizeToolStripMenuItem
            // 
            this.payPrizeToolStripMenuItem.Name = "payPrizeToolStripMenuItem";
            this.payPrizeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.payPrizeToolStripMenuItem.Text = "Check Ticket";
            this.payPrizeToolStripMenuItem.Click += new System.EventHandler(this.mnuPayPrize_Click);
            // 
            // NumberAnalysisToolStripMenuItem
            // 
            this.NumberAnalysisToolStripMenuItem.Name = "NumberAnalysisToolStripMenuItem";
            this.NumberAnalysisToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.NumberAnalysisToolStripMenuItem.Text = "Number Analysis";
            this.NumberAnalysisToolStripMenuItem.Click += new System.EventHandler(this.mnuNumberAnalysis_Click);
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
            // salesAnalysisToolStripMenuItem
            // 
            this.salesAnalysisToolStripMenuItem.Name = "salesAnalysisToolStripMenuItem";
            this.salesAnalysisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesAnalysisToolStripMenuItem.Text = "Sales Analysis";
            this.salesAnalysisToolStripMenuItem.Click += new System.EventHandler(this.salesAnalysisToolStripMenuItem_Click);
            // 
            // listCustomersToolStripMenuItem
            // 
            this.listCustomersToolStripMenuItem.Name = "listCustomersToolStripMenuItem";
            this.listCustomersToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.listCustomersToolStripMenuItem.Text = "List Customers";
            this.listCustomersToolStripMenuItem.Click += new System.EventHandler(this.listCustomersToolStripMenuItem_Click);
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
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerProfile;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerReg;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerDeReg;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerList;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStripMenuItem sellTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payPrizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NumberAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCustomersToolStripMenuItem;
    }
}

