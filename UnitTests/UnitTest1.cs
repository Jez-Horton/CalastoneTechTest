using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp;
using System.IO;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestClass]
        public class FileTests
        {
            FileOpen fileOpen = new FileOpen(Path.Combine(Directory.GetCurrentDirectory(), "l"));
            [TestMethod]
            public void FileStreamFailedName()
            {
                Assert.IsTrue(fileOpen.Stream.CanWrite);
            }
        }
        [TestClass]
        public class FilterTests
        {
            StreamEditing streamEdit = new StreamEditing();
            [TestMethod]
            public void FilterFromMiddleEvenFalse()
            {
                Assert.IsFalse(streamEdit.HasVowel("Mkfd"));
            }
            [TestMethod]
            public void FilterFromMiddleOddFalse()
            {
                Assert.IsFalse(streamEdit.HasVowel("MKD"));
            }
            [TestMethod]
            public void FilterFromMiddleEven()
            {
                Assert.IsTrue(streamEdit.HasVowel("HAFE"));
            }
            [TestMethod]
            public void FilterFromMiddleOdd()
            {
                Assert.IsTrue(streamEdit.HasVowel("HAS"));
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
