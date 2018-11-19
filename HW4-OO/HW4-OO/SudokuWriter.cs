using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4_OO
{
    public static class SudokuWriter
    {
        public static void Write(string path, SudokuPuzzle puzzle)
        {
            if (path == null)
            {
                Console.WriteLine("Empty Path");
                return;
            }
            if (puzzle == null)
            {
                Console.WriteLine("Empty Sudoku Puzzle");
                return;
            }

            File.WriteAllText(path,"myPuzzle");
        }

    }
}
