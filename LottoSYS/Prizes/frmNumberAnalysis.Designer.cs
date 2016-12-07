namespace LottoSYS.Prizes
{
    partial class frmNumberAnalysis
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
            this.lblnumberAnalysis = new System.Windows.Forms.Label();
            this.lstMost = new System.Windows.Forms.ListBox();
            this.lblMostFrequent = new System.Windows.Forms.Label();
            this.lblLeastFrequent = new System.Windows.Forms.Label();
            this.lstLeast = new System.Windows.Forms.ListBox();
            this.mnuRunDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRunDraw
            // 
            this.mnuRunDraw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuRunDraw.Location = new System.Drawing.Point(0, 0);
            this.mnuRunDraw.Name = "mnuRunDraw";
            this.mnuRunDraw.Size = new System.Drawing.Size(721, 24);
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
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblnumberAnalysis
            // 
            this.lblnumberAnalysis.AutoSize = true;
            this.lblnumberAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberAnalysis.Location = new System.Drawing.Point(26, 48);
            this.lblnumberAnalysis.Name = "lblnumberAnalysis";
            this.lblnumberAnalysis.Size = new System.Drawing.Size(174, 25);
            this.lblnumberAnalysis.TabIndex = 46;
            this.lblnumberAnalysis.Text = "Number Analysis";
            // 
            // lstMost
            // 
            this.lstMost.FormattingEnabled = true;
            this.lstMost.Location = new System.Drawing.Point(110, 221);
            this.lstMost.Name = "lstMost";
            this.lstMost.Size = new System.Drawing.Size(191, 95);
            this.lstMost.TabIndex = 47;
            // 
            // lblMostFrequent
            // 
            this.lblMostFrequent.AutoSize = true;
            this.lblMostFrequent.Location = new System.Drawing.Point(110, 188);
            this.lblMostFrequent.Name = "lblMostFrequent";
            this.lblMostFrequent.Size = new System.Drawing.Size(72, 13);
            this.lblMostFrequent.TabIndex = 49;
            this.lblMostFrequent.Text = "MostFrequent";
            this.lblMostFrequent.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLeastFrequent
            // 
            this.lblLeastFrequent.AutoSize = true;
            this.lblLeastFrequent.Location = new System.Drawing.Point(400, 188);
            this.lblLeastFrequent.Name = "lblLeastFrequent";
            this.lblLeastFrequent.Size = new System.Drawing.Size(75, 13);
            this.lblLeastFrequent.TabIndex = 50;
            this.lblLeastFrequent.Text = "LeastFrequent";
            // 
            // lstLeast
            // 
            this.lstLeast.FormattingEnabled = true;
            this.lstLeast.Location = new System.Drawing.Point(403, 221);
            this.lstLeast.Name = "lstLeast";
            this.lstLeast.Size = new System.Drawing.Size(188, 95);
            this.lstLeast.TabIndex = 51;
            // 
            // frmNumberAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 536);
            this.Controls.Add(this.lstLeast);
            this.Controls.Add(this.lblLeastFrequent);
            this.Controls.Add(this.lblMostFrequent);
            this.Controls.Add(this.lstMost);
            this.Controls.Add(this.lblnumberAnalysis);
            this.Controls.Add(this.mnuRunDraw);
            this.Name = "frmNumberAnalysis";
            this.Text = "v";
            this.Load += new System.EventHandler(this.frmUnclaimedPrize_Load);
            this.mnuRunDraw.ResumeLayout(false);
            this.mnuRunDraw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRunDraw;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblnumberAnalysis;
        private System.Windows.Forms.ListBox lstMost;
        private System.Windows.Forms.Label lblMostFrequent;
        private System.Windows.Forms.Label lblLeastFrequent;
        private System.Windows.Forms.ListBox lstLeast;
    }
}