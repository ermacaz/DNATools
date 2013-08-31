using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNATools
{
    class Cell
    {
        private Cell prevCell;
        private List<Cell> prevCells = new List<Cell>();
        private int row;
        private int column;
        private int score;
        private prevCellDir PCD;

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
            score = s;
        }

        public Cell(int r, int c, int s, Cell previous)
        {
            row = r;
            column = c;
            score = s;
            prevCell = previous;
        }

        public Cell(int r, int c, int s, Cell previous, prevCellDir pcd)
        {
            row = r;
            column = c;
            score = s;
            prevCell = previous;
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
