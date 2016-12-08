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
            this.lstUpdate = new System.Windows.Forms.ListBox();
            this.mnuUpdateCustomer.SuspendLayout();
            this.grpUpdateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuUpdateCustomer.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(774, 24);
            this.mnuUpdateCustomer.TabIndex = 0;
            this.mnuUpdateCustomer.Text = "menuStrip1";
            this.mnuUpdateCustomer.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuUpdateCustomer_ItemClicked);
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
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(49, 106);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 15);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Id Number:";
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
            this.grpUpdateBox.Location = new System.Drawing.Point(43, 214);
            this.grpUpdateBox.Name = "grpUpdateBox";
            this.grpUpdateBox.Size = new System.Drawing.Size(719, 276);
            this.grpUpdateBox.TabIndex = 42;
            this.grpUpdateBox.TabStop = false;
            this.grpUpdateBox.Text = "Update Details";
            // 
            // tbnSubmit
            // 
            this.tbnSubmit.Location = new System.Drawing.Point(534, 217);
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
            this.txtEmail.Location = new System.Drawing.Point(473, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 21);
            this.txtEmail.TabIndex = 59;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(418, 185);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 58;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(473, 142);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(136, 21);
            this.txtPhone.TabIndex = 57;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(392, 148);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 15);
            this.lblPhone.TabIndex = 56;
            this.lblPhone.Text = "Phone no.:";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(167, 104);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(136, 21);
            this.txtForename.TabIndex = 55;
            this.txtForename.TextChanged += new System.EventHandler(this.txtForename_TextChanged);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(80, 110);
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
            this.txtSurname.Location = new System.Drawing.Point(167, 67);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(136, 21);
            this.txtSurname.TabIndex = 53;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(86, 73);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 15);
            this.lblSurname.TabIndex = 52;
            this.lblSurname.Text = "Surname: *";
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click);
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(473, 104);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(136, 21);
            this.cboCountry.TabIndex = 51;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(327, 110);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(134, 15);
            this.lblCountry.TabIndex = 50;
            this.lblCountry.Text = "Country of Residence: *";
            this.lblCountry.Click += new System.EventHandler(this.lblCountry_Click);
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(473, 67);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(136, 21);
            this.cboCounty.TabIndex = 49;
            this.cboCounty.SelectedIndexChanged += new System.EventHandler(this.cboCounty_SelectedIndexChanged);
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(406, 73);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(55, 15);
            this.lblCounty.TabIndex = 48;
            this.lblCounty.Text = "County: *";
            this.lblCounty.Click += new System.EventHandler(this.lblCounty_Click);
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(167, 219);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(136, 20);
            this.txtTown.TabIndex = 47;
            this.txtTown.TextChanged += new System.EventHandler(this.txtTown_TextChanged);
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(107, 225);
            this.lblTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(48, 15);
            this.lblTown.TabIndex = 46;
            this.lblTown.Text = "Town: *";
            this.lblTown.Click += new System.EventHandler(this.lblTown_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(167, 180);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(136, 20);
            this.txtAddress2.TabIndex = 45;
            this.txtAddress2.TextChanged += new System.EventHandler(this.txtAddress2_TextChanged);
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine2.Location = new System.Drawing.Point(56, 185);
            this.lblAddressLine2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(99, 15);
            this.lblAddressLine2.TabIndex = 44;
            this.lblAddressLine2.Text = "Address Line 2: *";
            this.lblAddressLine2.Click += new System.EventHandler(this.lblAddressLine2_Click);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(167, 142);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(136, 20);
            this.txtAddress1.TabIndex = 43;
            this.txtAddress1.TextChanged += new System.EventHandler(this.txtAddress1_TextChanged);
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(56, 147);
            this.lblAddressLine1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(99, 15);
            this.lblAddressLine1.TabIndex = 42;
            this.lblAddressLine1.Text = "Address Line 1: *";
            this.lblAddressLine1.Click += new System.EventHandler(this.lblAddressLine1_Click);
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
            // lstUpdate
            // 
            this.lstUpdate.FormattingEnabled = true;
            this.lstUpdate.Location = new System.Drawing.Point(383, 59);
            this.lstUpdate.Name = "lstUpdate";
            this.lstUpdate.Size = new System.Drawing.Size(379, 134);
            this.lstUpdate.TabIndex = 44;
            this.lstUpdate.SelectedIndexChanged += new System.EventHandler(this.lstUpdate_SelectedIndexChanged);
            // 
            // frmCustomerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 545);
            this.Controls.Add(this.lstUpdate);
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
        private System.Windows.Forms.ListBox lstUpdate;
        private System.Windows.Forms.Button tbnSubmit;
    }
}