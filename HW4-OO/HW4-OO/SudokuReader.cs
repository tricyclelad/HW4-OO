using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4_OO
{
    public static class SudokuReader
    {
        public static SudokuPuzzle Read(string path)
        {
            if (path == null)
            {
                return null;
            }
            try
            {
                using (var reader = File.OpenText(path))
                {
                    int Rows = int.Parse(reader.ReadLine());
                    string stringCharList = reader.ReadLine().Replace(" ", "");

                    List<char> CharacterList = new List<char>();
                    CharacterList.AddRange(stringCharList);
                    string[] PuzzleData = new string[Rows];

                    for (int i = 0; i < Rows; i++)
                    {
                        string input = reader.ReadLine().Replace(" ", "");
                        if (input != string.Empty)
                        {
                            PuzzleData[i] = input;
                        }
                        else
                        {
                            return null;
                        }
                    }

                    SudokuPuzzle possibleSudoku = new SudokuPuzzle(CharacterList, Rows, PuzzleData);

                    if (!isCorrectDimension(possibleSudoku))
                    {
                        return null;
                    }

                    if (!isCorrectFormat(possibleSudoku))
                    {
                        return null;
                    }

                                       

                    return new SudokuPuzzle(CharacterList, Rows, PuzzleData);
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool isCorrectDimension(SudokuPuzzle _Puzzle)
        {
            if (!(_Puzzle.Rows == 4 || _Puzzle.Rows== 9 || _Puzzle.Rows== 16 || _Puzzle.Rows== 25 || _Puzzle.Rows== 36))
            {
                Console.WriteLine(_Puzzle.ToString());
                Console.WriteLine("Invalid: please enter 4, 9, 16, 25, or 36 rows");
                return false;
            }
            return true;
        }
        
        public static bool isCorrectFormat(SudokuPuzzle _Puzzle)
        {
            //Cell[] row;
            //List<char> validChars = _Puzzle.CharacterList;
            //for (int i = 0; i < _Puzzle.Rows; i++)
            //{
            //    row = _Puzzle.GetRow(i);

            //}
            return true;

        }
    }
}
