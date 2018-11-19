using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OO
{
    public abstract class CellSolutionAlgorithm
    {
        public abstract bool SolveCell(SudokuPuzzle _Puzzle, int _Row, int _Column);
        public bool IsSolved(SudokuPuzzle _Puzzle)
        {
            for (int i = 0; i < _Puzzle.Rows; i++)
            {
                for (int j = 0; j < _Puzzle.Rows; j++)
                {
                    if (_Puzzle.Cells[i,j].Value == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        //public bool Solve(SudokuPuzzle _Puzzle);

        public List<char> toCharList(Cell[] _Cells)
        {
            List<char> CellList = new List<char>();
            for (int i = 0; i < _Cells.Length; i++)
            {
                CellList.Add(_Cells[i].Value);
            }
            return CellList;

        }
    }
}
