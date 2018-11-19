using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW4_OO;

namespace UnitTestProject1
{
    [TestClass]
    public class CellSolutionAlgorithmTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<char> Chars = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems = "12-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);
            //CellSolutionAlgorithm solver = new  implemented version of this CellSolutionAlgorithm();
  
        }
    }
}
