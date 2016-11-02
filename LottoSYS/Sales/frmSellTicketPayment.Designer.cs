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
            this.grpCardDetails = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.llblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.mnuSellTickPayment.SuspendLayout();
            this.grpBankDetails.SuspendLayout();
            this.grpCardDetails.SuspendLayout();
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
            this.grpBankDetails.Location = new System.Drawing.Point(329, 229);
            this.grpBankDetails.Name = "grpBankDetails";
            this.grpBankDetails.Size = new System.Drawing.Size(345, 186);
            this.grpBankDetails.TabIndex = 12;
            this.grpBankDetails.TabStop = false;
            this.grpBankDetails.Text = "Bank Details";
            // 
            // txtBankAddress
            // 
            this.txtBankAddress.Location = new System.Drawing.Point(111, 144);
            this.txtBankAddress.Name = "txtBankAddress";
            this.txtBankAddress.Size = new System.Drawing.Size(214, 22);
            this.txtBankAddress.TabIndex = 11;
            // 
            // lblBankAddress
            // 
            this.lblBankAddress.AutoSize = true;
            this.lblBankAddress.Location = new System.Drawing.Point(8, 149);
            this.lblBankAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBankAddress.Name = "lblBankAddress";
            this.lblBankAddress.Size = new System.Drawing.Size(96, 16);
            this.lblBankAddress.TabIndex = 10;
            this.lblBankAddress.Text = "Bank Address:";
            // 
            // txtNameBank
            // 
            this.txtNameBank.Location = new System.Drawing.Point(111, 106);
            this.txtNameBank.Name = "txtNameBank";
            this.txtNameBank.Size = new System.Drawing.Size(214, 22);
            this.txtNameBank.TabIndex = 9;
            // 
            // lblNameBank
            // 
            this.lblNameBank.AutoSize = true;
            this.lblNameBank.Location = new System.Drawing.Point(8, 109);
            this.lblNameBank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameBank.Name = "lblNameBank";
            this.lblNameBank.Size = new System.Drawing.Size(96, 16);
            this.lblNameBank.TabIndex = 8;
            this.lblNameBank.Text = "Name of Bank:";
            // 
            // tctIBAN
            // 
            this.tctIBAN.Location = new System.Drawing.Point(111, 69);
            this.tctIBAN.Name = "tctIBAN";
            this.tctIBAN.Size = new System.Drawing.Size(214, 22);
            this.tctIBAN.TabIndex = 7;
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(62, 74);
            this.lblIBAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(42, 16);
            this.lblIBAN.TabIndex = 6;
            this.lblIBAN.Text = "IBAN:";
            // 
            // txtBIC
            // 
            this.txtBIC.Location = new System.Drawing.Point(111, 31);
            this.txtBIC.Name = "txtBIC";
            this.txtBIC.Size = new System.Drawing.Size(214, 22);
            this.txtBIC.TabIndex = 5;
            // 
            // lblBIC
            // 
            this.lblBIC.AutoSize = true;
            this.lblBIC.Location = new System.Drawing.Point(72, 34);
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
            this.rdoCheque.CheckedChanged += new System.EventHandler(this.rdoCheque_CheckedChanged);
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
            this.rdoCash.CheckedChanged += new System.EventHandler(this.rdoCash_CheckedChanged);
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
            this.rdoDebitCard.CheckedChanged += new System.EventHandler(this.rdoDebitCard_CheckedChanged);
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
            // grpCardDetails
            // 
            this.grpCardDetails.Controls.Add(this.llblType);
            this.grpCardDetails.Controls.Add(this.cboType);
            this.grpCardDetails.Controls.Add(this.lblMonth);
            this.grpCardDetails.Controls.Add(this.cboMonth);
            this.grpCardDetails.Controls.Add(this.lblYear);
            this.grpCardDetails.Controls.Add(this.cboYear);
            this.grpCardDetails.Controls.Add(this.textBox1);
            this.grpCardDetails.Controls.Add(this.lblCardNo);
            this.grpCardDetails.Controls.Add(this.textBox2);
            this.grpCardDetails.Controls.Add(this.lblName);
            this.grpCardDetails.Location = new System.Drawing.Point(28, 229);
            this.grpCardDetails.Name = "grpCardDetails";
            this.grpCardDetails.Size = new System.Drawing.Size(295, 186);
            this.grpCardDetails.TabIndex = 18;
            this.grpCardDetails.TabStop = false;
            this.grpCardDetails.Text = "Card Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 11;
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(47, 77);
            this.lblCardNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(61, 16);
            this.lblCardNo.TabIndex = 10;
            this.lblCardNo.Text = "Card No:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 37);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 116);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(48, 16);
            this.lblYear.TabIndex = 20;
            this.lblYear.Text = "Year: *";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(59, 108);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(82, 24);
            this.cboYear.TabIndex = 19;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(148, 116);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(55, 16);
            this.lblMonth.TabIndex = 22;
            this.lblMonth.Text = "Month: *";
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(209, 108);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(80, 24);
            this.cboMonth.TabIndex = 21;
            // 
            // llblType
            // 
            this.llblType.AutoSize = true;
            this.llblType.Location = new System.Drawing.Point(6, 164);
            this.llblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblType.Name = "llblType";
            this.llblType.Size = new System.Drawing.Size(51, 16);
            this.llblType.TabIndex = 24;
            this.llblType.Text = "Type: *";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(59, 156);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(82, 24);
            this.cboType.TabIndex = 23;
            // 
            // frmSellTicketPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 440);
            this.Controls.Add(this.grpCardDetails);
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
            this.grpCardDetails.ResumeLayout(false);
            this.grpCardDetails.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpCardDetails;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label llblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
    }
}