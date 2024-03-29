﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW4_OO;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class SudokuReaderTest
    {
        [TestMethod]
        public void NullPuzzle()
        {
            SudokuPuzzle Empty = SudokuReader.Read(null);
            Assert.AreEqual(Empty, null);
        }

        [TestMethod]
        public void InvalidTextPuzzle()
        {
            SudokuPuzzle Empty = SudokuReader.Read("NotAFile.txt");
            Assert.AreEqual(Empty, null);
        }

        [TestMethod]
        public void ReadPuzzle1()
        {
            List<char> Chars = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems = "42-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

            SudokuPuzzle readPuzzle = SudokuReader.Read("ReadPuzzle1.txt");

            CollectionAssert.AreEqual(myPuzzle.Cells, readPuzzle.Cells);
            CollectionAssert.AreEqual(myPuzzle.CharacterList, readPuzzle.CharacterList);
            Assert.AreEqual(myPuzzle.Rows, readPuzzle.Rows);
            Assert.AreEqual(myPuzzle.BlockDimension, readPuzzle.BlockDimension);

            //Assert.AreEqual(myPuzzle.Rows, 4);
            //CollectionAssert.AreEqual(myPuzzle.CharacterList, Chars);
            //Assert.AreEqual(myPuzzle.BlockDimension, 2);
            //Assert.AreEqual(myPuzzle.Cells[0, 0].Value, '1');
            //Assert.AreEqual(myPuzzle.Cells[0, 0].Column, 0);
            //Assert.AreEqual(myPuzzle.Cells[0, 0].Row, 0);
        }
        [TestMethod]
        public void ReadUnformatedPuzzle1()
        {
            SudokuPuzzle readPuzzle = SudokuReader.Read("ReadPuzzle2.txt");

            Assert.IsNull(readPuzzle);
        }
 
    }
}
