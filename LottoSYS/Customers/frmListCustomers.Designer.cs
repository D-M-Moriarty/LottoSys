namespace LottoSYS.Customers
{
    partial class frmListCustomers
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
            this.mnuListCustomers = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.rdoSurname = new System.Windows.Forms.RadioButton();
            this.rdoWinners = new System.Windows.Forms.RadioButton();
            this.rdoWithdrawn = new System.Windows.Forms.RadioButton();
            this.rdoAge = new System.Windows.Forms.RadioButton();
            this.grpSort = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdListing = new System.Windows.Forms.DataGridView();
            this.mnuListCustomers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListing)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuListCustomers
            // 
            this.mnuListCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuListCustomers.Location = new System.Drawing.Point(0, 0);
            this.mnuListCustomers.Name = "mnuListCustomers";
            this.mnuListCustomers.Size = new System.Drawing.Size(674, 24);
            this.mnuListCustomers.TabIndex = 2;
            this.mnuListCustomers.Text = "ListCustomers";
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
            // rdoSurname
            // 
            this.rdoSurname.AutoSize = true;
            this.rdoSurname.Location = new System.Drawing.Point(34, 74);
            this.rdoSurname.Name = "rdoSurname";
            this.rdoSurname.Size = new System.Drawing.Size(36, 17);
            this.rdoSurname.TabIndex = 4;
            this.rdoSurname.TabStop = true;
            this.rdoSurname.Text = "All";
            this.rdoSurname.UseVisualStyleBackColor = true;
            this.rdoSurname.CheckedChanged += new System.EventHandler(this.rdoSurname_CheckedChanged);
            // 
            // rdoWinners
            // 
            this.rdoWinners.AutoSize = true;
            this.rdoWinners.Location = new System.Drawing.Point(175, 74);
            this.rdoWinners.Name = "rdoWinners";
            this.rdoWinners.Size = new System.Drawing.Size(64, 17);
            this.rdoWinners.TabIndex = 5;
            this.rdoWinners.TabStop = true;
            this.rdoWinners.Text = "Winners";
            this.rdoWinners.UseVisualStyleBackColor = true;
            this.rdoWinners.CheckedChanged += new System.EventHandler(this.rdoWinners_CheckedChanged);
            // 
            // rdoWithdrawn
            // 
            this.rdoWithdrawn.AutoSize = true;
            this.rdoWithdrawn.Location = new System.Drawing.Point(345, 74);
            this.rdoWithdrawn.Name = "rdoWithdrawn";
            this.rdoWithdrawn.Size = new System.Drawing.Size(76, 17);
            this.rdoWithdrawn.TabIndex = 6;
            this.rdoWithdrawn.TabStop = true;
            this.rdoWithdrawn.Text = "Withdrawn";
            this.rdoWithdrawn.UseVisualStyleBackColor = true;
            this.rdoWithdrawn.CheckedChanged += new System.EventHandler(this.rdoWithdrawn_CheckedChanged);
            // 
            // rdoAge
            // 
            this.rdoAge.AutoSize = true;
            this.rdoAge.Location = new System.Drawing.Point(492, 74);
            this.rdoAge.Name = "rdoAge";
            this.rdoAge.Size = new System.Drawing.Size(44, 17);
            this.rdoAge.TabIndex = 7;
            this.rdoAge.TabStop = true;
            this.rdoAge.Text = "Age";
            this.rdoAge.UseVisualStyleBackColor = true;
            // 
            // grpSort
            // 
            this.grpSort.Location = new System.Drawing.Point(560, 235);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(75, 23);
            this.grpSort.TabIndex = 8;
            this.grpSort.Text = "Print";
            this.grpSort.UseVisualStyleBackColor = true;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(26, 37);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(160, 25);
            this.lblList.TabIndex = 47;
            this.lblList.Text = "Search Listings";
            this.lblList.Click += new System.EventHandler(this.lblSearchLabel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(225, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(99, 98);
            this.txtSearchBox.MaxLength = 25;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(100, 20);
            this.txtSearchBox.TabIndex = 45;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(22, 103);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 15);
            this.lblSearch.TabIndex = 44;
            this.lblSearch.Text = "Surname:";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdListing);
            this.groupBox1.Controls.Add(this.grpSort);
            this.groupBox1.Controls.Add(this.rdoAge);
            this.groupBox1.Controls.Add(this.rdoWithdrawn);
            this.groupBox1.Controls.Add(this.rdoWinners);
            this.groupBox1.Controls.Add(this.rdoSurname);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 289);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Listings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grdListing
            // 
            this.grdListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListing.Location = new System.Drawing.Point(34, 118);
            this.grdListing.Name = "grdListing";
            this.grdListing.Size = new System.Drawing.Size(502, 152);
            this.grdListing.TabIndex = 9;
            // 
            // frmListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.mnuListCustomers);
            this.Name = "frmListCustomers";
            this.Text = "frmListCustomers";
            this.Load += new System.EventHandler(this.frmListCustomers_Load);
            this.mnuListCustomers.ResumeLayout(false);
            this.mnuListCustomers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuListCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.RadioButton rdoSurname;
        private System.Windows.Forms.RadioButton rdoWinners;
        private System.Windows.Forms.RadioButton rdoWithdrawn;
        private System.Windows.Forms.RadioButton rdoAge;
        private System.Windows.Forms.Button grpSort;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdListing;
    }
}