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
            FileOpen fileOpen = new FileOpen();
            StreamEditing streamEdit = new StreamEditing();
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
                Assert.IsTrue(streamEdit.HasLength("ad"));
            }
            [TestMethod]
            public void FilterWordsMoreThanThree()
            {
                Assert.IsFalse(streamEdit.HasLength("adasd"));
            }
            [TestMethod]
            public void FilterWordsContainingT()
            {
                Assert.IsTrue(streamEdit.ContainsLetter("Testing"));
            }
            [TestMethod]
            public void FilterWordsNotContainingT()
            {
                Assert.IsFalse(streamEdit.ContainsLetter("False"));
            }
        }
    }
}
