using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW4_OO;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class StrategySolveTest
    {
        [TestMethod]
        public void Solve()
        {
            List<char> Chars = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems = "42-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

            bool solved = StrategySolve.Solve(myPuzzle);

            Assert.IsTrue(solved);
        }
        //[TestMethod]
        //public void CantSolve()
        //{
        //    List<char> Chars = new List<char> { '1', '2', '3', '4' };
        //    string[] puzzleItems = "4441\n---2\n3-2-\n-4-3".Split();
        //    SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

        //    bool solved = StrategySolve.Solve(myPuzzle);

        //    Assert.IsFalse(solved);
        //}
    }
}
