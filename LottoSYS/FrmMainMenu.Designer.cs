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
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
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
            // 
            // mnuCustomerList
            // 
            this.mnuCustomerList.Name = "mnuCustomerList";
            this.mnuCustomerList.Size = new System.Drawing.Size(190, 22);
            this.mnuCustomerList.Text = "List Customers";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.financeToolStripMenuItem.Text = "Finance";
            // 
            // prizesToolStripMenuItem
            // 
            this.prizesToolStripMenuItem.Name = "prizesToolStripMenuItem";
            this.prizesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.prizesToolStripMenuItem.Text = "Prizes";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 373);
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
    }
}

