namespace LottoSYS
{
    partial class frmCustomerDeReg
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDeReg = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpDeReg = new System.Windows.Forms.GroupBox();
            this.rdoWithdrawn = new System.Windows.Forms.RadioButton();
            this.rdoDeceased = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.grdListing = new System.Windows.Forms.DataGridView();
            this.mnuUpdateCustomer.SuspendLayout();
            this.grpDeReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListing)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.exitToolStripMenuItem});
            this.mnuUpdateCustomer.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(947, 24);
            this.mnuUpdateCustomer.TabIndex = 1;
            this.mnuUpdateCustomer.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblDeReg
            // 
            this.lblDeReg.AutoSize = true;
            this.lblDeReg.Location = new System.Drawing.Point(22, 29);
            this.lblDeReg.Name = "lblDeReg";
            this.lblDeReg.Size = new System.Drawing.Size(74, 15);
            this.lblDeReg.TabIndex = 2;
            this.lblDeReg.Text = "De - register";
            this.lblDeReg.Click += new System.EventHandler(this.lblDeReg_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(219, 56);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(91, 58);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchBox.MaxLength = 25;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(105, 22);
            this.txtSearchBox.TabIndex = 1;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(23, 64);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 15);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Surname:";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // grpDeReg
            // 
            this.grpDeReg.Controls.Add(this.rdoWithdrawn);
            this.grpDeReg.Controls.Add(this.rdoDeceased);
            this.grpDeReg.Controls.Add(this.btnSubmit);
            this.grpDeReg.Controls.Add(this.txtForename);
            this.grpDeReg.Controls.Add(this.lblForename);
            this.grpDeReg.Controls.Add(this.txtSurname);
            this.grpDeReg.Controls.Add(this.lblSurname);
            this.grpDeReg.Controls.Add(this.txtTown);
            this.grpDeReg.Controls.Add(this.lblTown);
            this.grpDeReg.Controls.Add(this.txtAddress2);
            this.grpDeReg.Controls.Add(this.lblAddressLine2);
            this.grpDeReg.Controls.Add(this.txtAddress1);
            this.grpDeReg.Controls.Add(this.lblAddressLine1);
            this.grpDeReg.Location = new System.Drawing.Point(712, 29);
            this.grpDeReg.Margin = new System.Windows.Forms.Padding(2);
            this.grpDeReg.Name = "grpDeReg";
            this.grpDeReg.Padding = new System.Windows.Forms.Padding(2);
            this.grpDeReg.Size = new System.Drawing.Size(224, 298);
            this.grpDeReg.TabIndex = 7;
            this.grpDeReg.TabStop = false;
            this.grpDeReg.Text = "DeReg";
            this.grpDeReg.Enter += new System.EventHandler(this.grpDeReg_Enter);
            // 
            // rdoWithdrawn
            // 
            this.rdoWithdrawn.AutoSize = true;
            this.rdoWithdrawn.Location = new System.Drawing.Point(41, 207);
            this.rdoWithdrawn.Margin = new System.Windows.Forms.Padding(2);
            this.rdoWithdrawn.Name = "rdoWithdrawn";
            this.rdoWithdrawn.Size = new System.Drawing.Size(83, 19);
            this.rdoWithdrawn.TabIndex = 8;
            this.rdoWithdrawn.TabStop = true;
            this.rdoWithdrawn.Text = "Withdrawn";
            // 
            // rdoDeceased
            // 
            this.rdoDeceased.AutoSize = true;
            this.rdoDeceased.Location = new System.Drawing.Point(41, 240);
            this.rdoDeceased.Margin = new System.Windows.Forms.Padding(2);
            this.rdoDeceased.Name = "rdoDeceased";
            this.rdoDeceased.Size = new System.Drawing.Size(81, 19);
            this.rdoDeceased.TabIndex = 9;
            this.rdoDeceased.TabStop = true;
            this.rdoDeceased.Text = "Deceased";
            this.rdoDeceased.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(152, 230);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(58, 28);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(129, 58);
            this.txtForename.Margin = new System.Windows.Forms.Padding(2);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(81, 21);
            this.txtForename.TabIndex = 4;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(35, 64);
            this.lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(75, 15);
            this.lblForename.TabIndex = 64;
            this.lblForename.Text = "Forename: *";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(129, 22);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(81, 21);
            this.txtSurname.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(39, 28);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 15);
            this.lblSurname.TabIndex = 62;
            this.lblSurname.Text = "Surname: *";
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(129, 168);
            this.txtTown.Margin = new System.Windows.Forms.Padding(2);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(81, 22);
            this.txtTown.TabIndex = 7;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(51, 175);
            this.lblTown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(48, 15);
            this.lblTown.TabIndex = 60;
            this.lblTown.Text = "Town: *";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(129, 131);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(81, 22);
            this.txtAddress2.TabIndex = 6;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine2.Location = new System.Drawing.Point(21, 138);
            this.lblAddressLine2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(99, 15);
            this.lblAddressLine2.TabIndex = 58;
            this.lblAddressLine2.Text = "Address Line 2: *";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(129, 94);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(81, 22);
            this.txtAddress1.TabIndex = 5;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(21, 101);
            this.lblAddressLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(99, 15);
            this.lblAddressLine1.TabIndex = 56;
            this.lblAddressLine1.Text = "Address Line 1: *";
            // 
            // grdListing
            // 
            this.grdListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListing.Location = new System.Drawing.Point(25, 102);
            this.grdListing.Margin = new System.Windows.Forms.Padding(2);
            this.grdListing.Name = "grdListing";
            this.grdListing.Size = new System.Drawing.Size(665, 225);
            this.grdListing.TabIndex = 8;
            this.grdListing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListing_CellClick);
            // 
            // frmCustomerDeReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 426);
            this.Controls.Add(this.grdListing);
            this.Controls.Add(this.grpDeReg);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblDeReg);
            this.Controls.Add(this.mnuUpdateCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCustomerDeReg";
            this.Text = "frmCustomerDeReg";
            this.Load += new System.EventHandler(this.frmCustomerDeReg_Load);
            this.mnuUpdateCustomer.ResumeLayout(false);
            this.mnuUpdateCustomer.PerformLayout();
            this.grpDeReg.ResumeLayout(false);
            this.grpDeReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblDeReg;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grpDeReg;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdoWithdrawn;
        private System.Windows.Forms.RadioButton rdoDeceased;
        private System.Windows.Forms.DataGridView grdListing;
    }
}