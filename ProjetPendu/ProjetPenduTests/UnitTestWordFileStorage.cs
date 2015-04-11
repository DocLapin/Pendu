using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pendu;
using System.IO;
using System.Collections.Generic;

namespace ProjetPenduTests
{
    [TestClass]
    public class UnitTestWordFileStorage
    {
        private readonly string TEST_FILE_PATH = @"C:\temp\TestPenduWords.txt";

        private StreamWriter _file;

        private readonly Word[] TEST_WORDS = { new Word("Test"), new Word("TotoIsHardToFind") };

        [TestInitialize]
        public void TestInitialize()
        {
            using (_file = new StreamWriter(TEST_FILE_PATH))
            {
                foreach (Word word in TEST_WORDS)
                {
                    _file.WriteLine(word.WordString);
                }
            }
            _file.Close();
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestLoad1()
        {
            String filePath = "C:\file.txt";
            IWordStorage wordStorage = new WordFileStorage(filePath);
            wordStorage.Load();
        }

        [TestMethod]
        public void TestLoad2()
        {
            IWordStorage wordStorage = new WordFileStorage(TEST_FILE_PATH);
            List<Word> words = wordStorage.Load();
            int expected = TEST_WORDS.Length;
            int actual = words.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoad3()
        {
            IWordStorage wordStorage = new WordFileStorage(TEST_FILE_PATH);
            List<Word> words = wordStorage.Load();
            int expected = TEST_WORDS.Length;
            int actual = words.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoad4()
        {
            IWordStorage wordStorage = new WordFileStorage(TEST_FILE_PATH);
            List<Word> words = wordStorage.Load();
            Word expectedWord = TEST_WORDS[0];
            Word actualWord = words[0];
            string expected = expectedWord.WordString;
            string actual = actualWord.WordString;
            Assert.AreEqual(expected, actual);
        }
    }
}
