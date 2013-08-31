using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNATools
{
    class Cell
    {
        private List<Cell> prevCells = new List<Cell>();
        private int row;
        private int column;
        private prevCellDir PCD;

        public Cell PrevCell { get; set; }
        public List<Cell> PrevCells
        {
            get { return prevCells; }
            set { prevCells = value; }
        }
        public int Score { get; set; }

        //constructors
        public Cell()
        {
            
        }

        public Cell(int r, int c)
        {
            row = r;
            column = c;
        }

        public Cell(int r, int c, int s)
        {
            row = r;
            column = c;
            Score = s;
        }

        public Cell(int r, int c, int s, Cell previous)
        {
            row = r;
            column = c;
            Score = s;
            PrevCell = previous;
        }

        public Cell(int r, int c, int s, Cell previous, prevCellDir pcd)
        {
            row = r;
            column = c;
            Score = s;
            PrevCell = previous;
            PCD = pcd;
        }


        public enum prevCellDir
        {
            Left,
            Above,
            Diagonal
        };

    }
}
