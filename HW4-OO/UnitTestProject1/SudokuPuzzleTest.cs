﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW4_OO;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class SudokuPuzzleTest
    {
        [TestMethod]
        public void TestConstruction()
        {
            //List<char> Chars = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<char> Chars = new List<char> { '1', '2', '3', '4'};
            //char[,] puzzleItems = new char[,] {{'1','2', '-','1'},{'-', '-', '-', '2' },{'3','-','2','-'},{'-','4','-','3', }};
            //string[] puzzleItems = new string[] { "12-1","---2","3-2-","-4-3"};
            string[] puzzleItems = "12-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);
            Assert.AreEqual(myPuzzle.Rows, 4);
            Assert.AreEqual(myPuzzle.BlockDimension, 2);
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
        [TestMethod]
        public void TestGetRow()
        {

            List<char> Chars = new List<char> { '1', '2', '3', '4'};
            string[] puzzleItems = "12-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

            Cell[] Row1 = new Cell[4];
            Cell[] Row2 = new Cell[4];
            Cell[] Row3 = new Cell[4];
            Cell[] Row4 = new Cell[4];

            for (int i = 0; i < 4; i++)
            {
                Row1[i] = new Cell(puzzleItems[0].ToCharArray()[i],0,i);
                Row2[i] = new Cell(puzzleItems[1].ToCharArray()[i],1,i);
                Row3[i] = new Cell(puzzleItems[2].ToCharArray()[i],2,i);
                Row4[i] = new Cell(puzzleItems[3].ToCharArray()[i],3,i);
            }

            var RealRow1 = myPuzzle.GetRow(0);
            var RealRow2 = myPuzzle.GetRow(1);
            var RealRow3 = myPuzzle.GetRow(2);
            var RealRow4 = myPuzzle.GetRow(3);

            CollectionAssert.AreEqual(RealRow1, Row1);
            CollectionAssert.AreEqual(RealRow2, Row2);
            CollectionAssert.AreEqual(RealRow3, Row3);
            CollectionAssert.AreEqual(RealRow4, Row4);

        }  
        [TestMethod]
        public void TestGetColumn()
        {

            List<char> Chars = new List<char> { '1', '2', '3', '4'};
            string[] puzzleItems = "12-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

            Cell[] Col1 = new Cell[4];
            Cell[] Col2 = new Cell[4];
            Cell[] Col3 = new Cell[4];
            Cell[] Col4 = new Cell[4];

            for (int i = 0; i < 4; i++)
            {
                Col1[i] = new Cell(puzzleItems[i].ToCharArray()[0],i,0);
                Col2[i] = new Cell(puzzleItems[i].ToCharArray()[1],i,1);
                Col3[i] = new Cell(puzzleItems[i].ToCharArray()[2],i,2);
                Col4[i] = new Cell(puzzleItems[i].ToCharArray()[3],i,3);
            }

            var RealCol1 = myPuzzle.GetCol(0);
            var RealCol2 = myPuzzle.GetCol(1);
            var RealCol3 = myPuzzle.GetCol(2);
            var RealCol4 = myPuzzle.GetCol(3);

            CollectionAssert.AreEqual(RealCol1, Col1);
            CollectionAssert.AreEqual(RealCol2, Col2);
            CollectionAssert.AreEqual(RealCol3, Col3);
            CollectionAssert.AreEqual(RealCol4, Col4);

        } 
    }
}
