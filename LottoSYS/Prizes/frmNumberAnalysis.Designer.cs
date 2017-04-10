namespace LottoSYS.Prize
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
            this.lblMostFrequent = new System.Windows.Forms.Label();
            this.lblLeastFrequent = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grdNumAnalysis = new System.Windows.Forms.DataGridView();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.mnuRunDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNumAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuRunDraw
            // 
            this.mnuRunDraw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuRunDraw.Location = new System.Drawing.Point(0, 0);
            this.mnuRunDraw.Name = "mnuRunDraw";
            this.mnuRunDraw.Size = new System.Drawing.Size(584, 24);
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
            // lblMostFrequent
            // 
            this.lblMostFrequent.AutoSize = true;
            this.lblMostFrequent.Location = new System.Drawing.Point(28, 100);
            this.lblMostFrequent.Name = "lblMostFrequent";
            this.lblMostFrequent.Size = new System.Drawing.Size(72, 13);
            this.lblMostFrequent.TabIndex = 49;
            this.lblMostFrequent.Text = "MostFrequent";
            this.lblMostFrequent.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLeastFrequent
            // 
            this.lblLeastFrequent.AutoSize = true;
            this.lblLeastFrequent.Location = new System.Drawing.Point(313, 100);
            this.lblLeastFrequent.Name = "lblLeastFrequent";
            this.lblLeastFrequent.Size = new System.Drawing.Size(75, 13);
            this.lblLeastFrequent.TabIndex = 50;
            this.lblLeastFrequent.Text = "LeastFrequent";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(31, 305);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(525, 23);
            this.btnPrint.TabIndex = 52;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grdNumAnalysis
            // 
            this.grdNumAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNumAnalysis.Location = new System.Drawing.Point(31, 131);
            this.grdNumAnalysis.Name = "grdNumAnalysis";
            this.grdNumAnalysis.Size = new System.Drawing.Size(248, 150);
            this.grdNumAnalysis.TabIndex = 53;
            // 
            // grdList
            // 
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Location = new System.Drawing.Point(316, 131);
            this.grdList.Name = "grdList";
            this.grdList.Size = new System.Drawing.Size(240, 150);
            this.grdList.TabIndex = 54;
            // 
            // frmNumberAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 340);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.grdNumAnalysis);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblLeastFrequent);
            this.Controls.Add(this.lblMostFrequent);
            this.Controls.Add(this.lblnumberAnalysis);
            this.Controls.Add(this.mnuRunDraw);
            this.Name = "frmNumberAnalysis";
            this.Text = "NumberAnalysis";
            this.Load += new System.EventHandler(this.frmNumberAnalysis_Load);
            this.mnuRunDraw.ResumeLayout(false);
            this.mnuRunDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNumAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRunDraw;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblnumberAnalysis;
        private System.Windows.Forms.Label lblMostFrequent;
        private System.Windows.Forms.Label lblLeastFrequent;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView grdNumAnalysis;
        private System.Windows.Forms.DataGridView grdList;
    }
}