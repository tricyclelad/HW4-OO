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
            //char[,] puzzleItems = new char[,] {{'1','2', '-','1'},{'-', '-', '-', '2' },{'3','-','2','-'},{'-','4','-','3', }};
            //string[] puzzleItems = new string[] { "12-1","---2","3-2-","-4-3"};
            string[] puzzleItems = "12-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 9, puzzleItems);
            Assert.AreEqual(myPuzzle.Rows, 9);
            Assert.AreEqual(myPuzzle.Dimension, 3);
            Assert.AreEqual(myPuzzle.Cells[0,0].Value, '1');
            Assert.AreEqual(myPuzzle.Cells[0,0].Column, 0);
            Assert.AreEqual(myPuzzle.Cells[0,0].Row, 0);

            Assert.AreEqual(myPuzzle.Cells[0,1].Value, '2');
            Assert.AreEqual(myPuzzle.Cells[0,2].Value, '-');
            Assert.AreEqual(myPuzzle.Cells[0,3].Value, '1');

            Assert.AreEqual(myPuzzle.Cells[1,0].Value, '-');
            Assert.AreEqual(myPuzzle.Cells[1,1].Value, '-');
            Assert.AreEqual(myPuzzle.Cells[1,2].Value, '-');
            Assert.AreEqual(myPuzzle.Cells[1,3].Value, '2');
            
            Assert.AreEqual(myPuzzle.Cells[2,0].Value, '3');

            Assert.AreEqual(myPuzzle.Cells[2,1].Value, '-');
            Assert.AreEqual(myPuzzle.Cells[2,1].Column, 1);
            Assert.AreEqual(myPuzzle.Cells[2,1].Row, 2);

            Assert.AreEqual(myPuzzle.Cells[2,2].Value, '2');
            Assert.AreEqual(myPuzzle.Cells[2,3].Value, '-');


            Assert.AreEqual(myPuzzle.Cells[3,0].Value, '-');
            Assert.AreEqual(myPuzzle.Cells[3,1].Value, '4');
            Assert.AreEqual(myPuzzle.Cells[3,2].Value, '-');
            Assert.AreEqual(myPuzzle.Cells[3,3].Value, '3');
        }
    }
}
