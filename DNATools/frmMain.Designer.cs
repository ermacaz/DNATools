namespace DNATools
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.primersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrimersDigest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrimerDigestReplaceMCS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrimerDigestInsertCS = new System.Windows.Forms.ToolStripMenuItem();
            this.lstDNAs = new System.Windows.Forms.ListBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.primersToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(797, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(195, 22);
            this.mnuFileNew.Text = "&New Sequence";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // primersToolStripMenuItem
            // 
            this.primersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrimersDigest});
            this.primersToolStripMenuItem.Name = "primersToolStripMenuItem";
            this.primersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.primersToolStripMenuItem.Text = "&Primers";
            // 
            // mnuPrimersDigest
            // 
            this.mnuPrimersDigest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrimerDigestReplaceMCS,
            this.mnuPrimerDigestInsertCS});
            this.mnuPrimersDigest.Name = "mnuPrimersDigest";
            this.mnuPrimersDigest.Size = new System.Drawing.Size(107, 22);
            this.mnuPrimersDigest.Text = "Digest";
            // 
            // mnuPrimerDigestReplaceMCS
            // 
            this.mnuPrimerDigestReplaceMCS.Name = "mnuPrimerDigestReplaceMCS";
            this.mnuPrimerDigestReplaceMCS.Size = new System.Drawing.Size(185, 22);
            this.mnuPrimerDigestReplaceMCS.Text = "Replace gene in MCS";
            // 
            // mnuPrimerDigestInsertCS
            // 
            this.mnuPrimerDigestInsertCS.Name = "mnuPrimerDigestInsertCS";
            this.mnuPrimerDigestInsertCS.Size = new System.Drawing.Size(185, 22);
            this.mnuPrimerDigestInsertCS.Text = "Insert to MCS";
            // 
            // lstDNAs
            // 
            this.lstDNAs.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstDNAs.FormattingEnabled = true;
            this.lstDNAs.Location = new System.Drawing.Point(0, 24);
            this.lstDNAs.Name = "lstDNAs";
            this.lstDNAs.Size = new System.Drawing.Size(120, 304);
            this.lstDNAs.TabIndex = 7;
            this.lstDNAs.SelectedIndexChanged += new System.EventHandler(this.lstDNAs_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 328);
            this.Controls.Add(this.lstDNAs);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "DNA Tools";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem primersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPrimersDigest;
        private System.Windows.Forms.ToolStripMenuItem mnuPrimerDigestReplaceMCS;
        private System.Windows.Forms.ToolStripMenuItem mnuPrimerDigestInsertCS;
        public System.Windows.Forms.ListBox lstDNAs;
    }
}