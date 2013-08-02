namespace DNATools
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
            this.SeqSize = new System.Windows.Forms.TextBox();
            this.fromAminoAcidsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromAminoAcidsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToMCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceGeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lowerCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parallelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeqSize
            // 
            this.SeqSize.Location = new System.Drawing.Point(521, 53);
            this.SeqSize.Name = "SeqSize";
            this.SeqSize.ReadOnly = true;
            this.SeqSize.Size = new System.Drawing.Size(72, 20);
            this.SeqSize.TabIndex = 6;
            // 
            // fromAminoAcidsToolStripMenuItem1
            // 
            this.fromAminoAcidsToolStripMenuItem1.Name = "fromAminoAcidsToolStripMenuItem1";
            this.fromAminoAcidsToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.fromAminoAcidsToolStripMenuItem1.Text = "From amino acids";
            // 
            // kdToolStripMenuItem
            // 
            this.kdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromAminoAcidsToolStripMenuItem1});
            this.kdToolStripMenuItem.Name = "kdToolStripMenuItem";
            this.kdToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.kdToolStripMenuItem.Text = "Kd";
            // 
            // tmToolStripMenuItem
            // 
            this.tmToolStripMenuItem.Name = "tmToolStripMenuItem";
            this.tmToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.tmToolStripMenuItem.Text = "Tm";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmToolStripMenuItem,
            this.kdToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateToolStripMenuItem.Text = "Calculate";
            // 
            // fromAminoAcidsToolStripMenuItem
            // 
            this.fromAminoAcidsToolStripMenuItem.Name = "fromAminoAcidsToolStripMenuItem";
            this.fromAminoAcidsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.fromAminoAcidsToolStripMenuItem.Text = "From amino acids";
            // 
            // insertToMCSToolStripMenuItem
            // 
            this.insertToMCSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromAminoAcidsToolStripMenuItem});
            this.insertToMCSToolStripMenuItem.Name = "insertToMCSToolStripMenuItem";
            this.insertToMCSToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.insertToMCSToolStripMenuItem.Text = "Insert to MCS";
            // 
            // replaceGeneToolStripMenuItem
            // 
            this.replaceGeneToolStripMenuItem.Name = "replaceGeneToolStripMenuItem";
            this.replaceGeneToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.replaceGeneToolStripMenuItem.Text = "Replace gene in MCS";
            // 
            // digestToolStripMenuItem
            // 
            this.digestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceGeneToolStripMenuItem,
            this.insertToMCSToolStripMenuItem});
            this.digestToolStripMenuItem.Name = "digestToolStripMenuItem";
            this.digestToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.digestToolStripMenuItem.Text = "Digest";
            // 
            // primersToolStripMenuItem
            // 
            this.primersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.digestToolStripMenuItem});
            this.primersToolStripMenuItem.Name = "primersToolStripMenuItem";
            this.primersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.primersToolStripMenuItem.Text = "Primers";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(31, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 211);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // lowerCaseToolStripMenuItem
            // 
            this.lowerCaseToolStripMenuItem.Name = "lowerCaseToolStripMenuItem";
            this.lowerCaseToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.lowerCaseToolStripMenuItem.Text = "Lower Case";
            // 
            // allignToolStripMenuItem
            // 
            this.allignToolStripMenuItem.Name = "allignToolStripMenuItem";
            this.allignToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.allignToolStripMenuItem.Text = "Align";
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cleanToolStripMenuItem.Text = "Clean";
            // 
            // translateToolStripMenuItem
            // 
            this.translateToolStripMenuItem.Name = "translateToolStripMenuItem";
            this.translateToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.translateToolStripMenuItem.Text = "Translate";
            // 
            // parallelToolStripMenuItem
            // 
            this.parallelToolStripMenuItem.Name = "parallelToolStripMenuItem";
            this.parallelToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.parallelToolStripMenuItem.Text = "Parallel";
            // 
            // addSequenceToolStripMenuItem
            // 
            this.addSequenceToolStripMenuItem.Name = "addSequenceToolStripMenuItem";
            this.addSequenceToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addSequenceToolStripMenuItem.Text = "Complement";
            // 
            // addTemplateToolStripMenuItem
            // 
            this.addTemplateToolStripMenuItem.Name = "addTemplateToolStripMenuItem";
            this.addTemplateToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addTemplateToolStripMenuItem.Text = "Reverse";
            // 
            // sequenceToolStripMenuItem
            // 
            this.sequenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTemplateToolStripMenuItem,
            this.addSequenceToolStripMenuItem,
            this.parallelToolStripMenuItem,
            this.translateToolStripMenuItem,
            this.cleanToolStripMenuItem,
            this.allignToolStripMenuItem,
            this.caseToolStripMenuItem,
            this.lowerCaseToolStripMenuItem});
            this.sequenceToolStripMenuItem.Name = "sequenceToolStripMenuItem";
            this.sequenceToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.sequenceToolStripMenuItem.Text = "Sequence";
            // 
            // caseToolStripMenuItem
            // 
            this.caseToolStripMenuItem.Name = "caseToolStripMenuItem";
            this.caseToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.caseToolStripMenuItem.Text = "Upper Case";
            // 
            // newSequenceToolStripMenuItem
            // 
            this.newSequenceToolStripMenuItem.Name = "newSequenceToolStripMenuItem";
            this.newSequenceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newSequenceToolStripMenuItem.Text = "New Sequence";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSequenceToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            this.Controls.Add(this.SeqSize);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmDNA";
            this.Text = "frmDNA";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeqSize;
        private System.Windows.Forms.ToolStripMenuItem fromAminoAcidsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromAminoAcidsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToMCSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceGeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primersToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem lowerCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parallelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSequenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sequenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSequenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}