using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OO
{
    public class OnlyChoiceAlgorithm : CellSolutionAlgorithm
    {
        public override bool SolveCell(SudokuPuzzle _Puzzle, int _Row, int _Column)
        {
            return FindOnlyChoice(_Puzzle, _Row, _Column, _Puzzle.GetRow(_Row)) ||
            FindOnlyChoice(_Puzzle, _Row, _Column, _Puzzle.GetColumn(_Column)) ||
            FindOnlyChoice(_Puzzle, _Row, _Column, _Puzzle.GetBlock(_Row,_Column));
        }

        //CellSet here can be a column, a row and a block
        //Simply search each row, column and block where there is 
        //only a single choice and then fill it.
        //http://sudokudragon.com/sudokustrategy.html
        //This is the only choice rule from the above link.
        private bool FindOnlyChoice(SudokuPuzzle _Puzzle, int _Row, int _Column, Cell[] cellSet)
        {
            int unsolvedCellCount = 0;
            foreach (var cell in cellSet)
            {
                if (cell.Value =='-')
                {
                    unsolvedCellCount++;
                    if (unsolvedCellCount>1)
                    {
                        return false;
                    }
                }
            }
            //If there is only one option, find out which value is not used, then place it in that spot
            if (unsolvedCellCount == 1)
            {
                List<char> PuzzleCharacterList = new List<char>();
                List<char> cellList = new List<char>();
                PuzzleCharacterList = _Puzzle.CharacterList;
                cellList = toCharList(cellSet);
                //Finds the differences of two char lists
                //.Single()returns the only element and throws an exception if there isn't only one.
                _Puzzle.Cells[_Row, _Column].Value = PuzzleCharacterList.Except(toCharList(cellSet)).Single();
                return true;
            }
            return false;
        }
    }
}
