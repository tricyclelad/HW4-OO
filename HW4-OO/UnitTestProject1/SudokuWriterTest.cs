using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW4_OO;
using System.Collections.Generic;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class SudokuWriterTest
    {
        [TestMethod]
        public void WriteTest1()
        {
            List<char> Chars = new List<char> { '1', '2', '3', '4' };
            string[] puzzleItems = "12-1\n---2\n3-2-\n-4-3".Split();
            SudokuPuzzle myPuzzle = new SudokuPuzzle(Chars, 4, puzzleItems);
            string expected = "4\r\n1 2 3 4 \r\n1 2 - 1 \r\n- - - 2 \r\n3 - 2 - \r\n- 4 - 3 \r\n";
            SudokuWriter.Write("WriteTest1.txt", myPuzzle);
            string actual = File.ReadAllText("WriteTest1.txt");

            Assert.AreEqual(expected, actual);
            //SudokuPuzzle readPuzzle = SudokuReader.Read("ReadPuzzle1.txt");


        }
        [TestCleanup]
        public void Cleanup()
        {
            if(File.Exists("WriteTest1.txt"))
            {
                File.Delete("WriteTest1.txt");
            }
        }
    }
}
