namespace LottoSYS.Prize
{
    partial class frmCheckTicket
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
            this.mnuRunDraw = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRunDraw = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rdoCounty = new System.Windows.Forms.RadioButton();
            this.rdoWinnings = new System.Windows.Forms.RadioButton();
            this.grdWinningTickets = new System.Windows.Forms.DataGridView();
            this.btnCheckTickets = new System.Windows.Forms.Button();
            this.mnuRunDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWinningTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuRunDraw
            // 
            this.mnuRunDraw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuRunDraw.Location = new System.Drawing.Point(0, 0);
            this.mnuRunDraw.Name = "mnuRunDraw";
            this.mnuRunDraw.Size = new System.Drawing.Size(516, 24);
            this.mnuRunDraw.TabIndex = 1;
            this.mnuRunDraw.Text = "menuStrip1";
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
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click_1);
            // 
            // lblRunDraw
            // 
            this.lblRunDraw.AutoSize = true;
            this.lblRunDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunDraw.Location = new System.Drawing.Point(25, 43);
            this.lblRunDraw.Name = "lblRunDraw";
            this.lblRunDraw.Size = new System.Drawing.Size(148, 25);
            this.lblRunDraw.TabIndex = 45;
            this.lblRunDraw.Text = "Check Tickets";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(405, 78);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 46;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // rdoCounty
            // 
            this.rdoCounty.AutoSize = true;
            this.rdoCounty.Location = new System.Drawing.Point(30, 81);
            this.rdoCounty.Name = "rdoCounty";
            this.rdoCounty.Size = new System.Drawing.Size(58, 17);
            this.rdoCounty.TabIndex = 48;
            this.rdoCounty.TabStop = true;
            this.rdoCounty.Text = "County";
            this.rdoCounty.UseVisualStyleBackColor = true;
            // 
            // rdoWinnings
            // 
            this.rdoWinnings.AutoSize = true;
            this.rdoWinnings.Location = new System.Drawing.Point(173, 81);
            this.rdoWinnings.Name = "rdoWinnings";
            this.rdoWinnings.Size = new System.Drawing.Size(69, 17);
            this.rdoWinnings.TabIndex = 49;
            this.rdoWinnings.TabStop = true;
            this.rdoWinnings.Text = "Winnings";
            this.rdoWinnings.UseVisualStyleBackColor = true;
            // 
            // grdWinningTickets
            // 
            this.grdWinningTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdWinningTickets.Location = new System.Drawing.Point(30, 110);
            this.grdWinningTickets.Name = "grdWinningTickets";
            this.grdWinningTickets.Size = new System.Drawing.Size(450, 150);
            this.grdWinningTickets.TabIndex = 50;
            // 
            // btnCheckTickets
            // 
            this.btnCheckTickets.Location = new System.Drawing.Point(280, 78);
            this.btnCheckTickets.Name = "btnCheckTickets";
            this.btnCheckTickets.Size = new System.Drawing.Size(109, 23);
            this.btnCheckTickets.TabIndex = 51;
            this.btnCheckTickets.Text = "Check Tickets";
            this.btnCheckTickets.UseVisualStyleBackColor = true;
            this.btnCheckTickets.Click += new System.EventHandler(this.btnCheckTickets_Click);
            // 
            // frmCheckTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 305);
            this.Controls.Add(this.btnCheckTickets);
            this.Controls.Add(this.grdWinningTickets);
            this.Controls.Add(this.rdoWinnings);
            this.Controls.Add(this.rdoCounty);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblRunDraw);
            this.Controls.Add(this.mnuRunDraw);
            this.Name = "frmCheckTicket";
            this.Text = "frmCheckTicket";
            this.Load += new System.EventHandler(this.frmPayPrize_Load);
            this.mnuRunDraw.ResumeLayout(false);
            this.mnuRunDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWinningTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRunDraw;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblRunDraw;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton rdoCounty;
        private System.Windows.Forms.RadioButton rdoWinnings;
        private System.Windows.Forms.DataGridView grdWinningTickets;
        private System.Windows.Forms.Button btnCheckTickets;
    }
}