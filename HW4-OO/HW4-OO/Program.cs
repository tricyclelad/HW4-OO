using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop indefinitely
            {
                Console.WriteLine("Enter input:"); // Prompt
                string line = Console.ReadLine(); // Get string from user
                if (line == "exit") // Check string
                {
                    break;
                }
                if (line == "-h")
                {
                    Console.WriteLine("exit: Exit the program");
                    Console.WriteLine("  -h: Get Possible Commands");
                    Console.WriteLine("   F: reads puzzle from the specified input file");
                    Console.WriteLine("    : and writes the output to the console");
                    Console.WriteLine("  FS: reads puzzle from the specified");
                    Console.WriteLine("    : input file and writes the output to specific output file");
                }

                if (line == "F")
                {
                    while (true)
                    {
                        Console.WriteLine("Please give the path to the puzzle");
                        string puzzlePath = Console.ReadLine();
                        SudokuPuzzle readPuzzle = SudokuReader.Read(puzzlePath);
                        SudokuPuzzle original = SudokuPuzzle.copySudokuPuzzle(readPuzzle);
                        StrategySolve.Solve(readPuzzle);
                        Console.WriteLine(original.ToString());
                        Console.WriteLine(readPuzzle.ToString());
                        break;
                    }
                }

                if (line == "FS")
                {
                    Console.WriteLine("Please give the path to the puzzle");
                    line = Console.ReadLine();
                    Console.WriteLine(line + " This is what you wrote");
                    Console.WriteLine("Please give the output path to the puzzle");
                    line = Console.ReadLine();
                    Console.WriteLine(line + " This is what you wrote");
                }

            }
            // For writing file tests.
            //List<char> Chars = new List<char> { '1', '2', '3', '4' };
            //string[] puzzleItems = "12-1\n---2\n3-2-\n-4-3".Split();
            //SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);
            //Console.Write(myPuzzle.ToString());
            //SudokuWriter.Write("WriteTest1.txt", myPuzzle);
        }
    }
}
