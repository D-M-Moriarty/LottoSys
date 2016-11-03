namespace LottoSYS.Prizes
{
    partial class frmRunDraw
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
            this.btnRunDraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRunDraw = new System.Windows.Forms.Label();
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
            this.mnuRunDraw.Size = new System.Drawing.Size(559, 24);
            this.mnuRunDraw.TabIndex = 0;
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
            // btnRunDraw
            // 
            this.btnRunDraw.Location = new System.Drawing.Point(228, 291);
            this.btnRunDraw.Name = "btnRunDraw";
            this.btnRunDraw.Size = new System.Drawing.Size(92, 48);
            this.btnRunDraw.TabIndex = 1;
            this.btnRunDraw.Text = "Run Draw";
            this.btnRunDraw.UseVisualStyleBackColor = true;
            this.btnRunDraw.Click += new System.EventHandler(this.btnRunDraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // lblRunDraw
            // 
            this.lblRunDraw.AutoSize = true;
            this.lblRunDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunDraw.Location = new System.Drawing.Point(13, 47);
            this.lblRunDraw.Name = "lblRunDraw";
            this.lblRunDraw.Size = new System.Drawing.Size(160, 25);
            this.lblRunDraw.TabIndex = 44;
            this.lblRunDraw.Text = "Run Lotto Draw";
            // 
            // frmRunDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 415);
            this.Controls.Add(this.lblRunDraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRunDraw);
            this.Controls.Add(this.mnuRunDraw);
            this.MainMenuStrip = this.mnuRunDraw;
            this.Name = "frmRunDraw";
            this.Text = "frmRunDraw";
            this.Load += new System.EventHandler(this.frmRunDraw_Load);
            this.mnuRunDraw.ResumeLayout(false);
            this.mnuRunDraw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRunDraw;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnRunDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRunDraw;
    }
}