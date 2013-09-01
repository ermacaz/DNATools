using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNATools
{
    //adapted from Sara El-Sayed El-Metwally
    //http://www.codeproject.com/Articles/304772/DNA-Sequence-Alignment-using-Dynamic-Programming-A
    class Alignment
    {
        public static Cell[,] Initialize(string seq1, string seq2, int simVal, int nonSimVal, int gapPenalty)
        {
            //add - to front of sequences for scoring purposes
            seq1 = seq1;
            seq2 = seq2;
            int len1 = seq1.Length;
            int len2 = seq2.Length;

            Cell[,] Matrix = new Cell[len2,len1];

            //penalty of first row/column = index * gapPenalty
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Matrix[i, 0] = new Cell(i, 0, i*gapPenalty);
            }
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                Matrix[0,i] = new Cell(i, 0, i * gapPenalty);
            }

            //fill rest of matrix with max_value()
            for (int i = 1; i < Matrix.GetLength(0); i++)
            {
                for (int j = 1; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = GetMax(i, j, seq1, seq2, Matrix, simVal, nonSimVal, gapPenalty);
                }
            }
            return Matrix;
        }

        public static Cell GetMax(int i, int j, string seq1, string seq2, Cell[,] Matrix, int simVal, int nonSimVal,
                                  int gapPenalty)
        {
            Cell temp = new Cell();

            //assign points based on if seq1 base == seq2 base
            int simPoints;
            if (seq1[j] == seq2[i])
                simPoints = simVal;
            else
                simPoints = nonSimVal;

            //3 possible values, take max
            int M1 = Matrix[i - 1, j - 1].Score + simPoints;
            int M2 = Matrix[i, j - 1].Score + gapPenalty;
            int M3 = Matrix[i - 1, j].Score + gapPenalty;
            int maxtemp = M1 >= M2 ? M1 : M2;
            int max = maxtemp > M3 ? maxtemp : M3;

            //set cell to max value
            if (max == M1)
                temp = new Cell(i, j, M1, Matrix[i - 1, j - 1], Cell.prevCellDir.Diagonal);                   
            else if (max == M2)
                temp = new Cell(i, j, M2, Matrix[i, j - 1], Cell.prevCellDir.Left);       
            else
                temp = new Cell(i, j, M3, Matrix[i - 1, j], Cell.prevCellDir.Above);

            return temp;
        }

        //creates alignment strings out of alignemnt score matrix
        //updates references lseq1 and lseq2 rather than returning new lists
        public static void Traceback(Cell[,] Matrix, string seq1, string seq2, List<char> lseq1, List<char> lseq2)
        {
            //set starting place to bottom right of matrix
            Cell CurrentCell = Matrix[seq2.Length - 1, seq1.Length - 1];

            //work way to top left
            while (CurrentCell.PrevCell != null)
            {
                switch (CurrentCell.PCD)
                {
                    case Cell.prevCellDir.Diagonal:
                        lseq1.Add(seq1[CurrentCell.Column]);
                        lseq2.Add(seq2[CurrentCell.Row]);
                        break;
                    case Cell.prevCellDir.Left:
                        lseq1.Add(seq1[CurrentCell.Column]);
                        lseq2.Add('-');
                        break;
                    case Cell.prevCellDir.Above:
                        lseq1.Add('-');
                        lseq2.Add(seq2[CurrentCell.Row]);
                        break;
                }
                CurrentCell = CurrentCell.PrevCell;
            }
        }


    }
}
