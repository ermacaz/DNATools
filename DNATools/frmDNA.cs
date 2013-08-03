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
        public frmDNA()
        {
            InitializeComponent();
            
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
            frmDNA newFrm = new frmDNA();
            newFrm.Show();
        }

        private void mnuSequenceReverse_Click(object sender, EventArgs e)
        {
            txtDNASequence.Text = current.Reverse();
        }

        private void mnuSequenceComplement_Click(object sender, EventArgs e)
        {
            txtDNASequence.Text = current.Complement();
        }

        private void mnuSequenceParallel_Click(object sender, EventArgs e)
        {
            txtDNASequence.Text = current.Parallel();
        }

        private void mnuSequenceTranslate_Click(object sender, EventArgs e)
        {
            txtDNASequence.Text = current.Translate();
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
            frmDigestPrimers newfrm = new frmDigestPrimers();
            newfrm.Show();
        }
    }
}
