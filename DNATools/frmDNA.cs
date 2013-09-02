using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNATools
{
    public partial class frmDNA : Form
    {
        private int totalLines = 0;
        DNA current = new DNA("");
        public frmMain frmMaster;
        public string strDNAme { get; set; }
        public string DNAseq { get; set; }
        public frmDNA(frmMain master, string titleText)
        {
            InitializeComponent();
            this.Text = titleText;
            strDNAme = titleText;
            frmMaster = master;
            frmMaster.lstDNAs.Items.Add(this);
        }

        public frmDNA(frmMain master, string sequence, string nameExtension)
        {
            InitializeComponent();
            this.Text = nameExtension;
            strDNAme = nameExtension;
            frmMaster = master;
            frmMaster.lstDNAs.Items.Add(this);
            current.Sequence = sequence;
            txtDNASequence.Text = current.Sequence;

        }

        //draws line numbers
        private void DrawRichTextBoxLineNumbers(Graphics g)
        {
            Single fontHeight;
            //set font size to same as textbox
            if (txtDNASequence.Lines.Length < 3)
            {
                fontHeight = txtDNASequence.Font.Height;
            }
            else
            {
                //adjust line number size to height of text
                fontHeight = txtDNASequence.GetPositionFromCharIndex(txtDNASequence.GetFirstCharIndexFromLine(2)).Y - txtDNASequence.GetPositionFromCharIndex(txtDNASequence.GetFirstCharIndexFromLine(1)).Y;
            }

            Point pos = new Point(0, (int)(g.VisibleClipBounds.Y + fontHeight / 3));
            int firstIndex, firstLine, firstLineY;

            //should always be 0,0,1 respectively
            firstIndex = txtDNASequence.GetCharIndexFromPosition(pos);
            firstLine = txtDNASequence.GetLineFromCharIndex(firstIndex);
            firstLineY = txtDNASequence.GetPositionFromCharIndex(firstIndex).Y;

            g.Clear(Control.DefaultBackColor);
            int i = firstLine;
            int x = 0;
            Single y = 0;
            //incrase by 50/line 
            totalLines = txtDNASequence.GetLineFromCharIndex(Int32.MaxValue) + 1;

            while (y < g.VisibleClipBounds.Y + g.VisibleClipBounds.Height)
            {
                y = firstLineY - 1 + fontHeight * (i - firstLine - 1);
                x = panel1.Width - (int)g.MeasureString(i.ToString(), txtDNASequence.Font).Width - 5;

                //draw line number next to rtxt
                if (i <= totalLines)
                {
                    if (i <= 1)
                    {        
                        g.DrawString((i).ToString(), SystemFonts.DefaultFont, Brushes.DarkBlue, x + 12, (int) y + 4);
                    }
                    else if (i > 2 && i < 8)
                        g.DrawString((((i - 1)*50) + 1).ToString(), SystemFonts.DefaultFont, Brushes.DarkBlue, x,
                                     (int) y + 4);
                    else if (i == 8)
                        g.DrawString((((i - 1)*50) + 1).ToString(), SystemFonts.DefaultFont, Brushes.DarkBlue, x - 3,
                                     (int) y + 4);
                    else if (i == 9)
                        g.DrawString((((i - 1)*50) + 1).ToString(), SystemFonts.DefaultFont, Brushes.DarkBlue, x - 2,
                                     (int) y + 4);
                    else if (i > 9 && i < 21)
                        g.DrawString((((i - 1)*50) + 1).ToString(), SystemFonts.DefaultFont, Brushes.DarkBlue, x + 10,
                                     (int) y + 4);

                    else
                    {
                        g.DrawString((((i - 1)*50) + 1).ToString(), SystemFonts.DefaultFont, Brushes.DarkBlue, x + 4,
                                     (int) y + 4);

                    }
                }
                i++;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawRichTextBoxLineNumbers(e.Graphics);
        }

        private void txtDNASequence_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void txtDNASequence_VScroll(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void frmDNA_Load(object sender, EventArgs e)
        {

        }

        private void txtDNASequence_TextChanged(object sender, EventArgs e)
        {
            current.Sequence = txtDNASequence.Text;
            current.Clean();
            txtNumBases.Text = current.Sequence.Length.ToString();
            DNAseq = txtDNASequence.Text;

            //for line numbering
            if ((txtDNASequence.GetLineFromCharIndex(Int32.MaxValue) + 1) != totalLines)
            {
                panel1.Invalidate();
            }
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuSequenceReverse_Click(object sender, EventArgs e)
        {
            frmDNA newfrm = new frmDNA(frmMaster, current.Reverse(), this.Text + @"-Reverse");
            newfrm.MdiParent = this.MdiParent;
            newfrm.Show();
        }

        private void mnuSequenceComplement_Click(object sender, EventArgs e)
        {
            frmDNA newfrm = new frmDNA(frmMaster, current.Complement(), this.Text + @"-Complement");
            newfrm.MdiParent = this.MdiParent;
            newfrm.Show();
        }

        private void mnuSequenceParallel_Click(object sender, EventArgs e)
        {
            frmDNA newfrm = new frmDNA(frmMaster, current.Parallel(), this.Text + @"-Reverse Complement");
            newfrm.MdiParent = this.MdiParent;
            newfrm.Show();
        }

        private void mnuSequenceTranslate_Click(object sender, EventArgs e)
        {
            frmDNA newfrm = new frmDNA(frmMaster, current.Translate(), this.Text + @"-Translated");
            newfrm.MdiParent = this.MdiParent;
            newfrm.Show();
        }

        private void mnuSequenceClean_Click(object sender, EventArgs e)
        {
            txtDNASequence.Text = current.Sequence;
        }

        private void mnuSequenceUpcase_Click(object sender, EventArgs e)
        {
            txtDNASequence.Text = txtDNASequence.Text.ToUpper();
        }

        private void mnuSequenceLowcase_Click(object sender, EventArgs e)
        {
            txtDNASequence.Text = txtDNASequence.Text.ToLower();

        }

        private void sequenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuPrimerDigestInsertCS_Click(object sender, EventArgs e)
        {
            frmDigestPrimers newfrm = new frmDigestPrimers(current.Sequence);
            newfrm.Show();
        }

        private void mnuPrimerDigestReplaceMCS_Click(object sender, EventArgs e)
        {
            frmDigestInsertReplace newfrm = new frmDigestInsertReplace(current.Sequence);
            newfrm.Show();
        }

        public override string ToString()
        {
            return this.Text;
        }

        private void frmDNA_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMaster.lstDNAs.Items.Remove(this);
        }
    }
}
