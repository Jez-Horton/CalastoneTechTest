using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class FileTests
        {

            [TestMethod]
            public void FileStreamFailedName()
            {
            }
            [TestMethod]
            public void FileStreamFailedPath()
            {
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
