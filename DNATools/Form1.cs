using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DNATools
{
    public partial class frmDigestPrimers : Form
    {
        public frmDigestPrimers()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            if (lstUserPicks.Items.Count < 2 && cbxSingleCut.Checked)
            {
                MessageBox.Show(@"Error: cannot filter single cuts with less than 2 enzymes entered.");
                return;
            }
            if (lstUserPicks.Items.Count < 1)
            {
                MessageBox.Show(@"Error: No enzymes entered.");
                return;
            }

            //generate forward and reverse primer base
            string seq = rtxtSequence.Text.ToLower();
            seq = Regex.Replace(seq, @"\P{L}", string.Empty);
            for (int i = 0; i < seq.Length; i++)
            {
                if (seq[i] != 'a' && seq[i] != 't' && seq[i] != 'c' && seq[i] != 'g')
                {
                    MessageBox.Show(@"Error: invalid base in sequence");
                    return;
                }
            }
            if (seq.Length < int.Parse(txtBaseNum.Text))
            {
                MessageBox.Show(string.Format("Error: Sequence must be atleast {0} bases", txtBaseNum.Text));
                return;
            }

            //generate primer base from sequence
            string seqF = seq.Substring(0, int.Parse(txtBaseNum.Text));
            txtFPrimer.Text = seqF;
            string seqR = new DNA(seq).Complement().Substring(int.Parse(txtBaseNum.Text));
            txtRPrimer.Text = seqR;

            //make list of enzyme objects based on enzymes added to listbox
            List<string> enzymes = new List<string>();
            foreach (string s in lstUserPicks.Items)
            {
                enzymes.Add(s);
            }
            List<ReEnzyme> enzCol = CompareLists.Listcompare(enzymes);

            //create all pairs of enzymes that follow 5->3
            List<EnzPair> enzPairs = CompareLists.Pairzymes(enzCol, cbxSingleCut.Checked);

            //create list of all primer combos            
            List<PrimPair> allPrimers = CompareLists.PairPrimers(enzPairs, seqF, seqR,
                                                                 (cbxGC.Checked ? int.Parse(gcClampSize.Text) : 0));

            //create list of primer-tm combos then find best
            List<PTpairs> ptList = CompareLists.PairFinal(allPrimers, double.Parse(txtNa.Text));
            PTpairs best = CompareLists.BestPair(ptList);

            txtFPrimer.Text = Regex.Replace(best.Pair.PrimF.Sequence, ".{3}", "$0 ").ToUpper();
            txtRPrimer.Text = Regex.Replace(best.Pair.PrimR.Sequence, ".{3}", "$0 ").ToUpper();
            txtFTemp.Text = Math.Round(best.TmF, 2).ToString(CultureInfo.InvariantCulture);
            txtRTemp.Text = Math.Round(best.TmR, 2).ToString(CultureInfo.InvariantCulture);
            txtFEnzyme.Text = best.Pair.EnzF.ToString();
            txtREnzyme.Text = best.Pair.EnzR.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void cbxSingleCut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxGC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gcClampSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBaseNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtSequence_TextChanged(object sender, EventArgs e)
        {

        }

       




    }
}
