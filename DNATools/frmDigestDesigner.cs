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
        public frmDigestPrimers(string sequence)
        {
            InitializeComponent();
            rtxtSequence.Text = sequence;

            ReEnzyme AatII = new ReEnzyme("AatII", "GACGTC");
            ReEnzyme Acc65I = new ReEnzyme("Acc65I", "GGTACC");
            ReEnzyme AciI = new ReEnzyme("AciI", "CCGC");
            ReEnzyme AclI = new ReEnzyme("AclI", "AACGTT");
            ReEnzyme AcuI = new ReEnzyme("AcuI", "CTGAAG");
            ReEnzyme AfeI = new ReEnzyme("AfeI", "ACGCT");
            ReEnzyme AflII = new ReEnzyme("AflII", "CTTAGG");
            ReEnzyme AgeI = new ReEnzyme("AgeI", "ACCGGT");
            ReEnzyme AgeI_HF = new ReEnzyme("AgeI_HF", "ACCGGT");
            ReEnzyme AluI = new ReEnzyme("AluI", "AGCT");
            ReEnzyme AlwI = new ReEnzyme("AlwI", "GGATC");
            ReEnzyme ApaI = new ReEnzyme("ApaI", "GGGCCC");
            ReEnzyme ApaLI = new ReEnzyme("ApaLI", "GTGCAC");
            ReEnzyme AscI = new ReEnzyme("AscI", "GGCGCGCC");
            ReEnzyme AseI = new ReEnzyme("AseI", "ATTAAT");
            ReEnzyme AsiSI = new ReEnzyme("AsiSI", "GCGATCGC");
            ReEnzyme BaeGI = new ReEnzyme("BaeGI", "GKGCMC");
            ReEnzyme BaeI = new ReEnzyme("BaeI", "ACNNNNGTAYC");
            ReEnzyme BamHI = new ReEnzyme("BamHI", "GGATCC");
            ReEnzyme BamHI_HF = new ReEnzyme("BamHI_HF", "GGATCC");
            ReEnzyme Bsbi = new ReEnzyme("Bsbi", "GAAGAC");
            ReEnzyme BbvCI = new ReEnzyme("BbvCI", "CCTCAGC");
            ReEnzyme BbvI = new ReEnzyme("BbvI", "GCAGC");
            ReEnzyme Bcci = new ReEnzyme("Bcci", "CCATC");
            ReEnzyme BciVI = new ReEnzyme("BciVI", "GTATCC");
            ReEnzyme BclI = new ReEnzyme("BclI", "TGATCA");
            ReEnzyme BcoDI = new ReEnzyme("BcoDI", "GTCTC");
            ReEnzyme BfaI = new ReEnzyme("BfaI", "CTAG");
            ReEnzyme BfuAI = new ReEnzyme("BfuAI", "ACCTGC");
            ReEnzyme BfuCI = new ReEnzyme("BfuCI", "GATC");
            ReEnzyme BglII = new ReEnzyme("BglII", "AGATCT");
            ReEnzyme BmgBI = new ReEnzyme("BmgBI", "CACGTC");
            ReEnzyme BmrI = new ReEnzyme("BmrI", "ACTGGG");
            ReEnzyme BmtI = new ReEnzyme("BmtI", "GCTAGC");
            ReEnzyme BmtI_HF = new ReEnzyme("BmtI_HF", "GCTAGC");
            ReEnzyme BpmI = new ReEnzyme("BpmI", "CTGGAG");
            ReEnzyme BpuEI = new ReEnzyme("BpuEI", "CTTGAG");
            ReEnzyme BsaI_HF = new ReEnzyme("BsaI_HF", "GGTCTC");
            ReEnzyme BsaXI = new ReEnzyme("BsaXI", "ACNNNNNCTCC");
            ReEnzyme BseRI = new ReEnzyme("BseRI", "GAGGAG");
            ReEnzyme BseYI = new ReEnzyme("BseYI", "CCCAGC");
            ReEnzyme BsgI = new ReEnzyme("BsgI", "GTGCAG");
            ReEnzyme BsiHKAI = new ReEnzyme("BsiHKAI", "GWGCWC");
            ReEnzyme BsiWI = new ReEnzyme("BsiWI", "CTGACG");
            ReEnzyme BsmAI = new ReEnzyme("BsmAI", "GTCTC");
            ReEnzyme BsmBI = new ReEnzyme("BsmBI", "CGTCTC");
            ReEnzyme BsmFI = new ReEnzyme("BsmFI", "GGGAC");
            ReEnzyme BsmI = new ReEnzyme("BsmI", "GAATGC");
            ReEnzyme BspCNI = new ReEnzyme("BspCNI", "CTCAG");
            ReEnzyme BspDI = new ReEnzyme("BspDI", "ATCGAT");
            ReEnzyme BspEI = new ReEnzyme("BspEI", "TCCGGA");
            ReEnzyme BspHI = new ReEnzyme("BspHI", "TCATGA");
            ReEnzyme BspMI = new ReEnzyme("BspMI", "ACCTGC");
            ReEnzyme BspQI = new ReEnzyme("BspQI", "GCTCTTC");
            ReEnzyme BsrBI = new ReEnzyme("BsrBI", "CCGCTC");
            ReEnzyme BsrDI = new ReEnzyme("BsrDI", "GCAATG");
            ReEnzyme BsrGI = new ReEnzyme("BsrGI", "TGTACA");
            ReEnzyme BsrI = new ReEnzyme("BsrI", "ACTGG");
            ReEnzyme BssHII = new ReEnzyme("BssHII", "GCGCGC");
            ReEnzyme BssSI = new ReEnzyme("BssSI", "CACGAG");
            ReEnzyme BstBI = new ReEnzyme("BstBI", "TTCGAA");
            ReEnzyme BstNI = new ReEnzyme("BstNI", "CCWGG");
            ReEnzyme BstUI = new ReEnzyme("BstUI", "CGCG");
            ReEnzyme BstZ171 = new ReEnzyme("BstZ171", "GTATAC");
            ReEnzyme BtgI = new ReEnzyme("BtgI", "GCGATG");
            ReEnzyme BtgZI = new ReEnzyme("BtgZI", "GCGATG");
            ReEnzyme BtsCI = new ReEnzyme("BtsCI", "GGATG");
            ReEnzyme BtsI = new ReEnzyme("BtsI", "GCAGTG");
            ReEnzyme BtsIMutI = new ReEnzyme("BtsIMutI", "CAGTG");
            ReEnzyme ClaI = new ReEnzyme("ClaI", "ATCGAT");
            ReEnzyme CviAII = new ReEnzyme("CviAII", "CATG");
            ReEnzyme CviQI = new ReEnzyme("CviQI", "GTAC");
            ReEnzyme DpnI = new ReEnzyme("DpnI", "GATC");
            ReEnzyme DraI = new ReEnzyme("DraI", "TTTAAA");
            ReEnzyme EagI = new ReEnzyme("EagI", "CGGCCG");
            ReEnzyme EagI_HF = new ReEnzyme("EagI_HF", "CGGCCG");
            ReEnzyme EarI = new ReEnzyme("EarI", "CTCTTC");
            ReEnzyme EciI = new ReEnzyme("EciI", "GGCGGA");
            ReEnzyme Eco53kI = new ReEnzyme("Eco53kI", "GAGCTC");
            ReEnzyme EcoO109I = new ReEnzyme("EcoO109I", "RGGNCCY");
            ReEnzyme EcoP151 = new ReEnzyme("EcoP151", "CAGCAG");
            ReEnzyme EcoRI = new ReEnzyme("EcoRI", "GAATTC");
            ReEnzyme EcoRI_HF = new ReEnzyme("EcoRI_HF", "GAATTC");
            ReEnzyme EcoRV = new ReEnzyme("EcoRV", "GATATC");
            ReEnzyme EcoRV_HF = new ReEnzyme("EcoRV_HF", "GATATC");
            ReEnzyme FatI = new ReEnzyme("FatI", "CATG");
            ReEnzyme FseI = new ReEnzyme("FseI", "GGCCGGCC");
            ReEnzyme FspI = new ReEnzyme("FspI", "TGCGCA");
            ReEnzyme HaeII = new ReEnzyme("HaeII", "RGCGCY");
            ReEnzyme HaeIII = new ReEnzyme("HaeIII", "GGCC");
            ReEnzyme HhaI = new ReEnzyme("HhaI", "GCGC");
            ReEnzyme HindIII = new ReEnzyme("HindIII", "AAGCTT");
            ReEnzyme HindIII_HF = new ReEnzyme("HindIII_HF", "AAGCTT");
            ReEnzyme HinfI = new ReEnzyme("HinfI", "GANTC");
            ReEnzyme HinP1I = new ReEnzyme("HinP1I", "GCGC");
            ReEnzyme HpaI = new ReEnzyme("HpaI", "GTTAAC");
            ReEnzyme HpaII = new ReEnzyme("HpaII", "CCGG");
            ReEnzyme Hpy99I = new ReEnzyme("Hpy99I", "CGWCG");
            ReEnzyme HpyCH4IV = new ReEnzyme("HpyCH4IV", "ACGT");
            ReEnzyme HpyCH4V = new ReEnzyme("HpyCH4V", "TGCA");
            ReEnzyme KasI = new ReEnzyme("KasI", "GGCGCC");
            ReEnzyme KpnI = new ReEnzyme("KpnI", "GGTACC");
            ReEnzyme KpnI_HF = new ReEnzyme("KpnI_HF", "GGTACC");
            ReEnzyme MobI = new ReEnzyme("MobI", "GTAC");
            ReEnzyme MfeI = new ReEnzyme("MfeI", "CAATTG");
            ReEnzyme MfeI_HF = new ReEnzyme("MfeI_HF", "CAATTG");
            ReEnzyme MluCI = new ReEnzyme("MluCI", "AATT");
            ReEnzyme MluI = new ReEnzyme("MluI", "ACGCGT");
            ReEnzyme MscI = new ReEnzyme("MscI", "TGGCAA");
            ReEnzyme MseI = new ReEnzyme("MseI", "TTAA");
            ReEnzyme MslI = new ReEnzyme("MslI", "CAYNNNNRTG");
            ReEnzyme NaeI = new ReEnzyme("NaeI", "GCCGGC");
            ReEnzyme NarI = new ReEnzyme("NarI", "GGCGCC");
            ReEnzyme NcoI = new ReEnzyme("NcoI", "CCATGG");
            ReEnzyme NcoI_HF = new ReEnzyme("NcoI_HF", "CCATGG");
            ReEnzyme NdeI = new ReEnzyme("NdeI", "CATATG");
            ReEnzyme NgoMIV = new ReEnzyme("NgoMIV", "GCCGGC");
            ReEnzyme NheI = new ReEnzyme("NheI", "GCTAGC");
            ReEnzyme NheI_HF = new ReEnzyme("NheI_HF", "GCTAGC");
            ReEnzyme NlaIII = new ReEnzyme("NlaIII", "GCTAGC");
            ReEnzyme NotI = new ReEnzyme("NotI", "GCGGCCGC");
            ReEnzyme NotI_HF = new ReEnzyme("NotI_HF", "GCGGCCGC");
            ReEnzyme NruI = new ReEnzyme("NruI", "TCGCGA");
            ReEnzyme NsiI = new ReEnzyme("NsiI", "ATGCAT");
            ReEnzyme Nt_AlwI = new ReEnzyme("Nt_AlwI", "GGATC");
            ReEnzyme PacI = new ReEnzyme("PacI", "TTAATTAA");
            ReEnzyme PaeR7I = new ReEnzyme("PaeR7I", "CTCGAG");
            ReEnzyme PciI = new ReEnzyme("PciI", "ACATGT");
            ReEnzyme PhoI = new ReEnzyme("PhoI", "GGCC");
            ReEnzyme PleI = new ReEnzyme("PleI", "GAGTC");
            ReEnzyme PluTI = new ReEnzyme("PluTI", "GGCGCC");
            ReEnzyme PmeI = new ReEnzyme("PmeI", "GTTTAAAC");
            ReEnzyme PmII = new ReEnzyme("PmII", "CACGTG");
            ReEnzyme PsiI = new ReEnzyme("PsiI", "TTATAA");
            ReEnzyme PspOMI = new ReEnzyme("PspOMI", "GGGCCC");
            ReEnzyme PsiI_HF = new ReEnzyme("PsiI_HF", "CTGCAG");
            ReEnzyme PstI = new ReEnzyme("PstI", "CTGCAG");
            ReEnzyme PvuI = new ReEnzyme("PvuI", "CGATCG");
            ReEnzyme PvuI_HF = new ReEnzyme("PvuI_HF", "CGATCG");
            ReEnzyme PvuII = new ReEnzyme("PvuII", "CAGCTG");
            ReEnzyme PvuII_HF = new ReEnzyme("PvuII_HF", "CAGCTG");
            ReEnzyme RsaI = new ReEnzyme("RsaI", "GTAC");
            ReEnzyme SacI = new ReEnzyme("SacI", "GAGCTC");
            ReEnzyme SacI_HF = new ReEnzyme("SacI_HF", "GAGCTC");
            ReEnzyme SacII = new ReEnzyme("SacII", "CCGCGG");
            ReEnzyme SalI = new ReEnzyme("SalI", "GTCGAC");
            ReEnzyme SalI_HF = new ReEnzyme("SalI_HF", "GTCGAC");
            ReEnzyme SapI = new ReEnzyme("SapI", "GCTCCTTC");
            ReEnzyme Sau3AI = new ReEnzyme("Sau3AI", "GATC");
            ReEnzyme SbfI = new ReEnzyme("SbfI", "CCTGCAGG");
            ReEnzyme SbfI_HF = new ReEnzyme("SbfI_HF", "CCTGCAGG");
            ReEnzyme ScaI = new ReEnzyme("ScaI", "AGTACT");
            ReEnzyme ScaI_HF = new ReEnzyme("ScaI_HF", "AGTACT");
            ReEnzyme SfaNI = new ReEnzyme("SfaNI", "GCATC");
            ReEnzyme SfoI = new ReEnzyme("SfoI", "GGCGCC");
            ReEnzyme SmaI = new ReEnzyme("SmaI", "CCCGGG");
            ReEnzyme SnaBI = new ReEnzyme("SnaBI", "TACGTA");
            ReEnzyme SpeI = new ReEnzyme("SpeI", "ACTAGT");
            ReEnzyme SpeI_HF = new ReEnzyme("SpeI_HF", "ACTAGT");
            ReEnzyme SphI = new ReEnzyme("SphI", "GCATGC");
            ReEnzyme SphI_HF = new ReEnzyme("SphI_HF", "GCATGC");
            ReEnzyme SspI_HF = new ReEnzyme("SspI_HF", "AATATT");
            ReEnzyme StuI = new ReEnzyme("StuI", "AGGCCT");
            ReEnzyme SwaI = new ReEnzyme("SwaI", "ATTTAAAT");
            ReEnzyme TliI = new ReEnzyme("TliI", "CTCGAG");
            ReEnzyme Tsp509I = new ReEnzyme("Tsp509I", "AATT");
            ReEnzyme TspMI = new ReEnzyme("TspMI", "CCCGGG");
            ReEnzyme XbaI = new ReEnzyme("XbaI", "TCTAGA");
            ReEnzyme XhoI = new ReEnzyme("XhoI", "CTCGAG");
            ReEnzyme XmaI = new ReEnzyme("XmaI", "CCCGGG");
            ReEnzyme ZraI = new ReEnzyme("ZraI", "GACGTC");
        
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
            string seqR = new DNA(seq).Complement().Substring(0, int.Parse(txtBaseNum.Text));

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
            txtFEnzyme.Text = best.Pair.EnzF.Name;
            txtREnzyme.Text = best.Pair.EnzR.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstLibrary.SelectedItem != null)
                lstUserPicks.Items.Add(lstLibrary.SelectedItem); 
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lstUserPicks.SelectedIndex > 0)
            {
                int currentIndex = lstUserPicks.SelectedIndex;
                int newindex = lstUserPicks.SelectedIndex - 1;
                string name = (string)lstUserPicks.Items[lstUserPicks.SelectedIndex];
                string swapName = (string)lstUserPicks.Items[currentIndex - 1];
                if (newindex < lstUserPicks.Items.Count)
                {
                    lstUserPicks.Items[newindex] = name;
                    lstUserPicks.Items[lstUserPicks.SelectedIndex] = swapName;
                    lstUserPicks.SelectedIndex -= 1;
                }

            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int currentIndex = lstUserPicks.SelectedIndex;
            int newindex = lstUserPicks.SelectedIndex + 1;
            string name = (string)lstUserPicks.Items[lstUserPicks.SelectedIndex];
            if (newindex < lstUserPicks.Items.Count && newindex <= lstUserPicks.Items.Count)
            {
                string swapName = (string)lstUserPicks.Items[currentIndex + 1];
                lstUserPicks.Items[newindex] = name;
                lstUserPicks.Items[lstUserPicks.SelectedIndex] = swapName;
                lstUserPicks.SelectedIndex += 1;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstUserPicks.Items.Remove(lstUserPicks.SelectedItem);
        }

        private void cbxSingleCut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxGC_CheckedChanged(object sender, EventArgs e)
        {
            gcClampSize.ReadOnly = cbxGC.Checked == false;
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

        

        private void lstUserPicks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUserPicks.Items.Remove(lstUserPicks.SelectedItem);
        }

        private void rtxtSequence_Click(object sender, EventArgs e)
        {
            if (rtxtSequence.Text == @"Enter Sequence Here")
            {
                rtxtSequence.Clear();
                rtxtSequence.Focus();
            }
        }
       




    }
}
