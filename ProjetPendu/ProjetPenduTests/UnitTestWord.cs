using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pendu;

namespace ProjetPenduTests
{
    [TestClass]
    public class UnitTestWord
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructor1()
        {
            Word word = new Word("  ");
        }

        [TestMethod]
        public void TestGotCorrectSize1()
        {
            Word word = new Word("Word");
            int minLength = 1;
            int maxLength = 5;
            Assert.IsTrue(word.GotCorrectSize(minLength, maxLength));
        }

        [TestMethod]
        public void TestGotCorrectSize2()
        {
            Word word = new Word("Word");
            int minLength = 1;
            int maxLength = 4;
            Assert.IsTrue(word.GotCorrectSize(minLength, maxLength));
        }

        [TestMethod]
        public void TestGotCorrectSize3()
        {
            Word word = new Word("Word");
            int minLength = 1;
            int maxLength = 2;
            Assert.IsFalse(word.GotCorrectSize(minLength, maxLength));
        }

        [TestMethod]
        public void TestGotCorrectSize4()
        {
            Word word = new Word("Word");
            int minLength = 5;
            int maxLength = 8;
            Assert.IsFalse(word.GotCorrectSize(minLength, maxLength));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGotCorrectSize5()
        {
            Word word = new Word("Word");
            int minLength = 4;
            int maxLength = 1;
            Assert.IsFalse(word.GotCorrectSize(minLength, maxLength));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGotCorrectSize6()
        {
            Word word = new Word("Word");
            int minLength = -4;
            int maxLength = 1;
            Assert.IsFalse(word.GotCorrectSize(minLength, maxLength));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGotCorrectSize7()
        {
            Word word = new Word("Word");
            int minLength = 4;
            int maxLength = -1;
            Assert.IsFalse(word.GotCorrectSize(minLength, maxLength));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGotCorrectSize8()
        {
            Word word = new Word("Word");
            int minLength = -4;
            int maxLength = -1;
            Assert.IsFalse(word.GotCorrectSize(minLength, maxLength));
        }
    }
}
