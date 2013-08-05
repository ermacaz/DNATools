using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNATools
{
    public partial class frmDigestInsertReplace : Form
    {
        public frmDigestInsertReplace(string sequence)
        {
            InitializeComponent();
            rtxtSequence.Text = sequence;

            //populate enzyme library list
            foreach (var enzyme in ReEnzyme.EnzCol)
            {
                lstEnzLibrary.Items.Add(enzyme.Name);
            }
        }

        private void btnAddTop_Click(object sender, EventArgs e)
        {
            if (lstEnzLibrary.SelectedItem != null)
                lstEnzTop.Items.Add(lstEnzLibrary.SelectedItem);      
        }

        private void btnMoveUpTop_Click(object sender, EventArgs e)
        {
            if (lstEnzTop.SelectedIndex > 0)
            {
                int currentIndex = lstEnzTop.SelectedIndex;
                int newindex = lstEnzTop.SelectedIndex - 1;
                string name = (string)lstEnzTop.Items[lstEnzTop.SelectedIndex];
                string swapName = (string)lstEnzTop.Items[currentIndex - 1];
                if (newindex < lstEnzTop.Items.Count)
                {
                    lstEnzTop.Items[newindex] = name;
                    lstEnzTop.Items[lstEnzTop.SelectedIndex] = swapName;
                    lstEnzTop.SelectedIndex -= 1;
                }

            }
        }

        private void btnDownTop_Click(object sender, EventArgs e)
        {
            int currentIndex = lstEnzTop.SelectedIndex;
            int newindex = lstEnzTop.SelectedIndex + 1;
            string name = (string)lstEnzTop.Items[lstEnzTop.SelectedIndex];
            if (newindex < lstEnzTop.Items.Count && newindex <= lstEnzTop.Items.Count)
            {
                string swapName = (string)lstEnzTop.Items[currentIndex + 1];
                lstEnzTop.Items[newindex] = name;
                lstEnzTop.Items[lstEnzTop.SelectedIndex] = swapName;
                lstEnzTop.SelectedIndex += 1;
            }
        }

        private void btnRemoveTop_Click(object sender, EventArgs e)
        {
            lstEnzTop.Items.Remove(lstEnzTop.SelectedItem);
        }

        private void btnAddBtm_Click(object sender, EventArgs e)
        {
            if (lstEnzLibrary.SelectedItem != null)
                lstEnzBtm.Items.Add(lstEnzLibrary.SelectedItem);   
        }

        private void btnUpbtm_Click(object sender, EventArgs e)
        {
            if (lstEnzBtm.SelectedIndex > 0)
            {
                int currentIndex = lstEnzBtm.SelectedIndex;
                int newindex = lstEnzBtm.SelectedIndex - 1;
                string name = (string)lstEnzBtm.Items[lstEnzTop.SelectedIndex];
                string swapName = (string)lstEnzBtm.Items[currentIndex - 1];
                if (newindex < lstEnzBtm.Items.Count)
                {
                    lstEnzBtm.Items[newindex] = name;
                    lstEnzBtm.Items[lstEnzTop.SelectedIndex] = swapName;
                    lstEnzBtm.SelectedIndex -= 1;
                }

            }   
        }

        private void btnDownBtm_Click(object sender, EventArgs e)
        {
            int currentIndex = lstEnzTop.SelectedIndex;
            int newindex = lstEnzTop.SelectedIndex + 1;
            string name = (string)lstEnzTop.Items[lstEnzTop.SelectedIndex];
            if (newindex < lstEnzTop.Items.Count && newindex <= lstEnzTop.Items.Count)
            {
                string swapName = (string)lstEnzTop.Items[currentIndex + 1];
                lstEnzTop.Items[newindex] = name;
                lstEnzTop.Items[lstEnzTop.SelectedIndex] = swapName;
                lstEnzTop.SelectedIndex += 1;
            }
        }

        private void btnRemoveBtm_Click(object sender, EventArgs e)
        {
            lstEnzBtm.Items.Remove(lstEnzBtm.SelectedItem);
        }

    

        private void rtxtSequence_Click(object sender, EventArgs eventArgs)
        {
            if (rtxtSequence.Text == @"Enter Sequence Here")
            {
                rtxtSequence.Text = "";
            }
        }

        private void cbxClamp_CheckedChanged(object sender, EventArgs e)
        {
            txtClampSize.ReadOnly = !cbxClamp.Checked;
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            //verify both boxes have entries
            if (lstEnzTop.Items.Count < 1 || lstEnzBtm.Items.Count < 1)
            {
                MessageBox.Show(@"Error: Not enough enzymes entered.");
                return;
            }

            //clean and check sequence
            string seq = rtxtSequence.Text.ToUpper();
            seq = Regex.Replace(seq, @"\P{L}", string.Empty);
            for (int i = 0; i < seq.Length; i++)
            {
                if (seq[i] != 'A' && seq[i] != 'T' && seq[i] != 'C' && seq[i] != 'G')
                {
                    MessageBox.Show(@"Error: invalid base in sequence");
                    return;
                }
            }
            //verify minimum length met
            if (seq.Length < int.Parse(txtBaseNum.Text))
            {
                MessageBox.Show(string.Format("Error: Sequence must be atleast {0} bases", txtBaseNum.Text));
                return;
            }

            //generate primer base from sequence
            string seqF = seq.Substring(0, int.Parse(txtBaseNum.Text));
            string seqR = new DNA(seq).Parallel().Substring(0, int.Parse(txtBaseNum.Text));

            //make 2list of enzyme objects based on enzymes added to listbox
            List<string> lstEnzymesForward = new List<string>();
            foreach (string s in lstEnzTop.Items)
            {
                lstEnzymesForward.Add(s);
            }
            List<string> lstEnzymesReverse = new List<string>();
            foreach (string s in lstEnzBtm.Items)
            {
                lstEnzymesReverse.Add(s);
            }

            //get list of enzyme objects from list of strings
            List<ReEnzyme> lstEnzColF = CompareLists.Listcompare(lstEnzymesForward);
            List<ReEnzyme> lstEnzColR = CompareLists.Listcompare(lstEnzymesReverse);

            //create all pairs of enzymes that follow 5->3
            List<EnzPair> enzPairs = CompareLists.PairzymesSeparate(lstEnzColF, lstEnzColR);

            //create list of all primer combos            
            List<PrimPair> allPrimers = CompareLists.PairPrimers(enzPairs, seqF, seqR,
                                                                 (cbxClamp.Checked ? int.Parse(txtClampSize.Text) : 0));

            //create list of primer-tm combos then find best
            List<PTpairs> ptList = CompareLists.PairFinal(allPrimers, double.Parse(txtNa.Text));
            PTpairs best = CompareLists.BestPair(ptList);

            txtFPrimer.Text = Regex.Replace(best.Pair.PrimF.Sequence, ".{3}", "$0 ").ToUpper();
            txtRPrimer.Text = Regex.Replace(best.Pair.PrimR.Sequence, ".{3}", "$0 ").ToUpper();
            txtFTm.Text = Math.Round(best.TmF, 2).ToString();
            txtRTm.Text = Math.Round(best.TmR, 2).ToString();
            txtFEnzyme.Text = best.Pair.EnzF.Name;
            txtREnzyme.Text = best.Pair.EnzR.Name;//create list of primer-tm combos then find best
            ptList = CompareLists.PairFinal(allPrimers, double.Parse(txtNa.Text));
            best = CompareLists.BestPair(ptList);

            txtFPrimer.Text = Regex.Replace(best.Pair.PrimF.Sequence, ".{3}", "$0 ").ToUpper();
            txtRPrimer.Text = Regex.Replace(best.Pair.PrimR.Sequence, ".{3}", "$0 ").ToUpper();
            txtFTm.Text = Math.Round(best.TmF, 2).ToString(CultureInfo.InvariantCulture);
            txtRTm.Text = Math.Round(best.TmR, 2).ToString(CultureInfo.InvariantCulture);
            txtFEnzyme.Text = best.Pair.EnzF.Name;
            txtREnzyme.Text = best.Pair.EnzR.Name;

        }

        private void frmDigestInsertReplace_Load(object sender, EventArgs e)
        {

        }



        
    }
}
