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
        public int Row { get; set; }
        public int Column { get; set; }
        

        public Cell PrevCell { get; set; }
        public List<Cell> PrevCells
        {
            get { return prevCells; }
            set { prevCells = value; }
        }

        public int Score { get; set; }
        public prevCellDir PCD { get; set; }


        //constructors
        public Cell()
        {
            
        }

        public Cell(int r, int c)
        {
            Row = r;
            Column = c;
        }

        public Cell(int r, int c, int s)
        {
            Row = r;
            Column = c;
            Score = s;
        }

        public Cell(int r, int c, int s, Cell previous)
        {
            Row = r;
            Column = c;
            Score = s;
            PrevCell = previous;
        }

        public Cell(int r, int c, int s, Cell previous, prevCellDir pcd)
        {
            Row = r;
            Column = c;
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
