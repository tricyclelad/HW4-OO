using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OO
{
    public class RecursiveAlgorithm : CellSolutionAlgorithm
    {
        public override bool SolveCell(SudokuPuzzle _Puzzle, int _Row, int _Column)
        {
            if (_Row == _Puzzle.Rows)
            {
                return true;
            }

            if (_Puzzle.Cells[_Row,_Column].Value!= '-')
            {
                //Console.WriteLine("Working" + _Row + _Column);
                if (Next(_Puzzle,_Row,_Column))
                {
                    return true;
                }
                return false;
            }
            foreach (var character in _Puzzle.CharacterList)
            {
                if (AvailableMove(_Puzzle, _Row, _Column, character))
                {
                    _Puzzle.Cells[_Row, _Column].Value = character;
                    if (Next(_Puzzle, _Row, _Column))
                    {
                        return true;
                    }
                }
            }
            _Puzzle.Cells[_Row, _Column].Value = '-';
            return false;
        }
        private bool Next(SudokuPuzzle _Puzzle, int _Row, int _Column)
        {
            if (_Column == _Puzzle.Rows -1)
            {
                if (SolveCell(_Puzzle, _Row+1, 0))
                {
                    return true;
                }
            }
            else if(SolveCell(_Puzzle, _Row, _Column + 1))
            {
                return true;
            }
            return false;
        }

        private bool AvailableMove(SudokuPuzzle _Puzzle, int _Row, int _Column, char value)
        {
            var r = _Puzzle.GetRow(_Row);
            var c = _Puzzle.GetColumn(_Column);
            var block = _Puzzle.GetBlock(_Row, _Column);

            //Returns false if the value is found anywhere in the row, column, or block
            return !(r.Any(cell => cell.Value == value) || c.Any(cell => cell.Value == value) || block.Any(cell => cell.Value == value));
        }
    }
}
