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
        public bool IsSolved(SudokuPuzzle _Puzzle);
        public bool Solve(SudokuPuzzle _Puzzle);
    }
}
