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
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtPPSN = new System.Windows.Forms.TextBox();
            this.lblPPSN = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cboNationality = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.mnuCustomerReg.SuspendLayout();
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
            this.mnuCustomerReg.Size = new System.Drawing.Size(704, 24);
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
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(94, 88);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(73, 16);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname: *";
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(175, 82);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(136, 22);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(175, 119);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(136, 22);
            this.txtForename.TabIndex = 4;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(86, 125);
            this.lblForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(81, 16);
            this.lblForename.TabIndex = 3;
            this.lblForename.Text = "Forename: *";
            // 
            // txtPPSN
            // 
            this.txtPPSN.Location = new System.Drawing.Point(175, 198);
            this.txtPPSN.Name = "txtPPSN";
            this.txtPPSN.Size = new System.Drawing.Size(136, 22);
            this.txtPPSN.TabIndex = 6;
            // 
            // lblPPSN
            // 
            this.lblPPSN.AutoSize = true;
            this.lblPPSN.Location = new System.Drawing.Point(111, 204);
            this.lblPPSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPPSN.Name = "lblPPSN";
            this.lblPPSN.Size = new System.Drawing.Size(56, 16);
            this.lblPPSN.TabIndex = 5;
            this.lblPPSN.Text = "PPSN: *";
            // 
            // cboTitle
            // 
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(175, 42);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(66, 24);
            this.cboTitle.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(122, 50);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 16);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title: *";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(175, 157);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(136, 22);
            this.dtpDOB.TabIndex = 9;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(119, 163);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(48, 16);
            this.lblDOB.TabIndex = 10;
            this.lblDOB.Text = "DOB: *";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(175, 239);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(136, 22);
            this.txtAddress1.TabIndex = 12;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(59, 245);
            this.lblAddressLine1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(108, 16);
            this.lblAddressLine1.TabIndex = 11;
            this.lblAddressLine1.Text = "Address Line 1: *";
            this.lblAddressLine1.Click += new System.EventHandler(this.lblAddressLine1_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(175, 277);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(136, 22);
            this.txtAddress2.TabIndex = 14;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(59, 283);
            this.lblAddressLine2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(108, 16);
            this.lblAddressLine2.TabIndex = 13;
            this.lblAddressLine2.Text = "Address Line 2: *";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(175, 316);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(136, 22);
            this.txtTown.TabIndex = 16;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(115, 322);
            this.lblTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(52, 16);
            this.lblTown.TabIndex = 15;
            this.lblTown.Text = "Town: *";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(107, 360);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(60, 16);
            this.lblCounty.TabIndex = 17;
            this.lblCounty.Text = "County: *";
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(175, 352);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(136, 24);
            this.cboCounty.TabIndex = 19;
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(175, 394);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(136, 24);
            this.cboCountry.TabIndex = 21;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(20, 402);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(147, 16);
            this.lblCountry.TabIndex = 20;
            this.lblCountry.Text = "Country of Residence: *";
            // 
            // cboNationality
            // 
            this.cboNationality.FormattingEnabled = true;
            this.cboNationality.Location = new System.Drawing.Point(422, 80);
            this.cboNationality.Name = "cboNationality";
            this.cboNationality.Size = new System.Drawing.Size(136, 24);
            this.cboNationality.TabIndex = 23;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(341, 88);
            this.lblNationality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(82, 16);
            this.lblNationality.TabIndex = 22;
            this.lblNationality.Text = "Nationality: *";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(422, 117);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(136, 24);
            this.cboGender.TabIndex = 25;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(359, 125);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 16);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Gender:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(422, 157);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(136, 22);
            this.txtPhone.TabIndex = 27;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(341, 163);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(71, 16);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Phone no.:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(422, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 22);
            this.txtEmail.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(367, 204);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email:";
            // 
            // grpInfo
            // 
            this.grpInfo.Location = new System.Drawing.Point(422, 292);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(212, 126);
            this.grpInfo.TabIndex = 30;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Fields marked with * Must be completed";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(422, 438);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 39);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmCustomerReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 550);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cboNationality);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cboCounty);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cboTitle);
            this.Controls.Add(this.txtPPSN);
            this.Controls.Add(this.lblPPSN);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCustomerReg;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtPPSN;
        private System.Windows.Forms.Label lblPPSN;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cboNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnSubmit;
    }
}