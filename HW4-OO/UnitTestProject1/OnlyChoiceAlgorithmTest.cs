﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW4_OO;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class OnlyChoiceAlgorithmTest
    {
        [TestMethod]
        public void isSolvedTest()
        {
            List<char> Chars = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems = "42-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

            List<char> Chars2 = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems2 = "4231\n1342\n3124\n2413".Split();
            SudokuPuzzle myPuzzle2 = new SudokuPuzzle(Chars, 4, puzzleItems2);


            CellSolutionAlgorithm solution = new OnlyChoiceAlgorithm();
            bool notSolved = solution.IsSolved(myPuzzle);
            Assert.IsFalse(notSolved);

            bool Solved = solution.IsSolved(myPuzzle2);
            Assert.IsTrue(Solved);
        }
        //[TestMethod]
        //public void betterIsSolvedTest()
        //{
        //    List<char> Chars = new List<char> { '1', '2', '3', '4' };
        //    string[] puzzleItems = "42-1\n---2\n3-2-\n-4-3".Split();
        //    SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

        //    List<char> Chars2 = new List<char> { '1', '2', '3', '4' };
        //    string[] puzzleItems2 = "4231\n1342\n3124\n2413".Split();
        //    SudokuPuzzle myPuzzle2 = new SudokuPuzzle(Chars, 4, puzzleItems2);


        //    CellSolutionAlgorithm solution = new OnlyChoiceAlgorithm();
        //    bool notSolved = solution.betterIsSolved(myPuzzle);
        //    Assert.IsFalse(notSolved);

        //    bool Solved = solution.betterIsSolved(myPuzzle2);
        //    Assert.IsTrue(Solved);
        //}
        [TestMethod]
        public void OnlyChoiceRow()
        {
            List<char> Chars = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems = "42-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

            CellSolutionAlgorithm solution = new OnlyChoiceAlgorithm();

            bool solved = solution.SolveCell(myPuzzle, 0, 2);
            Assert.IsTrue(solved);
            Assert.AreEqual(myPuzzle.Cells[0,2].Value,'3');
        }
        [TestMethod]
        public void OnlyChoiceColumn()
        {
            List<char> Chars = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems = "42-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

            CellSolutionAlgorithm solution = new OnlyChoiceAlgorithm();

            bool solved = solution.SolveCell(myPuzzle, 2, 3);
            Assert.IsTrue(solved);
            Assert.AreEqual(myPuzzle.Cells[2,3].Value,'4');
        }
        [TestMethod]
        public void OnlyChoiceBlock()
        {
            List<char> Chars = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems = "4231\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

            CellSolutionAlgorithm solution = new OnlyChoiceAlgorithm();

            bool solved = solution.SolveCell(myPuzzle, 1, 3);
            Assert.IsTrue(solved);
            Assert.AreEqual(myPuzzle.Cells[1,3].Value,'4');

        }
        [TestMethod]
        //More than 1 blank space in each column, row, and box
        public void cantSolveByOnlyChoice()
        {
            List<char> Chars = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems = "42-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);

            CellSolutionAlgorithm solution = new OnlyChoiceAlgorithm();

            bool solved = solution.SolveCell(myPuzzle, 1, 1);
            Assert.IsFalse(solved);
            Assert.AreEqual(myPuzzle.Cells[1,1].Value,'-');
        }
    }
}
