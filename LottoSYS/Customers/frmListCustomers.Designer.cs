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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdoSurname = new System.Windows.Forms.RadioButton();
            this.rdoCustID = new System.Windows.Forms.RadioButton();
            this.rdoCounty = new System.Windows.Forms.RadioButton();
            this.rdoAge = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.mnuListCustomers.SuspendLayout();
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(502, 147);
            this.listBox1.TabIndex = 3;
            // 
            // rdoSurname
            // 
            this.rdoSurname.AutoSize = true;
            this.rdoSurname.Location = new System.Drawing.Point(40, 165);
            this.rdoSurname.Name = "rdoSurname";
            this.rdoSurname.Size = new System.Drawing.Size(67, 17);
            this.rdoSurname.TabIndex = 4;
            this.rdoSurname.TabStop = true;
            this.rdoSurname.Text = "Surname";
            this.rdoSurname.UseVisualStyleBackColor = true;
            this.rdoSurname.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoCustID
            // 
            this.rdoCustID.AutoSize = true;
            this.rdoCustID.Location = new System.Drawing.Point(181, 165);
            this.rdoCustID.Name = "rdoCustID";
            this.rdoCustID.Size = new System.Drawing.Size(80, 17);
            this.rdoCustID.TabIndex = 5;
            this.rdoCustID.TabStop = true;
            this.rdoCustID.Text = "CustomerID";
            this.rdoCustID.UseVisualStyleBackColor = true;
            // 
            // rdoCounty
            // 
            this.rdoCounty.AutoSize = true;
            this.rdoCounty.Location = new System.Drawing.Point(351, 165);
            this.rdoCounty.Name = "rdoCounty";
            this.rdoCounty.Size = new System.Drawing.Size(58, 17);
            this.rdoCounty.TabIndex = 6;
            this.rdoCounty.TabStop = true;
            this.rdoCounty.Text = "County";
            this.rdoCounty.UseVisualStyleBackColor = true;
            // 
            // rdoAge
            // 
            this.rdoAge.AutoSize = true;
            this.rdoAge.Location = new System.Drawing.Point(498, 165);
            this.rdoAge.Name = "rdoAge";
            this.rdoAge.Size = new System.Drawing.Size(44, 17);
            this.rdoAge.TabIndex = 7;
            this.rdoAge.TabStop = true;
            this.rdoAge.Text = "Age";
            this.rdoAge.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(566, 326);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
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
            // frmListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 442);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rdoAge);
            this.Controls.Add(this.rdoCounty);
            this.Controls.Add(this.rdoCustID);
            this.Controls.Add(this.rdoSurname);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mnuListCustomers);
            this.Name = "frmListCustomers";
            this.Text = "frmListCustomers";
            this.Load += new System.EventHandler(this.frmListCustomers_Load);
            this.mnuListCustomers.ResumeLayout(false);
            this.mnuListCustomers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuListCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rdoSurname;
        private System.Windows.Forms.RadioButton rdoCustID;
        private System.Windows.Forms.RadioButton rdoCounty;
        private System.Windows.Forms.RadioButton rdoAge;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label lblSearch;
    }
}