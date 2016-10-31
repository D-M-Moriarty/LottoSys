namespace LottoSYS.Sales
{
    partial class frmSellTicketPayment
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
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtNoOfLines = new System.Windows.Forms.TextBox();
            this.lblNoOfLines = new System.Windows.Forms.Label();
            this.mnuSellTickPayment = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblPrizePayment = new System.Windows.Forms.Label();
            this.grpBankDetails = new System.Windows.Forms.GroupBox();
            this.txtBankAddress = new System.Windows.Forms.TextBox();
            this.lblBankAddress = new System.Windows.Forms.Label();
            this.txtNameBank = new System.Windows.Forms.TextBox();
            this.lblNameBank = new System.Windows.Forms.Label();
            this.tctIBAN = new System.Windows.Forms.TextBox();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.txtBIC = new System.Windows.Forms.TextBox();
            this.lblBIC = new System.Windows.Forms.Label();
            this.rdoCheque = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.rdoDebitCard = new System.Windows.Forms.RadioButton();
            this.rdoForwardAdd = new System.Windows.Forms.RadioButton();
            this.rdoLodged = new System.Windows.Forms.RadioButton();
            this.mnuSellTickPayment.SuspendLayout();
            this.grpBankDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(59, 53);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(46, 16);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "Value:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(116, 49);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 22);
            this.txtValue.TabIndex = 1;
            // 
            // txtNoOfLines
            // 
            this.txtNoOfLines.Location = new System.Drawing.Point(116, 87);
            this.txtNoOfLines.Name = "txtNoOfLines";
            this.txtNoOfLines.Size = new System.Drawing.Size(100, 22);
            this.txtNoOfLines.TabIndex = 3;
            // 
            // lblNoOfLines
            // 
            this.lblNoOfLines.AutoSize = true;
            this.lblNoOfLines.Location = new System.Drawing.Point(25, 93);
            this.lblNoOfLines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfLines.Name = "lblNoOfLines";
            this.lblNoOfLines.Size = new System.Drawing.Size(80, 16);
            this.lblNoOfLines.TabIndex = 2;
            this.lblNoOfLines.Text = "No Of Lines:";
            // 
            // mnuSellTickPayment
            // 
            this.mnuSellTickPayment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuSellTickPayment.Location = new System.Drawing.Point(0, 0);
            this.mnuSellTickPayment.Name = "mnuSellTickPayment";
            this.mnuSellTickPayment.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.mnuSellTickPayment.Size = new System.Drawing.Size(686, 27);
            this.mnuSellTickPayment.TabIndex = 4;
            this.mnuSellTickPayment.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 19);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 19);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(25, 141);
            this.lblMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(128, 16);
            this.lblMethod.TabIndex = 5;
            this.lblMethod.Text = "Method of payment: ";
            // 
            // lblPrizePayment
            // 
            this.lblPrizePayment.AutoSize = true;
            this.lblPrizePayment.Location = new System.Drawing.Point(365, 49);
            this.lblPrizePayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrizePayment.Name = "lblPrizePayment";
            this.lblPrizePayment.Size = new System.Drawing.Size(142, 16);
            this.lblPrizePayment.TabIndex = 9;
            this.lblPrizePayment.Text = "Prize Payment Option: ";
            // 
            // grpBankDetails
            // 
            this.grpBankDetails.Controls.Add(this.txtBankAddress);
            this.grpBankDetails.Controls.Add(this.lblBankAddress);
            this.grpBankDetails.Controls.Add(this.txtNameBank);
            this.grpBankDetails.Controls.Add(this.lblNameBank);
            this.grpBankDetails.Controls.Add(this.tctIBAN);
            this.grpBankDetails.Controls.Add(this.lblIBAN);
            this.grpBankDetails.Controls.Add(this.txtBIC);
            this.grpBankDetails.Controls.Add(this.lblBIC);
            this.grpBankDetails.Location = new System.Drawing.Point(291, 156);
            this.grpBankDetails.Name = "grpBankDetails";
            this.grpBankDetails.Size = new System.Drawing.Size(383, 205);
            this.grpBankDetails.TabIndex = 12;
            this.grpBankDetails.TabStop = false;
            this.grpBankDetails.Text = "Bank Details";
            // 
            // txtBankAddress
            // 
            this.txtBankAddress.Location = new System.Drawing.Point(149, 148);
            this.txtBankAddress.Name = "txtBankAddress";
            this.txtBankAddress.Size = new System.Drawing.Size(214, 22);
            this.txtBankAddress.TabIndex = 11;
            // 
            // lblBankAddress
            // 
            this.lblBankAddress.AutoSize = true;
            this.lblBankAddress.Location = new System.Drawing.Point(46, 153);
            this.lblBankAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBankAddress.Name = "lblBankAddress";
            this.lblBankAddress.Size = new System.Drawing.Size(96, 16);
            this.lblBankAddress.TabIndex = 10;
            this.lblBankAddress.Text = "Bank Address:";
            // 
            // txtNameBank
            // 
            this.txtNameBank.Location = new System.Drawing.Point(149, 110);
            this.txtNameBank.Name = "txtNameBank";
            this.txtNameBank.Size = new System.Drawing.Size(214, 22);
            this.txtNameBank.TabIndex = 9;
            // 
            // lblNameBank
            // 
            this.lblNameBank.AutoSize = true;
            this.lblNameBank.Location = new System.Drawing.Point(46, 113);
            this.lblNameBank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameBank.Name = "lblNameBank";
            this.lblNameBank.Size = new System.Drawing.Size(96, 16);
            this.lblNameBank.TabIndex = 8;
            this.lblNameBank.Text = "Name of Bank:";
            // 
            // tctIBAN
            // 
            this.tctIBAN.Location = new System.Drawing.Point(149, 73);
            this.tctIBAN.Name = "tctIBAN";
            this.tctIBAN.Size = new System.Drawing.Size(214, 22);
            this.tctIBAN.TabIndex = 7;
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(100, 78);
            this.lblIBAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(42, 16);
            this.lblIBAN.TabIndex = 6;
            this.lblIBAN.Text = "IBAN:";
            // 
            // txtBIC
            // 
            this.txtBIC.Location = new System.Drawing.Point(149, 35);
            this.txtBIC.Name = "txtBIC";
            this.txtBIC.Size = new System.Drawing.Size(214, 22);
            this.txtBIC.TabIndex = 5;
            // 
            // lblBIC
            // 
            this.lblBIC.AutoSize = true;
            this.lblBIC.Location = new System.Drawing.Point(110, 38);
            this.lblBIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBIC.Name = "lblBIC";
            this.lblBIC.Size = new System.Drawing.Size(32, 16);
            this.lblBIC.TabIndex = 4;
            this.lblBIC.Text = "BIC:";
            // 
            // rdoCheque
            // 
            this.rdoCheque.AutoSize = true;
            this.rdoCheque.Location = new System.Drawing.Point(160, 141);
            this.rdoCheque.Name = "rdoCheque";
            this.rdoCheque.Size = new System.Drawing.Size(73, 20);
            this.rdoCheque.TabIndex = 13;
            this.rdoCheque.TabStop = true;
            this.rdoCheque.Text = "Cheque";
            this.rdoCheque.UseVisualStyleBackColor = true;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(161, 167);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(57, 20);
            this.rdoCash.TabIndex = 14;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // rdoDebitCard
            // 
            this.rdoDebitCard.AutoSize = true;
            this.rdoDebitCard.Location = new System.Drawing.Point(161, 193);
            this.rdoDebitCard.Name = "rdoDebitCard";
            this.rdoDebitCard.Size = new System.Drawing.Size(90, 20);
            this.rdoDebitCard.TabIndex = 15;
            this.rdoDebitCard.TabStop = true;
            this.rdoDebitCard.Text = "Debit Card";
            this.rdoDebitCard.UseVisualStyleBackColor = true;
            // 
            // rdoForwardAdd
            // 
            this.rdoForwardAdd.AutoSize = true;
            this.rdoForwardAdd.Location = new System.Drawing.Point(514, 43);
            this.rdoForwardAdd.Name = "rdoForwardAdd";
            this.rdoForwardAdd.Size = new System.Drawing.Size(140, 36);
            this.rdoForwardAdd.TabIndex = 17;
            this.rdoForwardAdd.TabStop = true;
            this.rdoForwardAdd.Text = "Prize forwarded to\r\nregistered address\r\n";
            this.rdoForwardAdd.UseVisualStyleBackColor = true;
            this.rdoForwardAdd.CheckedChanged += new System.EventHandler(this.rdoForwardAdd_CheckedChanged);
            // 
            // rdoLodged
            // 
            this.rdoLodged.AutoSize = true;
            this.rdoLodged.Location = new System.Drawing.Point(514, 85);
            this.rdoLodged.Name = "rdoLodged";
            this.rdoLodged.Size = new System.Drawing.Size(107, 36);
            this.rdoLodged.TabIndex = 16;
            this.rdoLodged.TabStop = true;
            this.rdoLodged.Text = "Lodged in \r\nbank Account";
            this.rdoLodged.UseVisualStyleBackColor = true;
            this.rdoLodged.CheckedChanged += new System.EventHandler(this.rdoLodged_CheckedChanged);
            // 
            // frmSellTicketPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 440);
            this.Controls.Add(this.rdoForwardAdd);
            this.Controls.Add(this.rdoLodged);
            this.Controls.Add(this.rdoDebitCard);
            this.Controls.Add(this.rdoCash);
            this.Controls.Add(this.rdoCheque);
            this.Controls.Add(this.grpBankDetails);
            this.Controls.Add(this.lblPrizePayment);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.mnuSellTickPayment);
            this.Controls.Add(this.txtNoOfLines);
            this.Controls.Add(this.lblNoOfLines);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblValue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSellTicketPayment";
            this.Text = "SellTicketPaymentForm";
            this.Load += new System.EventHandler(this.SellTicketPaymentForm_Load);
            this.mnuSellTickPayment.ResumeLayout(false);
            this.mnuSellTickPayment.PerformLayout();
            this.grpBankDetails.ResumeLayout(false);
            this.grpBankDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtNoOfLines;
        private System.Windows.Forms.Label lblNoOfLines;
        private System.Windows.Forms.MenuStrip mnuSellTickPayment;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblPrizePayment;
        private System.Windows.Forms.GroupBox grpBankDetails;
        private System.Windows.Forms.RadioButton rdoCheque;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton rdoDebitCard;
        private System.Windows.Forms.RadioButton rdoForwardAdd;
        private System.Windows.Forms.RadioButton rdoLodged;
        private System.Windows.Forms.TextBox txtBankAddress;
        private System.Windows.Forms.Label lblBankAddress;
        private System.Windows.Forms.TextBox txtNameBank;
        private System.Windows.Forms.Label lblNameBank;
        private System.Windows.Forms.TextBox tctIBAN;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.TextBox txtBIC;
        private System.Windows.Forms.Label lblBIC;
    }
}