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

        [TestMethod]
        public void TestCheck1()
        {
            Word word = new Word("Word");
            Assert.IsTrue(word.Check("WORD"));
        }

        [TestMethod]
        public void TestCheck2()
        {
            Word word = new Word("Word");
            Assert.IsFalse(word.Check("worz"));
        }

        [TestMethod]
        public void TestCheck3()
        {
            Word word = new Word("Word");
            Assert.IsTrue(word.Check("w"));
        }

        [TestMethod]
        public void TestCheck4()
        {
            Word word = new Word("Word");
            Assert.IsFalse(word.Check("z"));
        }

        [TestMethod]
        public void TestCheck5()
        {
            Word word = new Word("Word");
            Assert.IsTrue(word.Check("r"));
        }

        [TestMethod]
        public void TestCheck6()
        {
            Word word = new Word("Word");
            Assert.IsTrue(word.Check("R"));
        }

        [TestMethod]
        public void TestGotCorrectState1()
        {
            Word word = new Word("Word");
            string currentState = word.GetCurrentState();
            string expectedState = "****";
            Assert.AreEqual(expectedState, currentState);
        }

        [TestMethod]
        public void TestGotCorrectState2()
        {
            Word word = new Word("Word");
            word.Check("Z");
            string currentState = word.GetCurrentState();
            string expectedState = "****";
            Assert.AreEqual(expectedState, currentState);
        }

        [TestMethod]
        public void TestGotCorrectState3()
        {
            Word word = new Word("Word");
            word.Check("o");
            string currentState = word.GetCurrentState();
            string expectedState = "*o**";
            Assert.AreEqual(expectedState, currentState);
        }

        [TestMethod]
        public void TestGotCorrectState4()
        {
            Word word = new Word("Word");
            word.Check("O");
            string currentState = word.GetCurrentState();
            string expectedState = "*o**";
            Assert.AreEqual(expectedState, currentState);
        }

        [TestMethod]
        public void TestGotCorrectState5()
        {
            Word word = new Word("Word");
            word.Check("OR");
            string currentState = word.GetCurrentState();
            string expectedState = "****";
            Assert.AreEqual(expectedState, currentState);
        }

        [TestMethod]
        public void TestGotCorrectState6()
        {
            Word word = new Word("Word");
            word.Check("TEST");
            string currentState = word.GetCurrentState();
            string expectedState = "****";
            Assert.AreEqual(expectedState, currentState);
        }

        [TestMethod]
        public void TestGotCorrectState7()
        {
            Word word = new Word("Word");
            word.Check("WORDD");
            string currentState = word.GetCurrentState();
            string expectedState = "****";
            Assert.AreEqual(expectedState, currentState);
        }

        [TestMethod]
        public void TestGotCorrectState8()
        {
            Word word = new Word("Word");
            word.Check("word");
            string currentState = word.GetCurrentState();
            string expectedState = "Word";
            Assert.AreEqual(expectedState, currentState);
        }

        [TestMethod]
        public void TestGotCorrectState9()
        {
            Word word = new Word("Word");
            word.Check("WORD");
            string currentState = word.GetCurrentState();
            string expectedState = "Word";
            Assert.AreEqual(expectedState, currentState);
        }

        [TestMethod]
        public void TestGotCorrectState10()
        {
            Word word = new Word("Word");
            word.Check("WorD");
            string currentState = word.GetCurrentState();
            string expectedState = "Word";
            Assert.AreEqual(expectedState, currentState);
        }


    }
}
