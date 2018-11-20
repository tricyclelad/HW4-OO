using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OO
{
    public static class StrategySolve
    {
        public static bool Solve(SudokuPuzzle _Puzzle)
        {
            SudokuPuzzle LastIterationPuzzle = _Puzzle;
            SudokuPuzzle CurrentIterationPuzzle = _Puzzle;
            CellSolutionAlgorithm solver = new OnlyChoiceAlgorithm();
            bool solved = solver.IsSolved(CurrentIterationPuzzle);
            if (solved)
                return true;

            bool puzzleChanged = true;
            while(puzzleChanged)
            {
                solved = solver.SolvePuzzle(CurrentIterationPuzzle);
                if (LastIterationPuzzle == CurrentIterationPuzzle)
                {
                    puzzleChanged = false;
                }
                LastIterationPuzzle = CurrentIterationPuzzle;
            }
            solved = solver.IsSolved(CurrentIterationPuzzle);
            if(solved)
            {
                _Puzzle = CurrentIterationPuzzle;
                return true;
            }
            
            solver = new RecursiveAlgorithm();
            solved = solver.SolvePuzzle(CurrentIterationPuzzle);

            _Puzzle = CurrentIterationPuzzle;

            return solved;
        }
    }
}
