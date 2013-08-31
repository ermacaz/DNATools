using System;
using System.Collections;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            lstDNAs.DisplayMember = "strDNAme";
            lstDNAs.ContextMenuStrip = cmLstDNA;

        }

        private void mnuCalculateTm_Click(object sender, EventArgs e)
        {

        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            frmDNAmer newFrm = new frmDNAmer(this);
            newFrm.StartPosition = FormStartPosition.CenterScreen;
            newFrm.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuSequenceReverse_Click(object sender, EventArgs e)
        {

        }

        private void lstDNAs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lstDNAs_DoubleClick(object sender, EventArgs e)
        {
            frmDNA temp = (frmDNA)lstDNAs.SelectedItem;
            temp.Activate();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDNA temp  = (frmDNA)lstDNAs.SelectedItem;
            temp.Close();
            lstDNAs.Items.Remove(lstDNAs.SelectedItem);
        }

        private void cloneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAlign_Click(object sender, EventArgs e)
        {
            if (lstDNAs.SelectedIndices.Count != 2)
            {
                MessageBox.Show("Must select two DNA sequences", "Wrong number of sequences to allign");
                return;
            }

            //get sequences of selected sequence forms on lstDNA to send to allignment form
            string seq1 = null, seq2 = null;
            int index = 0;
            foreach (frmDNA frm in lstDNAs.SelectedItems)
            {
                if (index == 0)
                    seq1 = frm.DNAseq;
                if (index == 1)
                    seq2 = frm.DNAseq;
                ++index;
            }
            
            FrmAlignment newfrm = new FrmAlignment(seq1, seq2);
            newfrm.Show();

        }
    }
}
