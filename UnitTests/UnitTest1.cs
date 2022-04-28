using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestClass]
        public class FileTests
        {
            FileOpen fileOpen = new FileOpen();
            [TestMethod]
            public void FileStreamFailedName()
            {
                Assert.ThrowsException<ArgumentException>(() => fileOpen.openFile(""));
            }
        }
        [TestClass]
        public class FilterTests
        {
            [TestMethod]
            public void FilterVowel()
            {
                //Open File test with valid input
            }
            [TestMethod]
            public void FilterConsanant()
            {
                //Open File test with invalid input
            }
            [TestMethod]
            public void FilterFromMiddle()
            {
                //Open File test with valid input
            }
            [TestMethod]
            public void FilterWordsLessThanThree()
            {
            }
            [TestMethod]
            public void FilterWordsMoreThanThree()
            {
            }
            [TestMethod]
            public void FilterWordsContainingT()
            {
            }
            [TestMethod]
            public void FilterWordsNotContainingT()
            {
            }
        }
    }
}
