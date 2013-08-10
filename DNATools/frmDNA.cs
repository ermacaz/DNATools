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

        DNA current = new DNA("");
        public frmMain frmMaster;
        public string strDNAme { get; set; }
        public frmDNA(frmMain master, string titleText)
        {
            InitializeComponent();
            this.Text = titleText;
            strDNAme = titleText;
            frmMaster = master;
            frmMaster.lstDNAs.Items.Add(this);
        }

        public frmDNA(frmMain master, string titleText, string nameExtension)
        {
            InitializeComponent();
            this.Text = nameExtension;
            strDNAme = nameExtension;
            frmMaster = master;
            frmMaster.lstDNAs.Items.Add(this.Text);         

        }


        private void frmDNA_Load(object sender, EventArgs e)
        {

        }

        private void txtDNASequence_TextChanged(object sender, EventArgs e)
        {
            current.Sequence = txtDNASequence.Text;
            current.Clean();
            txtNumBases.Text = current.Sequence.Length.ToString();
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
    }
}
