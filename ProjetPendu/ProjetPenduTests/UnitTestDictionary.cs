using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pendu;
using System.Collections.Generic;

namespace ProjetPenduTests
{
    [TestClass]
    public class UnitTestDictionary
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructor1()
        {
            List<Word> words = new List<Word>();
            new Dictionary(words);
        }

        [TestMethod]
        public void TestSelectAWord1()
        {
            List<Word> words = new List<Word>();
            words.Add(new Word("UnitTest"));
            Dictionary dico = new Dictionary(words);
            string expected = "UnitTest";
            string actual = dico.SelectAWord().WordString;
            Assert.AreEqual(expected, actual);
 
        }

        [TestMethod]
        public void TestSelectAWord2()
        {
            List<Word> words = new List<Word>();
            words.Add(new Word("UnitTest"));
            Dictionary dico = new Dictionary(words);
            string expected = "UnitTest";
            string actual = dico.SelectAWord(1, 8).WordString;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSelectAWord3()
        {
            List<Word> words = new List<Word>();
            words.Add(new Word("UnitTest"));
            Dictionary dico = new Dictionary(words);
            Word actual = dico.SelectAWord(1, 2);
            Assert.IsNull(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSelectAWord4()
        {
            List<Word> words = new List<Word>();
            words.Add(new Word("UnitTest"));
            Dictionary dico = new Dictionary(words);
            dico.SelectAWord(-1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSelectAWord5()
        {
            List<Word> words = new List<Word>();
            words.Add(new Word("UnitTest"));
            Dictionary dico = new Dictionary(words);
            dico.SelectAWord(1, -2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSelectAWord6()
        {
            List<Word> words = new List<Word>();
            words.Add(new Word("UnitTest"));
            Dictionary dico = new Dictionary(words);
            dico.SelectAWord(-1, -2);
        }
    }
}
