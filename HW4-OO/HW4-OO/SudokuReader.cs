using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4_OO
{
    public class SudokuReader
    {
        public static SudokuPuzzle Read(string filename)
        {
            if (filename == null)
            {
                return null;
            }
            try
            {
                using (var reader = File.OpenText(filename))
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
                    return new SudokuPuzzle(CharacterList, Rows, PuzzleData);
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
