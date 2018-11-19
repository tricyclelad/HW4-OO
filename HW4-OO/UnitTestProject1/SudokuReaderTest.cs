using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW4_OO;

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
    }
}
