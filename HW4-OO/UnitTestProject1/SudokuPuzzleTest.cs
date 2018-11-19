using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW4_OO;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class SudokuPuzzleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //List<char> Chars = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<char> Chars = new List<char> { '1', '2', '3', '4'};
            string[] puzzleItems = new string[] {"1234", "12-1", "---2","3-2-","-4-3"  };
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 9, puzzleItems);
            Assert.AreEqual(myPuzzle.Rows, 9);
            Assert.AreEqual(myPuzzle.Dimension, 3);
            Assert.AreEqual(myPuzzle.Cells[0,0], 1);
        }
    }
}
