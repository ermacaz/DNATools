﻿namespace DNATools
{
    partial class frmDNA
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
            this.txtNumBases = new System.Windows.Forms.TextBox();
            this.mnuCalculateKdFromAA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateKd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateTm = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrimerDigestInsertCS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrimerDigestReplaceMCS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrimersDigest = new System.Windows.Forms.ToolStripMenuItem();
            this.primersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDNASequence = new System.Windows.Forms.RichTextBox();
            this.mnuSequenceLowcase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSequenceAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSequenceClean = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSequenceTranslate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSequenceParallel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSequenceComplement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSequenceReverse = new System.Windows.Forms.ToolStripMenuItem();
            this.sequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSequenceUpcase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumBases
            // 
            this.txtNumBases.Location = new System.Drawing.Point(521, 53);
            this.txtNumBases.Name = "txtNumBases";
            this.txtNumBases.ReadOnly = true;
            this.txtNumBases.Size = new System.Drawing.Size(72, 20);
            this.txtNumBases.TabIndex = 6;
            // 
            // mnuCalculateKdFromAA
            // 
            this.mnuCalculateKdFromAA.Name = "mnuCalculateKdFromAA";
            this.mnuCalculateKdFromAA.Size = new System.Drawing.Size(169, 22);
            this.mnuCalculateKdFromAA.Text = "From amino acids";
            // 
            // mnuCalculateKd
            // 
            this.mnuCalculateKd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCalculateKdFromAA});
            this.mnuCalculateKd.Name = "mnuCalculateKd";
            this.mnuCalculateKd.Size = new System.Drawing.Size(152, 22);
            this.mnuCalculateKd.Text = "Kd";
            // 
            // mnuCalculateTm
            // 
            this.mnuCalculateTm.Name = "mnuCalculateTm";
            this.mnuCalculateTm.Size = new System.Drawing.Size(152, 22);
            this.mnuCalculateTm.Text = "Tm";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCalculateTm,
            this.mnuCalculateKd});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            // 
            // mnuPrimerDigestInsertCS
            // 
            this.mnuPrimerDigestInsertCS.Name = "mnuPrimerDigestInsertCS";
            this.mnuPrimerDigestInsertCS.Size = new System.Drawing.Size(185, 22);
            this.mnuPrimerDigestInsertCS.Text = "Insert to MCS";
            // 
            // mnuPrimerDigestReplaceMCS
            // 
            this.mnuPrimerDigestReplaceMCS.Name = "mnuPrimerDigestReplaceMCS";
            this.mnuPrimerDigestReplaceMCS.Size = new System.Drawing.Size(185, 22);
            this.mnuPrimerDigestReplaceMCS.Text = "Replace gene in MCS";
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
            // primersToolStripMenuItem
            // 
            this.primersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrimersDigest});
            this.primersToolStripMenuItem.Name = "primersToolStripMenuItem";
            this.primersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.primersToolStripMenuItem.Text = "&Primers";
            // 
            // txtDNASequence
            // 
            this.txtDNASequence.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNASequence.Location = new System.Drawing.Point(31, 53);
            this.txtDNASequence.Name = "txtDNASequence";
            this.txtDNASequence.Size = new System.Drawing.Size(484, 211);
            this.txtDNASequence.TabIndex = 5;
            this.txtDNASequence.Text = "";
            // 
            // mnuSequenceLowcase
            // 
            this.mnuSequenceLowcase.Name = "mnuSequenceLowcase";
            this.mnuSequenceLowcase.Size = new System.Drawing.Size(144, 22);
            this.mnuSequenceLowcase.Text = "Lower Case";
            // 
            // mnuSequenceAlign
            // 
            this.mnuSequenceAlign.Name = "mnuSequenceAlign";
            this.mnuSequenceAlign.Size = new System.Drawing.Size(144, 22);
            this.mnuSequenceAlign.Text = "Align";
            // 
            // mnuSequenceClean
            // 
            this.mnuSequenceClean.Name = "mnuSequenceClean";
            this.mnuSequenceClean.Size = new System.Drawing.Size(144, 22);
            this.mnuSequenceClean.Text = "Clean";
            // 
            // mnuSequenceTranslate
            // 
            this.mnuSequenceTranslate.Name = "mnuSequenceTranslate";
            this.mnuSequenceTranslate.Size = new System.Drawing.Size(144, 22);
            this.mnuSequenceTranslate.Text = "Translate";
            // 
            // mnuSequenceParallel
            // 
            this.mnuSequenceParallel.Name = "mnuSequenceParallel";
            this.mnuSequenceParallel.Size = new System.Drawing.Size(144, 22);
            this.mnuSequenceParallel.Text = "Parallel";
            // 
            // mnuSequenceComplement
            // 
            this.mnuSequenceComplement.Name = "mnuSequenceComplement";
            this.mnuSequenceComplement.Size = new System.Drawing.Size(144, 22);
            this.mnuSequenceComplement.Text = "Complement";
            // 
            // mnuSequenceReverse
            // 
            this.mnuSequenceReverse.Name = "mnuSequenceReverse";
            this.mnuSequenceReverse.Size = new System.Drawing.Size(144, 22);
            this.mnuSequenceReverse.Text = "Reverse";
            // 
            // sequenceToolStripMenuItem
            // 
            this.sequenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSequenceReverse,
            this.mnuSequenceComplement,
            this.mnuSequenceParallel,
            this.mnuSequenceTranslate,
            this.mnuSequenceClean,
            this.mnuSequenceAlign,
            this.mnuSequenceUpcase,
            this.mnuSequenceLowcase});
            this.sequenceToolStripMenuItem.Name = "sequenceToolStripMenuItem";
            this.sequenceToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.sequenceToolStripMenuItem.Text = "&Sequence";
            // 
            // mnuSequenceUpcase
            // 
            this.mnuSequenceUpcase.Name = "mnuSequenceUpcase";
            this.mnuSequenceUpcase.Size = new System.Drawing.Size(144, 22);
            this.mnuSequenceUpcase.Text = "Upper Case";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(152, 22);
            this.mnuFileNew.Text = "&New Sequence";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sequenceToolStripMenuItem,
            this.primersToolStripMenuItem,
            this.calculateToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(605, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // frmDNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 301);
            this.Controls.Add(this.txtNumBases);
            this.Controls.Add(this.txtDNASequence);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmDNA";
            this.Text = "frmDNA";
            this.Load += new System.EventHandler(this.frmDNA_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumBases;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculateKdFromAA;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculateKd;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculateTm;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPrimerDigestInsertCS;
        private System.Windows.Forms.ToolStripMenuItem mnuPrimerDigestReplaceMCS;
        private System.Windows.Forms.ToolStripMenuItem mnuPrimersDigest;
        private System.Windows.Forms.ToolStripMenuItem primersToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtDNASequence;
        private System.Windows.Forms.ToolStripMenuItem mnuSequenceLowcase;
        private System.Windows.Forms.ToolStripMenuItem mnuSequenceAlign;
        private System.Windows.Forms.ToolStripMenuItem mnuSequenceClean;
        private System.Windows.Forms.ToolStripMenuItem mnuSequenceTranslate;
        private System.Windows.Forms.ToolStripMenuItem mnuSequenceParallel;
        private System.Windows.Forms.ToolStripMenuItem mnuSequenceComplement;
        private System.Windows.Forms.ToolStripMenuItem mnuSequenceReverse;
        private System.Windows.Forms.ToolStripMenuItem sequenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSequenceUpcase;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}