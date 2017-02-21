namespace LottoSYS
{
    partial class frmCustomerUpdate
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
            this.mnuUpdateCustomer = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpUpdateBox = new System.Windows.Forms.GroupBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboNationality = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPPSN = new System.Windows.Forms.TextBox();
            this.lblPPSN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.tbnSubmit = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
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
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.grdUpdate = new System.Windows.Forms.DataGridView();
            this.mnuUpdateCustomer.SuspendLayout();
            this.grpUpdateBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuUpdateCustomer.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(792, 24);
            this.mnuUpdateCustomer.TabIndex = 0;
            this.mnuUpdateCustomer.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(49, 106);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 15);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Surname:";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(126, 101);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(100, 20);
            this.txtSearchBox.TabIndex = 2;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(252, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpUpdateBox
            // 
            this.grpUpdateBox.Controls.Add(this.cboGender);
            this.grpUpdateBox.Controls.Add(this.lblGender);
            this.grpUpdateBox.Controls.Add(this.cboNationality);
            this.grpUpdateBox.Controls.Add(this.lblNationality);
            this.grpUpdateBox.Controls.Add(this.lblDOB);
            this.grpUpdateBox.Controls.Add(this.dtpDOB);
            this.grpUpdateBox.Controls.Add(this.txtPPSN);
            this.grpUpdateBox.Controls.Add(this.lblPPSN);
            this.grpUpdateBox.Controls.Add(this.lblTitle);
            this.grpUpdateBox.Controls.Add(this.cboTitle);
            this.grpUpdateBox.Controls.Add(this.tbnSubmit);
            this.grpUpdateBox.Controls.Add(this.txtEmail);
            this.grpUpdateBox.Controls.Add(this.lblEmail);
            this.grpUpdateBox.Controls.Add(this.txtPhone);
            this.grpUpdateBox.Controls.Add(this.lblPhone);
            this.grpUpdateBox.Controls.Add(this.txtForename);
            this.grpUpdateBox.Controls.Add(this.lblForename);
            this.grpUpdateBox.Controls.Add(this.txtSurname);
            this.grpUpdateBox.Controls.Add(this.lblSurname);
            this.grpUpdateBox.Controls.Add(this.cboCountry);
            this.grpUpdateBox.Controls.Add(this.lblCountry);
            this.grpUpdateBox.Controls.Add(this.cboCounty);
            this.grpUpdateBox.Controls.Add(this.lblCounty);
            this.grpUpdateBox.Controls.Add(this.txtTown);
            this.grpUpdateBox.Controls.Add(this.lblTown);
            this.grpUpdateBox.Controls.Add(this.txtAddress2);
            this.grpUpdateBox.Controls.Add(this.lblAddressLine2);
            this.grpUpdateBox.Controls.Add(this.txtAddress1);
            this.grpUpdateBox.Controls.Add(this.lblAddressLine1);
            this.grpUpdateBox.Location = new System.Drawing.Point(43, 199);
            this.grpUpdateBox.Name = "grpUpdateBox";
            this.grpUpdateBox.Size = new System.Drawing.Size(719, 334);
            this.grpUpdateBox.TabIndex = 42;
            this.grpUpdateBox.TabStop = false;
            this.grpUpdateBox.Text = "Update Details";
            this.grpUpdateBox.Enter += new System.EventHandler(this.grpUpdateBox_Enter);
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(167, 235);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(136, 21);
            this.cboGender.TabIndex = 68;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(104, 243);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 71;
            this.lblGender.Text = "Gender:";
            // 
            // cboNationality
            // 
            this.cboNationality.FormattingEnabled = true;
            this.cboNationality.Location = new System.Drawing.Point(167, 199);
            this.cboNationality.Name = "cboNationality";
            this.cboNationality.Size = new System.Drawing.Size(136, 21);
            this.cboNationality.TabIndex = 64;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(77, 207);
            this.lblNationality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(66, 13);
            this.lblNationality.TabIndex = 67;
            this.lblNationality.Text = "Nationality: *";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(111, 136);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(40, 13);
            this.lblDOB.TabIndex = 66;
            this.lblDOB.Text = "DOB: *";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(167, 130);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(136, 20);
            this.dtpDOB.TabIndex = 62;
            // 
            // txtPPSN
            // 
            this.txtPPSN.Location = new System.Drawing.Point(167, 166);
            this.txtPPSN.Name = "txtPPSN";
            this.txtPPSN.Size = new System.Drawing.Size(136, 20);
            this.txtPPSN.TabIndex = 63;
            // 
            // lblPPSN
            // 
            this.lblPPSN.AutoSize = true;
            this.lblPPSN.Location = new System.Drawing.Point(103, 172);
            this.lblPPSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPPSN.Name = "lblPPSN";
            this.lblPPSN.Size = new System.Drawing.Size(46, 13);
            this.lblPPSN.TabIndex = 65;
            this.lblPPSN.Text = "PPSN: *";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(114, 42);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 13);
            this.lblTitle.TabIndex = 61;
            this.lblTitle.Text = "Title: *";
            // 
            // cboTitle
            // 
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(167, 34);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(66, 21);
            this.cboTitle.TabIndex = 60;
            // 
            // tbnSubmit
            // 
            this.tbnSubmit.Location = new System.Drawing.Point(534, 270);
            this.tbnSubmit.Name = "tbnSubmit";
            this.tbnSubmit.Size = new System.Drawing.Size(75, 23);
            this.tbnSubmit.TabIndex = 45;
            this.tbnSubmit.Text = "Submit";
            this.tbnSubmit.UseVisualStyleBackColor = true;
            this.tbnSubmit.Click += new System.EventHandler(this.tbnSubmit_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(167, 272);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 21);
            this.txtEmail.TabIndex = 59;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(112, 278);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 58;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(473, 224);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(136, 21);
            this.txtPhone.TabIndex = 57;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(392, 230);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 15);
            this.lblPhone.TabIndex = 56;
            this.lblPhone.Text = "Phone no.:";
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(167, 98);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(136, 21);
            this.txtForename.TabIndex = 55;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(80, 104);
            this.lblForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(75, 15);
            this.lblForename.TabIndex = 54;
            this.lblForename.Text = "Forename: *";
            this.lblForename.Click += new System.EventHandler(this.lblForename_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(167, 61);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(136, 21);
            this.txtSurname.TabIndex = 53;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(86, 67);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 15);
            this.lblSurname.TabIndex = 52;
            this.lblSurname.Text = "Surname: *";
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(473, 186);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(136, 21);
            this.cboCountry.TabIndex = 51;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(327, 192);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(134, 15);
            this.lblCountry.TabIndex = 50;
            this.lblCountry.Text = "Country of Residence: *";
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(473, 146);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(136, 21);
            this.cboCounty.TabIndex = 49;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(406, 152);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(55, 15);
            this.lblCounty.TabIndex = 48;
            this.lblCounty.Text = "County: *";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(473, 112);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(136, 20);
            this.txtTown.TabIndex = 47;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(413, 118);
            this.lblTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(48, 15);
            this.lblTown.TabIndex = 46;
            this.lblTown.Text = "Town: *";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(473, 73);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(136, 20);
            this.txtAddress2.TabIndex = 45;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine2.Location = new System.Drawing.Point(362, 78);
            this.lblAddressLine2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(99, 15);
            this.lblAddressLine2.TabIndex = 44;
            this.lblAddressLine2.Text = "Address Line 2: *";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(473, 35);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(136, 20);
            this.txtAddress1.TabIndex = 43;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(362, 40);
            this.lblAddressLine1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(99, 15);
            this.lblAddressLine1.TabIndex = 42;
            this.lblAddressLine1.Text = "Address Line 1: *";
            // 
            // lblSearchLabel
            // 
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLabel.Location = new System.Drawing.Point(53, 40);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(209, 25);
            this.lblSearchLabel.TabIndex = 43;
            this.lblSearchLabel.Text = "Search for Customer";
            // 
            // grdUpdate
            // 
            this.grdUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdate.Location = new System.Drawing.Point(359, 40);
            this.grdUpdate.Name = "grdUpdate";
            this.grdUpdate.Size = new System.Drawing.Size(403, 150);
            this.grdUpdate.TabIndex = 44;
            this.grdUpdate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUpdate_CellClick);
            // 
            // frmCustomerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 545);
            this.Controls.Add(this.grdUpdate);
            this.Controls.Add(this.lblSearchLabel);
            this.Controls.Add(this.grpUpdateBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.mnuUpdateCustomer);
            this.MainMenuStrip = this.mnuUpdateCustomer;
            this.Name = "frmCustomerUpdate";
            this.Text = "frmCustomerUpdate";
            this.Load += new System.EventHandler(this.frmCustomerUpdate_Load);
            this.mnuUpdateCustomer.ResumeLayout(false);
            this.mnuUpdateCustomer.PerformLayout();
            this.grpUpdateBox.ResumeLayout(false);
            this.grpUpdateBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpUpdateBox;
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
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.Button tbnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.ComboBox cboNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtPPSN;
        private System.Windows.Forms.Label lblPPSN;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DataGridView grdUpdate;
    }
}