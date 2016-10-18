namespace LottoSYS
{
    partial class frmCustomerReg
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
            this.mnuCustomerReg = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpPersonalDetails = new System.Windows.Forms.GroupBox();
            this.cboNationality = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.txtPPSN = new System.Windows.Forms.TextBox();
            this.lblPPSN = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grpOptional = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.mnuCustomerReg.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpPersonalDetails.SuspendLayout();
            this.grpOptional.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCustomerReg
            // 
            this.mnuCustomerReg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.exitToolStripMenuItem});
            this.mnuCustomerReg.Location = new System.Drawing.Point(0, 0);
            this.mnuCustomerReg.Name = "mnuCustomerReg";
            this.mnuCustomerReg.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuCustomerReg.Size = new System.Drawing.Size(781, 24);
            this.mnuCustomerReg.TabIndex = 0;
            this.mnuCustomerReg.Text = "RegisterCustomer";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.mnuExit);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnSubmit);
            this.grpInfo.Location = new System.Drawing.Point(517, 459);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(212, 126);
            this.grpInfo.TabIndex = 30;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Fields marked with * Must be completed";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(61, 79);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 39);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // grpPersonalDetails
            // 
            this.grpPersonalDetails.Controls.Add(this.cboNationality);
            this.grpPersonalDetails.Controls.Add(this.lblNationality);
            this.grpPersonalDetails.Controls.Add(this.lblDOB);
            this.grpPersonalDetails.Controls.Add(this.dtpDOB);
            this.grpPersonalDetails.Controls.Add(this.lblTitle);
            this.grpPersonalDetails.Controls.Add(this.cboTitle);
            this.grpPersonalDetails.Controls.Add(this.txtPPSN);
            this.grpPersonalDetails.Controls.Add(this.lblPPSN);
            this.grpPersonalDetails.Controls.Add(this.txtForename);
            this.grpPersonalDetails.Controls.Add(this.lblForename);
            this.grpPersonalDetails.Controls.Add(this.txtSurname);
            this.grpPersonalDetails.Controls.Add(this.lblSurname);
            this.grpPersonalDetails.Location = new System.Drawing.Point(16, 96);
            this.grpPersonalDetails.Name = "grpPersonalDetails";
            this.grpPersonalDetails.Size = new System.Drawing.Size(336, 276);
            this.grpPersonalDetails.TabIndex = 33;
            this.grpPersonalDetails.TabStop = false;
            this.grpPersonalDetails.Text = "Personal Details";
            // 
            // cboNationality
            // 
            this.cboNationality.FormattingEnabled = true;
            this.cboNationality.Location = new System.Drawing.Point(125, 220);
            this.cboNationality.Name = "cboNationality";
            this.cboNationality.Size = new System.Drawing.Size(136, 24);
            this.cboNationality.TabIndex = 6;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(35, 228);
            this.lblNationality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(82, 16);
            this.lblNationality.TabIndex = 34;
            this.lblNationality.Text = "Nationality: *";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(69, 157);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(48, 16);
            this.lblDOB.TabIndex = 20;
            this.lblDOB.Text = "DOB: *";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(125, 151);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(136, 22);
            this.dtpDOB.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(72, 44);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 16);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Title: *";
            // 
            // cboTitle
            // 
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(125, 36);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(66, 24);
            this.cboTitle.TabIndex = 1;
            // 
            // txtPPSN
            // 
            this.txtPPSN.Location = new System.Drawing.Point(125, 192);
            this.txtPPSN.Name = "txtPPSN";
            this.txtPPSN.Size = new System.Drawing.Size(136, 22);
            this.txtPPSN.TabIndex = 5;
            // 
            // lblPPSN
            // 
            this.lblPPSN.AutoSize = true;
            this.lblPPSN.Location = new System.Drawing.Point(61, 198);
            this.lblPPSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPPSN.Name = "lblPPSN";
            this.lblPPSN.Size = new System.Drawing.Size(56, 16);
            this.lblPPSN.TabIndex = 15;
            this.lblPPSN.Text = "PPSN: *";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(125, 113);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(136, 22);
            this.txtForename.TabIndex = 3;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(36, 119);
            this.lblForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(81, 16);
            this.lblForename.TabIndex = 13;
            this.lblForename.Text = "Forename: *";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(125, 76);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(136, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(44, 82);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(73, 16);
            this.lblSurname.TabIndex = 11;
            this.lblSurname.Text = "Surname: *";
            // 
            // grpOptional
            // 
            this.grpOptional.Controls.Add(this.txtEmail);
            this.grpOptional.Controls.Add(this.lblEmail);
            this.grpOptional.Controls.Add(this.txtPhone);
            this.grpOptional.Controls.Add(this.lblPhone);
            this.grpOptional.Controls.Add(this.cboGender);
            this.grpOptional.Controls.Add(this.lblGender);
            this.grpOptional.Location = new System.Drawing.Point(16, 398);
            this.grpOptional.Name = "grpOptional";
            this.grpOptional.Size = new System.Drawing.Size(279, 187);
            this.grpOptional.TabIndex = 34;
            this.grpOptional.TabStop = false;
            this.grpOptional.Text = "Optional Details";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(70, 140);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(125, 93);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(136, 22);
            this.txtPhone.TabIndex = 13;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(44, 99);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(71, 16);
            this.lblPhone.TabIndex = 32;
            this.lblPhone.Text = "Phone no.:";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(125, 53);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(136, 24);
            this.cboGender.TabIndex = 12;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(62, 61);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 16);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Gender:";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.cboCountry);
            this.grpAddress.Controls.Add(this.lblCountry);
            this.grpAddress.Controls.Add(this.cboCounty);
            this.grpAddress.Controls.Add(this.lblCounty);
            this.grpAddress.Controls.Add(this.txtTown);
            this.grpAddress.Controls.Add(this.lblTown);
            this.grpAddress.Controls.Add(this.txtAddress2);
            this.grpAddress.Controls.Add(this.lblAddressLine2);
            this.grpAddress.Controls.Add(this.txtAddress1);
            this.grpAddress.Controls.Add(this.lblAddressLine1);
            this.grpAddress.Location = new System.Drawing.Point(393, 96);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(336, 276);
            this.grpAddress.TabIndex = 35;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address Details";
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(166, 212);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(136, 24);
            this.cboCountry.TabIndex = 11;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(11, 220);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(147, 16);
            this.lblCountry.TabIndex = 30;
            this.lblCountry.Text = "Country of Residence: *";
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(166, 170);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(136, 24);
            this.cboCounty.TabIndex = 10;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(98, 178);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(60, 16);
            this.lblCounty.TabIndex = 28;
            this.lblCounty.Text = "County: *";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(166, 134);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(136, 22);
            this.txtTown.TabIndex = 9;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(106, 140);
            this.lblTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(52, 16);
            this.lblTown.TabIndex = 26;
            this.lblTown.Text = "Town: *";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(166, 95);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(136, 22);
            this.txtAddress2.TabIndex = 8;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(50, 101);
            this.lblAddressLine2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(108, 16);
            this.lblAddressLine2.TabIndex = 24;
            this.lblAddressLine2.Text = "Address Line 2: *";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(166, 57);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(136, 22);
            this.txtAddress1.TabIndex = 7;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(50, 63);
            this.lblAddressLine1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(108, 16);
            this.lblAddressLine1.TabIndex = 22;
            this.lblAddressLine1.Text = "Address Line 1: *";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(10, 39);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(357, 31);
            this.lblHeading.TabIndex = 36;
            this.lblHeading.Text = "Enter New Customer Details";
            // 
            // frmCustomerReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 611);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpOptional);
            this.Controls.Add(this.grpPersonalDetails);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.mnuCustomerReg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuCustomerReg;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerReg";
            this.Text = "frmCustomerReg";
            this.Load += new System.EventHandler(this.frmCustomerReg_Load);
            this.Click += new System.EventHandler(this.frmCustomerReg_Click);
            this.mnuCustomerReg.ResumeLayout(false);
            this.mnuCustomerReg.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpPersonalDetails.ResumeLayout(false);
            this.grpPersonalDetails.PerformLayout();
            this.grpOptional.ResumeLayout(false);
            this.grpOptional.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCustomerReg;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpPersonalDetails;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.TextBox txtPPSN;
        private System.Windows.Forms.Label lblPPSN;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.ComboBox cboNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.GroupBox grpOptional;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblHeading;
    }
}