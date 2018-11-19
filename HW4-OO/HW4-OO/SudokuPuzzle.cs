using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OO
{
    class SudokuPuzzle
    {
        public List<char> CharacterList { get; }

        public int Rows { get;}
        public int Dimension
        {
            get { return (int)Math.Sqrt(Rows); }
        }
        public char [,] Cells { get; set; }

        public SudokuPuzzle(string _CharacterList, int _Rows, string[] puzzleData)
        {
            Rows = _Rows;
            CharacterList = _CharacterList.ToList();
            Cells = new char[puzzleData.Length, puzzleData.Length];
            for (int i = 0; i < puzzleData.Length; i++)
            {
                for (int j = 0; j < puzzleData[i].Length; j++)
                {
                    Cells[i, j] = puzzleData[i][j];
                }
            }


        }


    }
}
