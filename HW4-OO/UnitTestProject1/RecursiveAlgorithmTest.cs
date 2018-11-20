using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW4_OO;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class RecursiveAlgorithmTest
    {
        [TestMethod]
        public void RecursiveAlgorithmTotal()
        {
            List<char> Chars = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems = "42-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

            CellSolutionAlgorithm solution = new RecursiveAlgorithm();

            bool solved = solution.SolveCell(myPuzzle, 0, 0);
            Assert.IsTrue(solved);
            Assert.IsTrue(solution.IsSolved(myPuzzle));
        }
        [TestMethod]
        public void UnsolvableRecursiveAlgorithmTotal()
        {
            List<char> Chars = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems = "12-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

            CellSolutionAlgorithm solution = new RecursiveAlgorithm();

            bool solved = solution.SolveCell(myPuzzle, 0, 0);
            Assert.IsFalse(solved);
            Assert.IsFalse(solution.IsSolved(myPuzzle));
        }


    }
}
