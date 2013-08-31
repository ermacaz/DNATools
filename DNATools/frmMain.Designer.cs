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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.primersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrimersDigest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrimerDigestReplaceMCS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrimerDigestInsertCS = new System.Windows.Forms.ToolStripMenuItem();
            this.lstDNAs = new System.Windows.Forms.ListBox();
            this.cmLstDNA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAlign = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.cmLstDNA.SuspendLayout();
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
            this.lstDNAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDNAs.FormattingEnabled = true;
            this.lstDNAs.ItemHeight = 25;
            this.lstDNAs.Location = new System.Drawing.Point(0, 24);
            this.lstDNAs.Name = "lstDNAs";
            this.lstDNAs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDNAs.Size = new System.Drawing.Size(167, 304);
            this.lstDNAs.TabIndex = 7;
            this.lstDNAs.SelectedIndexChanged += new System.EventHandler(this.lstDNAs_SelectedIndexChanged);
            this.lstDNAs.DoubleClick += new System.EventHandler(this.lstDNAs_DoubleClick);
            // 
            // cmLstDNA
            // 
            this.cmLstDNA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.cloneToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.cmLstDNA.Name = "cmLstDNA";
            this.cmLstDNA.Size = new System.Drawing.Size(118, 70);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // cloneToolStripMenuItem
            // 
            this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
            this.cloneToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cloneToolStripMenuItem.Text = "Clone";
            this.cloneToolStripMenuItem.Click += new System.EventHandler(this.cloneToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAlign
            // 
            this.btnAlign.Location = new System.Drawing.Point(198, 280);
            this.btnAlign.Name = "btnAlign";
            this.btnAlign.Size = new System.Drawing.Size(75, 23);
            this.btnAlign.TabIndex = 9;
            this.btnAlign.Text = "Align";
            this.btnAlign.UseVisualStyleBackColor = true;
            this.btnAlign.Click += new System.EventHandler(this.btnAlign_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 328);
            this.Controls.Add(this.btnAlign);
            this.Controls.Add(this.lstDNAs);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "DNA Tools";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.cmLstDNA.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmLstDNA;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAlign;
    }
}