namespace LottoSYS
{
    partial class frmCustomerProfile
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
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grdListing = new System.Windows.Forms.DataGridView();
            this.btnProfile = new System.Windows.Forms.Button();
            this.mnuListCustomers.SuspendLayout();
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
            this.mnuListCustomers.Size = new System.Drawing.Size(799, 24);
            this.mnuListCustomers.TabIndex = 1;
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
            // lblSearchLabel
            // 
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLabel.Location = new System.Drawing.Point(17, 36);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(171, 25);
            this.lblSearchLabel.TabIndex = 47;
            this.lblSearchLabel.Text = "Customer Profile";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(229, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(90, 97);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(100, 20);
            this.txtSearchBox.TabIndex = 45;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(20, 102);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 15);
            this.lblSearch.TabIndex = 44;
            this.lblSearch.Text = "Surname:";
            // 
            // grdListing
            // 
            this.grdListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListing.Location = new System.Drawing.Point(22, 156);
            this.grdListing.Name = "grdListing";
            this.grdListing.Size = new System.Drawing.Size(752, 150);
            this.grdListing.TabIndex = 48;
            this.grdListing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListing_CellClick);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(496, 95);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(278, 23);
            this.btnProfile.TabIndex = 49;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // frmCustomerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 411);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.grdListing);
            this.Controls.Add(this.lblSearchLabel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.mnuListCustomers);
            this.Name = "frmCustomerProfile";
            this.Text = "frmCustomerProfile";
            this.Load += new System.EventHandler(this.frmListCustomers_Load);
            this.mnuListCustomers.ResumeLayout(false);
            this.mnuListCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuListCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView grdListing;
        private System.Windows.Forms.Button btnProfile;
    }
}