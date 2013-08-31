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
    public partial class FrmAlignment : Form
    {
        //hardcoded score values
        private const int SIMSCORE = 1;
        private const int NONSIMSCORE = -1;
        private const int GAPSCORE = -2;

        private List<char> lseq1 = new List<char>();
        private List<char> lseq2 = new List<char>();
        private string seq1;
        private string seq2;
 
        public FrmAlignment(string sq1, string sq2)
        {
            InitializeComponent();
            seq1 = '-' + sq1;
            seq2 = '-' + sq2;

            Cell[,] Matrix = Alignment.Initialize(seq1, seq2, SIMSCORE, NONSIMSCORE, GAPSCORE);

            //fll in datagrid
            this.dataGridView1.ColumnCount = Matrix.GetLength(1) + 1;
            for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                this.dataGridView1.Columns[i].Width = 25;//18 for positive values

            }
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.RowCount = Matrix.GetLength(0) + 1;

            //add sequence text to matrix
            for (int j = 1; j < Matrix.GetLength(0) + 1; j++)
            {

                this.dataGridView1.Rows[j].Cells[0].Value = seq2[j - 1];
            }
            for (int i = 1; i < Matrix.GetLength(1) + 1; i++)
            {
                this.dataGridView1.Rows[0].Cells[i].Value = seq1[i - 1];
                //this.dataGridView1.Columns[i].HeaderText = Seq1[i-1].ToString();
            }

            for (int j = 1; j < Matrix.GetLength(0) + 1; j++)
            {
                for (int i = 1; i < Matrix.GetLength(1) + 1; i++)
                {

                    this.dataGridView1.Rows[j].Cells[i].Value = Matrix[j - 1, i - 1].Score;

                }

            }

            //get alligned sequences - function updates given char lists of each seq
            Alignment.Traceback(Matrix, seq1, seq2, lseq1, lseq2);
            //display results
            for (int i = lseq1.Count - 1; i >= 0; i--)
            {
                richTextBox1.AppendText(lseq1[i].ToString());
            }
            this.richTextBox1.AppendText('\n'.ToString());
            for (int i = lseq2.Count - 1; i >= 0; i--)
            {
                richTextBox1.AppendText(lseq2[i].ToString());
            }
        }

        private void FrmAlignment_Load(object sender, EventArgs e)
        {
            //build score matrix
            

        }
    }
}
