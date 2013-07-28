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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            DNA newDNA = new DNA(txtOrig.Text);
            DNA revDNA = newDNA.Reverse();
            txtNew.Text = revDNA.Sequence;
        }

        private void btnCmp_Click(object sender, EventArgs e)
        {
            DNA newDNA = new DNA(txtOrig.Text);
            DNA revDNA = newDNA.Complement();
            txtNew.Text = revDNA.Sequence;
        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            DNA newDNA = new DNA(txtOrig.Text);
            DNA revDNA = newDNA.Parallel();
            txtNew.Text = revDNA.Sequence;
        }

        private void btnprotein_Click(object sender, EventArgs e)
        {
            DNA newDNA = new DNA(txtOrig.Text);
            string revDNA = newDNA.Translate();
            txtNew.Text = revDNA;
        }
    }
}
