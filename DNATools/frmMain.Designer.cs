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
            this.cmLstDNA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAlign = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstDNAs = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.cmLstDNA.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.primersToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1063, 28);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(229, 24);
            this.mnuFileNew.Text = "&New Sequence";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // primersToolStripMenuItem
            // 
            this.primersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrimersDigest});
            this.primersToolStripMenuItem.Name = "primersToolStripMenuItem";
            this.primersToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.primersToolStripMenuItem.Text = "&Primers";
            // 
            // mnuPrimersDigest
            // 
            this.mnuPrimersDigest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrimerDigestReplaceMCS,
            this.mnuPrimerDigestInsertCS});
            this.mnuPrimersDigest.Name = "mnuPrimersDigest";
            this.mnuPrimersDigest.Size = new System.Drawing.Size(121, 24);
            this.mnuPrimersDigest.Text = "Digest";
            // 
            // mnuPrimerDigestReplaceMCS
            // 
            this.mnuPrimerDigestReplaceMCS.Name = "mnuPrimerDigestReplaceMCS";
            this.mnuPrimerDigestReplaceMCS.Size = new System.Drawing.Size(218, 24);
            this.mnuPrimerDigestReplaceMCS.Text = "Replace gene in MCS";
            // 
            // mnuPrimerDigestInsertCS
            // 
            this.mnuPrimerDigestInsertCS.Name = "mnuPrimerDigestInsertCS";
            this.mnuPrimerDigestInsertCS.Size = new System.Drawing.Size(218, 24);
            this.mnuPrimerDigestInsertCS.Text = "Insert to MCS";
            // 
            // cmLstDNA
            // 
            this.cmLstDNA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.cloneToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.cmLstDNA.Name = "cmLstDNA";
            this.cmLstDNA.Size = new System.Drawing.Size(133, 76);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // cloneToolStripMenuItem
            // 
            this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
            this.cloneToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.cloneToolStripMenuItem.Text = "Clone";
            this.cloneToolStripMenuItem.Click += new System.EventHandler(this.cloneToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAlign
            // 
            this.btnAlign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAlign.Location = new System.Drawing.Point(0, 514);
            this.btnAlign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlign.Name = "btnAlign";
            this.btnAlign.Size = new System.Drawing.Size(124, 28);
            this.btnAlign.TabIndex = 9;
            this.btnAlign.Text = "Align";
            this.btnAlign.UseVisualStyleBackColor = true;
            this.btnAlign.Click += new System.EventHandler(this.btnAlign_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstDNAs
            // 
            this.lstDNAs.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstDNAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDNAs.FormattingEnabled = true;
            this.lstDNAs.ItemHeight = 29;
            this.lstDNAs.Location = new System.Drawing.Point(0, 0);
            this.lstDNAs.Margin = new System.Windows.Forms.Padding(4);
            this.lstDNAs.Name = "lstDNAs";
            this.lstDNAs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDNAs.Size = new System.Drawing.Size(125, 514);
            this.lstDNAs.TabIndex = 7;
            this.lstDNAs.SelectedIndexChanged += new System.EventHandler(this.lstDNAs_SelectedIndexChanged);
            this.lstDNAs.DoubleClick += new System.EventHandler(this.lstDNAs_DoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 542);
            this.flowLayoutPanel1.TabIndex = 11;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstDNAs);
            this.panel1.Controls.Add(this.btnAlign);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 542);
            this.panel1.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "DNA Tools";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.cmLstDNA.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmLstDNA;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAlign;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox lstDNAs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}