using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OO
{
    public class SudokuPuzzle
    {
        public List<char> CharacterList { get; }

        public int Rows { get;}
        public int BlockDimension
        {
            get { return (int)Math.Sqrt(Rows); }
        }
        public Cell[,] Cells { get; set; }

        public SudokuPuzzle(List<char> _CharacterList, int _Rows, string[] puzzleData)
        {
            if (_CharacterList == null)
                throw new ArgumentException("Null _CharacterList Argument");

            if (puzzleData == null)
                throw new ArgumentException("Null puzzleData Argument");


            if (_CharacterList.Count == 0)
                throw new ArgumentException("Empty _CharacterList Argument");

            if (_Rows<0)
                throw new ArgumentException("Negative _Rows Argument");

            Rows = _Rows;
            CharacterList = _CharacterList;
            Cells = new Cell[puzzleData.Length, puzzleData.Length];
            for (int i = 0; i < puzzleData.Length; i++)
            {
                for (int j = 0; j < puzzleData[i].Length; j++)
                {
                    Cells[i, j] = new Cell(puzzleData[i][j], i, j) ;
                }
            }
        }

        //returns row at given index
        public Cell[] GetRow(int index)
        {
            if (index < 0 || index >= Rows)
                return null;

            Cell[] row = new Cell[Rows];

            for (int i = 0; i < Rows; i++)
            {
                row[i] = Cells[index, i];
            }

            return row;
        }

        //returns column at given index
        public Cell[] GetCol(int index)
        {
            if (index < 0 || index >= Rows)
                return null;

            Cell[] column = new Cell[Rows];

            for (int i = 0; i < Rows; i++)
            {
                column[i] = Cells[i, index];
            }

            return column;
        
        }

        //returns block at given coordinate
        public Cell[] GetBlock(int row, int column)
        {
            if (column < 0 || row < 0 || column >= Rows || row >= Rows)
                return null;

            List<Cell> block = new List<Cell>(Rows);

            for (int i = row; i < row + BlockDimension; i++)
            {
                for (int j = column; j < column + BlockDimension; j++)
                {
                    block.Add(Cells[i,j]);
                }
            }
            return block.ToArray();

        }


        public override string ToString()
        {
            StringBuilder puzzleString = new StringBuilder();

            puzzleString.AppendLine(Rows.ToString());

            foreach (var item in CharacterList)
            {
                puzzleString.Append(item + " ");
            }

            puzzleString.AppendLine();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    puzzleString.AppendFormat(Cells[i,j].Value + " ");
                    puzzleString.AppendLine();
                } 
            }
            return puzzleString.ToString();
        }
    }
}
